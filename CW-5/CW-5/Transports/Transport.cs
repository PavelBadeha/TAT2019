namespace CW_5
{
    abstract class Transport
    {
        public Chassis Chassis { get; }
        public Engine Engine { get; }
        public Transmission Transmission { get; }
        public Transport(Chassis chassis,Engine engine,Transmission transmission)
        {
            Chassis = chassis;
            Engine = engine;
            Transmission = transmission;
        }
        public override string ToString()
        {
            return Chassis.ToString() + "\n"+ Engine.ToString() +"\n" + Transmission.ToString() ;
        }
    }
}
