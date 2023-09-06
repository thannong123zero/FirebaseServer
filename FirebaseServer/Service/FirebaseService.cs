using FirebaseAdmin;

namespace FirebaseServer.Service
{
    public class FirebaseService
    {
        public FirebaseService() { }
        public void CreateServiceFaireBase()
        {
            FirebaseApp.Create();
        }
    }
}
