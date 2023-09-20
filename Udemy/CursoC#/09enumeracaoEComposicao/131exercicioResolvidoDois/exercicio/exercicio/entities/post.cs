using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class post
    {
        public DateTime moment { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int likes { get; set; }
        public List<comment> comments { get; set; } = new List<comment>();

        public post()
        {

        }

        public post(DateTime moment, string title, string content, int likes)
        {
            this.moment = moment;
            this.title = title;
            this.content = content;
            this.likes = likes;
        }

        public void addComment(comment comment)
        {
            this.comments.Add(comment);
        }

        public void removeComment(comment comment)
        {
            this.comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(title);
            sb.AppendLine($"{likes} - {moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine(content);
            sb.AppendLine("Comments: ");
            foreach (comment comment in comments)
            {
                sb.AppendLine(comment.text);
            }

            return sb.ToString();
        }
    }
}
