public class LabelService : ILabelService
{
    public string GenerateLabel(Product product)
    {
        return $"{product.Name} - Precio: {product.GetType().Name}-{product.GetHashCode()}";
    }
}