namespace Oficondo.Management.Web.App.Pages
{
    using Microsoft.AspNetCore.Components;
    using Oficondo.Management.Web.App.Contracts;
    using Oficondo.Management.Web.App.ViewModels;
    public partial class Register
    {      
        public RegisterViewModel RegisterViewModel { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string Message { get; set; }
        [Inject]
        private IAuthenticationService AuthenticationService { get; set; }
        public Register()
        {

        }

        protected override void OnInitialized()
        {
            RegisterViewModel = new RegisterViewModel();
        }

        protected async void HandleValidSubmit()
        {
            var result = await AuthenticationService.Register(
                RegisterViewModel.FirstName,
                RegisterViewModel.LastName,
                RegisterViewModel.UserName,
                RegisterViewModel.Email,
                RegisterViewModel.Password
            );

            if (result)
            {
                NavigationManager.NavigateTo("home");
            }
            Message = "Something went wrong, please try again";
        }
    }
}
