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
4. In https://dotnetfiddle.net and Select Menu -> Run

using System;					
public class Program
{
	public static void Main()
	{	    
           var n = 3; // disks           
           towerOfHanoi(n, 'A', 'B', 'C');// source ,  auxil, destin,  
	}	
	static void towerOfHanoi(int n, char from_Tower,char helper_Tower, char to_Tower )
        {
            if (n > 0)
            {            
            towerOfHanoi(n - 1, from_Tower,to_Tower, helper_Tower);            
            Console.WriteLine("move disk " + n + " from tower " + from_Tower + " to tower " + to_Tower);
            towerOfHanoi(n - 1, helper_Tower, from_Tower, to_Tower);
            }            
        }    
}

![Capture](https://user-images.githubusercontent.com/6586322/193430676-2d35364a-d186-44a8-b6c1-d3c73cd5ebb5.PNG)
![Capture](https://user-images.githubusercontent.com/6586322/193430682-24459b2a-e01e-4b06-9972-2762fbc70c29.PNG)
