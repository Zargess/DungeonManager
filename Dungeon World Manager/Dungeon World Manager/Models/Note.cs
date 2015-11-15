using System;
using System.ComponentModel;

namespace Dungeon_World_Manager.Models
{
    public class Note : INotifyPropertyChanged
    {
        private string title;
        private string body;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        public string Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
                RaisePropertyChanged(nameof(Body));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Note()
        {
            Title = "";
            Body = "";
        }

        private void RaisePropertyChanged(string v)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}