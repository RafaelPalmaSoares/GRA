using FluentValidation;
using GRA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Domain.Validators
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(movie => movie)
                .NotEmpty()
                .WithMessage($"A entidade não pode ser vazia ! Data da integração: {DateTime.Now}")

                .NotNull()
                .WithMessage($"A entidade não pode ser nula ! Data da integração: {DateTime.Now}");

            RuleFor(movie => movie.Year)
                .NotEmpty()
                .WithMessage($"O atributo Year não pode ser vazia ! Data da integração: {DateTime.Now}")

                .NotNull()
                .WithMessage($"O atributo Year não pode ser nula ! Data da integração: {DateTime.Now}");

            RuleFor(movie => movie.Title)
                .NotEmpty()
                .WithMessage($"O atributo Title não pode ser vazia ! Data da integração: {DateTime.Now}")

                .NotNull()
                .WithMessage($"O atributo Title não pode ser nula ! Data da integração: {DateTime.Now}");

            RuleFor(movie => movie.Studios)
                .NotEmpty()
                .WithMessage($"O atributo Studios não pode ser vazia ! Data da integração: {DateTime.Now}")

                .NotNull()
                .WithMessage($"O atributo Studios não pode ser nula ! Data da integração: {DateTime.Now}");

            RuleFor(movie => movie.Producers)
                .NotEmpty()
                .WithMessage($"O atributo Producers não pode ser vazia ! Data da integração: {DateTime.Now}")

                .NotNull()
                .WithMessage($"O atributo Producers não pode ser nula ! Data da integração: {DateTime.Now}");

        }
    }
}
