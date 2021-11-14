using System;

namespace Login.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
