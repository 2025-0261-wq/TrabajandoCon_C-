using System;

namespace EjerciciosIfSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("              MENÚ DE EJERCICIOS");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("--- Ejercicios con if / else ---");
                Console.WriteLine("1. Control de acceso por edad");
                Console.WriteLine("2. Sistema de calificaciones escolares");
                Console.WriteLine("3. Verificador de números pares e impares");
                Console.WriteLine("4. Simulador de cajero automático");
                Console.WriteLine("5. Clasificador de temperatura ambiental");
                Console.WriteLine("\n--- Ejercicios con switch ---");
                Console.WriteLine("6. Selector de días de la semana");
                Console.WriteLine("7. Calculadora básica de operaciones");
                Console.WriteLine("8. Conversor de tipo de usuario (Roles)");
                Console.WriteLine("9. Dispensador automático de bebidas");
                Console.WriteLine("10. Identificador de estaciones por mes");
                Console.WriteLine("\n0. Salir");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("--- 1. Control de acceso por edad ---");
                        Console.Write("Ingresa tu edad: ");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        if (edad >= 18)
                        {
                            Console.WriteLine("¡Bienvenido! Acceso concedido :).");
                        }
                        else
                        {
                            Console.WriteLine("Acceso denegado :(. Debes ser mayor de 18 años para ingresar.");
                        }
                        break;

                    case "2";
                        Console.WriteLine("--- 2. Sistema de calificaciones escolares ---");
                        Console.Write("Ingresa la calificación obtenida (0-100): ");
                        double nota = Convert.ToDouble(Console.ReadLine());

                        if (nota >= 60)
                        {
                            Console.WriteLine("Pasaste");
                        }
                        else
                        {
                            Console.WriteLine("Tienes que repetir");
                        }
                        break;

                    case "3":
                       
                        Console.WriteLine("--- 3. Verificador de números pares e impares ---");
                        Console.Write("Ingresa un número entero: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        if (numero % 2 == 0)
                        {
                            Console.WriteLine("El número ingresado es un Número Par.");
                        }
                        else
                        {
                            Console.WriteLine("El número ingresado es un Número Impar.");
                        }
                        break;

                    case "4":
                        
                        Console.WriteLine("--- 4. Simulador de cajero automático ---");
                        double saldoDisponible = 15000.00; 
                        Console.WriteLine($"Saldo disponible: ${saldoDisponible}");
                        Console.Write("¿Cuánto dinero deseas retirar?: $");
                        double retiro = Convert.ToDouble(Console.ReadLine());

                        if (retiro <= saldoDisponible)
                        {
                            saldoDisponible -= retiro; 
                            Console.WriteLine($"Transacción autorizada. Has retirado ${retiro}.");
                            Console.WriteLine($"Nuevo saldo disponible: ${saldoDisponible}");
                        }
                        else
                        {
                            Console.WriteLine("Operación cancelada: Fondos Insuficientes.");
                        }
                        break;

                    case "5":
                        
                        Console.WriteLine("--- 5. Clasificador de temperatura ambiental ---");
                        Console.Write("Ingresa la temperatura actual en grados Celsius: ");
                        double temperatura = Convert.ToDouble(Console.ReadLine());

                        if (temperatura < 15)
                        {
                            Console.WriteLine("Clima Frío.(sal con abrigado)");
                        }
                        else if (temperatura >= 15 && temperatura <= 28)
                        {
                            Console.WriteLine("Clima Templado.");
                        }
                        else
                        {
                            Console.WriteLine("Clima Cálido.");
                        }
                        break;

                    case "6":
                        
                        Console.WriteLine("--- 6. Selector de días de la semana ---");
                        Console.Write("Ingresa un número del 1 al 7: ");
                        int dia = Convert.ToInt32(Console.ReadLine());

                        switch (dia)
                        {
                            case 1: Console.WriteLine("El día es: Lunes"); break;
                            case 2: Console.WriteLine("El día es: Martes"); break;
                            case 3: Console.WriteLine("El día es: Miércoles"); break;
                            case 4: Console.WriteLine("El día es: Jueves"); break;
                            case 5: Console.WriteLine("El día es: Viernes"); break;
                            case 6: Console.WriteLine("El día es: Sábado"); break;
                            case 7: Console.WriteLine("El día es: Domingo"); break;
                            default: Console.WriteLine("Día inválido. Debes ingresar un número entre 1 y 7."); break;
                        }
                        break;

                    case "7":
                        
                        Console.WriteLine("--- 7. Calculadora básica de operaciones ---");
                        Console.Write("Ingresa el primer número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingresa un símbolo matemático (+, -, *, /): ");
                        string operacion = Console.ReadLine();

                        Console.Write("Ingresa el segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        switch (operacion)
                        {
                            case "+":
                                Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                                break;
                            case "-":
                                Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                                break;
                            case "*":
                                Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                                break;
                            case "/":
                                if (num2 != 0)
                                    Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                                else
                                    Console.WriteLine("Error: No se puede dividir entre cero.");
                                break;
                            default:
                                Console.WriteLine("Operación no válida.");
                                break;
                        }
                        break;

                    case "8":
                        Console.WriteLine("--- 8. Conversor de tipo de usuario ---");
                        Console.WriteLine("Roles disponibles: A (Administrador), E (Editor), U (Autor), L (Lector)");
                        Console.Write("Ingresa la letra de tu rol: ");
                        string rol = Console.ReadLine().ToUpper(); 

                        switch (rol)
                        {
                            case "A":
                                Console.WriteLine("Rol: Administrador. Permisos: Acceso total al sistema, creación y borrado de usuarios.");
                                break;
                            case "E":
                                Console.WriteLine("Rol: Editor. Permisos: Modificar y publicar contenido existente.");
                                break;
                            case "U": // Cambiado a 'U' para evitar conflicto con 'A' de Administrador
                                Console.WriteLine("Rol: Autor. Permisos: Escribir nuevo contenido y enviarlo a revisión.");
                                break;
                            case "L":
                                Console.WriteLine("Rol: Lector. Permisos: Solo lectura del contenido publicado.");
                                break;
                            default:
                                Console.WriteLine("Rol no reconocido. Asignando rol por defecto: Invitado.");
                                break;
                        }
                        break;

                    case "9":
                        
                        Console.WriteLine("--- 9. Dispensador automático de bebidas ---");
                        Console.WriteLine("Menú: 1. Café | 2. Té | 3. Chocolate | 4. Capuchino");
                        Console.Write("Selecciona una opción (1-4): ");
                        string bebida = Console.ReadLine();

                        switch (bebida)
                        {
                            case "1": Console.WriteLine("Has seleccionado Café. El precio es: $25.00"); break;
                            case "2": Console.WriteLine("Has seleccionado Té. El precio es: $19.99"); break;
                            case "3": Console.WriteLine("Has seleccionado Chocolate. El precio es: $30.00"); break;
                            case "4": Console.WriteLine("Has seleccionado Capuchino. El precio es: $60.50"); break;
                            default: Console.WriteLine("Error: La opción seleccionada no está disponible."); break;
                        }
                        break;

                    case "10":
                        
                        Console.WriteLine("--- 10. Identificador de estaciones del año ---");
                        Console.Write("Ingresa el nombre de un mes (Ej: Enero, Marzo): ");
                        string mes = Console.ReadLine().ToLower().Trim(); 

                        switch (mes)
                        {
                            case "marzo":
                            case "abril":
                            case "mayo":
                                Console.WriteLine($"El mes de {mes} pertenece a la estación: Primavera.");
                                break;
                            case "junio":
                            case "julio":
                            case "agosto":
                                Console.WriteLine($"El mes de {mes} pertenece a la estación: Verano.");
                                break;
                            case "septiembre":
                            case "octubre":
                            case "noviembre":
                                Console.WriteLine($"El mes de {mes} pertenece a la estación: Otoño.");
                                break;
                            case "diciembre":
                            case "enero":
                            case "febrero":
                                Console.WriteLine($"El mes de {mes} pertenece a la estación: Invierno.");
                                break;
                            default:
                                Console.WriteLine("Nombre de mes inválido. Asegúrate de escribirlo correctamente.");
                                break;
                        }
                        break;

                    case "0":
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, intenta de nuevo.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }
    }
}
