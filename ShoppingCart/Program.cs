using ShoppingCart.ShoppingCart;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddTransient<IShoppingCartStore, ShoppingCartStore>();
//builder.Services.Scan(selector => selector.FromCallingAssembly().AddClasses().AsImplementedInterfaces());

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();
