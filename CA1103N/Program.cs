using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1103N
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();
            funcionario1.cadastrar();
            funcionario1.mostrarDados();
            funcionario1.descontaSalario();
            funcionario1.mostrarDados();
            Console.ReadKey();
            funcionario2.cadastrar();
            funcionario2.mostrarDados();
            Console.ReadKey();
        }
    }
}
