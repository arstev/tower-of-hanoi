There are 2 ways to run it:

1st This program need to Visual studio code installed on your Pc

If you have three disks
The program will solve this in 7 Steps :
 
move disk 1 from tower A to tower C
move disk 2 from tower A to tower B
move disk 1 from tower C to tower B
move disk 3 from tower A to tower C
move disk 1 from tower B to tower A
move disk 2 from tower B to tower C
move disk 1 from tower A to tower C

2nd way to test this 
You can run it in https://dotnetfiddle.net/. 
1. Menu -> NEW 
2. Select Language -> C# 
3. Copy and Paste this code below
4 Go back to https://dotnetfiddle.net and Select Menu -> Run

using System;					
public class Program
{
	public static void Main()
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
            Console.WriteLine("move disk " + n + " from tower " + from_Tower + " to tower " + to_Tower);

            towerOfHanoi(n - 1, helper_Tower, from_Tower, to_Tower);
            }            
        }    
}

