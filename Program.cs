using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main()
    {
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
    }
}




