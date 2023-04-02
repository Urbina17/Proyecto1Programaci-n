using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        int opcionmenu;
        int numeroFactura = 0;
        int cantidadproductos;
        int cantidad1 = 0, cantidad2 = 0, cantidad3 = 0, cantidad4 = 0, cantidad5 = 0;
        int puntosCliente = 0;
        int puntostotales = 0;
        do
        {
            // Menú principal
            Console.WriteLine("Bienvenido a Tiendas Mas - Sucursal Campus Central");
            Console.WriteLine("1. FACTURACIÓN");
            Console.WriteLine("2. REPORTES DE FACTURACIÓN");
            Console.WriteLine("3. SALIR");
            opcionmenu = int.Parse(Console.ReadLine());

            // Ejecutar el menú

            {
                switch (opcionmenu)
                {
                    case 1:
                        Console.Clear();
                        // Información de la factura
                        Console.WriteLine("------- FACTURACION -------");
                        Console.WriteLine("Ingrese la información de la factura:");
                        Console.Write("Nombre de la factura: ");
                        string nombreFactura = Console.ReadLine();
                        Console.Write("NIT: ");
                        string nit = Console.ReadLine();
                        Console.Write("Correo electrónico del cliente: ");
                        string correoCliente = Console.ReadLine();
                        Console.WriteLine();

                        // Ingreso de productos
                        string opcion = "";
                        double totalFactura = 0;


                        Console.WriteLine("Ingrese los productos que el cliente desea comprar:");
                        Console.WriteLine("Producto: | ---Libra de azúcar.| --- Precio: Q.10.80. | --- Código: 001 --- |");
                        Console.WriteLine("Producto: | ---Libra de arroz. | --- Precio: Q.3.80.  | --- Código: 002 --- |");
                        Console.WriteLine("Producto: | ---Galleta GAMA.   | --- Precio: Q.1.10.  | --- Código: 003 --- |");
                        Console.WriteLine("Producto: | ---Coca Cola.      | --- Precio: Q17.00.  | --- Código: 004 --- |");
                        Console.WriteLine("Producto: | ---Libra de café.  | --- Precio: Q.50.00. | --- Código: 005 --- |");

                        while (opcion != "N")
                        {
                            Console.Write("Ingrese el código del producto: ");
                            int codigoProducto = Convert.ToInt32(Console.ReadLine());
                            double total = 0;
                            if (codigoProducto == 001)
                            {
                                Console.WriteLine("Cuantas libras de azucar desea?");
                                int cantidadProductos;
                                bool entero = false;
                                do
                                {
                                    string entrada = Console.ReadLine();
                                    if (int.TryParse(entrada, out cantidadProductos) && cantidadProductos > 0)

                                    {
                                        entero = true;
                                        total = 10.80 * cantidadProductos;
                                        total += totalFactura;
                                        totalFactura = total;
                                        cantidad1 += cantidadProductos;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cantidad no válida, ingresar una cantidad entera porfavor: ");
                                    }


                                } while (!entero);
                            }
                            else if (codigoProducto == 002)
                            {
                                Console.WriteLine("Cuantas libras de arroz desea?");
                                int cantidadProductos;
                                bool entero = false;
                                do
                                {
                                    string entrada = Console.ReadLine();
                                    if (int.TryParse(entrada, out cantidadProductos) && cantidadProductos > 0)

                                    {
                                        entero = true;
                                        total = 3.80 * cantidadProductos;
                                        total += totalFactura;
                                        totalFactura = total;
                                        cantidad2 += cantidadProductos;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cantidad no valida, ingresar una cantidad entera porfavor: ");
                                    }
                                } while (!entero);
                            }
                            else if (codigoProducto == 003)
                            {
                                Console.WriteLine("Cuantas Galletas GAMA desea?");
                                int cantidadProductos;
                                bool entero = false;
                                do
                                {
                                    string entrada = Console.ReadLine();
                                    if (int.TryParse(entrada, out cantidadProductos) && cantidadProductos > 0)


                                    {
                                        entero = true;
                                        total = 1.10 * cantidadProductos;
                                        total += totalFactura;
                                        totalFactura = total;
                                        cantidad3 += cantidadProductos;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cantidad no valida, ingresar una cantidad entera porfavor: ");
                                    }
                                } while (!entero);
                            }
                            else if (codigoProducto == 004)
                            {
                                Console.WriteLine("Cuantas Coca Cola desea?");
                                int cantidadProductos;
                                bool entero = false;
                                do
                                {
                                    string entrada = Console.ReadLine();
                                    if (int.TryParse(entrada, out cantidadProductos) && cantidadProductos > 0)

                                    {
                                        entero = true;
                                        total = 17.00 * cantidadProductos;
                                        total += totalFactura;
                                        totalFactura = total;
                                        cantidad4 += cantidadProductos;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cantidad no valida, ingresar una cantidad entera porfavor: ");
                                    }
                                } while (!entero);
                            }
                            else if (codigoProducto == 005)
                            {
                                Console.WriteLine("Cuantas libras de café desea?");
                                int cantidadProductos;
                                bool entero = false;
                                do
                                {
                                    string entrada = Console.ReadLine();
                                    if (int.TryParse(entrada, out cantidadProductos) && cantidadProductos > 0)

                                    {
                                        entero = true;
                                        total = 50.00 * cantidadProductos;
                                        total += totalFactura;
                                        totalFactura = total;
                                        cantidad5 += cantidadProductos;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cantidad no válida, ingresar una cantidad entera porfavor: ");
                                    }
                                } while (!entero);
                            }
                            else
                            {
                                Console.WriteLine("Codigo inválido");
                            }

                            Console.Write("¿Desea continuar ingresando productos? (S/N): ");
                            opcion = Console.ReadLine().ToUpper();

                            Console.WriteLine();
                        }

                        // Modo de pago
                        Console.Write("Ingrese el modo de pago (Efectivo o Tarjeta): ");
                        string modoPago = Console.ReadLine().ToLower();
                        while (modoPago != "efectivo" && modoPago != "tarjeta")
                        {
                            Console.WriteLine("El modo de pago ingresado es incorrecto. Por favor, ingrese un modo de pago válido.");
                            Console.Write("Ingrese el modo de pago (Efectivo o Tarjeta): ");
                            modoPago = Console.ReadLine().ToLower();
                        }
                        if (modoPago == "tarjeta")
                        {
                            // Cálculo de puntos 
                            if (totalFactura <= 50)
                            {
                                puntosCliente = Convert.ToInt32(Math.Floor(totalFactura / 10));
                                puntostotales += puntosCliente;
                            }
                            else if (totalFactura <= 100 && totalFactura > 50)
                            {
                                puntosCliente = Convert.ToInt32(Math.Floor(totalFactura / 10) * 2);
                                puntostotales += puntosCliente;
                            }
                            else
                            {
                                puntosCliente = Convert.ToInt32(Math.Floor(totalFactura / 10) * 3);
                                puntostotales += puntosCliente;
                            }
                        }
                        else
                        {
                            puntosCliente = 0;
                        }


                        // Impresión de factura


                        numeroFactura++;
                        Console.WriteLine("----- FACTURA -----");
                        Console.WriteLine("Numero de factura :" + numeroFactura);
                        Console.WriteLine($"Nombre de la factura: {nombreFactura}");
                        Console.WriteLine($"NIT: {nit}");
                        Console.WriteLine($"Correo electrónico del cliente: {correoCliente}");
                        Console.WriteLine();
                        // Imprimir los productos comprados
                        Console.WriteLine();
                        Console.WriteLine("Productos comprados:");
                        Console.WriteLine("--------------------");
                        if (cantidad1 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Libra azucar: " + cantidad1 + "| -- Precio unitario = 10.80 --" + "| -- Precio total: " + cantidad1 * 10.80 + " -- | ");
                        }
                        if (cantidad2 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Libra arroz: " + cantidad2 + " | -- Precio unitario = 3.80 --" + " | -- Precio total: " + cantidad2 * 3.80 + " -- | ");
                        }
                        if (cantidad3 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Galleta GAMA: " + cantidad3 + "| -- Precio unitario = 1.10 --" + " | -- Precio total: " + cantidad3 * 1.10 + " -- | ");
                        }
                        if (cantidad4 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Coca cola: " + cantidad4 + "   | -- Precio unitario = 17.00" + "   | -- Precio total: " + cantidad4 * 17.00 + " -- | ");
                        }
                        if (cantidad5 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Libras cafe " + cantidad5 + "  | -- Precio unitario = 50.00" + "   | -- Precio total: " + cantidad5 * 50.00 + " -- | ");
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Total: " + totalFactura);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Puntos acumulados: " + puntosCliente);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        //Reportes de facturación
                        Console.Clear();
                        cantidadproductos = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;
                        Console.WriteLine("-------REPORTES DE FACTURACION-------");
                        Console.WriteLine("| ---Facturas totales: " + numeroFactura + "----------------- |");
                        Console.WriteLine("| ---Cantidad de productos vendidos: " + cantidadproductos + "--- |");
                        Console.WriteLine("| ---Cantidad de puntos generados: " + puntostotales + "----- |");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        //Salida del programa
                        Console.Clear();
                        Console.WriteLine("------- SALIO DEL PROGRAMA -------");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }
        } while (opcionmenu != 3);
    }
}