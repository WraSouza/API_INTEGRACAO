

namespace Domain.Entities.SAPEntities
{
    public class LoginResponse
    {
        public LoginResponse(string sessionId, string version, int sessionTimeout)
        {
            SessionId = sessionId;
            Version = version;
            SessionTimeout = sessionTimeout;
        }

        public string SessionId { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public int SessionTimeout { get; set; }
    }
}