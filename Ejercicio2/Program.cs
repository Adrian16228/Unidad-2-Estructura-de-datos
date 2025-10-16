using Ejercicio2;
ClasePila<char> miPila = new ClasePila<char>();
string strPalabra;
string strPalabraInvertida="";
int intOpcion = 0;

    Console.Write("Ingrese una palabra: ");
    strPalabra = Console.ReadLine();
    for (int i = 0; i < strPalabra.Length; i++)
    {
        char Caracter = strPalabra[i];
        miPila.Agregar(Caracter);
    }
    for (int i = 0; i < strPalabra.Length; i++)
    {
        strPalabraInvertida += miPila.ELiminar();
    }
    if (strPalabra == strPalabraInvertida)
    {
        Console.WriteLine("La palabra si es palindromo");
    }
    else
    {
        Console.WriteLine("La palabra NO es palindromo");
    }
    
    Console.ReadKey();

