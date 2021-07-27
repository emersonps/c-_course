using System;

namespace HelloWorldCSharp
{
    public class HelloWorld
    {
        string _hello;

        public void SetHello(string hello){
            _hello = hello;
        }

        public string GetHello(){
            return _hello;
        }
    } 
}
