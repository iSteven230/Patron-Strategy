using System;

namespace PatronStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = "";

            IOperacion mioperacion = new Csuma();
            while(opcion != "5")
            {
                Console.WriteLine(" 1- Suma\n 2- Resta\n 3- Multiplicar\n 4- Dividir\n 5- Salir\n");
                opcion = Console.ReadLine();
                if (opcion == "5")
                    break;

                Console.WriteLine("Dame el valor de a");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.WriteLine("Dame el valor de b");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                if (opcion == "1")
                    mioperacion = new Csuma();

                if (opcion == "2")
                    mioperacion = new Cresta();

                if (opcion == "3")
                    mioperacion = new Cmulti();

                if (opcion == "4")
                    mioperacion = new Cdiv();

                r = mioperacion.operacion(x, y);

                Console.WriteLine("el resultado de {0}", r);




            }




        }
    }
}
