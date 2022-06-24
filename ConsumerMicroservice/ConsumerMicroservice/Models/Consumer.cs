using System.ComponentModel.DataAnnotations;
namespace ConsumerMicroservice.Models
{
    public class Consumer
    {
        /*protected static int _lastId = 0;

        public int ID = ++Consumer._lastId;*/

        public int ID { get; set; } = 0;
        public string Name { get; set; } = "";

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        public string Email { get; set; } = "";

        public string PAN { get; set; } = "";

        public Business Business { get; set; }
    }
}
