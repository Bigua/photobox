using System.Collections.Generic;
using System.Linq;
using PhotoBox.Helpers;
using PhotoBox.Models;
using PhotoBox.Services;


namespace PhotoBox.ViewModels
{
    public class PhotosViewModel
    {
        public List<KeyedList<string, Photo>> GroupedPhotos
        {
            get
            {
                var photos = DataService.GetPhotos();

                var groupedPhotos =
                    from photo in photos
                    orderby photo.TimeStamp
                    group photo by photo.TimeStamp.ToString("y") into photosByMonth
                    select new KeyedList<string, Photo>(photosByMonth);

                return new List<KeyedList<string, Photo>>(groupedPhotos);
            }
        }
    }
}
