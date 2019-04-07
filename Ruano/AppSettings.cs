namespace Ruano
{
    using Xamarin.Essentials;

    public class AppSettings
    {
        public const string defaultAppCenterAndroid = "#";
        public const string defaultAppCenteriOS = "#";

        public static bool Login
        {
            get => Preferences.Get("login_key", false);
            set => Preferences.Set("login_key", value);
        }

        public static void RemoveUserData() => Preferences.Clear();
    }
}
