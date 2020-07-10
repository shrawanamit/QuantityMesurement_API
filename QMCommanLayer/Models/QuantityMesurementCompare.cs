using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QMCommanLayer.Models
{
    public class QuantityMesurementCompare
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //value for First unit value
        [Required]
        public double ValueOne { get; set; }

        //value for First unit
        [Required]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string UnitOfValueOne { get; set; }

        //value for Second unit value
        [Required]
        public double ValueTwo { get; set; }

        //value for Second unit
        [Required]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string UnitOfValueTwo { get; set; }

        //result of comparison
        public string Result { get; set; }

        //date and time when result is generated
        public DateTime DateOnCreation { get; set; } = DateTime.Now;
    }
}
