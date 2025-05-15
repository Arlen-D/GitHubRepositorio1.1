//programa que permite visualizar los departamentos de nicaragua con
//la cantidad poblacional
//encuentra: Mayor, menor, sumas y ordena los datos
using System;
using System.Collections.Generic;

String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439986, 190083, 535656, 414543, 223886, 214917, 475650, 421052, 174744, 1546939, 391903, 593533, 271581, 135446, 182645 };

Dictionary<string, int> diccionario = new Dictionary<string, int>();
for (int i = 0; i < Departamento.Length; i++)
{
    diccionario.Add(Departamento[i], Poblacion[i]);
}

//encontrar el mayor y el menor (poblacion)
int maxDep = Poblacion[0];
int minDep = Poblacion[0];
string maxDepKey = "";
string minDepKey = "";

//encontrar el nombre del departamento que tiene la mayor y menor poblacion
for (var i = 0; i < Poblacion.Length; i++)
{
    if (Poblacion[i] >= maxDep)
    {
<<<<<<< HEAD
        // definición e inicialización de los arreglos en paralelo y diccionario.
        int[] población = {185013,197119,439906,198063,530586,414543,229866,214317,475630,421050,174744,1575819,391093,593503,271581,135446,197198};
        string[] Departamento = {
            "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", 
            "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", 
            "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", 
            "Río San Juan", "Rivas"
        };

        Dictionary<string,int> diccionario = Departamento
            .Zip(población, (k,v) => new {clave = k, valor = v})
            .ToDictionary(x => x.clave, x => x.valor);

        // Obtener claves con mayor y menor valor sin ordenar
        var minDep = diccionario.Aggregate((l, r) => l.Value < r.Value ? l : r);
        var maxDep = diccionario.Aggregate((l, r) => l.Value > r.Value ? l : r);

        // Mostrar el diccionario sin ordenar
        CultureInfo ni = new CultureInfo("es-NI");

        foreach (var item in diccionario)
        {
            Console.WriteLine($"{item.Key,-20} ==> {item.Value.ToString("N0", ni)}");
        }
         //Ordenando con LINQ OrdeBy el diccionario
         
        // suma de toda la población y nombre de mayor y menor.
        Console.WriteLine($"Población general: {diccionario.Values.Sum().ToString("N0", ni)}");
        Console.WriteLine($"Departamento con mayor población: {maxDep.Key}");
        Console.WriteLine($"Departamento con menor población: {minDep.Key}");
        //poblacion promedio 
        Console.WriteLine($"poblacion promedio:{diccionario.Values.Average():N2}");
=======
        maxDep = Poblacion[i];
        maxDepKey = Departamento[i];
    }
    if (Poblacion[i] <= minDep)
    {
        minDep = Poblacion[i];
        minDepKey = Departamento[i];
>>>>>>> 0caf572362b0552a8ac2d3f52b07774389e22995
    }
}

//mostrar el diccionario sin ordenar
Console.WriteLine("Datos desordenados");
foreach (var item in diccionario)
{
    Console.WriteLine("{0} Item Key, {1} Item Value", item.Key, item.Value);
}
Console.WriteLine("");
//mostrar resultados
for (var i = 0; i < Poblacion.Length; i++)
{
    Console.WriteLine("Departamento:{0}, Poblacion:{1}", Departamento[i], Poblacion[i]);
}
//sumar todas la poblaciones con SUM de LINQ
Console.WriteLine("Población General (diccionario.Values.Sum()):" + diccionario.Values.Sum());
Console.WriteLine("Departamento con mayor Población:" + maxDepKey + "(" + maxDep + ")");
Console.WriteLine("Departamento con menor Población:" + minDepKey + "(" + minDep + ")");




