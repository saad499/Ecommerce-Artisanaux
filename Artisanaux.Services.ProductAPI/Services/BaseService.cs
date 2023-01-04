using Artisanaux.Services.ProductAPI.Models.Dto;
using Artisanaux.Services.ProductAPI.Services.IServices;
using AutoMapper.Internal;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Newtonsoft.Json;

namespace Artisanaux.Services.ProductAPI.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDto responseModel { get; set; }
        IHttpClientFactory httpClient;

        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new ResponseDto();
            this.httpClient = httpClient;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<T> SendAsync<T>(/*ApiRequest apiRequest*/)
        {
            try
            {
                var client = httpClient.CreateClient("ArtisanaAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                //message.RequestUri = new(apiRequest.URL);
                client.DefaultRequestHeaders.Clear();

                /*if(apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonContent.SerializeObject(ApiRequestFormat.Data),
                            Encoding.UTF8, "application/json");
                }
                if (string.IsNullOrEmpty(ApiRequestFormat.AccessToken))
                {
                    Client.DefaultRequestHeaders.Authentication = new AuthenticationHeaderValue("Bearer",apiRequest.AccessToken);
                }*/
                HttpResponseMessage apiResponse = null;

                /*switch (ApiRequestFormat.ApiType)
                {
                    case SD.ApiTypr.POST:
                        Message.Method = HttpMethod.POST;
                        break;
                    case SD.ApiTypr.PUT:
                        Message.Method = HttpMethod.PUT;
                        break;
                    case SD.ApiTypr.DELETE:
                        Message.Method = HttpMethod.DELETE;
                        break;
                    DEFAULT
                        Message.Method = HttpMethod.GET;
                        break;
                }*/
                apiResponse = await client.SendAsync(message);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResposeDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResposeDto;

            }
            catch (Exception e)
            {
                var dto = new ResponseDto
                {
                    DisplayMessage = "Error",
                    ErrorMessages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
                return apiResponseDto;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
