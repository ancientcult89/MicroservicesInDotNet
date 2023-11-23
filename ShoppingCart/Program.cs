using Polly;
using ShoppingCart;
using ShoppingCart.ShoppingCart;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddTransient<IShoppingCartStore, ShoppingCartStore>();
builder.Services.AddHttpClient<IProductCatalogClient, ProductCatalogClient>().AddTransientHttpErrorPolicy(p =>
    (IAsyncPolicy<HttpResponseMessage>)p.WaitAndRetry(3, attempt => TimeSpan.FromMilliseconds(100 * Math.Pow(2, attempt)))
);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();
