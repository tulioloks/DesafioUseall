using System;

namespace DesafioUseall.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string RequestCnpj { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
