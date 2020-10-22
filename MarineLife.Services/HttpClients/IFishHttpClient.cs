using MarineLife.Services.Models;

namespace MarineLife.Services.HttpClients
{
    public interface IFishHttpClient
    {
        public FishApi GetFishInfo(string species, string genus);
    }
}