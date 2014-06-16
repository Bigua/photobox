using System;
using System.ComponentModel;

namespace PhotoBox.Models
{
    public class Photo
    {
        public string Title { get; set; }
        public Uri ImageSource { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
