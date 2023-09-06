using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;

namespace FirebaseServer.Service
{
    public class FirebaseService
    {
        public FirebaseService()
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(@"D:\cShap\FirebaseServer\FirebaseServer\Recourse\fcmdemo-dd699-firebase-adminsdk-imkl7-18f0a494c2.json"),
            });

        }
        public async void CreateServiceFaireBase()
        {
            // Construct the message payload
            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = "Test Notification",
                    Body = "This is a test notification"
                },
                Token = "f9CjkoJTQTiY_a32B5jAvt:APA91bG2XvONsRH_8Ut12b3MbV1Z4B90OOK0_wYN2v9SUiX8w8b_31XDwUVWzOw2asOHzHMRQL3O1ZlgDK6v_LlNy6Cne8pJ2pNlM2hhUSe1WcBSrQLrrxCvrI1ellwN2BPx0Y1i-014"
            };

            // Send the message
            var response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
            Console.WriteLine($"Successfully sent message: {response}");
        }
    }
}
