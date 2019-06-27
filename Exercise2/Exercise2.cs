using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Exercise2
    {
        public static void start()
        {
            Node root = new Branch(1);
            root.Add(new Leaf(2));

            Branch b1 = new Branch(3);
            b1.Add(new Leaf(4));
            b1.Add(new Leaf(5));

            root.Add(b1);

            Console.WriteLine(root.Sum());
            Console.WriteLine(IsAllOdd(root));
        }

        private static bool IsAllOdd(Node node)
        {
            bool isSubNodesEven = true;
            if(node.GetType()==typeof(Branch))
            {
                Branch b = (Branch)node;
                foreach (Node n in b.Childrens)
                {
                    isSubNodesEven = isSubNodesEven && n.IsEven();
                }
            }

            return isSubNodesEven && node.IsEven();
        }
    }
}
