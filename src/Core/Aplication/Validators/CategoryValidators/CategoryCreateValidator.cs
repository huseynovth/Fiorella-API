using Fiorella.Aplication.DTOs.CategoryDTOs;
using FluentValidation;
using System;

namespace Fiorella.Aplication.Validators.CategoryValidators;

public class CategoryCreateValidator : AbstractValidator<CategoryCreateDto>
{
    public CategoryCreateValidator()
    {
        RuleFor(x => x.name).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.description).MaximumLength(500);
    }
}
