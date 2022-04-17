using System;
namespace LibraryManager.BLL
{
    public class DVD : Item
    {
        public Person director { get; set; }

        public DVD(String title, int barcode, Person director) : base(title, barcode)
        {
            this.director = director;
        }
    }
}
