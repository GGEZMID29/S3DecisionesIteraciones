Console.Clear();

/*Logica Booleana
/*Operadores Relacionales
>: Mayor que.
<: Menor que.
>=: Mayor o igual que.
<=: Menor o igual que.
==: Igual a.
!=: Diferente de.
Console.Clear();
var cantidad1 = 5;
var cantidad2 = 5;

var cantidad1IgualACantidad2 = cantidad1 == cantidad2; // true

var cantidad1EsDiferenteACantidad2 = cantidad1 != cantidad2; // false

Console.WriteLine($"Son {cantidad1} y {cantidad2} iguales? {cantidad1IgualACantidad2}");
Console.WriteLine($"Son {cantidad1} y {cantidad2} diferentes? {cantidad1EsDiferenteACantidad2}");

var esCantidad1MenorQue10 = cantidad1 < 10; // true
var esCantidad1MayorQue10 = cantidad1 > 10; // false

var esCantidad1MenorOIgualQue10 = cantidad1 <= 10; // true
var esCantidad1MayorOIgualQue10 = cantidad1 >= 10; // false

string? nombre1 = null;
var nombre2 = "Felipe";

var NombresIguales = nombre1 == nombre2; //false

var esNombre1Nulo = nombre1 is null; //false
var esNombre1NoNulo = nombre1 is not null; //true

Console.WriteLine("Es nombre 1 igual a nulo? " + esNombre1Nulo);
Console.WriteLine("Es nombre 1 diferente de nulo? " + esNombre1NoNulo);
*/

/*Operadores Booleanos Condicionales
var c1 = 6;

// true && true => true
// true && false => false 
// false && true => false 
// false && false => false

var estaEntre5y10 = c1 > 5 && c1 < 10;
Console.WriteLine($"¿Está el {c1} entre 5 y 10? {estaEntre5y10}");

// true || true => true
// true || false => true
// false || true => true
// false || false => false


var cantidad1Es5o6 = c1 == 5 || c1 == 6; // true
Console.WriteLine($"¿Es {c1} igual a 5 o 6? {cantidad1Es5o6}");

string? apellido = null;

var estaElApellidoEnMayusculas = apellido is not null && apellido == apellido.ToUpper();

Console.WriteLine("Está el string en mayúsculas? " + estaElApellidoEnMayusculas);
*/

/*Sentencias de Seleccion
//Nota: Meter siempre un bloque de codigo después del IF.
var cant = 1;

if(cant > 5) {
   Console.WriteLine("Es mayor a 5"); 
}
else if(cant is 3){
    Console.WriteLine("El valor es 3!");
}
else {
    Console.WriteLine("Es menor o igual a 5");
}
  
Console.WriteLine("Fin");
*/

/*Operador Ternario
//Es un if else abreviado.

//bool usuarioLogueado = true;

// string mensajeBienvenida;

// if (usuarioLogueado)
// {
//     mensajeBienvenida = "¡Qué bueno que has vuelto!";
// }
// else
// {
//    mensajeBienvenida = "Logueate para comenzar";
// }

// string mensajeBienvenida = usuarioLogueado ? "¡Qué bueno que has vuelto!" : "Logueate para comenzar";
// // <condicion> ? <si la condición es true> : <si la condición es false>

// System.Console.WriteLine(mensajeBienvenida);

// int a = 20;
// int b = 15;
// int max = (a > b) ? a : b;
// Console.WriteLine("El número mayor es: " + max);
*/

/*Switch

// var lugar = 6;

// // if (lugar == 1)
// // {
// //     Console.WriteLine("¡Quedaste en primer lugar!");
// // }
// // else if (lugar == 2)
// // {
// //     Console.WriteLine("¡Quedaste en segundo lugar!");
// // }
// // else if (lugar == 3)
// // {
// //     Console.WriteLine("¡Puedes vender tu medalla de bronce en una compraventa!");
// // }
// // else
// // {
// //     Console.WriteLine("¡Mejor suerte para la próxima!");
// // }

// switch (lugar)
// {
//     case 1:
//         Console.WriteLine("¡Quedaste en primer lugar!");
//         break;
//     case 2:
//         Console.WriteLine("¡Quedaste en segundo lugar!");
//         Console.WriteLine("esta linea pertenece al case 2");
//         break;
//     case 3:
//         Console.WriteLine("¡Puedes vender tu medalla de bronce en una compraventa!");
//         break;
//     case 4:
//     case 5:
//         Console.WriteLine("Casi casi lo lograste");
//         break;
//     default:
//         Console.WriteLine("¡Mejor suerte para la próxima!");
//         break;
// }
*/

