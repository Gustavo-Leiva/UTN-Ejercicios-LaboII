using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validacion
    {

        public static bool ValidarCarga(string name, string address, string gender, string country, string[] courses, int age)
        {

            return (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address)
                || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(country)
                || courses == null || courses.Length == 0 || age <= 18);
        }   

    }
}

