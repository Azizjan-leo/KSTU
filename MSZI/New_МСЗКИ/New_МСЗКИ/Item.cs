using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МСЗКИ
{
    public class Item
    {
        public int Letter { get; set; }
        public int Count { get; set; }
        public Item() { }
        public Item(int l, int c)
        {
            Letter = l;
            Count = c;
        }
    }
}