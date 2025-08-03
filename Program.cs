// See https://aka.ms/new-console-template for more information


using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var laptop = new Product("Laptop", 1200);
        // WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte tecnico", 300, 30);
        // WriteLine(soporte.GetDescription());
        var product = new Product("Mouse Gamer", 600);
        var productDto = ProductAdapter.ToDto(product);
        // WriteLine($"{productDto.Name} - {productDto.Price} - Codigo: {productDto.Code}");

        //Inyeccion de dependencias
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var monitor = new Product("Monitor", 100);
        var installation = new ServiceProduct("Instalar Monitor", 20, 20);
        // manager.PrintLabel(monitor);
        // manager.PrintLabel(installation);
        var firstProduct = await new ProductRepository().GetProduct(1);
        firstProduct.Desciption = "Esta es la descripcion del primer producto";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        WriteLine($"{firstProduct.Name}-{firstProduct.Price}-{firstProduct.Desciption}");

    }
}

