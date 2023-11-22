namespace ShoppingCart.ShoppingCart
{
    public interface IProductCatalogClient
    {
       public Task<IEnumerable<ShoppingCartItem>> GetShoppingCartItems(int[] productCatalogIds);
    }
}