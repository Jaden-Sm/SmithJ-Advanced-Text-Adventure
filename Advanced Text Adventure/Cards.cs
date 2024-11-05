using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Text_Adventure
{
    internal class Cards
    {
        public string name, Render;
        public int value;

        public Cards(int value = 1, string name = "a", string Render = "a")
        {
            this.value = value;
            this.name = name;
            this.Render = Render;
        }
    }
}
