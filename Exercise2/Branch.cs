using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Branch : Node
    {
        private List<Node> _childrens = new List<Node>();

        public List<Node> Childrens { get { return _childrens; } }

        public Branch(double num):base(num)
        {

        }

        public override void Add(Node node)
        {
            _childrens.Add(node);
        }

        public override void Remove(Node node)
        {
            _childrens.Remove(node);
        }

        public override double Sum()
        {
            double sum = num;
            foreach (Node child in _childrens)
            {
                sum += child.Sum();
            }

            return sum;
        }
    }
}
