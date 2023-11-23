using ShoppingCart.ShoppingCart;

namespace ShoppingCart.EventFeed
{
    public class EventStore : IEventStore
    {
        public IEnumerable<Event> GetEvents(long firstEventSequenceNumber, long lastEventSequenceNumber)
        {
            return database.Where(e => e.SequenceNumber >= firstEventSequenceNumber && e.SequenceNumber <= lastEventSequenceNumber).OrderBy(e => e.SequenceNUmber)
        }

        public Task<IEnumerable<ShoppingCartItem>> GetShoppingCartItems(int[] items)
        {
            throw new NotImplementedException();
        }

        public void Raise(string eventName, object content)
        {
            throw new NotImplementedException();
        }
    }
}
