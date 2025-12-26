using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BVSAttribute;

namespace BVSAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BonaventureSystemsAttribute : Attribute
    {
        private string _CompanyName;
        private string _DeveloperName;



        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }
        public string DeveloperName
        {
            get { return _DeveloperName; }
            set { _DeveloperName = value; }
        }
    }
}
