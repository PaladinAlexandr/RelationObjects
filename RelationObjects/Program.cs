JetEngine jetEngine = new JetEngine();
Rocket rocket = new Rocket(jetEngine);

Trolleybus trolleybus = new Trolleybus();

class User
{
    public int Id;
    public string Name;

    public User()
    {

    }
}
class Manager : User
{
    public string Company;
    public Manager()
    {

    }
}

class Car : IMovable
{
    public float Speed { get; set; }

    public void Move()
    {

    }
}

interface IMovable
{
    public float Speed { get; set; }

    public void Move();
}

public class Trolleybus
{
    private ElectricEngine Engine;
    public Trolleybus()
    {
        Engine = new ElectricEngine();
    }
}
public class ElectricEngine
{

}

public class Rocket
{
    private JetEngine Engine;
    public Rocket(JetEngine engine)
    {
        Engine = engine;
    }
}
public class JetEngine
{

}