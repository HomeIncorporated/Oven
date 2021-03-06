using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Oven.Request
{
    /// <summary>
    /// Project
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Project: {Title}")]
    public partial class Project
    {
        public static readonly ObjectId KitchenId = new ObjectId("5ca86ae16668b25914b67e73");
        /// <summary>
        /// Constructor sets default values
        /// </summary>
        public Project()
        {
            ImutableDatabase = false;
            AllowDestructiveDatabaseChanges = true;
            ServerSideRendering = false;
            UsePutForUpdate = true;
            CleanDirectoryIgnoreDirectories = new string[]
            {
                "bin",
                "obj",
                "node_modules",
                "Properties"
            };
        }
        /// <summary>
        /// Uniqueidentifier
        /// </summary>
        [Required]
        [NonDefault]
        public ObjectId Id { get; set; }
        /// <summary>
        /// Internal Name
        /// </summary>
        [MaxLength(100)]
        [MinLength(5)]
        [PascalString]
        public string InternalName { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string Title { get; set; }
        /// <summary>
        /// Major version
        /// </summary>
        [Required]
        [Range(0, 999999)]
        public int MajorVersion { get; set; }
        /// <summary>
        /// Minor Version
        /// </summary>
        [Required]
        [Range(0, 999999)]
        public int MinorVersion { get; set; }
        /// <summary>
        /// Build Version
        /// </summary>
        [Required]
        [Range(0, 99999999)]
        public int BuildVersion { get; set; }
        /// <summary>
        /// Entities
        /// </summary>
        [MustHaveOneElement]
        public IEnumerable<Entity> Entities { get; set; }
        /// <summary>
        /// Screens
        /// </summary>
        [MustHaveOneElement]
        public IEnumerable<Screen> Screens { get; set; }
        /// <summary>
        /// Menu Items
        /// </summary>
        [MustHaveOneElement]
        public IEnumerable<MenuItem> MenuItems { get; set; }
        /// <summary>
        /// Service configurations
        /// </summary>
        public IEnumerable<Service> Services { get; set; }
        /// <summary>
        /// Default Screen to load
        /// </summary>
        [NonDefault]
        public ObjectId? DefaultScreenId { get; set; }

        /// <summary>
        /// Any NuGet dependencies to include
        /// </summary>
        public IEnumerable<NuGetDependency> NuGetDependencies { get; set; }

        /// <summary>
        /// Any NuGet package sources to reference
        /// </summary>
        public IEnumerable<NuGetPackageSource> NuGetPackageSources { get; set; }
        /// <summary>
        /// Generate a Project that allows custom code
        /// </summary>
        public bool EnableCustomCode { get; set; }
        /// <summary>
        /// Theme Colour HEX
        /// </summary>
        public string ThemeColour { get; set; } = "#4285f4";

        #region Internal Settings

        /// <summary>
        /// Semantic Version
        /// </summary>
        [JsonIgnore]
        public string Version
        {
            get
            {
                return $"{MajorVersion}.{MinorVersion}.{BuildVersion}";
            }
        }
        /// <summary>
        /// Allow Destructive Database Change, things like dropping columns, tables, keys
        /// </summary>
        [JsonIgnore]
        public bool AllowDestructiveDatabaseChanges { get; set; }
        /// <summary>
        /// Folders to ignore when cleaning out the directory on build
        /// </summary>
        [JsonIgnore]
        public string[] CleanDirectoryIgnoreDirectories { get; set; }
        /// <summary>
        /// If true database tables and columns are all uniqueidentifiers making database 
        /// hard to use but less chance of needing to change database columns which can result in data loss
        /// </summary>
        [JsonIgnore]
        public bool? ImutableDatabase { get; set; }
        /// <summary>
        /// Enable Server side rendering
        /// </summary>
        [JsonIgnore]
        public bool ServerSideRendering { get; set; }
        /// <summary>
        /// Use Put for update instead of patch
        /// </summary>
        [JsonIgnore]
        public bool UsePutForUpdate { get; set; }
        /// <summary>
        /// Whether to include support for spatial properties
        /// </summary>
        [JsonIgnore]
        public bool IncludeSupportForSpatial { get; set; }
        /// <summary>
        /// Default Screen
        /// </summary>
        [JsonIgnore]
        public Screen DefaultScreen { get; private set; }
        /// <summary>
        /// Internal Id of the Web Project/Main entry project
        /// </summary>
        [JsonIgnore]
        public Guid ProjectWebId { get; set; } = new Guid("{2AF7569A-8978-4FA6-B7B7-E49CB9AE46D8}");
        /// <summary>
        /// Internal Id of the Shared Project
        /// </summary>
        [JsonIgnore]
        public Guid ProjectSharedId { get; set; } = new Guid("{9F905352-6C68-4738-B27D-F695C47EF611}");
        /// <summary>
        /// Internal Id of the Api Project
        /// </summary>
        [JsonIgnore]
        public Guid ProjectApiId { get; set; } = new Guid("{CDC20F0A-B763-4DEE-B037-2F8A4F3DFC1B}");
        /// <summary>
        /// Internal Id of the Data Access Layer Project
        /// </summary>
        [JsonIgnore]
        public Guid ProjectDataAccessLayerId { get; set; } = new Guid("{5BE39A8E-3012-4F57-8D44-36BA26CE5036}");
        /// <summary>
        /// Internal Id of the Data Access Layer Project
        /// </summary>
        [JsonIgnore]
        public Guid ProjectApiCustomId { get; set; } = new Guid("{84FAA2EF-D7B9-4981-BA59-BF122AB0FF68}");
        #endregion
        /// <summary>
        /// Validate and Resolve this and child objects
        /// </summary>
        /// <param name="message">Error messages</param>
        /// <returns>true for no errors</returns>
        public bool ValidateAndResolve(out string message)
        {
            var errors = new List<string>();

            if (!Validate(out string validateError))
            {
                errors.Add(validateError);
            }

            if (!Resolve(out string resolveError))
            {
                errors.Add(resolveError);
            }
            
            if (errors.Any())
            {
                message = string.Join(Environment.NewLine, errors);
                return false;
            }
            else
            {
                message = null;
                return true;
            }
        }
    }
}
