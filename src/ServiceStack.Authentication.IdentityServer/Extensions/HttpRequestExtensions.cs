using System;

namespace ServiceStack.Authentication.IdentityServer.Extensions
{
    /// <summary>
    /// The GetLeftAuthority method is copied from ServiceStack 4.5.2 because we are using ServiceStack 4.5.0
    /// </summary>
    public static class HttpRequestExtensions
    {
        public static string GetLeftAuthority(this Uri uri)
        {
            return $"{uri.Scheme}://{uri.Authority}";
        }
    }
}