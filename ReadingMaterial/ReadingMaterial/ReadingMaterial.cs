using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingMaterial
{
    class ReadingMaterial
    {
        private string Title { get; set; }
        private string Subtitle { get; set; }
        private string Author { get; set; }

        public ReadingMaterial(string author = "N/A", string title = "N/A", string subtitle = "N/A")
        {
            Title = title;
            Subtitle = subtitle;
            Author = author;
        }
    }
}
