using PSIUWeb.Models;

namespace PSIUWeb.Data.Interface
{
    public interface IContentMidiaRepository
    {
        public ContentMidia? GetContentMidiaById(int id);

        public IQueryable<ContentMidia>? GetContentMidias();

        public ContentMidia? Update(ContentMidia cm);

        public ContentMidia? Delete(int id);

        public ContentMidia? Create(ContentMidia cm);
    }
}
