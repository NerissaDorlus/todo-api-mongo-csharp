using Models;
using MongoDB.Driver;
using Settings;

namespace Services;


public interface ITodoItemService
{
    Task<IEnumerable<TodoItem>> GetAllTodoItems();
    Task<TodoItemService> GetTodoItemById( string id);

    Task<TodoItemService> UpdateTodoItem(string id, TodoItemService todoItem);

    Task<TodoItemService> CreateTodoItem(TodoItem todoItem);


}
public class TodoItemService : ITodoItemService
{
    private readonly   IMongoCollection<TodoItem> todoItemCollection;
    public TodoItemService(InsertOneOptions<TodoDbSettings> todoSettings)
    {
        
    }
    public Task<TodoItemService> CreateTodoItem(TodoItem todoItem)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TodoItem>> GetAllTodoItems()
    {
        throw new NotImplementedException();
    }

    public Task<TodoItemService> GetTodoItemById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<TodoItemService> UpdateTodoItem(string id, TodoItemService todoItem)
    {
        throw new NotImplementedException();
    }
}
