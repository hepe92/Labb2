using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{

    public class ListConfig
    {
        string answer;
        bool yn;

        public string ToString()
        {
            return answer;
        }

        public ListConfig(string answer, bool yn)
        {
            this.answer = answer;
            this.yn = yn;

        }

        public string Answer { get => answer; set => answer = value; }
        public bool Yn { get => yn; set => yn = value; }
    }
}
