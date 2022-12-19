using AdvertApi.Data;

namespace WebAdvert.AdvertApi.Services
{
    public class DynamoDBAdvertStorage : IAdvertStorageService
    {
        Task<string> IAdvertStorageService.AddAdvert(AdvertModel model)
        {
            throw new NotImplementedException();
        }

        Task<bool> IAdvertStorageService.ConfirmAdvert(ConfirmAdvertModel model)
        {
            throw new NotImplementedException();
        }
    }
}
