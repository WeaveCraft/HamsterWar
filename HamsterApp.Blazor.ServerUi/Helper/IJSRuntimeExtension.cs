using Microsoft.JSInterop;

namespace HamsterApp.Blazor.ServerUi.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }

        public static async ValueTask SweetAlertSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowSwal", "success", message);
        }

        public static async ValueTask SweetAlertError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowSwal", "error", message);
        }
    }
}
