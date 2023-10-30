using Realms.Sync;
using Realms;
using MongoDB.Bson;
using MongoDB.Driver;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CommunityToolkit.Mvvm.ComponentModel;
//using System.Collections.ObjectModel;
////using TodoMaui.Models;
//using CommunityToolkit.Mvvm.Input;
//using TodoMaui.Helpers;

class Program
{
    static async Task Main(string[] args)
    {
        // Замените "your-app-id" на фактический Realm App Id.
        var appId = "application-0-ypabv";

        // Создайте конфигурацию для подключения к MongoDB Realm.
        var appConfig = new AppConfiguration(appId)
        {
            // Дополнительные параметры, если необходимо.
        };

        // Инициализируйте Realm приложение.
        var app = App.Create(appConfig);

        // Аутентифицируйтесь, если это необходимо.
        var user = await app.LogInAsync(Credentials.Anonymous());

        if (user != null)
        {
            Console.WriteLine("Успешно вошли в Realm.");
            // Вы можете выполнять операции с MongoDB Realm здесь.
        }
        else
        {
            Console.WriteLine("Не удалось войти в Realm.");
        }
    }
}




//public class MongoRealm
//{
//    private Realm realm;
//    private PartitionSyncConfiguration config;

//    public async Task InitialiseRealm()
//    {
//        config = new PartitionSyncConfiguration($"{App.RealmApp.CurrentUser.Id}", App.RealmApp.CurrentUser);
//        realm = Realm.GetInstance(config);

//        //GetTodos();
//        //if (TodoList.Count == 0)
//        //{
//        //    EmptyText = "Loading projects..";
//        //    await Task.Delay(2000);
//        //    GetTodos();
//        //    EmptyText = "No todos here. Add new Todo to get started 💪";
//        //}

//    }
//    //public static Realms.Sync.App RealmApp;

//    //public MongoRealm() 
//    //{
//    //    RealmApp = Realms.Sync.App.Create("application-0-ypabv");
//    //}

//}



