using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1103N
{
    class Funcionario
    {
        public int matricula;
        public string nome;
        public string email;
        public double salario;


        public void cadastrar()
        {

            Console.WriteLine("Digite sua matricula:");
            this.matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome:");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite o salario:");
            this.salario = double.Parse(Console.ReadLine());
        }

        public void mostrarDados()
        {
            Console.WriteLine("Matricula:" + this.matricula);
            Console.WriteLine("Nome:{0}", this.nome);
            Console.WriteLine("E-mail:" + this.email);
            Console.WriteLine("Salario: R${0}", this.salario);
        }

        public void descontaSalario()
        {
            Console.WriteLine("Digite o valor do desconto:");
            double valorDesconto = double.Parse(Console.ReadLine());

            while(valorDesconto <= 0)
            {
                Console.WriteLine("Valor incorreto!");
                valorDesconto = this.setValorDesconto();
            }
            if(valorDesconto > 0)
            {
                this.salario = this.salario - valorDesconto;
                Console.WriteLine("Valor descontado" + valorDesconto);
            } else
            {
                Console.WriteLine("não houve desconto.");
            }
           
        }

        public void aumentaSalario(){
            Console.WriteLine("Digite o valor do aumento:");
            double valorAumento = double.Parse(Console.ReadLine());
            this.salario = this.salario + valorAumento;
            Console.WriteLine("Valor atualizado" + valorAumento);

        }

        public double setValorDesconto()
        {
            double valor;
            Console.WriteLine("Digite um valor: ");
            valor = double.Parse(Console.ReadLine());
            return valor;
        }
    }
}
