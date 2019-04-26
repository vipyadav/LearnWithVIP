using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace LINQ
{
    public class ListFiltering
    {
        // Get items in one List<>, that are not in another List<>

        public static void ItemsNotInList1()
        {
            var peopleList1 = new List<Person>
            {
                new Person() {Id = 1},
                new Person() {Id = 2},
                new Person() {Id = 3}
            };

            var peopleList2 = new List<Person>
            {
                new Person() {Id = 1},
                new Person() {Id = 2},
                new Person() {Id = 3},
                new Person() {Id = 4},
                new Person() {Id = 5}
            };

            var personsNotInList1 = peopleList2.Where(p => peopleList1.All(p2 => p2.Id != p.Id));

            //Basically it says get all from peopleList2 where all ids in peopleList1 are different from id in peoplesList2.

            /*               OR                     */

            // var personsNotInList1 = peopleList2.Where(p => !peopleList1.Any(p2 => p2.Id == p.Id));


            /*               OR                   Faster  */

            var excludedIDs = new HashSet<int>(peopleList1.Select(p => p.Id));
            var result = peopleList2.Where(p => !excludedIDs.Contains(p.Id));
        }

        public static void StringItemsNotInList1()
        {
            var peopleList1 = new List<Person>
            {
                new Person() {Id = 1, Name = "Vip1"},
                new Person() {Id = 2, Name = "Vip2"},
                new Person() {Id = 3, Name = "Vip3"}
            };

            var peopleList2 = new List<Person>
            {
                new Person() {Id = 1, Name = "Vip1"},
                new Person() {Id = 2, Name = "Vip2"},
                new Person() {Id = 3, Name = "Vip3"},
                new Person() {Id = 4, Name = "Vip4"},
                new Person() {Id = 5, Name = "Vipin5"}
            };

            var personsNotInList1 = peopleList2.Where(p => peopleList1.All(p2 => p2.Name.ToLower() != p.Name.ToLower()));

            var personsNotInList2 = peopleList1.Where(x => peopleList2.Any(y => string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase) == 0));

            /*               OR                     */

            personsNotInList2 = from a in peopleList1
                                join b in peopleList2 on a.Name.ToLower() equals b.Name.ToLower()
                                select a;

            var result = peopleList1.Where(x => peopleList2.Any(y => y.Name.Contains(x.Name)));

            result = peopleList1.Where(x => peopleList2.Any(y => y.Name.Contains("in")));
        }
    }
}
