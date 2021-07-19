using System;
using System.Collections.Generic;
using System.Text;

namespace Encontro22POO
{
    public class PessoaFisica: Cliente
    {
        private string nome;
        
        private string endereco;

        private string cpf;

        private string rg ;

        private string tituloEleitor;
        
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Endereco 
        { 
            get => this.endereco; 
            set => this.endereco = value;
        }
        public string Cpf 
        { 
            get => this.cpf; 
            set => this.cpf = value;
        }
        public string Rg 
        {
            get => this.rg; 
            set => this.rg = value; 
        }
        public string TituloEleitor
        { 
            get => this.tituloEleitor; 
            set => this.tituloEleitor = value;
        }

        public PessoaFisica(): base()
        { }

        public PessoaFisica(int codCliente,
            string nome,
            string endereco,
            string cpf,
            string rg,
            string tituloEleitor,
            DateTime dataInclusao) 
            : base(codCliente, dataInclusao)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
            this.rg = rg;
            this.tituloEleitor = tituloEleitor;
        
        }

          
    }
}
