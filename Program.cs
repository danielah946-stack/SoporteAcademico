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


    static bool ValidarTipoConsulta(string tipo)
    {
        string[] tipoPermitido= { "matricula", "pagos", "plataforma", "constancia"};


        if(string.IsNullOrWhiteSpace(tipo))
        {
            return false;
        }
        string tipoNormalizado = tipo.Trim().ToLower();


        switch (tipoNormalizado)
        {
           case "matricula":
           case "pagos":
           case "constancia":
           case "plataforma":
            return true;
        default:
            return false;
           
        }
    }    
   //Requerimiento 5
   static string CalcularPrioridad(string tipo)
    {
        string tipoNormalizado= tipo.Trim(). ToLower();
        switch(tipoNormalizado)
        {
            case "pagos":
                return"Alta";
            case "matricula":
                return "Alta";
            case "constancia":
                return "Media";
            case "plataforma":
                return "Media";
            default:
                return "Sin definir";
        }
    }

// Requerimiento 6
static bool ValidarTextoObligatorio(string texto)
     {
        return !string.IsNullOrWhiteSpace(texto);

     }
    static void Main(string[] args)
    {
        Console.WriteLine("--- Modulo de Soporte Academico --- ");
       
        //Requerimiento 2
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
           
            // Requerimiento 3
            string tipo= "";
            while (true)
            {
                Console.WriteLine("Ingresa el tipo de consulta: ");
                tipo= Console.ReadLine();
               
                if(ValidarTipoConsulta(tipo))
                {
                     break;
                }
                Console.WriteLine("[Error] El tipo de consulta no es válido. Debe ser uno de la lista permitida.");
            }
            // reguirimiento 5
             string prioridad = CalcularPrioridad(tipo);
             Console.WriteLine("Prioridad asignada: " + prioridad);
           //Requerimiento 6
           string descripcion ="";
           while(true)
        {
            Console.WriteLine("Ingresa la descripcion breve: ");
            descripcion= Console.ReadLine();

            if (ValidarTextoObligatorio(descripcion))
            {
                break;
            }
            Console.WriteLine("[Error] La descripcion  no puede estar vacia. Intentalo de nuevo.");
           
        }
            
            Console.WriteLine("\n[exito] Codigo y datos registrados correctamente");
    }
    }


