﻿namespace PetClinic.DataProcessor.Dto.ImportDto
{
    using System.ComponentModel.DataAnnotations;

    public class AnimalAidDto
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "79228162514264337593543950335")]
        public decimal Price { get; set; }
    }
}
