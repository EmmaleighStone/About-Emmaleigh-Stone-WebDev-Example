using Midterm_Project.Models;
namespace Midterm_Project.Services
{
    /// <summary>
    /// interface to create a task with GetInputModel that calls the GetName method using name as an parameter
    /// </summary>
    public interface IGenderApiService
    {
        // task using GetInputModel as a model with the ProcessName method with the name parameter
        Task<GetInputModel> GetName(string name);
    } // end of interface
}
