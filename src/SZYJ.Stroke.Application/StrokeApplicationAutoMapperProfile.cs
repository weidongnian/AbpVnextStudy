using AutoMapper;

namespace SZYJ.Stroke
{
    public class StrokeApplicationAutoMapperProfile : Profile
    {
        public StrokeApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();

            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
