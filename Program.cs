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
        maxDep = Poblacion[i];
        maxDepKey = Departamento[i];
    }
    if (Poblacion[i] <= minDep)
    {
        minDep = Poblacion[i];
        minDepKey = Departamento[i];
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




