using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Reader : IReader
    {
        public string ReadText()
        {
            return Console.ReadLine();
        }
        public int ReadNumbers()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
