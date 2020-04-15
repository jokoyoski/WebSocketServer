using System;
using Microsoft.AspNetCore.Builder;
using WebSocketServer.CustomMiddleware;

namespace WebSocketServer.ExtensionsMiddleware
{
    public static class CultureExtensionMiddlware
    {
        public static IApplicationBuilder UseRequestCulture(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }
    }
}
