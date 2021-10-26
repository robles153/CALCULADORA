using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1 , Subtracao = 2, Divisao =3, Multiplicacao, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool EscolheuSair = false;
            while(!EscolheuSair) //Enquanto o usuario não(!) escolher sair exiba o menu
                                  //
            {

                Console.WriteLine("Seja Bem Vindo Ao CALC, Selecione Uma Das Opções:\n");
                Console.WriteLine(" 1-Soma\n 2-Subtração\n 3-Divisão\n 4-Multiplicação\n 5-Potência\n 6-Raiz\n 7-SAIR");

                /*string opcaoTXT = Console.ReadLine();
                int opcaoint = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoint;*/

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

               switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divi();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                            EscolheuSair = true;

                            break;
                }
                Console.Clear();      

            }



        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois Numeros:");
            Console.WriteLine("Digite o Primeiro Numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sigite o Segundo Numero:");
            int b = int.Parse(Console.ReadLine());
            int Resultado = a + b;
            Console.WriteLine($"O resultado é: {Resultado} "); // Usando interpolação $ {}
            Console.WriteLine("Aperte ENTER Para Voltar Para o MENU:");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois Numeros:");
            Console.WriteLine("Digite o Primeiro Numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sigite o Segundo Numero:");
            int b = int.Parse(Console.ReadLine());
            int Resultado = a - b;
            Console.WriteLine($"O resultado é: {Resultado} "); 
            Console.WriteLine("Aperte ENTER Para Voltar Para o MENU:");
            Console.ReadLine();
        }
        static void Divi()
        {
            Console.WriteLine("Divisão de dois Numeros:");
            Console.WriteLine("Digite o Primeiro Numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sigite o Segundo Numero:");
            int b = int.Parse(Console.ReadLine());
            float Resultado = (float)a / (float)b;  //Cast
            Console.WriteLine($"O resultado é: {Resultado} "); 
            Console.WriteLine("Aperte ENTER Para Voltar Para o MENU:");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois Numeros:");
            Console.WriteLine("Digite o Primeiro Numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sigite o Segundo Numero:");
            int b = int.Parse(Console.ReadLine());
            int Resultado = a * b;  
            Console.WriteLine($"O resultado é: {Resultado} ");
            Console.WriteLine("Aperte ENTER Para Voltar Para o MENU:");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potencia de um numero:");
            Console.WriteLine("Digite a Base:");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int expo = int.Parse(Console.ReadLine());
            int Resultado = (int)Math.Pow(basenum, expo);
            Console.WriteLine($"O resultado é: {Resultado} ");
            Console.WriteLine("Aperte ENTER Para Voltar Para o MENU:");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero:");
            Console.WriteLine("Digite o numero:");
            int a = int.Parse(Console.ReadLine());
           
            double Resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {Resultado} ");
            Console.WriteLine("Aperte ENTER Para Voltar Para o MENU:");
            Console.ReadLine();
        }



    }

}