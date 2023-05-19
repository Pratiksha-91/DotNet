using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransposeArray
{
    internal class Program
    {
         public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int[,] arr = new int[10,20];
            int[,] brr = new int[10,20];
            Console.Write("enter array size");
            int row,col;
            
            
          
            row = Convert.ToInt32(Console.ReadLine());
            col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter array elements:");
            for(int i=0;i<row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Accepted array is:");
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j]);
                    
                }
            }
            for(int i =0; i <row;i++)
            {
                for(int j=0;j<col; j++)
                {
                    brr[j, i] = arr[i, j];
                }
            }
            Console.WriteLine("transpose of array");
            for(int i = 0; i<col; i++)
            {
                for(int j = 0; j<row; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
           
            


        }
    }
}
