﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShelf.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name can't be Empty")]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
