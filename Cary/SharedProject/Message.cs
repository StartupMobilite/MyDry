using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace SharedProject
{
    public class Message
    {
        public string Id { get; set; }
        public string TextMessage { get; set; }
        public int IdPerson { get; set; }
    }

    //recuperation des messages
    public partial class DataMessage : Message
    {
        private ObservableCollection<Message> items = new ObservableCollection<Message>();

        public DataMessage()
        {
            // InitializeComponent();
        }

        private void InsertMessage(Message message)
        {
            message.Id = Guid.NewGuid().ToString();
            items.Add(message);
        }

        private void RefreshMessageItems()
        {
            //TODO #1 mark this method "async" 
            //items = await MessageTable.ToCollectionAsync();

            //TODO #2 More advanced !!!
            //items = await MessageItem
            //. Where(MessageItem => MessageItem.Complete == false)
            //.ToCollectionAsync();

            ListItems.ItemsSource = items;
        }

        private void UpdateCheckedMessage(Message item)
        {
            // TODO :mark "async"
            // await todoTable.UpdateAsync(message);
            items.Remove(item);
        }

        private void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshMessageItems();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            var message = new Message {Text = InputText.Text};
            InsertMessage(message);
        }

        private void CheckBoxComplete_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox) sender;
            Message message = cb.DataContext as Message;
            message.Complete = true;
            UpdateCheckedMessage(message);
        }

        protected override void onNavigatedTo(NavigationEventArgs e)
        {
            RefreshMessageItems();
        }
    }

}
