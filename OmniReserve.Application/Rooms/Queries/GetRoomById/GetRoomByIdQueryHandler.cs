using MediatR;

namespace OmniReserve.Application.Rooms.Queries.GetRoomById;

public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, RoomResponseDto>
{
    public Task<RoomResponseDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
    {
        // Simulación de respuesta desde base de datos
        var roomDto = new RoomResponseDto(
            request.RoomId,
            "101-A",
            "Suite",
            150.00m,
            true
        );

        return Task.FromResult(roomDto);
    }
}