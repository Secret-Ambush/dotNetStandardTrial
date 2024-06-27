using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetStandardTrialClass
{
    public class Operator
    {
        public List<Person> CreateListOfPeople()
        {
            List<Person> output = new List<Person>();
            output.Add(new Person { FirstName = "Rebecca", LastName = "Banner" });

            return output;
        }
    }
}
