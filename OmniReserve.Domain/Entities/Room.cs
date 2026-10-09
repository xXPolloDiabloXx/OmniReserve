using OmniReserve.Domain.Enums;

namespace OmniReserve.Domain.Entities;

public class Room
{
    public Guid Id { get; private set; }
    public string Number { get; private set; } = string.Empty;
    public RoomType Type { get; private set; }
    public decimal PricePerNight { get; private set; }
    public bool IsAvailable { get; private set; }

    private Room() { }

    public Room(string roomNumber, RoomType type, decimal pricePerNight)
    {
        if (string.IsNullOrWhiteSpace(roomNumber))
            throw new ArgumentNullException(nameof(roomNumber), "El número de habitación es requerido.");

        if (pricePerNight <= 0)
            throw new ArgumentException("El precio por noche debe ser mayor a cero.", nameof(pricePerNight));

        Id = Guid.NewGuid();
        Number = roomNumber;
        Type = type;
        PricePerNight = pricePerNight;
        IsAvailable = true;
    }
}