namespace HobbyTracker.Entities.Dtos
{
    public record HobbyPutDto(string Name, string ColorHex);
    public record HobbyUpdateDto(Guid id, string Name, string ColorHex, bool IsVisible);
}
