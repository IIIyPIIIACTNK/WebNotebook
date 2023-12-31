﻿using System.ComponentModel.DataAnnotations;

namespace Notebook.Models
{
    public class Contact
    {
        [Key]
        public string Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
