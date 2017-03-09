using System.Collections.Generic;

namespace FizzBuzz.Service.Exception
{
    public class BusinessException : System.Exception
    {
        private new List<string> _message;
        public BusinessException(List<string> messages) 
            : base(string.Join(",",messages))
        {
            _message = new List<string>();
            _message.AddRange(messages);
        }
    }
}
