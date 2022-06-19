// See https://aka.ms/new-console-template for more information



Console.WriteLine();
//Cigarros

int cigarroCamel = 420;
int cigarroRedPoint = 160;
int cigarroLucky = 320;
int cigarroMalboro = 400;

//nombro variables BEBIDA.
int cocaCola = 280;
int cocaColaZero = 280;
int manaosCola = 110;
int manaosNaranja = 110;
int manaosPomelo = 110;
int sevenUp = 280;
int monster = 220;
int redBull = 220;
int baggioNaranja = 120;



//nombro variables COMIDA.
int sangucheMilanesa = 150;
int sangucheMiga = 170;
int pancho = 100;
int alfajorGuaymallen = 30;
int alfajorJorgito = 80;
int alfajorFulbito = 20;
int alfajorOreo = 90;
int lays = 120;
int doritos = 130;
int palitoSalado = 120;
int pebete = 180;
int galleDonSatur = 70;
int galleOreo = 70;
int galleSonrisa = 60;
int gallePepito = 110;
int galleMerengada = 70;
int galleSurtida = 70;

//variable sube
int sube = 240;

//Ingresar cosas que lleve el cliente
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Ingresa lo que lleva el cliente (1)MERCADO | (2)SUBE : ");
int opcion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


//COMIDA
if (opcion == 1)
{
    Console.WriteLine("Seleccionaste la lista del mercado:");
    Console.WriteLine();

    //Comidas
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-LISTA MERCADO-*-*-*-*-*-*-*-*-*-*-*-*");
    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
    Console.WriteLine("*-*    1 - Sanguche Milanesa = $150.                    *-*");
    Console.WriteLine("*-*    2 - Sanguche de  Miga = $170.                    *-*");
    Console.WriteLine("*-*    3 - Pancho = $100.                               *-*");
    Console.WriteLine("*-*    4 - Alfajor Guaymallen = $30.                    *-*");
    Console.WriteLine("*-*    5 - Alfajor Jorgito = $80.                       *-*");
    Console.WriteLine("*-*    6 - Alfajor Fulbito = $20.                       *-*");
    Console.WriteLine("*-*    7- Alfajor Oreo = $90.                           *-*");
    Console.WriteLine("*-*    8- Lays = $120.                                  *-*");
    Console.WriteLine("*-*    9- Doritos = $130.                               *-*");
    Console.WriteLine("*-*    10- Palitos Salados = $120.                      *-*");
    Console.WriteLine("*-*    11- Pebete = $180.                               *-*");
    Console.WriteLine("*-*    12- Galletita DON SATUR = $70.                   *-*");
    Console.WriteLine("*-*    13- Galletita OREO = $70.                        *-*");
    Console.WriteLine("*-*    14- Galletita SONRISA = $60.                     *-*");
    Console.WriteLine("*-*    15- Galletita PEPITO = $110.                     *-*");
    Console.WriteLine("*-*    16- Galletita MERENGADA = $70.                   *-*");
    Console.WriteLine("*-*    17- Galletita SURTIDA = $70.                     *-*");
    Console.WriteLine("*-*    18 - Cigarrillos CAMEL = $420.                   *-*");
    Console.WriteLine("*-*    19 - Cigarrillos RED POINT = $160.               *-*");
    Console.WriteLine("*-*    20 - Cigarrillos LUCKY MENTOLADO = $320.         *-*");
    Console.WriteLine("*-*    21 - Cigarrillos MALBORO = $400.                 *-*");
    Console.WriteLine("*-*    22 - Coca Cola 3L = $280.                        *-*");
    Console.WriteLine("*-*    23 - Coca Cola Zero 3L = $280.                   *-*");
    Console.WriteLine("*-*    24 - Manaos COLA = $110.                         *-*");
    Console.WriteLine("*-*    25 - Manaos NARANJA = $110.                      *-*");
    Console.WriteLine("*-*    26 - Manaos POMELO = $110.                       *-*");
    Console.WriteLine("*-*    27 - Seven UP 3L = $280.                         *-*");
    Console.WriteLine("*-*    28 - Monster = $120.                             *-*");
    Console.WriteLine("*-*    29 - RedBull = ${0}.                             *-*", redBull);
    Console.WriteLine("*-*    30 - Baggio NARANJA = ${0}.                      *-*", baggioNaranja);
    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;


    //CANTIDAD PRODUCTOS
    Console.Write("Ingresar la cantidad de productos que desea comprar el cliente: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < cantidad; i++)
    {
        //Ingresar lo que llevaria el cliente
        Console.WriteLine();
        Console.Write("Ingresar productos: ");
        int comidaOpc = Convert.ToInt32(Console.ReadLine());
        //SANGUCHE MILANESA
        if (comidaOpc == 1)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - sangucheMilanesa;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //SANGUCHE MIGA
        else if (comidaOpc == 2)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            Console.WriteLine();
            //vuelto
            double vuelto = dinero - sangucheMiga;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //PANCHO
        else if (comidaOpc == 3)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - pancho;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //GUAYMALLEN
        else if (comidaOpc == 4)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - alfajorGuaymallen;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //JORGITO
        else if (comidaOpc == 5)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - alfajorJorgito;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //FULBITO
        else if (comidaOpc == 6)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - alfajorFulbito;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        // ALFAJOR OREO
        else if (comidaOpc == 7)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - alfajorOreo;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //LAYS
        else if (comidaOpc == 8)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - lays;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //DORITOS
        else if (comidaOpc == 9)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - doritos;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //PALITO SALADO
        else if (comidaOpc == 10)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - palitoSalado;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //PEBETE
        else if (comidaOpc == 11)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - pebete;
            Console.Write("Vuelto: ${0}", vuelto);
        }


        //GALLE DON SATUR
        else if (comidaOpc == 12)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - galleDonSatur;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //GALLE OREO
        else if (comidaOpc == 13)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - galleOreo;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //GALLE SONRISA
        else if (comidaOpc == 14)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - galleSonrisa;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //GALLE PEPITO
        else if (comidaOpc == 15)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - gallePepito;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //GALLE MERENGADA
        else if (comidaOpc == 16)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - galleMerengada;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //GALLE SURTIDO
        else if (comidaOpc == 17)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - galleSurtida;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //CAMEL
        else if (comidaOpc == 18)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - cigarroCamel;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //RED POINT
        else if (comidaOpc == 19)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - cigarroRedPoint;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //lucky 
        else if (comidaOpc == 20)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - cigarroLucky;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //malboro
        else if (comidaOpc == 21)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - cigarroMalboro;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //COCA-COLA
        else if (comidaOpc == 22)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - cocaCola;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //COCA-COLA ZERO
        else if (comidaOpc == 23)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - cocaColaZero;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //MANAOS COLA
        else if (comidaOpc == 24)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - manaosCola;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //MANAOS NARANJA
        else if (comidaOpc == 25)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - manaosNaranja;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //MANAOS POMELO
        else if (comidaOpc == 26)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - manaosPomelo;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //SEVEN UP
        else if (comidaOpc == 27)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - sevenUp;
            Console.Write("Vuelto: ${0}", vuelto);
        }

        //MONSTER
        else if (comidaOpc == 28)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - sevenUp;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //RED BULL
        else if (comidaOpc == 29)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - sevenUp;
            Console.Write("Vuelto: ${0}", vuelto);
        }
        //BAGGIO
        else if (comidaOpc == 30)
        {
            // Ingresa DINERO

            Console.Write("Ingresa Dinero del cliente: $");
            int dinero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero del Cliente : ${0}", dinero);
            //vuelto
            Console.WriteLine();
            double vuelto = dinero - baggioNaranja;
            Console.Write("Vuelto: ${0}", vuelto);
        }


    }






}

