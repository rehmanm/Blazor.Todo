using Microsoft.JSInterop;

namespace Blazor.Todo.Helper
{
    public class AppTheme(IJSRuntime _jsRuntime)
    {
        private bool _isDarkMode = false;

        public bool IsDarkMode
        {
            get { return _isDarkMode; }
            set
            {
                _isDarkMode = value;
                _jsRuntime.InvokeVoidAsync("setDarkMode", value);
                OnChange?.Invoke();
            }
        }

        public async Task<bool> IsBrowserDarkMode() => await _jsRuntime.InvokeAsync<bool>("isBorwserDarkMode");

        public event Action? OnChange;

        public async Task ListenForThemeChanges()
        {
            var dotnetHelper = DotNetObjectReference.Create(this);

            await _jsRuntime.InvokeVoidAsync("addThemeEventListener", dotnetHelper);
        }

        [JSInvokable]
        public async Task SetDarkMode(bool isDarkMode) =>  IsDarkMode = isDarkMode;  
    }
}