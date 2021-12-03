using System;
using System.ComponentModel.DataAnnotations;

namespace AlbumList.Models
{
    public class ListensModel
    {
        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter an artist")]
        public string Artist { get; set; }

        [Required(ErrorMessage = "Please enter an album")]
        public string Album { get; set; }

        [Required(ErrorMessage = "Please enter a rating")]
        [Range(0, 10, ErrorMessage = "Rating must be from 0-10")]
        public double? Rating { get; set; }
    }
}
