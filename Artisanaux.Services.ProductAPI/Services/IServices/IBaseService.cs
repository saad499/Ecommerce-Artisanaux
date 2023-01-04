using Artisanaux.Services.ProductAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Artisanaux.Services.ProductAPI.Services.IServices
{
    public interface IBaseService:IDisposable
    {
        public ResponseDto responseModel { get; set; }

        Task<T> SendAsync<T>(/*ApiRequest apiRequest*/);
    }
}
