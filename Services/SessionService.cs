using Confiho.MVVM.Model;
using PropertyChanged;

namespace Confiho.Services
{
    [AddINotifyPropertyChangedInterface]
    public class SessionService
    {
        public Session Session { get; set; }

        private static SessionService _instance = null;

        public static SessionService getInstance()
        {
            if (_instance == null)
            {
                _instance = new SessionService();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }

        private SessionService() { }
    }
}
