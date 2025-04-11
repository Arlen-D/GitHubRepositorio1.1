using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main()
    {
        // definición e inicialización de los arreglos en paralelo y diccionario.
        int[] población = {185013,197119,439906,198063,530586,414543,229866,214317,475630,421050,174744,1546939,391093,593503,271581,135446,197198};
        string[] Departamento = {
            "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", 
            "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", 
            "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", 
            "Río San Juan", "Rivas"
        };

        Dictionary<string,int> diccionario = Departamento
            .Zip(población, (k,v) => new {clave = k, valor = v})
            .ToDictionary(x => x.clave, x => x.valor);

        // Ordenando el diccionario de menor a mayor
        var ordenado = diccionario.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        // Fijando los nombres de los departamentos con menor y mayor población.
        string minDepkey = ordenado.First().Key;
        string maxDepkey = ordenado.Last().Key;

        // Reasignación de los arreglos en paralelo.
        Departamento = ordenado.Keys.ToArray();
        población = ordenado.Values.ToArray();

        // Mostrar los arreglos ordenados de menor a mayor.
        CultureInfo ni = new CultureInfo("es-NI"); // para usar el punto como separador de miles

        for (var i = 0; i < población.Length; i++)
        {
            Console.WriteLine($"{Departamento[i],-20} ==> {población[i].ToString("N0", ni)}");
        }
        Console.WriteLine($"mayor población: {maxDepkey}");
        Console.WriteLine($"menor población: {minDepkey}");
        // suma de toda la población y nombre de mayor y menor.
        Console.WriteLine($"\nPoblación general: {población.Sum().ToString("N0", ni)}");
        Console.WriteLine($"Departamento con mayor población: {maxDepkey}");
        Console.WriteLine($"Departamento con menor población: {minDepkey}");
       
    

       
    }
}

