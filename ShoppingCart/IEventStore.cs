namespace ShoppingCart.ShoppingCart
{
    public interface IEventStore
    {
        public Task<IEnumerable<ShoppingCartItem>>  GetShoppingCartItems(int[] items);
    }
}