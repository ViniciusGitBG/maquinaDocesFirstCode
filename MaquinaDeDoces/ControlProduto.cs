using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
     class ControlProduto
    {
        Produto prod;
        private int opcao;
        public ControlProduto()
        {
            prod = new Produto();
            modificarOpcao = -1;
        }// fim do método construtor

        // metodo get set

        public int modificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }

        }// fim do metodo get e set



        public void menu() // inicio metodo menu 
        {
            
            Console.WriteLine("Escolha uma das opções abaixo: \n" +
                "0. Sair\n"+
                "1. Cadastrar um produto\n" +
                "2.Consultar um produto\n" +
                "3.Atualizar um produto\n" +
                "4. Mudar situação\n");
            modificarOpcao = Convert.ToInt32(Console.ReadLine());
        }// fim metodo menu

        // Realizar a operação
        public void Operacao()
        {
            do
            {
                menu(); // mostrando menu na tela
                switch (modificarOpcao)
                {
                    case 1:
                        Console.WriteLine("Obrigado");
                        Console.Clear();// limpando a tela
                        break;
                    case 2:
                        ColetarDados();
                        Console.Clear();// limpando a tela
                        break;
                    case 3:
                        Consultar();
                        Console.Clear();// limpando a tela
                        break;
                    case 4:
                        Atualizar();
                        Console.Clear();// limpando a tela
                        break;
                    case 5:
                        alterarSituacao();
                        Console.Clear();// limpando a tela
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;

                }// fim do switch
            } while(modificarOpcao != 0);

        }// fim do metodo operacao


        // Criar um metodo de solicitação de dados

        public void ColetarDados()
        {
            Console.WriteLine("Informe um código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe uma breve descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produto em estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validade do produto: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a Situação: True - Ativo | False - Inativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

            // cadastrar produto
            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, data, situacao);
            Console.WriteLine("Dado não registrado");


        }// fim do metodo construtor coletar dados


        // consultar 

        public void Consultar()
        {
 
            Console.WriteLine("\n\n\nInforme o código do produto que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            // Escrever o resultado da consulta na tela

            Console.WriteLine("Os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
            Console.WriteLine(prod.ConsultarProduto(0)); // para chamar os metodos

        }// fim do metodo 

        // atualizar 

        public void Atualizar()
        {
            Console.WriteLine("\n\nInforme o código do produto que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            short campo = 0;
            do {
                Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regra abaixo: \n" +
                    "1. Nome\n" +
                    "2.descrição\n" +
                    "3. preço\n" +
                    "4. quantidade\n" +
                    "5. data de validade\n" +
                    "6. Situação\n");

                campo = Convert.ToInt16(Console.ReadLine());

                // avisar usuario

                if ((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro, escolha um código entre 1 e 6");

                }

            }while((campo <1)|| (campo > 6));


            Console.WriteLine("Informe o dado para a atualização: ");
            string novoDado = Console.ReadLine();

            // chamar o metodo de atualização 
            prod.AtualizaProduto(codigo, campo, novoDado);

        }// fim do metodo atualizar

        public void alterarSituacao()
        {
            Console.WriteLine("Informe o código do produto que deseja alterar o status: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            // chamar o metodo alterarSituacao - classe produto

            prod.SolicitarProduto(codigo);
            Console.WriteLine("Alterado");

        }


    }// fim da classe
}// fim do projeto
