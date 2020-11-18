using System;
using System.Collections.Generic;
using System.Text;

namespace PracticandoCsharp.Entidades
{
    public class Escuela
    {
        //Propiedades
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value.ToUpper();
            }
        }
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        //Constructor sobrecargado +2
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        public Escuela(string nombre, int año, TiposEscuela tipoEscuela, string pais = "", string ciudad = "")
        {
            Nombre = nombre;
            AñoDeCreacion = año;
            TipoEscuela = tipoEscuela;
            Pais = pais;
            Ciudad = ciudad;
        }

        //Metodo override ToString()
        public override string ToString()
        {
            return $"Nombre: {Nombre} \nAño de creacion: {AñoDeCreacion} \nPais: {Pais} \nCiudad: {Ciudad} \nTipo: {TipoEscuela}";
        }
    }
}
