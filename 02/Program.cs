using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        class Block
        {
            public int left;
            public int right;
            public int top;
            public int bottom;

            public override string ToString()
            {
                return $"left: {left}, right: {right}, top: {top}, bottom: {bottom}";
            }


            public override int GetHashCode()
            {
                return left ^ right ^ top ^ bottom;
            }
            public override bool Equals(object obj)
            {

                if(obj != null && obj is Block rightHand)
                {

                    if (left == rightHand.left && right == rightHand.right && top == rightHand.top && bottom == rightHand.bottom)
                        return true;

                }

                return false;


                //
                // old style
                //
                if (obj == null || !(obj is Block))
                    return false;

                Block rightHand_ = obj as Block;
                if (left != rightHand_.left || right != rightHand_.right || top != rightHand_.top || bottom != rightHand_.bottom)
                    return false;

                return true;
            }

            public Block(int left, int right, int top, int bottom)
            {
                this.left = left;
                this.right = right;
                this.top = top;
                this.bottom = bottom;
            }
        }
        static void Main(string[] args)
        {
            Block block1 = new Block(2, 2, 4, 4);
            Block block2 = new Block(2, 2, 4, 4);

            Console.WriteLine(block1.Equals(block2));
            Console.WriteLine(block1.GetHashCode());
            Console.WriteLine(block2.GetHashCode());


            Console.ReadKey();
        }
    }
}
