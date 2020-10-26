using System;
using System.Net.Http;
using System.Threading.Tasks;
using flavors.AppLayer.Environments;
using Refit;

namespace flavors.DataLayer
{
    public class MyBestService
    {
        private readonly HttpClient httpClient;
        private readonly MyBestApi myBestApi;

        public MyBestService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Environments.Current.BaseUrl);
            myBestApi = RestService.For<MyBestApi>(httpClient);
        }

        //DEV:  http://iamabaseurl.dev.com/someMethod/{id}
        //QA:   http://iamabaseurl.qa.com/someMethod/{id}
        //PROD: http://iamabaseurl.com/someMethod/{id}
        public async Task<string> GetSomeInfoInSomeMethod(int id)
        {
            return await myBestApi.getSomeInfoInSomeMethod(id);
        }
    }
}