using System;

namespace HelloWorldCSharp
{
    public class Principal
    {
        static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();
            hello.SetHello("Hello World");
            Console.WriteLine(hello.GetHello());
        } 
    } 
}