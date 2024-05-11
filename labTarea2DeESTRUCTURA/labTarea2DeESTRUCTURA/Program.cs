



//   RECURSIVIDAD


//    (1) Ejercicio  Escribe una función recursiva que imprima los números pares del 1 al 100.  

//class Program
//{
//    static void Main(string[] args)
//    {
//        ImprimirNumerosPares(1);
//        Console.ReadKey();
//    }
//    static void ImprimirNumerosPares(int numero)
//    {
//        // Caso base: si el número es mayor que 100, terminamos la recursión
//        if (numero > 100)
//        {
//            return;
//        }

//        if (numero % 2 == 0)
//        {
//            Console.WriteLine(numero);
//        }
//        // Llamamos a la función recursivamente con el siguiente número
//        ImprimirNumerosPares(numero + 1);
//    }
//}




//   2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n. 


//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese el valor de 'n': ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("La suma de los números del 1 al " + n + " es: " + SumaRecursiva(n));
//        Console.ReadKey();
//    }
//    static int SumaRecursiva(int n)
//    {
//        // Caso base: si n es 1, la suma es 1
//        if (n == 1)
//        {
//            return 1;
//        }
//        // Caso recursivo: sumar n con la suma de los números del 1 al n-1
//        else
//        {
//            return n + SumaRecursiva(n - 1);
//        }
//    }
//}




//   3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n. 


//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese el valor de 'n': ");
//        int n = int.Parse(Console.ReadLine());

//        ImprimirPiramide(n);
//        Console.ReadKey();
//    }
//    static void ImprimirPiramide(int n, int nivel = 1)
//    {
//        // Caso base
//        if (nivel > n)
//        {
//            return;
//        }
//        // Imprimir los números del 1 al nivel actual
//        for (int i = 1; i <= nivel; i++)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine(); 

//        // Llamamos a la función recursivamente
//        ImprimirPiramide(n, nivel + 1);
//    }
//}





//   4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese el valor de 'n': ");
//        int n = int.Parse(Console.ReadLine());
//        ImprimirPiramideInvertida(n);
//        Console.ReadKey();
//    }
//    static void ImprimirPiramideInvertida(int n, int nivel = 1)
//    {
//        // Caso base
//        if (nivel > n)
//        {
//            return;
//        }
//        for (int i = 0; i < n - nivel; i++)
//        {
//            Console.Write(" ");
//        }
//        for (int i = nivel; i >= 1; i--)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine(); 
//        // Llamamos a la función recursiva
//        ImprimirPiramideInvertida(n, nivel + 1);
//    }
//}



//    5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n. 


//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese el número para la tabla de multiplicar: ");
//        int n = int.Parse(Console.ReadLine());

//        ImprimirTablaMultiplicar(n);
//        Console.ReadKey();
//    }

//    static void ImprimirTablaMultiplicar(int n, int multiplicador = 1)
//    {
//        // Caso base
//        if (multiplicador > 10)
//        {
//            return;
//        }

//        Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");

//        // Llamamos a la función recursivamente con el siguiente multiplicador
//        ImprimirTablaMultiplicar(n, multiplicador + 1);
//    }
//}










//   ARREGLOS Y MATRICES

//    6) Crea una matriz de números reales. 


//// Crear una matriz de tamaño 3x3 de números reales
//double[,] matriz = new double[3, 3];

//matriz[0, 0] = 1.9;
//matriz[0, 1] = 2.8;
//matriz[0, 2] = 3.7;
//matriz[1, 0] = 4.6;
//matriz[1, 1] = 5.5;
//matriz[1, 2] = 6.4;
//matriz[2, 0] = 7.3;
//matriz[2, 1] = 8.2;
//matriz[2, 2] = 9.1;

//// Mostrar la matriz
//Console.WriteLine("Matriz de números reales:");

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(matriz[i, j] + "\t");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();













//  7) Crea una matriz de números complejos. 


//// Crear una matriz de números complejos de tamaño 2x2

//Complex[,] matrizCompleja = new Complex[2, 2];

//matrizCompleja[0, 0] = new Complex(1, 2);
//matrizCompleja[0, 1] = new Complex(-3, 4);
//matrizCompleja[1, 0] = new Complex(5, -6);
//matrizCompleja[1, 1] = new Complex(-7, -8);

//// Mostrar la matriz de números complejos
//Console.WriteLine("Matriz de números complejos:");

//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write("(" + matrizCompleja[i, j].Real + ", " +
//            matrizCompleja[i, j].Imaginary + ")\t");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();






//8) Crea una matriz de matrices. 



