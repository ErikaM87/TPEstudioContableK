using System;
using System.Collections.Generic;
using EstudioContable.AccesoDatos.Utilidades;
using EstudioContable.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstudioContable.AccesoDatos
{
   public class EmpresaDatos
    {
        //Empresa
        public List<Empresa> TraerTodosEmpresa()
        {
            string json2 = WebHelper.Get("EstudioContable/Empresas");
            List<Empresa> resultado = MapList(json2);
            return resultado;
        }

        public List<Empresa> Traer(int registro)
        {
            string json2 = WebHelper.Get("EstudioContable/Empresas/" + registro.ToString()); // trae un texto en formato json de una web
            List<Empresa> resultado = MapList(json2);
            return resultado;
        }


        public List<Empresa> MapList(string json)
        {
            List<Empresa> lst = JsonConvert.DeserializeObject<List<Empresa>>(json); // deserializacion
            return lst;
        }



        public Empresa MapObj(string json)
        {
            Empresa lst = JsonConvert.DeserializeObject<Empresa>(json); // deserializacion
            return lst;
        }

        public TransactionResult InsertarEmpresa(Empresa empresa)
        {
            NameValueCollection obj = ReverseMapEmpresa(empresa); //serializacion -> json

            string json = WebHelper.Post("EstudioContable/Empresa", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }


        public TransactionResult ActualizarEmpresa(Empresa empresa)
        {
            NameValueCollection obj = ReverseMapEmpresa(empresa);

            string json = WebHelper.Put("EstudioContable/Empresa", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public NameValueCollection ReverseMapEmpresa(Empresa empresa)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("razonSocial", empresa._razonSocial);
            n.Add("cuit", empresa._cuit.ToString());
            n.Add("domicilio", empresa._domicilio);
            n.Add("fechaAlta", empresa._fechaAlta.ToString());
            n.Add("usuario", empresa._usuario.ToString());
            n.Add("id", empresa._id.ToString());
            n.Add("Usuario", "892310");

            return n;
        }

    }
}
