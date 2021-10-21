using CsvHelper.Configuration.Attributes;
using GRA.Domain.Exceptions;
using GRA.Domain.Validators;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Domain.Entities
{
    public class Movie : Base
    {

        [Name("year")]
        public int Year { get; set; }

        [Name("title")]
        public string Title { get; set; }

        [Name("studios")]
        public string Studios { get; set; }

        [Name("producers")]
        public string Producers { get; set; }

        [Name("winner")]
        public string Winner { get; set; }

        //internal List<string> _errors = new List<string>();
        //public IReadOnlyCollection<string> Errors => _errors;

        public Movie(){}

        public override bool Validate()
        {
            var validator = new MovieValidator();
            var valid = validator.Validate(this);

            if (!valid.IsValid)
            {
                foreach (var erro in valid.Errors)
                    _errors.Add(erro.ErrorMessage);

                throw new DomainException($"Campos inválidos ", _errors);
            }

            return true;
        }
    }
}
