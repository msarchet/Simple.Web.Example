using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Simple.Web.Behaviors;
using Simple.Web.Example.Models;
using Simple.Web.Links;

namespace Simple.Web.Example
{
    [UriTemplate("json/{Id}/Address")]
    public class Addresses : IGet, IOutput<Address>
    {
        #region IGet Members

        public Status Get()
        {
            return 200;
        }

        #endregion

        #region IOutput<Address> Members

        public Address Output
        {
            get { return new Address() { Street = "8th" }; }
        }

        public int Id { get; set; }

        #endregion
    }
}