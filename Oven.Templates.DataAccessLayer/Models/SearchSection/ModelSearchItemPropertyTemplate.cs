using Oven.Request;
using System;
using System.Collections.Generic;

namespace Oven.Templates.DataAccessLayer.Models
{
    /// <summary>
    /// Model Search Item Property Template
    /// </summary>
    public class ModelSearchItemPropertyTemplate
    {
        /// <summary>
        /// Evaluate
        /// </summary>
        public static string Evaluate(SearchColumn searchColumn)
        {
            var properties = new List<string>() { $@"        /// <summary>
        /// {searchColumn.TitleValue}
        /// </summary>
        [Display(Name = ""{searchColumn.TitleValue}"")]
        public {searchColumn.TypeCSharp} {searchColumn.InternalNameCSharp} {{ get; set; }}" };

            return string.Join(Environment.NewLine, properties);
        }
    }
}
