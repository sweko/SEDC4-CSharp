using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflect.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private string address = "Default Value";
        public string Address
        {
            get
            {
                if (address == null)
                    return string.Empty;
                return address;
            }
            set
            {
                if (value == null)
                    value = string.Empty;
                address = value;
            }
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetFormatedName(string format)
        {
            return string.Format(format, FirstName, LastName, Age);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public static class ReflectionExtensions
    {
        public static void SetProperty<T>(this object thing, string name, T value) {
            thing.GetType().GetProperty(name).SetValue(thing, value);
        }

        public static T GetProperty<T>(this object thing, string name)
        {
            return (T) thing.GetType().GetProperty(name).GetValue(thing);
        }

    }
}
