using AutoTestFramework.UIElements;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }


        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost IsPost = new LoginScenarioPost();

            IsPost.UsernameField.SendKeys(username);
            IsPost.PasswordField.SendKeys(password);
            IsPost.RepeatPasswordField.SendKeys(repeatPassword);
            IsPost.LoginButton.Click();
        }
    }
}
