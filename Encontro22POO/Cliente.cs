using System;
using System.Collections.Generic;
using System.Text;

namespace Encontro22POO
{
    public abstract class Cliente
    {
        private int codCliente;

        private DateTime dataInclusao;

        public int CodCliente
        {
            get { return this.codCliente; }
            set { this.codCliente = value; }
        }

        public DateTime DataInclusao
        {
            get { return this.dataInclusao; }
            set { this.dataInclusao = value; }
        }

        public Cliente()
        { }

        public Cliente(int codCliente, DateTime dataInclusao)
        {

            this.codCliente = codCliente;
            this.dataInclusao = dataInclusao;

        }
    }
}
