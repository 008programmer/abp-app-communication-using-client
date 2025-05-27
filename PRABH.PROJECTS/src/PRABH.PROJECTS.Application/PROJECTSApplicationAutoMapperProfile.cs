using AutoMapper;
using PRABH.PROJECTS.Books;

namespace PRABH.PROJECTS;

public class PROJECTSApplicationAutoMapperProfile : Profile
{
    public PROJECTSApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<Project, ProjectDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
