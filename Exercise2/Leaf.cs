using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Leaf : Node
    {
        public Leaf(double num): base(num)
        {

        }
        public override void Add(Node node)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Node node)
        {
            throw new NotImplementedException();
        }

        public override double Sum()
        {
            return num;
        }
    }
}
