using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingPlatform.Infrasctructure.Repositories
{
    public interface IBloggingPlatformRepository
    {
        public List<BlogPost> List();
        public BlogPost GetById(Guid id);
        public void Save(BlogPost BlogPostVM);
        public void SaveComment(Comment comment);
        public void Update(BlogPost blogPost);
        public bool Delete(int cod);
    }
}
