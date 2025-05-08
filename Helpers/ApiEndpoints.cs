namespace BlazorApp1.Helpers;

public static class ApiEndpoints
{
    public const string Register = "Authentication/Register";
    public const string Login = "Authentication/Login";
    public const string GetCards = "UserCard/UserCards";
    public const string AddCard = "UserCard/AddCard";
    public static string DeleteCard(int id) => $"UserCard/DeleteCard?id={id}";
    public const string AddOrder = "Order/AddOrder";
    public const string EasyTrade = "Order/EasyTrade/ETAddOrder";
}
