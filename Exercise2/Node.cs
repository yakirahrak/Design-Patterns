using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public abstract class Node
    {
        protected double num;

        public Node(double num)
        {
            this.num = num;
        }

        public abstract void Add(Node node);
        public abstract void Remove(Node node);
        public abstract double Sum();

        public bool IsEven()
        {
            return num % 2 == 0;    
        }
    }
}
