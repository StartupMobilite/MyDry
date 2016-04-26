using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Android.Bluetooth;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Windows.Storage;

namespace SharedProject
{
    class Message
    {
        public int Id { get; set; }
        public string TextMessage { get; set; }
        public int IdPerson { get; set; }
    }
}
