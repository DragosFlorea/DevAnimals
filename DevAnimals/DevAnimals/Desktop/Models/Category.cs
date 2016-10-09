using DevAnimals.Desktop.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAnimals.Desktop.Models
{
    internal class Category: ObservableObjectBase
    {
        /// <summary>
        /// Gets or sets the category name of interests
        /// </summary>
        public int IdCategory {get;set;}
        /// <summary>
        /// /// Gets or sets the category type
        /// </summary>
        public string TypeCategory {get; set;}
        /// <summary>
        /// /// Gets or sets the category type
        /// </summary>
        public string ZoneCategory { get; set; }
        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <remarks>Is a blob in the database.</remarks>
        public byte[] PictureCategory { get; set; }
    }
}
