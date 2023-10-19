using MauiBlazorAppDemo.Data;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace MauiBlazorAppDemo.Pages
{
    public partial class LoginPage : ComponentBase
    {
        private bool passwordVisibility;
        private InputType passwordInputType = InputType.Password;
        private string passwordInputIcon = Icons.Material.Filled.VisibilityOff;

        private LoginModel loginModel = new LoginModel();
        private string message = "";

        private void TogglePasswordVisibility()
        {
            if (passwordVisibility)
            {
                passwordVisibility = false;
                passwordInputIcon = Icons.Material.Filled.VisibilityOff;
                passwordInputType = InputType.Password;
            }
            else
            {
                passwordVisibility = true;
                passwordInputIcon = Icons.Material.Filled.Visibility;
                passwordInputType = InputType.Text;
            }
        }

        public void LoginUserAsync()
        {

        }
    }
}