/*Patrones Relacionales

var temperatura = 39;

var mensaje = temperatura switch {
    37 => "No tienes condición",
    > 37 => "Tienes fiebre",
    < 37 => "Puede que tengaas azúcar baja"
};

System.Console.WriteLine(mensaje);
*/

/*Patrones Lógicos

//Ejemplo 1: Not

// string? apellido = null;

// if (apellido is not null) {
//     System.Console.WriteLine(apellido.ToUpper());
// }
// Console.WriteLine("Fin");

//Ejemplo 2: And

// var temperatura = 38;

// var mensaje = temperatura switch
// {
//     37 => "No tienes condición",
//     > 37 and < 39 => "Tienes fiebre",
//     >= 39 and < 43 => "Debes ir al médico",
//     >= 43 => "Mueres",
//     < 37 => "Baja azúcar"
// };   
// System.Console.WriteLine(mensaje);

//Ejemplo 3: Or

var hoy = DateTime.Today;
var estacion = hoy.Month switch
{
    3 or 4 or 5 => "Primavera",
    6 or 7 or 8 => "Verano",
    9 or 10 or 11 => "Otoño",
    12 or 1 or 2 => "Invierno",
    _ => throw new ApplicationException("Mes incorrecto")
};

Console.WriteLine(estacion);
*/

/*Expresiones Switch y Discard


// var lugar = 7;

// switch (lugar)
// {
//     case 1:
//         Console.WriteLine("¡Quedaste en primer lugar!");
//         break;
//     case 2:
//         Console.WriteLine("¡Quedaste en segundo lugar!");
//         break;
//     case 3:
//         Console.WriteLine("¡Puedes vender tu medalla de bronce en una compraventa!");
//         break;
//     case 4:
//     case 5:
//         Console.WriteLine("Casi casi lo lograste");
//         break;
//     default:
//         Console.WriteLine("¡Mejor suerte para la próxima!");
//         break;
// }

var mensaje = lugar switch
{
    1 => "¡Quedaste en primer lugar!",
    2 => "¡Quedaste en segundo lugar!",
    3 => "¡Puedes vender tu medalla de bronce en una compraventa!",
    4 or 5 => "Casi casi lo lograste",
    _ => "¡Mejor suerte para la próxima!"
};
System.Console.WriteLine(mensaje);
*/

/*While
//Se ejecuta una acción mientras una condición sea verdadera

// int contador = 1;

// while(contador <= 10 ){
//     System.Console.WriteLine(contador);
//     contador++; // contador = contador + 1 (Le sumamos +1 al contador)
// }

var balance = 200m;
var interes = 1.07m;
var contadorInteres = 1;

while (contadorInteres <= 10)
{
    balance = balance * interes;
    contadorInteres++;
}

Console.WriteLine(balance);
*/

/*Do-While

//Se ejecuta una acción mientras una condición sea verdadera. La diferencia es que se ejecuta el bloque de
//codigo al menos 1 vez aún si la sentencia es falsa.

int contador = 1;

//El código no se ejecuta
// while (contador <= 10)
// {
//     System.Console.WriteLine(contador);
//     contador++; // contador = contador + 1 (Le sumamos +1 al contador)
// }

//El bloque de código se ejecuta una vez.
// El bloque de código se ejecuta una vez.
do
{
    Console.WriteLine(contador);
    contador++; // contador = contador + 1
} while (contador > 10);


Console.WriteLine("Fin");
*/

/*For

// int contador = 1; //Inicialización

// while (contador > 10) //Condición
// { 
//     // Bloque de código
//     Console.WriteLine(contador);
//     contador++; // Modificación de la variable inicializada
// }

for (int c = 1; c <= 10; c++){
    System.Console.WriteLine(c);
}
*/

/*Foreach
//Recorre cada elemento de una lista o string.

var nombre = @"Jayson Ventura";

foreach (var letra in nombre)
{
    System.Console.WriteLine(letra);
}
*/

