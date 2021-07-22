﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.POCO.Model
{
   public class UnidadesFederacaoPoco
    {
        public int  UFID { get; set; }

        public string Descricao { get; set; }

        public string SiglaUF { get; set; }

        public int RegiaoID { get; set; }

        public DateTime? DataInclusao { get; set; }
    }
}
