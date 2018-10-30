using System;
namespace projetocalculadora
{
    public class Calculo
    {
            private int num1, num2, resultado, teste;

        public void definirNum1(int valor1)
        {
            num1 = valor1;
        }

        public void definirNum2(int valor2)
        {
            num2 = valor2;
        }

        public void realizarOperacao (int sinal){
            teste = sinal;
            switch (sinal)
                {
                    case 1:
                        resultado = (num1 + num2);
                        break;

                    case 2:
                        resultado = (num1 - num2);
                        break;

                    case 3:
                        resultado = (num1 * num2);
                        break;

                    case 4:
                        resultado = (num1 / num2);
                        break;

                    default:

                        break;

                }

        }


        public int resul()
        {
            return resultado;
        }

        public int test()
        {
            return teste;
        }
    }
}

