﻿using FluentValidation;
using JRMarketing.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace JRMarketing.Infrastructure.Validators
{
    public class EtiquetaValidator : AbstractValidator<EtiquetumRequestDto>
    {
        public EtiquetaValidator()
        {
            RuleFor(eti => eti.NombreEtiqueta)
                .NotEmpty()
                .NotNull()
                .Length(3, 50);
        }
    }
}
