using System;
using System.Collections;

namespace Puzzle
{
    class Program
    {
       static void Main(string[] args)
       {       
           // disks
           var n = 3;
           // source ,  auxil, destin, 
           towerOfHanoi(n, 'A', 'B', 'C');
       } 
        static void towerOfHanoi(int n, char from_Tower,char helper_Tower, char to_Tower )
        {
            if (n > 0)
            {            
            towerOfHanoi(n - 1, from_Tower,to_Tower, helper_Tower);
            // showing a step
            Console.WriteLine("move disk " +  " from tower " + from_Tower + " to tower " + to_Tower);

            towerOfHanoi(n - 1, helper_Tower, from_Tower, to_Tower);
            }            
        }     
    }
}
