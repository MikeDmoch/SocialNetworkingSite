namespace SocialNetworkingSite.Models
{
    public class ErrorViewModel //Error View Model
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
