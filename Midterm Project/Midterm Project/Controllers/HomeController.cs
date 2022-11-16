using Microsoft.AspNetCore.Mvc;
using Midterm_Project.Models;
using Midterm_Project.Services;
using System.Diagnostics;

namespace Midterm_Project.Controllers
{
    /// <summary>
    /// public HomeController class to handle all of the actions required in the Index razor view page
    /// </summary>
    public class HomeController : Controller
    {

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        // declaring a readonly interface to collect the name input and call the GetName method
        private readonly IGenderApiService _getNameService;
        // a public HomeController method that takes the interface labelled getNameService as an arguement
        public HomeController(IGenderApiService getNameService)
        {
            //sets the readonly interface to the value of the getNameService
            _getNameService = getNameService;
        }
        /// <summary>
        //set up an async action task to run when form is submitted on index to make an addition to the index using the arguement name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>view with input</returns>
        public async Task<IActionResult> Index(string name)
        {
            // setting a GetInputModel object as a new GetInputModel object
            GetInputModel input = new GetInputModel();
            // set input to an await interface calling the GetName method for the name entered into the input box on the index page
            input = await _getNameService.GetName(name);
            // return the view of index with the addition of the input
            return View(input);
        } // end of action task Index method

    }
}