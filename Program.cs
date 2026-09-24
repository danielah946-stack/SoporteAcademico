using System;
class Program
{

    static bool ValidarCodigo(string codigo)
    {
        if (string.IsNullOrWhiteSpace(codigo) || codigo.Length !=9)
        {
            return false;
        }

        string codigoMayus= codigo.ToUpper();
        if(codigoMayus.StartsWith("N00"))
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("--- Modulo de Soporte Academico --- ");
        
        string codigo ="";
        
        while(true)
        {
            Console.WriteLine("Ingresa el codigo de estudiante: ");
            codigo = Console.ReadLine();
            
            if(ValidarCodigo(codigo))
            {
                break;
            }
            Console.WriteLine("[Error] El codigo debe tener exactamente 9 caracteres y empezar obligatoriamente con 'N00'. ");
        }
            
            Console.WriteLine("Ingresa el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("Ingresa el tipo de consulta: ");
            string tipo= Console.ReadLine();
            
            Console.WriteLine("Ingresa la descripcion breve: ");
            string descripcion= Console.ReadLine();
            
            Console.WriteLine("\n[exito] Codigo y datos registrados correctamente");
    }
}



