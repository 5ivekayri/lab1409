namespace WebApplication1
{
    public class PersonalComputer
    {
        public string Processor;
        public int Count_Of_Ram;
        public int Volume_Of_Disk;
        public string Operating_System;
        public string Graphic_Card;

        public PersonalComputer(string Processor, int Count_Of_Ram, int Volume_Of_Disk, string Operating_System, string Graphic_Card)
        {
            this.Processor = Processor;
            this.Count_Of_Ram = Count_Of_Ram;
            this.Volume_Of_Disk = Volume_Of_Disk;
            this.Operating_System = Operating_System;
            this.Graphic_Card = Graphic_Card;
        }

        public void Turn_OFF_PC()
        {

        }

        public void Turn_ON_PC()
        {

        }

        public void Reboot_PC()
        {

        }

    }

    public class Office : PersonalComputer
    {
        public Office(string Processor, int Count_Of_Ram, int Volume_Of_Disk, string Operating_System, string Graphic_Card) : base(Processor, Count_Of_Ram, Volume_Of_Disk, Operating_System, Graphic_Card)
        {
        }
    }

    public class Server : PersonalComputer
    {
        public Server(string Processor, int Count_Of_Ram, int Volume_Of_Disk, string Operating_System, string Graphic_Card)
          : base(Processor, Count_Of_Ram, Volume_Of_Disk, Operating_System, Graphic_Card)
        {
        }
    }

    public class Laptop : PersonalComputer
    {
        public Laptop(string Processor, int Count_Of_Ram, int Volume_Of_Disk, string Operating_System, string Graphic_Card)
          : base(Processor, Count_Of_Ram, Volume_Of_Disk, Operating_System, Graphic_Card)
        {
        }
    }

    public class GamingPC : PersonalComputer
    {
        public GamingPC(string Processor, int Count_Of_Ram, int Volume_Of_Disk, string Operating_System, string Graphic_Card)
          : base(Processor, Count_Of_Ram, Volume_Of_Disk, Operating_System, Graphic_Card)
        {
        }
    }

}