using Microsoft.AspNetCore.Mvc;

namespace MVCTestApplication.Models
{
    public class HomeModel
    {
        public int CurrentCount { get; set; }

        public void IncrementCount()
        {
            CurrentCount++;
        }
    }
}
