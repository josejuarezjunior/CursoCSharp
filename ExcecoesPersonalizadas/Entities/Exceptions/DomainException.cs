using System;

namespace ExcecoesPersonalizadas.Entities.Exceptions
{

    /* A Classe "DomainException" é uma classe personalizada
     * que contém herança da classe "ApplicationException"
     * que é uma classe do sistema para exceções personalizadas!
    */
    class DomainException : ApplicationException
    {

        /* ": base(message)" informa que será usada a mensagem do sistema
        ** como argumento também!
        */
        public DomainException(string message) : base(message)
        {
        }
    }
}