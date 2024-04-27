class Comprador : Persona
{
    public float CantidadPagada { get; set; }
    public float CantidadSenial { get; set; }


    public Comprador(string Nombre, string DNI, float CantidadPagada, float CantidadSenial) : base(Nombre, DNI)

    {
        this.CantidadPagada = CantidadPagada;
        this.CantidadSenial = CantidadSenial;
    }

}