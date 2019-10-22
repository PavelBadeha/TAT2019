using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CW_2
{
    class Dean:Person
    {
        [JsonProperty]
        public int Office { get; private set; }

        public Dean() { }
        public Dean(string name, int age, int office) : base(name, age)
        {
            Office = office;
        }

        public override string ToString()
        {
            return "Dean\n"+base.ToString()+" Office:"+Office;
        }
    }
}
