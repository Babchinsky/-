using System;
using System.ComponentModel;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;



class Program
{

    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    static async Task Main(string[] args)
    {
        // Настройка конфигурации Firesharp
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "o5DC7FefcQicjSQiIkBA37BkgzjhGZKwB0eL9Y72",
            BasePath = "https://buzzbusproject-64015-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client = new FirebaseClient(config);

        var user = new User()
        {
            Id = "1",
            Email = "test@test.com",
            Password = "password",
        };

        //await client.SetAsync(@"BuzzBusProject/" + email, password);
        //await client.SetAsync("Users/user1", user);
        client.Set(@"Users/" + user.Id, user);
    }   
}
