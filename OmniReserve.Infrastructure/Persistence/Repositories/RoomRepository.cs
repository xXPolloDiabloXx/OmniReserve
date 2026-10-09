using OmniReserve.Application.Common.Interfaces;
namespace OmniReserve.Infrastructure.Persistence.Repositories;
using OmniReserve.Domain.Entities;

public class RoomRepository : IRoomRepository
{
    private static readonly Dictionary<Guid, Room> _rooms = new();

    public Task AddAsync(Room room)
    {
        _rooms[room.Id] = room;
        return Task.CompletedTask;
    }

    public Task<Room?> GetByIdAsync(Guid id)
    {
        _rooms.TryGetValue(id, out var room);
        return Task.FromResult(room);
    }
}