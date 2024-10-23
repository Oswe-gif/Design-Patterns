using System.Runtime.CompilerServices;

namespace Singleton
{
    sealed class Database
    {
        private static Database _instance;
        private static readonly object _lock = new object();
        private string _value = "Default value";
        private Database() { }
            
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Database GetInstance() {
            if (_instance == null) {
                lock (_lock) {
                    _instance = new Database();
                }
            }
            return _instance;
        }

        public string Value { get => _value; set => _value = value; }


    }
}
