// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Ingresa el nombre: ");
//string nombre = Console.ReadLine();
//Console.WriteLine($"El nombre es: {nombre}");
//Console.WriteLine($"El nombre {nombre} es ilegal. ERROR " + nombre);

//Métodos

//void imprimirRango(int min, int max){

//Random rand = new Random();
//double numero = min + (rand.NextDouble() *(max - min));
//Console.WriteLine($"El numero ente {min} y {max} es: {numero}");

//}

//imprimirRango(30,60);
//---------------------

void recorrerString(){
    Console.WriteLine("Palabra: ");
    string input = Console.ReadLine();
    for (int posicion = 0; posicion < input.Length; posicion++)
    {
        Console.Write(input[posicion]);
        
        if(posicion < input.Length -1){
            Console.Write("-");
        }
    }
}
 recorrerString();
