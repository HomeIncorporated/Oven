﻿using System;
using System.Collections.Generic;
using System.Text;
using MasterBuilder.Request;

namespace MasterBuilder.Templates.Controllers
{
    public class ControllerEditMethodTemplate
    {
        internal static string Evaluate(Project project, Entity entity, Screen screen, ScreenSection screenSection)
        {
            var getPropertyMapping = new List<string>();
            var postPropertyMapping = new List<string>();
            var patchEntityOperations = new List<string>();
            foreach (var item in entity.Properties)
            {
                if (item.Type != PropertyTypeEnum.ParentRelationship)
                {
                    getPropertyMapping.Add($"                           {item.InternalName} = item.{item.InternalName}");
                }
                if (item.PropertyTemplate != PropertyTemplateEnum.PrimaryKey)
                {
                    switch (item.Type)
                    {
                        case PropertyTypeEnum.ParentRelationship:
                            postPropertyMapping.Add($"                {item.InternalName}Id = post.{item.InternalName}Id");
                            patchEntityOperations.Add($@"                     case ""/{item.InternalName.ToCamlCase()}Id"":
                        entity.{item.InternalName}Id = new Guid(operation.value.ToString());
                        entityEntry.Property(p => p.{item.InternalName}).IsModified = true;
                        break;");
                            break;
                        case PropertyTypeEnum.Uniqueidentifier:
                            break;
                        case PropertyTypeEnum.String:
                            postPropertyMapping.Add($"                {item.InternalName} = post.{item.InternalName}");
                            patchEntityOperations.Add($@"                     case ""/{item.InternalName.ToCamlCase()}"":
                        entity.{item.InternalName} = operation.value.ToString();
                        entityEntry.Property(p => p.{item.InternalName}).IsModified = true;
                        break;");
                            break;
                        case PropertyTypeEnum.Integer:
                            postPropertyMapping.Add($"                {item.InternalName} = post.{item.InternalName}");
                            patchEntityOperations.Add($@"                     case ""/{item.InternalName.ToCamlCase()}"":
                        bool int32Value;
                        if (operation.value != null && Int32.TryParse(operation.value.ToString(), out int32Value))
                        {{
                            entity.{item.InternalName} = int32Value;
                            entityEntry.Property(p => p.{item.InternalName}).IsModified = true;
                        }}
                        else if (operation.value == null || string.IsNullOrWhitespace(operation.value.ToString()))
                        {{
                            entity.{item.InternalName} = null;
                            entityEntry.Property(p => p.{item.InternalName}).IsModified = true;
                        }}
                        else
                        {{
                            throw new Exception(""Property: {item.InternalName}, Value:"" + operation.value + "" is not a valid boolean value"");
                        }}
                        break;");
                            break;
                        case PropertyTypeEnum.DateTime:
                            break;
                        case PropertyTypeEnum.Boolean:
                            postPropertyMapping.Add($"                {item.InternalName} = post.{item.InternalName}");
                            patchEntityOperations.Add($@"                     case ""/{item.InternalName.ToCamlCase()}"":
                        bool booleanValue;
                        if (operation.value != null && Boolean.TryParse(operation.value.ToString(), out booleanValue))
                        {{
                            entity.{item.InternalName} = booleanValue;
                            entityEntry.Property(p => p.{item.InternalName}).IsModified = true;
                        }}
                        else
                        {{
                            throw new Exception(""Property: {item.InternalName}, Value:"" + operation.value + "" is not a valid boolean value"");
                        }}
                        break;");
                            break;
                        default:
                            break;
                    }
                }
            }

            var get = $@"
        [HttpGet(""{screen.InternalName}/{{id}}"")]
        public async Task<IActionResult> {screen.InternalName}(Guid id)
        {{
            if (!ModelState.IsValid)
            {{
                return new BadRequestObjectResult(ModelState);
            }}

            if (id == Guid.Empty)
            {{
                return NotFound();
            }}
            
            var result = await _context.{entity.InternalNamePlural}
                            .AsNoTracking()
                            .Select(item => new Models.{screen.InternalName}Response
                            {{
{string.Join(string.Concat(",", Environment.NewLine), getPropertyMapping)}
                            }})
                            .SingleOrDefaultAsync(p => p.Id == id);
            if (result == null)
            {{
                return NotFound();
            }}

            return Ok(result);
        }}";


            var post = $@"
        [HttpPost(""{screen.InternalName}"")]
        public async Task<IActionResult> {screen.InternalName}([FromBody]{screen.InternalName}Request post)
        {{
            if (post == null)
            {{
                return BadRequest();
            }}
            
            if (!ModelState.IsValid)
            {{
                return new BadRequestObjectResult(ModelState);
            }}
            
            var newRecord = new {entity.InternalName}{{
{string.Join(string.Concat(",", Environment.NewLine), postPropertyMapping)}
            }};            

            _context.{entity.InternalNamePlural}.Add(newRecord);
            await _context.SaveChangesAsync();

            return Ok(newRecord.Id);
        }}";

            //http://benfoster.io/blog/aspnet-core-json-patch-partial-api-updates
            var patch = $@"
        [HttpPatch(""{screen.InternalName}/{{id}}"")]
        public async Task<IActionResult> {screen.InternalName}([FromRoute]Guid id, [FromBody]JsonPatchDocument<{screen.InternalName}Request> patch)
        {{
            if (patch == null)
            {{
                return BadRequest();
            }}
            
            if (!ModelState.IsValid)
            {{
                return new BadRequestObjectResult(ModelState);
            }}

            if (!patch.Operations.Any())
            {{
                return Ok();
            }}

            var entity = new Entities.{entity.InternalName}() {{ Id = id }};
            var entityEntry = _context.{entity.InternalNamePlural}.Attach(entity);
            
            // do stuff
            foreach(var operation in patch.Operations)
            {{
                switch (operation.path)
                {{
{string.Join(Environment.NewLine, patchEntityOperations)}
                }}
            }}

            await _context.SaveChangesAsync();
            
            return Ok();
        }}";

            // todo delete

            return string.Concat(get, post, patch);
        }
    }
}
