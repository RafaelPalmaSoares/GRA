using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Domain.Exceptions
{
    public class DomainException : Exception
    {
        internal List<string> _erros;
        public IReadOnlyCollection<string> Erros => _erros;
        public DomainException(string mensagem, List<string> erros) : base(mensagem)
        {
            _erros = erros;
        }
    }
}
