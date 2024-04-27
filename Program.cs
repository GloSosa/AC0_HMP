class Program
{
    static void Main(string[] args)
    {
        Coche Coche1 = new Coche("Civic", "Honda", 200, 1992, 1993, "2019", 4000, true, 5000);


        Console.WriteLine("Detalles del coche:");
        Console.WriteLine($"Modelo: {Coche1.Modelo}");
        Console.WriteLine($"Marca: {Coche1.Marca}");
        Console.WriteLine($"Kilometros: {Coche1.Kilometros}");
        Console.WriteLine($"Año de fabricacion: {Coche1.AnioFabricacion}");
        Console.WriteLine($"Año de matriculacion: {Coche1.AnioMatriculacion}");
        Console.WriteLine($"Fecha de compra: {Coche1.FechaCompra}");
        Console.WriteLine($"Precio de compra: {Coche1.PrecioCompra}");
        Console.WriteLine($"Probado: {Coche1.Probado}");
        Console.WriteLine($"Precio de venta: {Coche1.PrecioVenta}");



        Persona Persona1 = new Persona("Hugo", "6453632M");

        Console.WriteLine("Detalles de la persona :");
        Console.WriteLine($"Nombre: {Persona1.Nombre}");
        Console.WriteLine($"DNI: {Persona1.DNI}");

        Comprador Comprador1 = new Comprador("Hugo", "6453632M", 3600, 400);
        Console.WriteLine("Detalles del comprador");
        Console.WriteLine($"Cantidad pagada: {Comprador1.CantidadPagada}");
        Console.WriteLine($"Cantidad pagada por adelantado: {Comprador1.CantidadSenial}");

    }
}

