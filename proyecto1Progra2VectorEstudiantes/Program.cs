// See https://aka.ms/new-console-template for more information


string[] nombre = new string[10];

int[] cedula = new int[10];

float[] promedio = new float[10];

string[] condicion = new string[10];

float[] notas = new float[10];


int opcion = 0;

void inicializar()

{

    for (int i = 0; i < nombre.Length; i++)

    {

        nombre[i] = "0";

        cedula[i] = 0;

        promedio[i] = 0.0f;

        condicion[i] = "0";

        notas[i] = 0.0f;

    }

}

do
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("************ UNIVERSIDAD HISPANOAMERICANA **********************");

    Console.WriteLine("************ DEPARTAMENTO DE ADMISION **********************");

    Console.WriteLine("1- inicializar vectores");

    Console.WriteLine("2- incluir estudiantes");

    Console.WriteLine("3- consultar estudiantes");

    Console.WriteLine("4- modificar estudiantes");

    Console.WriteLine("5- eliminar estudiantes");

    Console.WriteLine("6- submenu reportes");

    Console.WriteLine("7- salir");


    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("que desea hacer");

    opcion = int.Parse(Console.ReadLine());

    if (opcion==1)
    {
        Console.WriteLine("inicializar vectores");
    }

    else if (opcion == 2)

    {
        Console.WriteLine("incluir estudiantes");  
    }

    else if (opcion == 3)

    {
        Console.WriteLine("consultar estudiantes");  

    }
    else if (opcion == 4)

    {
        Console.WriteLine("modificar estudiantess");  
    }

    else if (opcion == 5)

    {
        Console.WriteLine("eliminar estudiantes");  

    }

    else if (opcion == 6)

    {
        Console.WriteLine("submenu reportes");  

    }

    else if (opcion == 7)

    {
        Console.WriteLine("salir");  

    }

} while (opcion < 1 || opcion > 7);

Console.ForegroundColor = ConsoleColor.White;
