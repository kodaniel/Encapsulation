using Newtonsoft.Json;
using NLua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAssembly
{
    public class SomeClass
    {
        private Lua lua;

        public SomeClass()
        {
            lua = new Lua();
        }

        public void DoSomething()
        {
            var result = lua.DoString(@"return 4 + 5")[0];

            var jsonText = JsonConvert.SerializeObject(result);

            Console.WriteLine(jsonText);
        }
    }
}