//// Crear una matriz de matrices de tamaño 3x3
//int[][] matrizDeMatrices = new int[3][];

//matrizDeMatrices[0] = new int[] { 1, 2, 3, 4 };
//matrizDeMatrices[1] = new int[] { 5, 6, 7 };
//matrizDeMatrices[2] = new int[] { 8, 9, 10, 11, 12 };

//// Mostrar la matriz de matrices
//Console.WriteLine("Matriz de matrices:");

//for (int i = 0; i < matrizDeMatrices.Length; i++)
//{
//    Console.Write("[ ");
//    for (int j = 0; j < matrizDeMatrices[i].Length; j++)
//    {
//        Console.Write(matrizDeMatrices[i][j] + " ");
//    }
//    Console.WriteLine("]");
//}
//Console.ReadKey();







//   9) Accede al elemento central de una matriz. 


//// Crear una matriz de ejemplo de 3x3
//int[,] matriz = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//// Calcular el índice del elemento central
//int filaCentral = matriz.GetLength(0) / 2;
//int columnaCentral = matriz.GetLength(1) / 2;

//// Acceder al elemento central
//int elementoCentral = matriz[filaCentral, columnaCentral];

//Console.WriteLine("Matriz:");
//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        Console.Write(matriz[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("El elemento central de la matriz es: " + elementoCentral);
//Console.ReadKey();




//   10) Suma dos matrices de diferentes tamaños.
//// Definir la primera matriz
//int[,] matriz1 = new int[,]
//{
//    {1, 2, 3},
//    {4, 5, 6}
//};
//// Definir la segunda matriz
//int[,] matriz2 = new int[,]
//{
//    {7, 8, 9,},
//    {10, 11, 12},
//    {11, 12, 13},
//};
//// Verificar si las matrices tienen el mismo tamaño
//if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
//{
//    // Crear una matriz para almacenar la suma
//    int[,] matrizSuma = new int[matriz1.GetLength(0), matriz1.GetLength(1)];
//    for (int i = 0; i < matriz1.GetLength(0); i++)
//    {
//        for (int j = 0; j < matriz1.GetLength(1); j++)
//        {
//            matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
//        }
//    }
//    // Mostrar la matriz resultante de la suma
//    Console.WriteLine("Matriz resultante de la suma:");
//    for (int i = 0; i < matrizSuma.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrizSuma.GetLength(1); j++)
//        {
//            Console.Write(matrizSuma[i, j] + "\t");
//        }
//        Console.WriteLine();
//    }
//}
//else
//{
//    Console.WriteLine("Las matrices tienen tamaños diferentes y no se pueden sumar.");
//}
//Console.ReadKey();






//    11) Multiplica una matriz por un número. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matriz = new int[,]
//        {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };
//        int escalar = 2;
//        // Mostrar la matriz original
//        Console.WriteLine("Matriz original:");
//        MostrarMatriz(matriz);
//        // Mostrar el número escalar
//        Console.WriteLine("\nNúmero escalar a multiplicar: " + escalar);
//        // Multiplicar la matriz por el número escalar
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                matriz[i, j] *= escalar;
//            }
//        }
//        // Mostrar la matriz resultante
//        Console.WriteLine("\nMatriz resultante:");
//        MostrarMatriz(matriz);

//        Console.ReadKey();
//    }


//    // Método para mostrar la matriz en la consola
//    static void MostrarMatriz(int[,] matriz)
//    {
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}





//     12) Calcula la media de los elementos de una matriz. 


//class Program
//{
//    static void Main(string[] args)
//    {
//        // Definir la matriz
//        int[,] matriz = new int[,]
//        {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        // Mostrar la matriz original
//        Console.WriteLine("Matriz original:");
//        MostrarMatriz(matriz);

//        // Calcular la media de los elementos de la matriz
//        double media = CalcularMedia(matriz);

//        // Mostrar la media
//        Console.WriteLine("\nMedia de los elementos: " + media);

//        Console.ReadKey();
//    }

//    // Método para mostrar la matriz en la consola
//    static void MostrarMatriz(int[,] matriz)
//    {
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//    // Método para calcular la media de los elementos de la matriz
//    static double CalcularMedia(int[,] matriz)
//    {
//        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
//        int suma = 0;

//        // Calcular la suma de todos los elementos
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                suma += matriz[i, j];
//            }
//        }
//        // Calcular la media
//        double media = (double)suma / totalElementos;
//        return media;
//    }
//}



// matrices

//   Ejercicio 1: Crea una matriz de números aleatorios de tamaño 100x100. 

