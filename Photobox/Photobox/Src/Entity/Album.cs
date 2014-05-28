using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBox.Src.Entity
{
    [Table(Name = "Album")]
    class Album
    {
        private int _id;
        
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nomAlbum;

        [Column(Name = "NomAlbum", CanBeNull = false)]
        public string NomAlbum
        {
            get { return _nomAlbum; }
            set { _nomAlbum = value; }
        }
    }
}
