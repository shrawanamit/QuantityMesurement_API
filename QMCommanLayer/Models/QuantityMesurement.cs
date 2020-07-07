//-----------------------------------------------------------------------
// <copyright file="QuantityMesurementCL.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Amit kumar</author>
//-----------------------------------------------------------------------


namespace QMCommanLayer
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class QuantityMesurement
    {
        /// <summary>
        /// Auto generated Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// option type for different conversion
        /// </summary>
        [Required (ErrorMessage = "Conversion Type is Required")]
        public string ConversionType { get; set; }

        /// <summary>
        /// value for input
        /// </summary>
        [Required(ErrorMessage ="Value is Required")]
        public double Value { get; set; }

        /// <summary>
        /// result for conversion
        /// </summary>
        public double Result { get; set; }

        /// <summary>
        /// date and time when result is generated
        /// </summary>
        public DateTime DateOFCreation { get; set; } = DateTime.Now;
    }
}
