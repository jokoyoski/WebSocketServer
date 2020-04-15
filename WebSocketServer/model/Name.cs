using System;
using System.Threading;

namespace WebSocketServer.model
{
    public class Name
    {
        public static int counter = 0;
        public Name()
        {
            Interlocked.Increment(ref counter);
        }

        
    }
}
