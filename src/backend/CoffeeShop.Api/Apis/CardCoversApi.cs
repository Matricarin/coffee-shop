namespace CoffeeShop.Api.Apis;

public static class CardCoversApi
{
    public static IEndpointRouteBuilder MapCardCoversApi(this IEndpointRouteBuilder group)
    {
        group.MapPost("/new-cover", () => "Админ добавляет новую обложку");
        group.MapPut("/{id}", () => "Админ редактирует обложку или добавляет новую");
        group.MapGet("/list", () => "Получаем список обложек");
        group.MapGet("/{id}", (Guid id) => "Получаем выбранную обложку");
        group.MapDelete("/{id}", (Guid id) => "Админ удаляет обложку");
        return group;
    }
}