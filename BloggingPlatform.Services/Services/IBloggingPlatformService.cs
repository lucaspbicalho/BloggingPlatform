namespace BloggingPlatform.Services
{
    public interface IBloggingPlatformService
    {
        public List<BlogPost> List();
        public BlogPost GetById(Guid id);
        public void Save(BlogPost BlogPostVM);
        public bool Update(int codVenda);
        public bool Delete(int codVenda);
    }
}
