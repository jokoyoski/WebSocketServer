using System;
using Microsoft.AspNetCore.Builder;
using WebSocketServer.CustomMiddleware;

namespace WebSocketServer.ExtensionsMiddleware
{
      public static class WebSocketExtensionMiddlware
        {
            public static IApplicationBuilder UseSocket(
                this IApplicationBuilder builder)
            {
                return builder.UseMiddleware<WebSocketMiddleware>();
            }
        }
    
}
