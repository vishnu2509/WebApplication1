//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(18,60,ErrorMessage ="please enter age between 18 and  60")]
        public Nullable<int> Age { get; set; }

        [Required]
        [RegularExpression("[6-9]{1}[0-9]{9}",ErrorMessage ="Enter valid mobileno.")]
        public string Mobile { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
