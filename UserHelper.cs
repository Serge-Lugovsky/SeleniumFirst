
namespace SeleniumFirst
{
    public class UserHelper : PageManager
    {

        public UserHelper(ApplicationManager applicationManager) : base(applicationManager.Driver)
        {
            
        }

        public void Login( string email, string password)
        {
            Step("Login", () =>
            {
                LoginPage
                    .EnterEmail(email)
                    .EnterPassword(password)
                    .ClickLoginBtn();
            });
        }

    }

}