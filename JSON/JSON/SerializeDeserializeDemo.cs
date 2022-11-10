using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public static class SerializeDeserializeDemo
    {
        public static void Show()
        {
            string json = InitialData.Samples.SingleJson();
            Console.WriteLine("Išvedame JSON tesktą:");
            Console.WriteLine(json);
        }
    }
}
