using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlamacenEmpleados<Estudiante> empleados = new AlamacenEmpleados<Estudiante>(3);
            empleados.Agregar(new Estudiante(25500));
            empleados.Agregar(new Estudiante(15500));
            empleados.Agregar(new Estudiante(45500));


        }
    }
    class AlamacenEmpleados<T> where T : IParaEmpleados
    {
        private int i = 0;
        private T[] DatosEmpleado;

        public AlamacenEmpleados(int z)
        {
            DatosEmpleado = new T[z];
        }

        public void Agregar(T obj)
        {
            DatosEmpleado[i] = obj;
            i++;
        }

        public T GetEmpleado(int i) => DatosEmpleado[i];
    }
    interface IParaEmpleados
    {
        double GetSalario();
    }
    class Director : IParaEmpleados
    {
        private double salario;
        public Director(double salario) 
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Secretaria : IParaEmpleados 
    {
        private double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Electricista : IParaEmpleados 
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }

    }

    class Estudiante
    {
        private double edad;

        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double GetEdad() => edad;
    }
}
