namespace TheWorld.GameMechanics.StockEntities;

public static class StockItem
{
    public static string? Knife (GameData gameData) =>
        ItemBuilder.FromName("Knife")
            .WithDescription("A Big Fuggin Knife")
            .Build(gameData);
}