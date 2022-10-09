﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Company Name is Required Field")]
        [MaxLength(60,ErrorMessage = "Maximum length for Name is 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company Address is Required Field")]
        [MaxLength(60, ErrorMessage = "Maximum length for Address is 60 characters")]
        public string Address { get; set; }

        public string Country { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
