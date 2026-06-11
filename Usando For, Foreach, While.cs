using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("   MENÚ DE EJERCICIOS Usando For, Foreach, While   ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1.  Contador simple (1 al 10)");
            Console.WriteLine("2.  Suma de los primeros 100 números naturales");
            Console.WriteLine("3.  Tabla de multiplicar");
            Console.WriteLine("4.  Números pares (1 al 50)");
            Console.WriteLine("5.  Promedio de notas");
            Console.WriteLine("6.  Arreglo de 5 números (Cargar y Mostrar)");
            Console.WriteLine("7.  Mayor y menor en un arreglo (10 números)");
            Console.WriteLine("8.  Contador de positivos, negativos y ceros");
            Console.WriteLine("9.  Búsqueda en un arreglo");
            Console.WriteLine("10. Frecuencia de valores en una lista");
            Console.WriteLine("0.  Salir del programa");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Selecciona una opción (0-10): ");

            string opcion = Console.ReadLine();
            Console.Clear(); // Limpia la pantalla para ejecutar el ejercicio seleccionado

            switch (opcion)
            {
                case "1":
                    Ejercicio1();
                    break;
                case "2":
                    Ejercicio2();
                    break;
                case "3":
                    Ejercicio3();
                    break;
                case "4":
                    Ejercicio4();
                    break;
                case "5":
                    Ejercicio5();
                    break;
                case "6":
                    Ejercicio6();
                    break;
                case "7":
                    Ejercicio7();
                    break;
                case "8":
                    Ejercicio8();
                    break;
                case "9":
                    Ejercicio9();
                    break;
                case "10":
                    Ejercicio10();
                    break;
                case "0":
                    continuar = false;
                    Console.WriteLine("¡Gracias por usar el programa! Saliendo...");
                    break;
                default:
                    Console.WriteLine(" Intenta de nuevo.:( ");
                    break;
            }

            if (opcion != "0")
            {
                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine("Presiona cualquier tecla para regresar al menú...");
                Console.ReadKey();
            }
        }
    }

    static void Ejercicio1()
    {
        Console.WriteLine(" 1. Contador simple (1 al 10)");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void Ejercicio2()
    {
        Console.WriteLine(" 2. Suma de los primeros 100 números naturales ");
        int suma = 0;
        int i = 1;

        while (i <= 100)
        {
            suma += i;
            i++;
        }

        Console.WriteLine($"La suma total de los números del 1 al 100 es: {suma}");
    }

  
    static void Ejercicio3()
    {
        Console.WriteLine(" 3. Tabla de multiplicar");
        Console.Write("Ingresa el número que deseas multiplicar: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabla del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    static void Ejercicio4()
    {
        Console.WriteLine(" 4. Números pares (1 al 50) ");
        for (int i = 2; i <= 50; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Ejercicio5()
    {
        Console.WriteLine(" 5. Promedio de notas");
        Console.Write("¿Cuántas notas vas a ingresar?: ");
        int cantidad = int.Parse(Console.ReadLine());

        double sumaNotas = 0;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingresa la nota {i}: ");
            sumaNotas += double.Parse(Console.ReadLine());
        }

        double promedio = sumaNotas / cantidad;
        Console.WriteLine($"\nEl promedio final es: {promedio:F2}");
    }

    static void Ejercicio6()
    {
        Console.WriteLine(" 6. Arreglo de 5 números");
        int[] numeros = new int[5];

        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingresa el número para la posición [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nValores almacenados en el arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Posición [{i}]: {numeros[i]}");
        }
    }

    static void Ejercicio7()
    {
        Console.WriteLine(" 7. Mayor y menor en un arreglo");
        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingresa el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor) mayor = numeros[i];
            if (numeros[i] < menor) menor = numeros[i];
        }

        Console.WriteLine($"\nEl número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");
    }

    static void Ejercicio8()
    {
        Console.WriteLine(" 8. Contador de positivos, negativos y ceros ");
        Console.Write("¿Cuántos números deseas evaluar?: ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];

        int positivos = 0, negativos = 0, ceros = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] > 0) positivos++;
            else if (numeros[i] < 0) negativos++;
            else ceros++;
        }

        Console.WriteLine($"\nResultados del análisis:");
        Console.WriteLine($"Positivos: {positivos}");
        Console.WriteLine($"Negativos: {negativos}");
        Console.WriteLine($"Ceros:     {ceros}");
    }

    static void Ejercicio9()
    {
        Console.WriteLine(" 9. Búsqueda en un arreglo");
        int[] miArreglo = { 15, 23, 42, 8, 16, 4, 90 };

        Console.WriteLine("Arreglo disponible: [15, 23, 42, 8, 16, 4, 90]");
        Console.Write("Ingresa el valor que deseas buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < miArreglo.Length; i++)
        {
            if (miArreglo[i] == buscar)
            {
                Console.WriteLine($"\n¡Éxito! El número {buscar} existe y está en la posición (índice) {i}.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"\nEl número {buscar} no se encuentra en el arreglo.");
        }
    }

    static void Ejercicio10()
    {
        Console.WriteLine("10. Frecuencia de valores ");
        Console.Write("¿Cuántos números vas a ingresar a la lista?: ");
        int tamanio = int.Parse(Console.ReadLine());

        int[] lista = new int[tamanio];
        bool[] revisado = new bool[tamanio];

        for (int i = 0; i < tamanio; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            lista[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nConteo de frecuencias:");

        for (int i = 0; i < tamanio; i++)
        {
            if (revisado[i] == true)
                continue;

            int contador = 1;

            for (int j = i + 1; j < tamanio; j++)
            {
                if (lista[i] == lista[j])
                {
                    contador++;
                    revisado[j] = true;
                }
            }

            Console.WriteLine($"El número {lista[i]} aparece {contador} vez/veces.");
        }
    }
}