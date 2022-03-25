using System.Text;

namespace Task
{
    internal class Node<T>
        where T : struct, IComparable
    {
        public T Value { get; }
        private int count;
        private int countLeft;
        private Node<T>? left;
        private Node<T>? right;
        private bool IsLeave => left == null && right == null;

        public Node(T val)
        {
            this.Value = val;
            count = 1;
            left = null;
            right = null;
            countLeft = 0;
        }

        public void InsertValue(T value)
        {
            switch (Value.CompareTo(value))
            {
                case 0:
                    count++;
                    break;
                case < 0:
                    if (right != null)
                    {
                        right.InsertValue(value);
                    }
                    else
                    {
                        right = new Node<T>(value);
                    }

                    break;
                default:
                    if (left != null)
                    {
                        left.InsertValue(value);
                    }
                    else
                    {
                        left = new Node<T>(value);
                    }

                    countLeft = left.countLeft + 1;
                    break;
            }
        }

        public void Print()
        {
            var queue = new Queue<Node<T>>();
            queue.Enqueue(this);
            while (queue.Count != 0)
            {
                Node<T> step = queue.Dequeue();
                Console.WriteLine($"Значение: {step.Value}, в количестве {step.count}");
                if (step.left != null)
                {
                    queue.Enqueue(step.left);
                }

                if (step.right != null)
                {
                    queue.Enqueue(step.right);
                }
            }
        }

        public void PrintBack()
        {
            var queue = new Queue<Node<T>>();
            queue.Enqueue(this);
            while (queue.Count != 0)
            {
                Node<T> step = queue.Dequeue();
                Console.WriteLine($"Значение: {step.Value}, в количестве {step.count}");
                if (step.right != null)
                {
                    queue.Enqueue(step.right);
                }

                if (step.left != null)
                {
                    queue.Enqueue(step.left);
                }
            }
        }

        public void Delete(T value)
        {
            switch (Value.CompareTo(value))
            {
                case 0:
                    if (left == null)
                    {
                        right = right?.right;
                    }
                    else
                    {
                        left = left?.left;
                    }

                    break;
                case > 0:
                    if (left == null)
                    {
                        throw new ArgumentException("Такого элемента нет");
                    }

                    if (left.IsLeave)
                    {
                        left = null;
                    }
                    else
                    {
                        left.Delete(value);
                    }

                    break;
                default:
                    if (right == null)
                    {
                        throw new ArgumentException("Такого элемента нет");
                    }

                    if (right.IsLeave)
                    {
                        right = null;
                    }
                    else
                    {
                        right.Delete(value);
                    }

                    break;
            }
        }

        public bool Find(T value) => Value.CompareTo(value) switch
        {
            0 => true,
            > 0 => right != null && right.Find(value),
            _ => left != null && left.Find(value)
        };

        public void Postorder()
        {
            var queue = new Queue<(Node<T>, int, int)>();
            var ans = new List<StringBuilder>();
            queue.Enqueue((this, 0, countLeft));
            while (queue.Count != 0)
            {
                (Node<T> step, int depth, int stride) = queue.Dequeue();
                var isLeft = false;
                if (depth == ans.Count)
                {
                    if (depth != 0)
                        Console.WriteLine(ans[depth - 1]);
                    ans.Add(new StringBuilder());
                    isLeft = true;
                }

                for (var _ = 0; _ < (isLeft ? stride : 2); ++_)
                {
                    ans[depth].Append('\t');
                }

                ans[depth].Append(step.Value);
                if (step.left != null)
                {
                    queue.Enqueue((step.left, depth + 1, stride - 1));
                }

                if (step.right != null)
                {
                    queue.Enqueue((step.right, depth + 1, stride + 1));
                }
            }
        }
    }

    internal class BinaryTree<T>
        where T : struct, IComparable
    {
        private Node<T>? root;

        public BinaryTree() => root = null;

        public void Insert(T val)
        {
            if (root == null)
            {
                root = new Node<T>(val);
            }
            else
            {
                root?.InsertValue(val);
            }
        }

        public void Print() => root?.Print();


        public void Delete(T val)
        {
            if (root == null)
            {
                throw new ArgumentException("Такого элемента нет");
            }

            root?.Delete(val);
        }

        private bool Find(T value) => root != null && root.Find(value);

        public void Preorder(Node<T> node)
        {
            if (Find(node.Value))
            {
                node.Print();
            }
        }

        public void Clear() => root = null;

        public void Inorder() => root?.PrintBack();

        public void Postorder() => root?.Postorder();

    }

    class Program
    {
        private static void Main()
        {
            var tree = new BinaryTree<int>();
            for (var i = 0; i < 10; i++)
            {
                tree.Insert(i);
            }

            for (int i = -1; i > -11; i--)
            {
                tree.Insert(i);
            }

            tree.Print();
        }
    }
}