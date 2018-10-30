using System;

namespace projetocalculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculo calc = new Calculo();

            Console.WriteLine("Informe O 1o numeros");
            calc.definirNum1(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe O 2o numeros");
            calc.definirNum2(Int32.Parse(Console.ReadLine()));


            Console.WriteLine("Informe a operacao:\n\n1 - Soma;\n2 - Subtracao;\n3 - Multiplicacao;\n4 - Divisao.");
            calc.realizarOperacao(Int32.Parse(Console.ReadLine()));

            if(calc.test()>= 0 & calc.test() <= 4){
                Console.WriteLine("\nO resultado e: " + calc.resul());
            }
            else{
                Console.WriteLine("Operacao incorreta");
            }


        }
            
    }
}
