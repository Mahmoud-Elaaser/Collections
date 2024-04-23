using Collections;
using System;
using System.Collections.Generic;
using System.Text;
using Collections.Classes;


public class Program
{
    public static void Main()
    {

        List.Go();
        Console.WriteLine("********************[HashSet]********************");

        HashSet.Go();
        Console.WriteLine("******************[Dictionary]*******************");


        Dictionary.Go();
        Console.WriteLine("********************[Stack]**********************");


        Stack.Go();
        Console.WriteLine("********************[Queue]**********************");


        Queue.Go();
        Console.WriteLine("********************[Pair]**********************");


        Pair<int, string>.Go();             


        // Extension method => NameOfClass.NameOfFunction() and function must be static
    }
}