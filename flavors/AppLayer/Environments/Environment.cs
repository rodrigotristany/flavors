using System;
namespace flavors.AppLayer.Environments
{
    public class Environments
    {
        public static Environment Current { set; get; }

        public Environment Dev { get; set; }
        public Environment Qa { get; set; }
        public Environment Prod { get; set; }
    }

    public class Environment
    {
        public string BaseUrl { get; set; }
        public string BaseUrlPort5000 { get; set; }
        public string GoogleMapKey { get; set; }
        public string PageTitle { get; set; }
    }
}