using Ninject;

namespace Calculator.Controllers
{
    public class LoginController : ControllerBase, ILoginController
    {
        public IView LogInView { get; set; }
        public LoginController(IKernel container) : base(container)
        {
        }

        public bool LoggedIn { get; private set; }

        public void LogInAction(string user, string password)
        {
            if (model.LogIn(user, password))
            {
                LoggedIn = true;
                //hide login view
                ((Form)LogInView).Hide();
                //create instance of main view
                MainView = container.Get<IView>("Main"); //new MainForm(model, this);
                //show main view
                ((Form)MainView).Show();
            }
            else
            {
                LoggedIn = false;
                LogInView.UpdateView();
            }
        }
    }
}
