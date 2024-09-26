using FluentValidation;
using SocialMedia.Core.DTOs;

namespace SocialMedia.Infrastructure.Validators
{
    public class PostValidator : AbstractValidator<PostDto>
    {
        public PostValidator()
        {
            //Regla para validar que la descripcion no sea nula
            RuleFor(post => post.Description)
                .NotNull()
                .WithMessage("La descripcion no puede ser nula");

            //Regla para validar el rando de la descripcion
            RuleFor(post => post.Description)
                .Length(10, 500)
                .WithMessage("La longitud de la descripcion debe estar entre 10 y 500 caracteres");

            //Regla para que la fecha sea a tiempo real
            RuleFor(post => post.Date)
                .NotNull()
                .LessThan(DateTime.Now);

        }
    }
}