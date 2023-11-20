using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDatabase
{
    public class DatabaseService
    {
        static DatabaseService _instance;
        public static DatabaseService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseService();
                return _instance;
            }
        }
        public bool IsConnect { get; private set; } = false;
        
        private DatabaseConnection _connection;


        private DatabaseService()
        {
        }
       
        public async Task<bool> ConnectAsync()
        {
            return await Task.Run(() =>
            {
               _connection = new DatabaseConnection();
                return true;
            });
        }
        public async Task<bool> CheckLoginPasswordAsync(string username, string password)
        {
            return await Task.Run(() =>
            {
                return true;
            });
        }
        public async Task<bool> CreateUser(string username, string email, string password)
        {
            return true;
        }
        public async Task<bool> GetUser(string username)
        {
            return await Task.Run(() =>
            {
                return true;
            });
        }
        public async Task<bool> IsEmailExist(string email)
        {
            return await Task.Run(() =>
            {
                return true;
            });
        }       
        public async Task<bool> IsUserNameExist(string username)
        {
            return await Task.Run(() =>
            {
                return true;
            });
        }
        public async Task<List<M_Friend>> GetFreinds()
        {
            return await Task.Run(() =>
            {
               

                return new List<M_Friend>();
            });
        }
        public async Task<M_Friend> GetFriend(string username)
        {
            return new M_Friend();
        }
        public async Task<bool> SetPassword(string username, string newPassword)
        {
            return await Task.Run(() =>
            {
                return true;
            });
        }
        public async Task<List<M_Friend>> GetСoincidences(string UserName, string searchString)
        {
            return await Task.Run(() =>
            {

                return new List<M_Friend>();
            });
        }
        public async Task<bool> AddFriend(string username, string friendName)
        {
            return await Task.Run(() =>
            {
                return true;
            });
        }
        public async Task<bool> RemoveFriend(string username, string friendName)
        {
           
            return false;
        }
    }
}
