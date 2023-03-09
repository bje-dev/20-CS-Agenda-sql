using DAL;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLContacto
    {
        DALContacto dalcontacto = new DALContacto();

        public void Create(DOMContacto pcontacto)
        {
            if (pcontacto.edad<18)
            {
                throw new Exception("El contacto es menor de edad");
            }
            else
            {
                dalcontacto.Create(pcontacto);
            }

            
        }
    }
}
