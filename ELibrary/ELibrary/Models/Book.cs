using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Автор")]
        public string Author { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Доступность")]
        public bool Available { get; set; }

        public Book()
        {
            Available = true;
        }
    }
}