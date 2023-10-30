using MongoDB.Bson;
using Realms;


namespace MongoDB_Realm
{
    public class User : RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("Username")]
        [Required]
        public string Username { get; set; }

        [MapTo("Password")]
        [Required]
        public string Password { get; set; }
    }
}
