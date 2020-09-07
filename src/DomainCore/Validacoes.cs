namespace DomainCore
{
    public class Validacoes
    {
        public static void ValidarSeNulo(object obj, string mensagem)
        {
            if (obj == null)
            {
                throw new DomainException("Não deve ser nulo");
            }
        }
    }
}