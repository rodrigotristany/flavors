using System;
using System.Threading.Tasks;
using Refit;

namespace flavors.DataLayer
{
    public interface MyBestApi
    {
        [Get("/someMethod/{id}")]
        Task<string> getSomeInfoInSomeMethod(int id);
    }
}