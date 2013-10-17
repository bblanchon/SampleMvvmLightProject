using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvvmLightProject.Model
{
    class RunTimeModel : IModel
    {
        public string SomeText
        {
            get { return "I'm an instance of RunTimeModel"; }
        }
    }
}