//// Crear una instancia de la clase Random
//Random random = new Random();
//// Definir el tamaño de la matriz
//int filas = 100;
//int columnas = 100;
//// Crear una matriz de números aleatorios
//int[,] matriz = new int[filas, columnas];
//// Llenar la matriz con números aleatorios
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        matriz[i, j] = random.Next(1000);
//    }
//}
//// Imprimir la matriz
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        Console.Write(matriz[i, j] + "\t");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();











//  Ejercicio 2: Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Crear una instancia de la clase Random
//        Random random = new Random();

//        // Definir el tamaño de la matriz
//        int filas = 3;
//        int columnas = 3;

//        // Crear una matriz de números aleatorios
//        int[,] matriz = new int[filas, columnas];

//        // Llenar la matriz con números aleatorios
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                matriz[i, j] = random.Next(1, 100); // Generar un número aleatorio entre 1 y 99
//            }
//        }
//        // Mostrar la matriz
//        Console.WriteLine("Matriz:");
//        ImprimirMatriz(matriz);
//        // Calcular la media de los elementos
//        double media = CalcularMedia(matriz);
//        // Calcular la mediana de los elementos
//        double mediana = CalcularMediana(matriz);
//        // Calcular la desviación estándar de los elementos
//        double desviacionEstandar = CalcularDesviacionEstandar(matriz, media);
//        // Mostrar los resultados
//        Console.WriteLine("\nMedia: " + media);
//        Console.WriteLine("Mediana: " + mediana);
//        Console.WriteLine("Desviación estándar: " + desviacionEstandar);
//    }
//    static double CalcularMedia(int[,] matriz)
//    {
//        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
//        int suma = 0;
//        // Sumar todos los elementos de la matriz
//        foreach (int elemento in matriz)
//        {
//            suma += elemento;
//        }
//        // Calcular la media
//        return (double)suma / totalElementos;
//    }
//    static double CalcularMediana(int[,] matriz)
//    {
//        // Obtener todos los elementos de la matriz
//        int[] elementos = new int[matriz.GetLength(0) * matriz.GetLength(1)];
//        int k = 0;
//        foreach (int elemento in matriz)
//        {
//            elementos[k++] = elemento;
//        }
//        // Ordenar los elementos
//        Array.Sort(elementos);
//        // Calcular la mediana
//        int n = elementos.Length;
//        if (n % 2 == 0)
//        {
//            // Si hay un número par de elementos, tomar el promedio de los dos elementos centrales
//            int indice1 = n / 2 - 1;
//            int indice2 = n / 2;
//            return (elementos[indice1] + elementos[indice2]) / 2.0;
//        }
//        else
//        {
//            // Si hay un número impar de elementos, tomar el elemento central
//            int indice = n / 2;
//            return elementos[indice];
//        }
//    }
//    static double CalcularDesviacionEstandar(int[,] matriz, double media)
//    {
//        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
//        double sumaCuadrados = 0;
//        // Calcular la suma de los cuadrados de las diferencias entre cada elemento y la media
//        foreach (int elemento in matriz)
//        {
//            double diferencia = elemento - media;
//            sumaCuadrados += diferencia * diferencia;
//        }
//        // Calcular la desviación estándar
//        double varianza = sumaCuadrados / totalElementos;
//        return Math.Sqrt(varianza);
//    }
//    static void ImprimirMatriz(int[,] matriz)
//    {
//        int filas = matriz.GetLength(0);
//        int columnas = matriz.GetLength(1);
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}






//    Ejercicio 3: Escribe una función que encuentre el elemento máximo de una matriz. 

class Program
{
    static void Main(string[] args)
    {
        // Definir una matriz
        int[,] matriz = { { 1, 2, 3 }, { 4, 9, 6 }, { 7, 18, 5 } };
        // Mostrar la matriz
        Console.WriteLine("Matriz:");
        ImprimirMatriz(matriz);
        // Encontrar el elemento máximo de la matriz
        int maximo = EncontrarMaximo(matriz);
        // Mostrar el elemento máximo
        Console.WriteLine("\nEl elemento máximo de la matriz es: " + maximo);
        Console.ReadKey();
    }
    static int EncontrarMaximo(int[,] matriz)
    {
        int maximo = int.MinValue; // Inicializar el máximo con el menor valor posible de un entero
        // Recorrer todos los elementos de la matriz
        foreach (int elemento in matriz)
        {
            // Actualizar el máximo si encontramos un valor mayor
            if (elemento > maximo)
            {
                maximo = elemento;
            }
        }
        // Devolver el máximo encontrado
        return maximo;
    }
    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}




































