using MongoDB.Driver;
using MongoDB.Bson;

//const string connectionUri = "mongodb+srv://babchinskyprog:Pass123@buzzbuscluster.pymxgjf.mongodb.net/userbox?retryWrites=true&w=majority";

//var settings = MongoClientSettings.FromConnectionString(connectionUri);

//// Set the ServerApi field of the settings object to Stable API version 1
//settings.ServerApi = new ServerApi(ServerApiVersion.V1);

//// Create a new client and connect to the server
//var client = new MongoClient(settings);




//// Send a ping to confirm a successful connection
//try
//{
//    var result = client.GetDatabase("users").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
//    Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex);
//}


string connectionString = "";
MongoClient client = new MongoClient(connectionString);
IMongoDatabase database = client.GetDatabase("userbox");
IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("users");

// Формируем фильтр для извлечения всех документов
var filter = new BsonDocument();

// Извлекаем все документы из коллекции
var documents = await collection.Find(filter).ToListAsync();

// Выводим каждый документ
foreach (var document in documents)
{
    Console.WriteLine(document);
}

