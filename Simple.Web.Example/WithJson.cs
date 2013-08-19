using System;
using Simple.Web.Behaviors;
using Simple.Web.Example.Models;
using Simple.Web.Links;

namespace Simple.Web.Example
{
    [UriTemplate("/json")]
    public class WithJson : IGet, IOutput<Person>
    {
        public Status Get()
        {
            Output = new Person { Name = "Person" + DateTime.Now.Second };
            return Status.OK;
        }

        public Person Output
        {
            get;
            private set;
        }

    }
}