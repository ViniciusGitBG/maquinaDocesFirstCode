using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Produto
    { // definição de variáveis
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime data;
        private Boolean situacao;

        // Método construtor

        public Produto()
        {
            ModificarCodigo = 0;
            ModificarNome = "";
            ModificarDescricao = "";
            ModificarPreco = 0;
            ModificarQuantidade = 0;
            ModificarDataValidade = new DateTime();// valor padrão do date time 0000/00/00 00:00:00
            ModificarSituacao = false; 
        }// fim do método construtor

         // método construtor com parametros
        public Produto(int codigo,string nome, string descricao, double preco, 
            int quantidade, DateTime data, Boolean situacao)
        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = data;
            ModificarSituacao = situacao;

        } // fim do método construtor com parametros

        // Métodos get e set(metodos de acesso e modificação)

        public int ModificarCodigo
        {
            get{
                return this.codigo;

            } // fim do get - retornar codigo

            set{
                this.codigo = value;

            } // fim do set - modificar codigo

        } // fim do modificarCodigo

        public string ModificarNome
        {
            get { return this.nome; }
            set { this.nome = value; }

        }// fim do modificar nome

        public string ModificarDescricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public double ModificarPreco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }// fim do modificar preco

        public int ModificarQuantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }// fim do modificar quantidade

        public DateTime ModificarDataValidade
        {
            get { return this.data; }
            set { this.data = value; }
        }// fim do modificar Datavalidade

        public Boolean ModificarSituacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }
        }// fim do modificarSituacao

        // metodo cadastrar produto 

        public void CadastrarProduto(
            int codigo,
            string nome,
            string descricao,
            double preco,
            int quantidade,
            DateTime dtValidade,
            Boolean situacao
            
            )
        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;

        }// fim do metodo CadastrarProduto

        //Consultar Produto
        public string ConsultarProduto(int codigo)
        {
            string msg = ""; // Criando uma variavel local

            if(ModificarCodigo == codigo)
            {
                msg = "\nCódigo: "          + ModificarCodigo +
                      "\nNome: "            + ModificarNome +
                      "\nDescrição"         + ModificarDescricao +
                      "\nPreço:"            + ModificarPreco +
                      "\nQuantidade"        + ModificarQuantidade +
                      "\nData de Validade:" + ModificarDataValidade +
                      "\nSituação:"         + ModificarSituacao;
            }
            else
            {
                msg = "O código digitado não existe!";
            }
            return msg;
        }// fim do metodo consultar produto
            
        // metodo atualizar
        public Boolean AtualizaProduto(int codigo, int campo, string novoDado)
        {
            Boolean flag = false;
            if (ModificarCodigo == codigo)
            {
                switch (campo)
                {
                    case 1:
                        ModificarNome = novoDado;
                        flag = true;
                        break;
                        
                    case 2:
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;
                       
                    case 3:
                        ModificarPreco = Convert.ToDouble(novoDado);
                        flag = true;
                        break;
                        
                    case 4:
                        ModificarQuantidade = Convert.ToInt32(novoDado);
                        flag = true;
                        break;
                        
                    case 5:
                        ModificarDataValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;
                        
                    case 6:
                        ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true;
                        break;
                        

                    default:

                        break;

                }// fim do escolha caso

                return flag;

            }// fim do if
            return flag;

        }// fim do atualizar produto
        public Boolean DesativaProduto(int codigo)
        {
            Boolean flag = false;
            if(ModificarCodigo == codigo)
            {
                if(ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else
                {
                    ModificarSituacao = true;
                }//fim do modificarSituacao
                flag = true;
            }//modificar codigo
            return flag;
        }// fim do desativar produto

        // solicitar produtos
        public Boolean SolicitarProduto(int codigo)
        {
            if (ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }
            }// fim do if
            return false;

                   
            
           

        }// fim do solicitar produto
    }// fim da classe

    class pagamento
    {// definindo variaveis
        private int codigo;
        private string descricao;
        private double valorTotal;
        private string formaPagamento;
        private DateTime data;
        private DateTime hora;
        private int codCartao;
        private string bandeiraCartao;



        public pagar()
        {
            ModificarCodigo = 0;
            ModificarDescricao = "";
            ModificarValor = 0;
            ModificarFormaPagamento = "";
            ModificarData = new DateTime();
            ModificarHora = new DateTime();
            ModificarCodCartao = 0;
        }// fim do metodo 

        public pagar(int codigo, string descricao, double valorTotal, string formaPagamento, DateTime data, DateTime hora, int codCartao,string bandeiraCartao)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;
            ModificarValor = valorTotal;
            ModificarFormaPagamento = formaPagamento;
            ModificarData = data;
            ModificarHora = hora;
            ModificarCodCartao = codCartao;
        }// fim do metodo com parametro

    }// fim da classe
} // fim do projeto
