﻿using System;
using System.ComponentModel.DataAnnotations;

namespace APIUsuario.Validations
{
    public class NaoPermitirDataAtualAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var dataNascimento = Convert.ToDateTime(value);

            if (dataNascimento > DateTime.Now)
            {
                return new ValidationResult("A data de nascimento não pode ser maior que a de hoje.");
            }

            return ValidationResult.Success;
        }
    }
}
