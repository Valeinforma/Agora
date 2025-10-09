using MovilApp.ViewModels;
using MovilApp.Views.Login;

namespace MovilApp.Views;

public partial class AgoraShell : Shell
{
    public AgoraShellViewModel ViewModel => (AgoraShellViewModel)BindingContext;
    // Constructor de la clase AgoraShell
    public AgoraShell()
    {
        InitializeComponent(); // Inicializa los componentes definidos en XAML
 
    }

    public void SetLoginState(bool isLoggedIn)
    {
        ViewModel.SetLoginState(isLoggedIn);

    }


}