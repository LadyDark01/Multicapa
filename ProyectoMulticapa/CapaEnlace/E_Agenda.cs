using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEnlace
{
    public class E_Agenda
    {
        private int _ID;
        private string _Nombre;
        private string _Apellido;
        private string _Genero;
        private string _Estado_Civil;
        private string _Telefono;
        private string _Direccion;
        private string _Correo;

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Estado_Civil { get => _Estado_Civil; set => _Estado_Civil = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
    }
}
