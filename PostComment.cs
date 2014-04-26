using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Entities
{
    public class PostComment
    {
        private PostComment() {  }
        
        public PostComment(Post Post, string Comment) {
            this.Post = Post;
            this.Comment = Comment;
        }

        public int Id { get; set; }
        public string Comment { get; private set; }
        public Post Post { get; private set; }
    }
}
