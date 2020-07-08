using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Developer : User
    {
        private Dictionary<string, object> attrib;

        //calling the base constructor
        public Developer():base("firstName", "lastName")=> attrib = new Dictionary<string, object>();

        // getter and setter for arbitrary attributes
        public void SetAttribute(string key, object value) => attrib.Add(key, value);

        public object GetAttribute(string key) => attrib[key];


    }
}
