using System;

namespace _4_B4RB
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            string cadena = "";
            bool Inicio = true;
            int numero1;
            int quest1; int quest2; int quest3; int quest4; int quest5; int quest6;
            int quest7; int quest8; int quest9;
            int acumulador = 0;
            int grupoA = 0; int grupoB = 0; int grupoC = 0;
            int edadpromedioA = 0; int edadpromedioB = 0; int edadpromedioC = 0;
            int edadmayA = 0; int edadmenA = 0;
            int edadmayB = 0; int edadmenB = 0;
            int edadmayC = 0; int edadmenC = 0;


            while (Inicio)
            {
                Console.WriteLine("Bienvenido al programa");
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadKey();
              
                
                Console.WriteLine("Seleccione la edad a la que pertenece la persona");
                Console.WriteLine("0= Salir del programa");
                Console.WriteLine("1=Adulto de 55 Años o más");
                Console.WriteLine("2=Adulto de 26 Años, pero menor a 55");
                Console.WriteLine("3= Jovenes desde 16 Años, hasta 25");
                cadena = Console.ReadLine();
                numero1 = Convert.ToInt32(cadena);
                switch (numero1)
                {

                    case 1:
                        for (int i = 1; i <= 2; i++)
                        {
                            Console.WriteLine("Ingrese la edad de la persona");
                            cadena = Console.ReadLine();
                            edad = Convert.ToInt32(cadena);

                            if (edad >= 55)
                            {
                                Console.WriteLine("Grupo A");
                                Console.WriteLine("¿Que grado de satisfaccion le merece las instalaciones?");
                                Console.WriteLine("1= Muy satisfactorio   2= Satisfactorio  3=Poco satisfactorio");
                                cadena = Console.ReadLine();
                                quest1 = Convert.ToInt32(cadena);
                                Console.WriteLine("¿Recomendaría el uso de las instalaciones ?");
                                Console.WriteLine("1= Si  2= No estoy seguro 3= No");
                                cadena = Console.ReadLine();
                                quest2 = Convert.ToInt32(cadena);
                                Console.WriteLine("¿Como se encontraban las instalaciones en cuanto al saneamiento?");
                                Console.WriteLine("1=Muy limpio  2=Limpio  3=No muy Limpio");
                                cadena = Console.ReadLine();
                                quest3 = Convert.ToInt32(cadena);
                                grupoA = grupoA + 1;
                                acumulador = acumulador + edad;
                                edadpromedioA = acumulador / grupoA;
                                if (i == 1)
                                {
                                    edadmayA = edad;
                                    edadmenA = edad;
                                }
                                else if (edad > edadmayA)
                                {
                                    edadmayA = edad;
                                }
                                if (edad < edadmenA)
                                {
                                    edadmenA = edad;
                                }

                            }

                            else if (edad < 55)
                            {
                                Console.WriteLine(" Error, No pertenece a este grupo");
                                break;
                            }
                        } break;

                    case 2:
                        for (int i = 1; i <= 2; i++)
                        {
                            Console.WriteLine("Ingrese la edad de la persona");
                            cadena = Console.ReadLine();
                            edad = Convert.ToInt32(cadena);

                            if ((edad > 25 && edad < 55))
                            {

                                Console.WriteLine("Grupo B");
                                Console.WriteLine("¿La cantidad de menú que sirve el restaurante esta?");
                                Console.WriteLine("1= Acorde  2= No acorde  3= No lo utilicé");
                                cadena = Console.ReadLine();
                                quest4 = Convert.ToInt32(cadena);

                                Console.WriteLine("¿El costo de entrada unico por vehiculo para el uso de las instalaciones está?");
                                Console.WriteLine("1= Costoso  2= Accesible");
                                cadena = Console.ReadLine();
                                quest5 = Convert.ToInt32(cadena);

                                Console.WriteLine("¿El costo por el uso de los toldos está?");
                                Console.WriteLine("1= Costoso  2= Accesible");
                                cadena = Console.ReadLine();
                                quest6 = Convert.ToInt32(cadena);
                                grupoB = grupoB + 1;
                                acumulador = acumulador + edad;
                                edadpromedioB = acumulador / grupoB;
                                if (i == 1)
                                {
                                    edadmayB = edad;
                                    edadmenB = edad;
                                }
                                else if (edad > edadmayA)
                                {
                                    edadmayB = edad;
                                }
                                if (edad < edadmenA)
                                {
                                    edadmenB = edad;
                                }
                            }
                            else if ((edad >= 55 && edad <= 25))
                            {
                                Console.WriteLine(" ERROR, No pertenece a este grupo");
                                break;
                            }
                        }
                        break;

                    case 3:
                        for (int i = 1; i <= 2; i++)
                        {
                            Console.WriteLine("Ingrese la edad de la persona");
                            cadena = Console.ReadLine();
                            edad = Convert.ToInt32(cadena);

                            if ((edad > 16 && edad <= 25))
                            {
                                Console.WriteLine("Grupo C");
                                Console.WriteLine("¿La musica que se escucha dentro de las instalaciones debe ser?");
                                Console.WriteLine("1= Clasica  2= Actualizada  3= Variada");
                                cadena = Console.ReadLine();
                                quest7 = Convert.ToInt32(cadena);

                                Console.WriteLine("¿Que le pareció la presencia de nuestro personal de seguridad?");
                                Console.WriteLine("1= Presente 2= Ausente ");
                                cadena = Console.ReadLine();
                                quest8 = Convert.ToInt32(cadena);

                                Console.WriteLine("¿Que eventos desearia disfrutar en nuestras instalaciones?");
                                Console.WriteLine("1= concierto en vivo   2= Concursos   3= Paseos en Bote");
                                cadena = Console.ReadLine();
                                quest9 = Convert.ToInt32(cadena);
                                grupoC = grupoC + 1;
                                acumulador = acumulador + edad;
                                edadpromedioC = acumulador / grupoC;
                                if (i == 1)
                                {
                                    edadmayC = edad;
                                    edadmenC = edad;
                                }
                                else if (edad > edadmayA)
                                {
                                    edadmayC = edad;
                                }
                                if (edad < edadmenA)
                                {
                                    edadmenC = edad;
                                }

                            }
                            else
                        if ((edad >= 0 && edad <= 16))
                            {
                                Console.WriteLine("ERROR, Edad menor, no puede ser clasificada a un grupo");
                                break;
                            }
                        }
                        break;

                    case 0:
                        Inicio = false;
                        break;

                    default:
                        Console.WriteLine("Error, opcion no solicitada");
                        break;
                }
               
                Console.WriteLine("Si no desea continuar con el programa ingrese 0");
                cadena = Console.ReadLine();
                numero1 = Convert.ToInt32(cadena);
                if (numero1 == 0)
                {
                    Inicio = false;
                }

            }
            Console.WriteLine("La edad promedio del grupo A es " + edadpromedioA + " La edad mayor es " + edadmayA + ", La edad menor es " + edadmenA);
            Console.WriteLine("La edad promedio del grupo B es " + edadpromedioB + " La edad mayor es " + edadmayB + ", La edad menor es " + edadmenB);
            Console.WriteLine("La edad promedio del grupo C es " + edadpromedioC + " La edad mayor es " + edadmayC + ", La edad menor es " + edadmenC);


        }
    }
}
