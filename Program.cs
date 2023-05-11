using jugo;
using System.Collections.Generic;

class Jugo1 : Jugo
{
    public string Nombre { get; set; }
    private List<Ingrediente> _ingredientes = new List<Ingrediente>();
    public List<Ingrediente> Ingredientes { get { return _ingredientes; } }

    public void AgregarIngrediente(Ingrediente ingrediente)
    {
        _ingredientes.Add(ingrediente);
    }

    public string CantidadIngredientes()
    {
        string cantidad = "";
        foreach (Ingrediente ingrediente in _ingredientes)
        {
            cantidad += $" {ingrediente.Cantidad} \n"; ;
        }
        return cantidad;
    }

    public string ListaIngredientes()
    {
        string result = "";
        foreach (Ingrediente ingrediente in _ingredientes)
        {
            result += $"{ingrediente.Nombre} - {ingrediente.Cantidad} - {ingrediente.Precio}$\n";
        }
        return result;
    }

    public decimal CalcularCosto()
    {
        decimal cost = 0;
        foreach (Ingrediente ingrediente in _ingredientes)
        {
            cost += ingrediente.Precio;
        }
        return cost;
    }
}
