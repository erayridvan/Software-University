using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }
        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldersMember()
            => people.OrderByDescending(a => a.Age).FirstOrDefault();
    }
}
