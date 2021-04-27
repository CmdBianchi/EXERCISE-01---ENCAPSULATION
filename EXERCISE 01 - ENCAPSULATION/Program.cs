using System;
namespace EXERCISE_01___ENCAPSULATION {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {

            Product p = new Product("tv", 500, 10);

            p.SetName("T");
            Console.WriteLine(p.GetName());
            Console.WriteLine(p.GetPrice());
            Console.WriteLine(p.GetAmount());

        }
    }   
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}