//SUBE
else if (opcion == 2)
{
    Console.WriteLine("Seleccionaste SUBE:");
    Console.WriteLine("Cargar SALDO (1) | Comprar sube con carga de datos y saldo (2).");
    int opcionSube = Convert.ToInt32(Console.ReadLine());
    switch (opcionSube)
    {
        case 1:         //Saldo sube
            //dinero
            Console.Write("Ingresa el dinero de la tarjeta: $");
            int tarjetaSaldo = Convert.ToInt32(Console.ReadLine());

            //cuanto desea recargarle
            Console.Write("Ingresar cuanto desea cargar al cliente: $");
            int cargaSube = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("**                                                 **");
            Console.WriteLine("**     Sube cliente: ${0}                          **", tarjetaSaldo); //muestra la cantidad de dinero
            Console.WriteLine("**                                                 **");

            int totalCarga = tarjetaSaldo + cargaSube; //cuenta de suma entre el dinero de la sube y la carga del cliente

            Console.WriteLine("**     Total de la carga: ${0}                     **", totalCarga);//muestra el total del dinero de la sube
            Console.WriteLine("**                                                 **");
            Console.WriteLine("*****************************************************");
            break;

        case 2: //Carga de datos y saldo para el cliente
            Console.WriteLine("Costo de la sube ${0}", sube);
            Console.Write("Ingresa monto para pagar la sube: $");


            int pagoSube = Convert.ToInt32(Console.ReadLine()); //ingresa el dinero y si le alcanza prosigue en caso que no se cierra el programa
            if (pagoSube >= sube)
            {
                Console.Write("Ingresar nombre del nuevo propietario de la sube: "); //Ingresamos nombre
                string nombre = Convert.ToString(Console.ReadLine());
                Console.Write("Ingresar edad: ");                                    //Ingresamos edad
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Con cuanto dinero desea cargar su SUBE: $");   //Ingresamos abono de la tarjeta
                int totalAbonar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("**                                                 **");
                Console.WriteLine("**   Propietario de la tarjeta: {0}.             **", nombre);
                Console.WriteLine("**                                                 **");
                Console.WriteLine("**   Edad del propietario: {0}.                    **", edad);
                Console.WriteLine("**                                                 **");
                Console.WriteLine("**   Total SUBE cargada: {0}.                      **", totalAbonar);
                Console.WriteLine("**                                                 **");
                Console.WriteLine("*****************************************************");
            }

            else if (pagoSube < sube)
            {
                Console.WriteLine("No tiene salario suficiente.");


            }

            break;

        default:
            Console.WriteLine("No se reconoce, vuelva a intentarlo.");
            break;
    }

}

//Si no existe.....

else
{
    Console.WriteLine("No se reconoce, vuelva a intentarlo");
}
