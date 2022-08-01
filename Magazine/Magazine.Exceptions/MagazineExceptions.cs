using System;

namespace Magazine.Exceptions
{
    public class MagazineExceptions : ApplicationException
    {
        public MagazineExceptions(string message) : base(message)
        {

        }

        public MagazineExceptions(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}
