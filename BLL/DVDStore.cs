using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public sealed class DVDStore : ItemSearch<DVD>
    {
        public List<DVD> DVDs { get; set; }

        private static readonly DVDStore instance = new DVDStore();

        static DVDStore()
        {

        }

        private DVDStore()
        {
            DVDs = new List<DVD>();
        }

        public static DVDStore Instance
        {
            get
            {
                return instance;
            }
        }

        public List<DVD> SearchByBarcode(int barcode)
        {
            throw new NotImplementedException();
        }

        public List<DVD> SearchByTitle(string title)
        {
            throw new NotImplementedException();
        }

        List<DVD> SearchByPerson(Person person)
        {
            return DVDs.FindAll(i => i.director == person);
        }

        List<DVD> SearchDVDByDirector(string name)
        {
            return DVDs.FindAll(i => i.director.name == name);
        }

        public void AddNewDVD(String title, int barcode, Person director)
        {
            if (!DVDs.Exists(i => i.barcode == barcode))
            {
                DVD dvd = new DVD(title, barcode, director);
                DVDs.Add(dvd);
            }
        }

        public void RemoveDVD(DVD dvd)
        {
            if (DVDs.Contains(dvd))
            {
                _ = DVDs.Remove(dvd);
            }
        }
    }
}