/*Sentencias de Saltos - Brake y Continue

for (int i = 1; i <= 10; i++)
{
    if (i is 5){
        //brake; Detiene la ejecución dependiendo la condición
        //continue; Salta la ejecución dependiendo la condición
    }

    System.Console.WriteLine(i);
}

System.Console.WriteLine("Fin");
*/

/*Bucles infinitos

// while (true)
// {
//     System.Console.WriteLine("Nunca parará... :(");
// }

// for (; ;) {
//     System.Console.WriteLine("Sentimiento cero");
// }

while (true)
{
    Console.WriteLine("Te damos la bienvenida a la calculadora de suma con C#!");
    Console.Write("Escriba el primer número: ");
    var entradaUsuario = Console.ReadLine();

    if (entradaUsuario is null)
    {
        Console.WriteLine("Error. Vuelve a comenzar");
        continue;
    }

    var numero1 = decimal.Parse(entradaUsuario); // Cuidado, podría lanzar una excepción

    Console.Write("Escriba el segundo número: ");
    entradaUsuario = Console.ReadLine();

    if (entradaUsuario is null)
    {
        Console.WriteLine("Error. Vuelve a comenzar");
        continue;
    }

    var numero2 = decimal.Parse(entradaUsuario);

    Console.WriteLine($"El resultado de sumar {numero1} y {numero2} es {numero1 + numero2}");
    Console.Write("¿Desea sumar otra vez? (y/n) ");
    entradaUsuario = Console.ReadLine();

    if (entradaUsuario != "y")
    {
        break;
    }

}

Console.WriteLine("Adiós!");
*/

/*Practica de la S3

//1er ejercicio.

// System.Console.WriteLine(@"Bienvenido!
// Este programa determinará si el número es positivo, negativo o cero ");

// System.Console.Write("Dígite el número entero que desea verificar: ");
// string? input = Console.ReadLine();

// if (string.IsNullOrEmpty(input))
// {
//     System.Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
//     return;
// }

// if (int.TryParse(input, out int num))
// {
//     // Determina si el número es positivo, negativo o cero
//     if (num > 0)
//     {
//         System.Console.WriteLine("El número es positivo!");
//         System.Console.WriteLine("Números desde 1 hasta " + num + ":");

//         for (int i = 1; i <= num; i++)
//         {
//             System.Console.WriteLine(i);
//         }
//     }
//     else if (num < 0)
//     {
//         System.Console.WriteLine("El número es negativo!");
//         System.Console.WriteLine("Números desde " + num + " hasta -1:");

//         int i = num;
//         while (i < 0)
//         {
//             System.Console.WriteLine(i);
//             i++;
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("El número es cero!");
//     }
// }
// else
// {
//     System.Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
// }

//2do ejercicio.

// System.Console.WriteLine(@"Bienvenido!
// Hoy veremos si usted es mayor de edad.");

// System.Console.Write("Ingrese su edad: ");
// string? input = Console.ReadLine();
// int age;

// if (int.TryParse(input, out age))
// {
//     if (age >= 18)
//     {
//         System.Console.WriteLine("Eres mayor de edad! Felicidades puedes beber como un perro.");
//     }
// }
// else if (age < 18)
// {
//     System.Console.WriteLine("Eres menor de edad ve a hacer pipí y a dormir.");
// }
// else
// {
//     System.Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
// }

//3er ejercicio. 

// System.Console.WriteLine(@"Bienvenido a la tabla de multiplicar");
// System.Console.Write("Ingrese el número que desea múltiplicar: ");
// int number = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 12; i++){
//     int result = number * i;
//     System.Console.WriteLine(@$"{number} * {i} = {result}");
// }

//4to ejercicio 

System.Console.WriteLine("Vamos a verificar el tipo de triángulo!");

System.Console.Write("Introduzca el lado 1: ");
double lado1;
lado1 = int.Parse(System.Console.ReadLine());

System.Console.Write("Introduzca el lado 2: ");
double lado2;
lado2 = int.Parse(System.Console.ReadLine());

System.Console.Write("Introduzca el lado 3: ");
double lado3;
lado3 = int.Parse(System.Console.ReadLine());

Console.WriteLine($"Los lados son {lado1},{lado2} y {lado3}");

if(lado1 == lado2 && lado2 == lado3){
    System.Console.WriteLine("El triángulo es equilátero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("El triángulo es isósceles");
}
else
{
    Console.WriteLine("El triángulo es escaleno");
}
*/
