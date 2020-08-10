using System;
using System.Collections.Generic;
using System.Text;

namespace ExercPoposto_146.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensagem) : base(mensagem) { }
    }
}
