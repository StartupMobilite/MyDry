using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace SharedProject
{
    public class Message
    {
        public int Id { get; set; }
        public string TextMessage { get; set; }
        public int IdPerson { get; set; }
    }

    //recuperation des messages
    public class DataMessage : Message
    {
        
    }
    



}
