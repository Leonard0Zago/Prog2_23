using PSIUWeb.Data.Interface;
using PSIUWeb.Models;

namespace PSIUWeb.Data.EF
{
    public class EFContentMidiaRepository : IContentMidiaRepository
    {
        private AppDbContext context;
        public EFContentMidiaRepository(AppDbContext context)
        {
            this.context = context;
        }
        public ContentMidia? Create(ContentMidia cm)
        {
            try
            {
                context.ContentMidias?.Add(cm);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return cm;
        }

        public ContentMidia? Delete(int id)
        {
            ContentMidia? cm = GetContentMidiaById(id);
            if (cm == null)
                return null;

            context.ContentMidias?.Remove(cm);
            context.SaveChanges();

            return cm;
        }

        public ContentMidia? GetContentMidiaById(int id)
        {
            ContentMidia? cm =
                context
                    .ContentMidias?
                    .Where(cm => cm.Id == id)
                    .FirstOrDefault(); ;

            return cm;
        }

        public IQueryable<ContentMidia>? GetContentMidias()
        {
            return context.ContentMidias;
        }

        public ContentMidia? Update(ContentMidia cm)
        {
            try
            {
                context.ContentMidias?.Update(cm);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return cm;
        }
    }
}
