using Atacado.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro27UsandoDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            AtacadoModel crud = new AtacadoModel();
            List<UnidadesFederacao> estados = crud.Estados.ToList();
            Console.WriteLine("Lista de Unidades Federativas:");

            foreach (var item in estados)
            {
                Console.WriteLine("ID: {0} - Descrição: {1} - SiglaUF: {2} - RegiaoID: {3}", item.UFID, item.Descricao,item.SiglaUF,item.RegiaoID);
            }

            Console.ReadKey();
        }
    }
}
