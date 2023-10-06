using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LibraryApp
{
    [DataContract]
    [Serializable]
    public class Book
    {
        [DataMember]
        public List<string> Name { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author {  get; set; }    

        public Book()
        {
            Name=new List<string>();
            Title = "";
            Author = "";
        }
        public Book(string name, string title, string author)
        {
            Name = new List<string>();
            Title = title;
            Author = author;
        }
    }
}
