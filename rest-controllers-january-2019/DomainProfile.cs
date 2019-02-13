using System.Linq;
using AutoMapper;
using rest_controllers_january_2019.Data.Entities;
using rest_controllers_january_2019.DTO;

namespace rest_controllers_january_2019
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<TodoList, TodoListDto>();
            CreateMap<Todo, TodoDto>();
            CreateMap<TodoList, TodoListCompletedDto>()
                .ForMember(s => s.Todos, c => c.MapFrom(m => m.Todos.Select(t => t.Text)));
        }
    }
}