public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        //Obtener de una BD o API o Archivo
        WriteLine("Busacando Producto...");
        await Task.Delay(200);
        return new Product("Producto simulado", 500);
    }
}