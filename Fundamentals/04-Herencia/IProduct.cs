using System;


public interface IProduct
{
    public void ApplyDiscount(decimal percentage);
    public string GetDescription();
}
