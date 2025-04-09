using System;
using System.Collections.Generic;
using System.Linq; // Necesario para .Zip y .OrderBy

class Program
{
    static void Main(string[] args)
    {
        // Definición e inicialización de los arreglos en paralelo y diccionario.
        int[] poblacion = {
            185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317,
            421050, 389047, 174744, 1546939, 391903, 593503, 271581, 135446, 182645
        };

        string[] departamento = {
            "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte",
            "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz",
            "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas"
        };

        // Crear el diccionario
        Dictionary<string, int> diccionario = departamento
            .Zip(poblacion, (k, v) => new { k, v })
            .ToDictionary(x => x.k, x => x.v);

        // Ordenando el diccionario de menor a mayor
        var ordenado = diccionario.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        // Fijando los nombres de los departamentos con menor y mayor población
        string minDepKey = ordenado.First().Key;
        string maxDepKey = ordenado.Last().Key;

        // Reasignación de los arreglos en paralelo
        departamento = ordenado.Keys.ToArray();
        poblacion = ordenado.Values.ToArray();

        // Mostrar los arreglos ordenados de menor a mayor
        Console.WriteLine("Departamentos ordenados por población:\n");
        for (int i = 0; i < poblacion.Length; i++)
        {
            Console.WriteLine($"{departamento[i],-20} => {poblacion[i],10:N0}");
        }

        // Suma total de la población
        int totalPoblacion = poblacion.Sum();

        // Mostrar total, mayor y menor
        Console.WriteLine($"\nPoblación General: {totalPoblacion:N0}");
        Console.WriteLine($"Mayor población: {maxDepKey}");
        Console.WriteLine($"Menor población: {minDepKey}");
    }
}

