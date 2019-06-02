using Microsoft.AspNetCore.Mvc;
using TestTask.BusinessLogic.Interfaces;
using TestTask.BusinessLogic.Models;

namespace TestTaskInspirito.Controllers
{
    [Route("api/Books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _bookService.GetBooks();
            return GetActionResult(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _bookService.GetBookById(id);
            return GetActionResult(result);
        }

        [HttpPost]
        public IActionResult Add(AddBookModel creationModel)
        {
            var result = _bookService.AddBook(creationModel);
            return GetActionResult(result);
        }

        [HttpPut]
        public IActionResult Update(BookModel model)
        {
            var result = _bookService.UpdateBook(model);
            return GetActionResult(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _bookService.DeleteBook(id);
            return GetActionResult(result);
        }

        #region private members


        private IActionResult GetActionResult<T>(RequestResult<T> result)
        {
            if (result.Success)
                return Ok(result.Result);
            else
                return BadRequest(result.Message);
        }

        private IActionResult GetActionResult(RequestResult result)
        {
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.Message);
        }
        #endregion
    }
}