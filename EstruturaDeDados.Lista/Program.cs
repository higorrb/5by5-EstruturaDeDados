
List<Contact> contacts = new();

var c = new Contact("felipe");
c.Phone = "123123";
c.Gender = 'M';
contacts.Add(c);

c = new("Higor");

contacts.Add(c);

foreach(Contact contact in contacts)
{
    Console.WriteLine(contact);
}