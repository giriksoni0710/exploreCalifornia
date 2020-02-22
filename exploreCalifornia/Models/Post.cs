using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exploreCalifornia.Models
{
    public class Post
    {
        public long Id { get; set; }

        private string _key;

        public string key {

            get {
                if (_key == null) {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set {
                _key = value;
            }
        }

        [Required]
        [Display(Name = "Post Title ")]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Please enter atleast 5 letters for the title")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(100, ErrorMessage = "The body must be atleast 100 characters long")]
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }

    }
}
