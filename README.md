# Mercado 

### Explicación
**El codigo proporsionado es una implementacion en C# de una aplicacion que permite a un cliente comprar productos y calcular el cambio correspondiente, además brinda funcionalidades relacionadas con la tarjeta SUBE (Sistema Único de Boleto Electrónico), utilizado en Argentina para el transporte público.**
> Tienda

### Explicación técnica de lo que realiza el código:
                
1. El programa solicita al usuario que ingrese la cantidad de productos que desea comprar el cliente.
2. A continuación, se ejecuta un bucle "for" que itera tantas veces como la cantidad de productos especificada por el usuario.
3. Dentro del bucle, se solicita al usuario que ingrese el número correspondiente al producto que desea comprar.
4. Según el número ingresado, se ejecuta un conjunto de instrucciones para ese producto en particular.
5. Para cada producto, el programa solicita al usuario que ingrese la cantidad de dinero que el cliente está pagando.
6. Luego, se calcula el cambio restando el precio del producto al dinero ingresado por el cliente.
7. Finalmente, se muestra el vuelto al cliente.

#### El código utiliza declaraciones "if" y "else if" para determinar qué producto se ha seleccionado en función del número ingresado por el usuario. Cada producto tiene asignado un número y un precio correspondiente. El programa calcula el vuelto restando el precio del producto del dinero ingresado por el cliente. ####

<p align="center">
  <img src="https://i.postimg.cc/pT3RkqXP/image.png" alt="Tienda"/>
</p>

> Sube


### Explicación técnica de lo que realiza el código:
                
1. El programa muestra un menú de opciones y solicita al usuario que elija una opción.
2. Si el usuario elige la opción 2, el programa entra en el bloque else if (opcion == 2).
3. Dentro de ese bloque, se muestra otro menú relacionado con SUBE y se solicita al usuario que elija una opción específica para esa tarjeta.
4. Si el usuario elige la opción 1, el programa le solicita ingresar el saldo actual de la tarjeta (tarjetaSaldo) y la cantidad de saldo que desea cargar (cargaSube).
5. Luego, el programa muestra el saldo actual y el total después de la carga realizada.
6. Si el usuario elige la opción 2, el programa le muestra el costo de una nueva tarjeta SUBE (sube) y le solicita ingresar el monto para pagarla (pagoSube).
7. Si el monto ingresado es mayor o igual al costo de la tarjeta (sube), el programa le solicita al usuario que ingrese el nombre del nuevo propietario (nombre), su edad (edad) y la cantidad de dinero que desea cargar en la tarjeta (totalAbonar). 
8. Luego, el programa muestra la información del propietario, incluyendo el nombre, la edad y el total de saldo cargado en la tarjeta.
9. Si el monto ingresado es menor al costo de la tarjeta (sube), el programa muestra un mensaje indicando que no hay saldo suficiente.
10. Si el usuario elige una opción no reconocida, el programa muestra un mensaje de error.

#### En resumen, este código brinda funcionalidades relacionadas con la carga de saldo y la compra de una nueva tarjeta SUBE, mostrando información relevante al usuario en cada caso.

<p align="center">
  <img src="https://i.postimg.cc/qBc5117Q/image.png" alt="SUBE"/>
</p>

**Perfil LinkedIn:** </br>
`<link>` : www.linkedin.com/in/franco-galan-def



