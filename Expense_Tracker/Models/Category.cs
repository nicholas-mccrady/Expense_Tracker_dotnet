using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// calling the component models and creating a namespace 
namespace Expense_Tracker.Models
{
 // creating a primary key as well as our category icons
    public class Category
    {
        // use short cut alt+enter to set up our key in this case the categoryId
        [Key]
        //initialize our getters and setters for the categories
        public int CategoryId { get; set; }

        // creating our sql server datatypes and calling the appropriate namespace with it
        // Names the titles of each category
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        //each category will have an emoji icon
        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; }

        //type of category weather its income or expense
        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; }

    }
}
