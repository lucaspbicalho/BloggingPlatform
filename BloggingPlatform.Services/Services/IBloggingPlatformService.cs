﻿namespace BloggingPlatform.Services
{
    public interface IBloggingPlatformService
    {
        public List<BlogPost> List();
        public BlogPost GetById(Guid id);
        public void Save(BlogPost BlogPostVM);
        public void SaveComment(Comment comment);
        public void Update(BlogPost blogPost);
        public bool Delete(int cod);
    }
}
