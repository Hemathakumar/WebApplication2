using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp2.Models
{
    public interface IMessageService
    {
        string GetMessage();
    }
    public class EmailService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from EmailService!";
        }
    }
}
