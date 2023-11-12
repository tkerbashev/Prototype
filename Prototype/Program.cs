using Prototype;

Console.WriteLine( "Prototype Creational Design Pattern example" );
Console.WriteLine("(This is the most basic implementation using a shallow copy)");
Console.WriteLine();

var characters = new List<Person>();

Person agentSmith = new AgentSmith();
characters.Add( agentSmith );

Person agent2 = agentSmith.Clone();
characters.Add( agent2 );

Person agent3 = agentSmith.Clone();
characters.Add( agent3 );

Person john = new RegularPerson("John");
characters.Add( john );

Person mary = new RegularPerson( "Mary");
characters.Add( mary );

foreach ( Person person in characters )
{
    person.PresentYourself();
}
