// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Mediante un ciclo pedir al usuario que capture 20 números, calcular el promedio, moda, máximo y mínimo.
//Si el promedio es mayor igual que la moda, imprimir “El núm” + numModa + “ está a la moda”.
//DE
Console.WriteLine("En este programa, sabremos si la moda está a la moda, el promedio sea igual o mayor que ella sino " +
    "daremos a conocer los datos que capturaste.(moda,promedio,minimo,máximo)");
double[] numeros = new double[20];
double prom = 0;
double moda = 0;
double max = 0;
double min = 0;
double cont1 = 0;
double cont2 = 0;
double suma = 0;
//Procedimiento
Console.WriteLine("Vamos a capturar 20 números distintos");
for (int i = 0; i < numeros.Length; i++) 
{
    Console.WriteLine("Captura tu número No. " + (i+1));//Ciclo para la captura de los 20 números
    numeros[i] = double.Parse(Console.ReadLine());
    suma = suma + numeros[i];
    prom = suma/numeros.Length;//Promediamos los 20 números
}
for (int k = 0; k < numeros.Length; k++)//Ciclo para saber el número que más veces se repite
{
    for (int j = 0; j < numeros.Length; j++)
    {
        if (numeros[k] == numeros[j] && k != j)//Aquí valoramos si son iguales para que el contador se incremente
        {
            cont1++;//Contador que se incrementa cuando los números son iguales
        } 
    }
    if (cont1 > cont2)//valoramos si son distintos y si son distintos vamos intercambiandolo y sumandolo al cont
    {
        cont2 = cont1;
        moda = numeros[k];
    }
    cont1 = 0;//inicializamos en 0 la posición para que se vaya guardando ahí. 
}
//Comenzaremos con el ordenamiento de la bubruja para ordenamiento
for (int i = 0; i < numeros.Length; i++)
{
    for (int u = 0; u < numeros.Length-1; u++)
    {
        if (numeros[u] > numeros[u + 1])//Ordenamiento de menor a mayor
        {
            double temp = numeros[u];
            numeros[u] = numeros[u + 1];
            numeros[u + 1] = temp;//Ordenamiento de burbuja terminado. 
        }

    }
    min = numeros[0];//El minimo es el de la primera posición
    max = numeros[numeros.Length-1];//el máximo sería el de la ultima posición
}
if (prom>=moda)
{
    Console.WriteLine($"El número {moda} esta a la moda");
}
Console.WriteLine($"Si quieres conocer los demás datos, la moda fue {moda} el promedio es {prom} tu número mínimo es {min} y el máximo es {max}");
