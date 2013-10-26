﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Title must be between 3-50 characters!")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Author name must be between 3-50 characters!")]
        public string Author { get; set; }

        public string ISBN { get; set; }

        public string Description { get; set; }

        public string WebSite { get; set; }

        [UIHint("CategoryEditor")]
        public virtual Category Category { get; set; }

        public Book()
        {
            this.Category = new Category();
        }
    }
}