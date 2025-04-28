using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testapp2.Models;

namespace testapp2.App_Start
{
    public class NinjectWebCommon
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IMessageService>().To<EmailService>();
            
        }
    }
}