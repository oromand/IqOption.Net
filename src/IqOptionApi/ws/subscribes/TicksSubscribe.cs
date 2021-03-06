using System;

// ReSharper disable once CheckNamespace
namespace IqOptionApi.Ws
{
    public partial class IqOptionWebSocketClient
    {
        private long _heartbeatTick;
        private long _serverTimeTick;
        public DateTimeOffset Heartbeat => DateTimeOffset.FromUnixTimeMilliseconds(_heartbeatTick);
        public DateTimeOffset ServerTime => DateTimeOffset.FromUnixTimeMilliseconds(_serverTimeTick);

        private void SetHeartbeatTick(long heartbeat)
        {
            _heartbeatTick = heartbeat;
        }

        private void SetServerTime(long serverTime)
        {
            _serverTimeTick = serverTime;
        }
    }
}