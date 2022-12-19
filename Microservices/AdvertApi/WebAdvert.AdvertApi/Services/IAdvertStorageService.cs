using AdvertApi.Data;

namespace WebAdvert.AdvertApi.Services
{
    internal interface IAdvertStorageService
    {
        Task<string> AddAdvert(AdvertModel model);

        Task<bool> ConfirmAdvert(ConfirmAdvertModel model);
    }
}
