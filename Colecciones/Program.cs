using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas =
                new Grupo("Matematicas", "MAT5736");
            Grupo historia =
                new Grupo("Historia", "HST2149");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno juan = new Alumno("Juan", "78921");
            Alumno maria = new Alumno("María", "4566");
            Alumno pedro = new Alumno("Pedro", "74185");
            Alumno ana = new Alumno("Ana", "546786");
            Alumno pablo = new Alumno("Pablo", "569800");

            historia.Alumnos.Add(juan);
            historia.Alumnos.Add(ana);
            historia.Alumnos.Add(pedro);

            matematicas.Alumnos.Add(juan);
            matematicas.Alumnos.Add(maria);
            matematicas.Alumnos.Add(pedro);
            matematicas.Alumnos.Add(ana);
            matematicas.Alumnos.Add(pablo);

            foreach(Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " +
                    grupo.Codigo);
                Console.WriteLine("Materia: " +
                    grupo.Materia);
                Console.WriteLine("Lista de alumnos:");
                foreach(Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" +
                        alumno.Nombre);
                }
            }

            Console.Read();

        }
    }
}
