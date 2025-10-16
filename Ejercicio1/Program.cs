
using Ejercicio1;
ClasePila<char> miPila = new ClasePila<char>();
string strCadena;
char Caracter;
char CaracterPila;
int intOpcion;
do
{
    Console.WriteLine("Ingrese una cadena para ver si es correcta");
    strCadena = Console.ReadLine();

    for (int i = 0; i < strCadena.Length; i++)
    {
        Caracter = strCadena[i];
        if (Caracter == '(' || Caracter == '[' || Caracter == '{')
        {
            miPila.Agregar(Caracter);
        }
        else
        {
            if(Caracter == ')' || Caracter == ']' || Caracter == '}')
            {
                if (miPila.Vacia)
                {
                    Console.WriteLine("No hay un caracter de inicio para " + Caracter);
                    Console.ReadKey();
                    Environment.Exit(0);
                    
                }
                else
                {
                    CaracterPila = miPila.Peek();
                    if ((CaracterPila == '(' && Caracter == ')') || (CaracterPila == '[' && Caracter == ']') || (CaracterPila == '{' && Caracter == '}'))
                    {
                        miPila.ELiminar();
                    }
                }
            }
           
        }
    }
    if (miPila.Vacia)
    {
        Console.WriteLine("La cadena es correcta");
    }
    else Console.WriteLine("Falta un caracter de cierre para " + miPila.Peek());

    Console.WriteLine("\nIngrese 0 para reiniciar\nIngrese 1 para salir\n\n\n");
    intOpcion = int.Parse(Console.ReadLine());
    Console.ReadKey();
} while (intOpcion != 1);
