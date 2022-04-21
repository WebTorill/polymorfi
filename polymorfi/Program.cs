// See https://aka.ms/new-console-template for more information
using polymorfi;


Person person = new Person("Søren", "Stenvej 4");
Mechanic mekaniker = new Mechanic("Maja", "Nytoftvej 15", 2020, 120);
Foreman værkfører = new Foreman("Ivan", "Damtoftvej 2", 2020, 120, 2021, 25);
Inspector synsmand = new Inspector("Susanne", "Mariagervej 1", 2019, 130, 7);
List<Person> people = new List<Person>();
people.Add(person);
people.Add(mekaniker);
people.Add(værkfører);
people.Add(synsmand);

foreach(Person p in people)
{
    Console.WriteLine(p.ToString() + " - det giver en ugesløn på " + p.BeregnUgeLøn());
}