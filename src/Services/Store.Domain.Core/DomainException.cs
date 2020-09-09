using System;

namespace DomainCore
{
    public class DomainException: Exception
    {
       public DomainException(string mensagem): base(mensagem){}
    }
}