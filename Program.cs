namespace ProgramacionU2_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadPersonas;
            string nombrePersona;
            int edadPersona;

            Console.Write("Ingresa la cantidad de personas a clasificar: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadPersonas) || cantidadPersonas < 1)
            {
                Console.WriteLine("Valor inválido. Debes ingresar un número entero mayor o igual a 1.");
                Console.Write("Ingresa la cantidad de personas a clasificar: ");
            }

            if (cantidadPersonas == 1)
            {

                Console.Write("Ingresa el nombre de la persona: ");
                nombrePersona = Console.ReadLine().Trim();
                while (string.IsNullOrWhiteSpace(nombrePersona)){ 
                
                    Console.WriteLine("Nombre inválido. Intenta de nuevo.");
                    Console.Write("Ingresa el nombre de la persona: ");
                    nombrePersona = Console.ReadLine().Trim();
                }

                Console.Write("Ingresa la edad de la persona: ");
                while (!int.TryParse(Console.ReadLine(), out edadPersona) || edadPersona < 0)
                {
                    Console.WriteLine("Edad inválida. Ingresa un número entero no negativo.");
                    Console.Write("Ingresa la edad de la persona: ");
                }

                Console.WriteLine();
                Console.WriteLine(nombrePersona + " - " + edadPersona);
                Console.WriteLine(edadPersona >= 18 ? "Es mayor de edad." : "Es menor de edad.");
            }
            else
            {
                
                List<string> nombredePersonasMayores = new List<string>();
                List<int> edadesdePersonasMayores = new List<int>();

                List<string> nombredePersonasMenores = new List<string>();
                List<int> edadesdePersonasMenores = new List<int>();

                List<string> listaNombres = new List<string>();
                List<int> listaEdades = new List<int>();

                for (int i = 1; i <= cantidadPersonas; i++)
                {
                    
                    Console.Write("Ingresa el nombre de la persona " + i + ":");
                    nombrePersona = Console.ReadLine().Trim();
                    while (string.IsNullOrWhiteSpace(nombrePersona))
                    {
                        Console.WriteLine("Nombre inválido. Intenta de nuevo.");
                        Console.Write("Ingresa el nombre de la persona " + i + ":");
                        nombrePersona = Console.ReadLine().Trim();
                    }

                    Console.Write("Ingresa la edad de la persona " + i + ":");
                    while (!int.TryParse(Console.ReadLine(), out edadPersona) || edadPersona < 0)
                    {
                        Console.WriteLine("Edad inválida. Ingresa un número entero no negativo.");
                        Console.Write("Ingresa la edad de la persona " + i + ":");
                    }
                    listaNombres.Add(nombrePersona);
                    listaEdades.Add(edadPersona);

                    if (edadPersona >= 18)
                    {
                        nombredePersonasMayores.Add(nombrePersona);
                        edadesdePersonasMayores.Add(edadPersona);
                    }
                    else
                    {
                        nombredePersonasMenores.Add(nombrePersona);
                        edadesdePersonasMenores.Add(edadPersona);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("-- Lista general de personas registradas --");
                Console.WriteLine("");
                Console.WriteLine("");

                for (int i = 0; i < listaNombres.Count; i++)
                {
                    Console.WriteLine(listaNombres[i] + " - " + listaEdades[i]);
                }

                Console.WriteLine();

                if (nombredePersonasMayores.Count > 0)
                {
                    Console.WriteLine("--Personas Mayores--");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    for (int i = 0; i < nombredePersonasMayores.Count; i++)
                    {
                        Console.WriteLine(nombredePersonasMayores[i] + " - " + edadesdePersonasMayores[i]);
                    }
                    Console.WriteLine();
                }

                if (nombredePersonasMenores.Count > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("--Personas Menores--");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    for (int i = 0; i < nombredePersonasMenores.Count; i++)
                    {
                        Console.WriteLine(nombredePersonasMenores[i] + " - " + edadesdePersonasMenores[i]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}


