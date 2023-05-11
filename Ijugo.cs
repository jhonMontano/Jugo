namespace jugo;

public interface Jugo
{
    string Nombre { get; set; }
    List<Ingrediente> Ingredientes { get; }
    void AgregarIngrediente(Ingrediente ingrediente);
    string CantidadIngredientes();
    string ListaIngredientes();
    decimal CalcularCosto();
}

public class Ingrediente
{
    public string Nombre { get; }
    public string Cantidad { get; }
    public decimal Precio { get; }

    public Ingrediente(string nombre, string cantidad, decimal precio)
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Precio = precio;
    }
}