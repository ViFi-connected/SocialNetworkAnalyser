using System;

namespace SocialNetworkAnalyser.Shared.Services
{
    public class JobStateService
    {
        private bool _uploading;

        public bool Uploading
        {
            get => _uploading;
            set
            {
                _uploading = value;
                OnUploadingChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler? OnUploadingChanged;
    }
}
