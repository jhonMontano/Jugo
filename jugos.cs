namespace jugo;
class Programa
{
    static void Main(string[] args)
    {
        Jugo jugo1 = new Jugo1();
        jugo1.Nombre = "Jugo de mango";
        jugo1.AgregarIngrediente(new Ingrediente("mango", "300", 1200));
        jugo1.AgregarIngrediente(new Ingrediente("azucar", "300", 500));
        jugo1.AgregarIngrediente(new Ingrediente("leche", "400", 1200));
        Console.WriteLine($"\nNombre del jugo: {jugo1.Nombre}");
        Console.WriteLine($"Ingredientes:\n{jugo1.ListaIngredientes()}");
        Console.WriteLine($"Cantidad de fruta en gramos: \n{jugo1.CantidadIngredientes()}");
        Console.WriteLine($"Valor del jugo: {jugo1.CalcularCosto()}$\n");
    }
}