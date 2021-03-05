using System;

namespace OnionArcExample.Application.Exceptions
{
    public class MyException:Exception
    {
        public MyException():base("My error occured")
        {
        }
        public MyException(string message):base(message)
        {
        }
        public MyException(Exception exception):this(exception.Message)
        {
        }
    }
}
