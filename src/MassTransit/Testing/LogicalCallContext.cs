using System.Threading;

namespace RabbitMQ.Client.client.impl
{
    public class LogicalCallContext
    {
        public static AsyncLocal<string> State = new AsyncLocal<string>();
    }
}
