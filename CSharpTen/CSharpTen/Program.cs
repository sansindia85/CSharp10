// See https://aka.ms/new-console-template for more information

//var person = new Person
//{
//    FirstName = "Satya",
//    LastName = "Nadella"
//};


//Anonymous type
var person = new 
{
    FirstName = "Satya",
    LastName = "Nadella"
};
var otherPerson = person with { LastName = "Rao" };

WriteLine(person);
WriteLine(otherPerson);

var orginalPerson = otherPerson with { LastName = "Sharma" };

WriteLine(orginalPerson);

WriteLine($"Equals: {Equals(person, orginalPerson)}");
WriteLine($"= Operator: {person == orginalPerson}");

//Custom parameterless constructor for structs
Person p1 = default;
Person p2 = new();
WriteLine(p1);
WriteLine(p2);
