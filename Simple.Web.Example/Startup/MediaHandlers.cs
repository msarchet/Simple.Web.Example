using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple.Web.Example.Startup
{
    public class MediaHandlers : IStartupTask
    {
        public void Run(IConfiguration configuration, IWebEnvironment environment)
        {
            configuration.DefaultMediaTypeHandler = new Simple.Web.JsonNet.JsonMediaTypeHandler();
        }
    }
}