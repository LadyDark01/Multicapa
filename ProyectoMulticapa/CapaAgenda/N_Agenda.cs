using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEnlace;
using Capa_Datos;

namespace CapaAgenda
{
    public class N_Agenda
    {
        D_Agenda objDato = new D_Agenda();
        public List<E_Agenda> ListarContacto (string buscar)
        {
            return objDato.ListarContacto (buscar);
        }
        public void InsertandoContacto (E_Agenda Agenda)
        {
            objDato.InsertarContacto (Agenda);
        }
        public void EditandoContacto(E_Agenda Agenda)
        {
            objDato.EditarContacto(Agenda);
        }
        public void EliminandoContacto(E_Agenda Agenda)
        {
            objDato.EliminarContacto(Agenda);
        }
    }
}
