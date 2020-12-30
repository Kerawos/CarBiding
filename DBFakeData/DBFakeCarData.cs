using CarBiding.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBiding.DBFakeData
{
    public class DBFakeCarData : ICarData
    {
        List<Car> cars;

        public DBFakeCarData()
        {
            cars = GenerateFakeCars();
        }

        private List<Car> GenerateFakeCars()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car(1, "Subaru Impreza WRX", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(+25),
                "https://www.autocentrum.pl/galerie/prasowe/subaru-impreza-wrx-special-edition/",
                "Kontrowersyjne pod względem stylistycznym, ale doskonałe, jeśli chodzi o technikę Subaru Impreza " +
                "WRX doczekało się jesienią 2012 roku nowej edycji specjalnej. Ubrano ją w pomarańczowe nadwozie " +
                "z czarnymi lusterkami, czarnymi naklejkami i unikalnymi emblematami, całość osadzono na czarnych felgach, " +
                "a w środku skryto specjalne, czarno-pomarańczowe wykończenie.", 
                new List<Image>
                {
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565fcbdaf80f0a963506fe7d/subaru-impreza-wrx-special-edition.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565fcbd5f80f0a963506fe29/subaru-impreza-wrx-special-edition-02.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565fcbe0f80f0a963506fed1/subaru-impreza-wrx-special-edition-14.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565fcbecf80f0a963506ff85/subaru-impreza-wrx-special-edition-29.jpg")
                }));
            cars.Add(new Car(2, "Audi S6 Lambo!", DateTime.Now.AddDays(-20), DateTime.Now.AddDays(+1), 
                "", "", new List<Image>
                {
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565faebff80f0a9635052e3b/audi-s6-avant-2008-03.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565faec5f80f0a9635052e9b/audi-s6-avant-2008-02.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565faec6f80f0a9635052eb3/audi-s6-avant-2008-13.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565faebef80f0a9635052e2f/audi-s6-avant-2008-20.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/gallery-photo/565faec9f80f0a9635052ed7/audi-s6-avant-2008-19.jpg")
                }
                ));

            cars.Add(new Car(3, "Renault Clio RS 2015", DateTime.Now, DateTime.Now.AddDays(+10),
                "https://www.autocentrum.pl/newsy/renault-clio-rs-po-zmianach/",
                "Odświeżone Renault Clio RS będzie oferowane w dwóch wersjach silnikowych oraz z trzema typami " +
                "zawieszenia. Podstawową jednostką napędową będzie 200-konny silnik w wariancie RS, zaś w wersji " +
                "Trophy ten sam silnik będzie posiadał liczniejsze o 20 sztuk stado koni mechanicznych. " +
                "W obu przypadkach silnik współpracuje z 6-biegową skrzynią dwusprzęgłową EDC, która posiada " +
                "tryb zmiany przełożeń za pomocą łopatek umieszczonych przy kierownicy.",
                new List<Image> 
                {
                    new Image("https://www.autocentrum.pl/ac-file/news/58931350592c7d8b478c11c9/renault-clio-rs-po-zmianach.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/news/5893134f592c7d8b478c11b5/renault-clio-rs-po-zmianach-10.jpg"),
                    new Image("https://www.autocentrum.pl/ac-file/news/5893134d592c7d8b478c11a1/renault-clio-rs-po-zmianach-08.jpg")
                }
                ));
            return cars;
        }

        public IEnumerable<Car> GetAll()
        {
            return from c in cars
                   orderby c.TimeAuctionEnd
                   ascending
                   select c;
        }

        public IEnumerable<Car> GetAllByName(string name = null)
        {
            return from c in cars
                   where string.IsNullOrEmpty(name) || c.Title.StartsWith(name)
                   orderby c.Title
                   ascending
                   select c;
        }

        public Car GetByID(int id)
        {
            return cars.SingleOrDefault(c => c.ID == id);
        }
    }
}
