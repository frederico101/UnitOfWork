namespace DomainCore
{
    public class Validacoes
    {
        public static void ValidarSeNulo(object obj, string mensagem)
        {
            if (obj == "")
            {
                throw new DomainException(mensagem);
            }
        }
    }
}