using Atacado.DAL.Model;
using Atacado.POCO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AtacadoRestApi.Controllers
{
    public class EstadosController : ApiController
    {
        // GET: api/Estados
        public List<UnidadesFederacaoPoco> Get()
        {
            AtacadoModel contexto = new AtacadoModel();

            // VERSAO LINQ
            List<UnidadesFederacaoPoco> estadoPoco = contexto.Estados.Select(

                novo => new UnidadesFederacaoPoco()
                {
                    UFID = novo.UFID ,
                    Descricao = novo.Descricao ,
                    SiglaUF = novo.SiglaUF ,
                    RegiaoID = novo.RegiaoID,
                    DataInclusao = novo.datainsert

                }).ToList();

            return estadoPoco;
        }

        // GET: api/Estados/5
        public UnidadesFederacaoPoco Get(int id)
        {
            AtacadoModel contexto = new AtacadoModel();

            UnidadesFederacaoPoco estadoPoco = (
                 from novo in contexto.Estados
                 where novo.UFID == id
                 select new UnidadesFederacaoPoco()
                 {
                     UFID = novo.UFID,
                     Descricao = novo.Descricao,
                     SiglaUF = novo.SiglaUF,
                     RegiaoID = novo.RegiaoID,
                     DataInclusao = novo.datainsert
                 }).FirstOrDefault();

            return estadoPoco;

        }

        // POST: api/Estados
        public UnidadesFederacaoPoco Post([FromBody]UnidadesFederacaoPoco poco)
        {

            UnidadesFederacao estado = new UnidadesFederacao();
            estado.Descricao = poco.Descricao;
            estado.SiglaUF = poco.SiglaUF;
            estado.RegiaoID = poco.RegiaoID;
            estado.datainsert = DateTime.Now;

            AtacadoModel contexto = new AtacadoModel();
            contexto.Estados.Add(estado);
            contexto.SaveChanges();

            UnidadesFederacaoPoco novoPoco = new UnidadesFederacaoPoco();
            novoPoco.UFID = estado.UFID;
            novoPoco.Descricao = estado.Descricao;
            novoPoco.SiglaUF = estado.SiglaUF;
            novoPoco.RegiaoID = estado.RegiaoID;
            novoPoco.DataInclusao = estado.datainsert;

            return novoPoco;

        }

        // PUT: api/Estados/5
        public UnidadesFederacaoPoco Put(int id, [FromBody]UnidadesFederacaoPoco poco)
        {
            AtacadoModel contexto = new AtacadoModel();
            UnidadesFederacao estado = contexto.Estados.SingleOrDefault(reg =>reg.UFID== id);
            estado.Descricao = poco.Descricao;
            estado.SiglaUF = poco.SiglaUF;
            estado.RegiaoID = poco.RegiaoID;
            contexto.Entry<UnidadesFederacao>(estado).State = System.Data.Entity.EntityState.Modified;

            UnidadesFederacaoPoco novoPoco = new UnidadesFederacaoPoco();
            novoPoco.UFID = estado.UFID;
            novoPoco.Descricao = estado.Descricao;
            novoPoco.SiglaUF = estado.SiglaUF;
            novoPoco.RegiaoID = estado.RegiaoID;
            novoPoco.DataInclusao = estado.datainsert;

            return novoPoco;
        }

        // DELETE: api/Estados/5
        public UnidadesFederacaoPoco Delete(int id)
        {
            AtacadoModel contexto = new AtacadoModel();
            UnidadesFederacao estado = contexto.Estados.SingleOrDefault(reg => reg.UFID == id);
            contexto.Entry<UnidadesFederacao>(estado).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();

            UnidadesFederacaoPoco novoPoco = new UnidadesFederacaoPoco();
            novoPoco.UFID = estado.UFID;
            novoPoco.Descricao = estado.Descricao;
            novoPoco.SiglaUF = estado.SiglaUF;
            novoPoco.RegiaoID = estado.RegiaoID;
            novoPoco.DataInclusao = estado.datainsert;

            return novoPoco;
        }
    }
}
