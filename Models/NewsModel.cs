using System;

namespace coouncil.Models {
    public class NewsModel {
        public int Id { get; set; }

        public string Title { get; set; }
        public string ImgUrl { get; set; }

        public string Text { get; set; }

        public string Date { get; set; }

        // public bool visiblity { get; set; }
    }
}