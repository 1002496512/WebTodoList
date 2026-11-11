using System.ComponentModel.DataAnnotations;

namespace WebTodoList.Models
{
    public class City
    {
        int cityId;
        string cityName;

        public City(int cityid, string cityName)
        {
            this.cityId = cityid;
            this.cityName = cityName;
        }
        public City( string cityName)
        {
            this.cityId = 0;
            this.cityName = cityName;
        }

        public int CityId
        {
            get { return this.cityId; }
            set { this.cityId = value; }
        }


        [Required(ErrorMessage = "The city name cannot be empty.")]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "A city name must begin with a capital letter in English.")]
        [StringLength(15,MinimumLength =2,ErrorMessage = "City name: minimum 2 letters, maximum 15")]
        public string Cityname
        {
            get { return this.cityName; }
            set { this.cityName = value; }
        }

      
    }
}
