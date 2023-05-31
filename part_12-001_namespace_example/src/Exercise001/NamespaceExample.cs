
namespace NamespaceExample
{
    using System;
    class Example
    {
        public void ExampleMethod()
        {
            Console.WriteLine("ExampleMethod in NamespaceExample");
        }
    }
    namespace InnerNamespaceExample
    {

        class Example
        {
            public void ExampleMethod()
            {
                Console.WriteLine("ExampleMethod in InnerNamespaceExample");
            }
        }


    }

}