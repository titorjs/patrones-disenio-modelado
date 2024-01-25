namespace PatronesEjemplosPágina;

class Program
{
    static void Main(string[] args)
    {
        //***** Factory Method *****
        //new Client().Main();

        //***** Singleton *****
        // The client code.
        //Singleton s1 = Singleton.GetInstance();
        //Singleton s2 = Singleton.GetInstance();

        //if (s1 == s2)
        //{
        //    Console.WriteLine("Singleton works, both variables contain the same instance.");
        //}
        //else
        //{
        //    Console.WriteLine("Singleton failed, variables contain different instances.");
        //}

        //***** Decorator *****
        ClientD client = new ClientD();

        var simple = new ConcreteComponent();
        Console.WriteLine("Client: I get a simple component:");
        client.ClientCode(simple);
        Console.WriteLine();

        // ...as well as decorated ones.
        //
        // Note how decorators can wrap not only simple components but the
        // other decorators as well.
        ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
        ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
        Console.WriteLine("Client: Now I've got a decorated component:");
        client.ClientCode(decorator2);


        // ***** Chain of Responsability *****
        // The other part of the client code constructs the actual chain.
        /*var monkey = new MonkeyHandler();
        var squirrel = new SquirrelHandler();
        var dog = new DogHandler();

        monkey.SetNext(squirrel).SetNext(dog);

        // The client should be able to send a request to any handler, not
        // just the first one in the chain.
        Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
        ClientCR.ClientCode(monkey);
        Console.WriteLine();

        Console.WriteLine("Subchain: Squirrel > Dog\n");
        ClientCR.ClientCode(squirrel);*/

        //***** Memento *****
        // Client code.
        /*Originator originator = new Originator("Super-duper-super-puper-super.");
        Caretaker caretaker = new Caretaker(originator);

        caretaker.Backup();
        originator.DoSomething();

        caretaker.Backup();
        originator.DoSomething();

        caretaker.Backup();
        originator.DoSomething();

        Console.WriteLine();
        caretaker.ShowHistory();

        Console.WriteLine("\nClient: Now, let's rollback!\n");
        caretaker.Undo();

        Console.WriteLine("\n\nClient: Once more!\n");
        caretaker.Undo();

        Console.WriteLine();*/

        //***** Template Method *****
        //Console.WriteLine("Same client code can work with different subclasses:");

        //ClientTM.ClientCode(new ConcreteClass1());

        //Console.Write("\n");

        //Console.WriteLine("Same client code can work with different subclasses:");
        //ClientTM.ClientCode(new ConcreteClass2());
    }
}