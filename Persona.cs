using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personadni
{
    public class Persona
    {// atributos
        private string nombre;
        private long DNI;
        private DateTime fechaDeNacimiento;
        //propiedades
        public string propNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public long propDNI
        {
            set { DNI = value; }
            get { return DNI; }



        }
        public DateTime propFechaDeNacimiento
        {
            set { fechaDeNacimiento = value; }
            get { return fechaDeNacimiento; }





        }
        // constructor sin dato

        public Persona()
        { }
        // constructor con datos
        public Persona(string nomb, int dni, DateTime FechNac)
        {
            nombre = nomb;
            DNI = dni;
            fechaDeNacimiento = FechNac;

        }
        //metodo
        public int EdadPersona()
        {
            int edad = 0;
            {
                if (fechaDeNacimiento.Date > DateTime.Today)
                    throw new Exception(" fecha ingresada incorrecta");
                else
                    edad = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;
                return edad;
            }
            //(Exception)
            //{ return -1}

        }
    }

}

