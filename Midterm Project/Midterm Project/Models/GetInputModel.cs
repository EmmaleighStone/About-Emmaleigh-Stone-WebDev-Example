namespace Midterm_Project.Models
{/// <summary>
 ///GetInputModel model to get json data and set it as Count, Gender, Name, and Probability objects
 /// </summary>
    public class GetInputModel
    {
        // get and set public int Count object
        public int Count { get; set; }
        // get and set public string Gender object
        public string Gender { get; set; }
        // get and set public string Name object
        public string Name { get; set; }
        // get and set public float Probability object
        public float Probability { get; set; }
    } // end of GetInputModel
}
