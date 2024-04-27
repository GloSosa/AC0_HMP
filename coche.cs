class Coche
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public float Kilometros { get; set; }
    public int AnioFabricacion { get; set; }
    public int AnioMatriculacion { get; set; }
    public string FechaCompra { get; set; }
    public float PrecioCompra { get; set; }
    public bool Probado { get; set; }
    public float PrecioVenta { get; set; }

    public Coche(string Modelo, string Marca, float Kilometros, int AnioFabricacion, int AnioMatriculacion, string FechaCompra, float PrecioCompra, bool Probado, float PrecioVenta)
    {
        this.Modelo = Modelo;
        this.Marca = Marca;
        this.Kilometros = Kilometros;
        this.AnioFabricacion = AnioFabricacion;
        this.AnioMatriculacion = AnioMatriculacion;
        this.FechaCompra = FechaCompra;
        this.PrecioCompra = PrecioCompra;
        this.Probado = Probado;
        this.PrecioVenta = PrecioVenta;
    }

}


