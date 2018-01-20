using MasterBuilder.Request;
using System.Linq;

namespace MasterBuilder.Templates.Entities
{
    /// <summary>
    /// Entity Property Template
    /// </summary>
    public class EntityPropertyTemplate
    {
        /// <summary>
        /// Evaluate
        /// </summary>
        public static string Evaluate(Project project, Property property)
        {            
            if (property.PropertyType == PropertyType.ParentRelationship || property.PropertyType == PropertyType.ReferenceRelationship)
            {
                var relationshipEntity = project.Entities.Where(p => p.Id == property.ParentEntityId.Value).First();
                return $@"        /// <summary>
        /// Foreign Key (Parent Relationship) to {relationshipEntity.InternalName}
        /// </summary>
        public Guid{(property.Required ? "" : "?")} {property.InternalName}Id {{ get; set; }}
        /// <summary>
        /// Foreign Key navigation object (Parent Relationship) to {relationshipEntity.InternalName}
        /// </summary>
        public {relationshipEntity.InternalName} {property.InternalName} {{ get; set; }}";
            }
            else if (property.PropertyType == PropertyType.OneToOneRelationship)
            {
                var relationshipEntity = project.Entities.Where(p => p.Id == property.ParentEntityId.Value).First();
                return $@"        /// <summary>
        /// One to One Navigation object (One To One Relationship) to {relationshipEntity.InternalName}
        /// </summary>
        public {relationshipEntity.InternalName} {property.InternalName} {{ get; set; }}";
            }
            else if (property.PropertyType == PropertyType.PrimaryKey)
            {
                return @"        /// <summary>
        /// Primary Key
        /// </summary>
        public Guid Id { get; set; }";
            }
            else
            {
                return $@"        /// <summary>
        /// {property.Title}
        /// </summary>
        public {property.CsType} {property.InternalName} {{ get; set; }}";
            }

        }
    }
}
