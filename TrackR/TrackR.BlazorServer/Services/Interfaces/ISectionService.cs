using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Services.Interfaces;

public interface ISectionService : IServices<Section>
{
    public Task<int> RetrieveMaxPositionAsync();
}