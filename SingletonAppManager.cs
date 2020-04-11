namespace SeleniumFirst
{
    public class SingletonAppManager
    {
        private static SingletonAppManager _singleInstance;

        public readonly ApplicationManager App;

        private SingletonAppManager() {
            App = new ApplicationManager();
        }

        public static SingletonAppManager GetInstance()
        {
            return _singleInstance ??= new SingletonAppManager();
        }
        
        public static void ResetSingleton() {
            _singleInstance = null;
        }

    }

}