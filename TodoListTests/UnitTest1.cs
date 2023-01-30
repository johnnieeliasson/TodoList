using Bunit;
using System.Runtime.InteropServices;
using TodoList.Pages;

namespace TodoListTests
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void TodoList_CheckIfAddedItemMatchTodoList()
        {

            //render Todolist page component
            //cut = component unit test
            var cut = RenderComponent<Todolist>();

            
            //check if the list contains "Buy Milk".
            Assert.Equal("Buy Milk", cut.Find($"span").TextContent);

             

        }
    }
}