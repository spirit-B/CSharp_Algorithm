namespace AlgorithmPractice
{
    class Node
    {
        public char Value;
        public Node Left;
        public Node Right;

        public Node(char value)
        {
            Value = value;
        }
    }
    internal class Program
    {
        static Dictionary<char, Node> nodes = new Dictionary<char, Node>();

        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var inputs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                char root = inputs[0][0];
                char left = inputs[1][0];
                char right = inputs[2][0];

                if (!nodes.ContainsKey(root))
                {
                    nodes[root] = new Node(root);
                }

                Node current = nodes[root];

                if (left != '.')
                {
                    if (!nodes.ContainsKey(left))
                    {
                        nodes[left] = new Node(left);
                    }
                    current.Left = nodes[left];
                }

                if (right != '.')
                {
                    if (!nodes.ContainsKey(right))
                    {
                        nodes[right] = new Node(right);
                    }
                    current.Right = nodes[right];
                }
            }

            Node rootNode = nodes['A'];
            Preorder(rootNode);
            Console.WriteLine();
            Inorder(rootNode);
            Console.WriteLine();
            PostOrder(rootNode);
            Console.WriteLine();
        }
        static void Preorder(Node node)
        {
            if (node == null) return;
            Console.Write(node.Value);
            Preorder(node.Left);
            Preorder(node.Right);
        }

        static void Inorder(Node node)
        {
            if (node == null) return;
            Inorder(node.Left);
            Console.Write(node.Value);
            Inorder(node.Right);
        }

        static void PostOrder(Node node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value);
        }
    }
}
