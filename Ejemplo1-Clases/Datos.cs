using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Clases
{
    class Datos
    {
        //Conjunto de listas Publicas y estaticas

        public static List<Alumno> Alumnos = new List<Alumno>();
        public static List<Profesor> Profesores = new List<Profesor>();
        public static List<Personal> Personanles = new List<Personal>();
        public static List<Centro> Centros = new List<Centro>()
        {
            new Centro("Jose Gabriel","Cine blanco 1c arriba","81169905","telcor1234@gmail.com"),
            new Centro("Miguel Angel","Algun lugar de masaya","89011890","MiguelA@gmail.com"),
            new Centro("Edgar Lazo","Algun lugar de ciudad sandino","89951234","ElazoGonzales@gmail.com")

        };
    }
}
