namespace Teht1_ovi
{
    internal class Program
    {
        enum DoorState //create enumeration for the state of the door
        {
            Opened = 0,
            Closed = 1,
            Locked = 2,
        }
        
        enum Command  //create enumeration
        {
            Open = 0,
            Close = 1,
            Lock = 2,
            OpenLock = 3,
        }

        static void Main(string[] args)
        {
            DoorState state = DoorState.Opened;

            while (true)
            {

            
                string[] commands = Enum.GetNames<Command>();

                Console.WriteLine("Choose command.");

                for(int i = 0; i < commands.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {commands[i]}");
                }

                string response = Console.ReadLine();
                Command chosen;

                for (int i = 0; i < commands.Length; i++)
                {
                    if (commands[i].ToLower() == response.ToLower())
                    {
                        chosen = (Command)i;
                    }
                }



                if (Enum.TryParse<Command>(response, out chosen))
                {
                    if (chosen == Command.Open)
                    {

                        state = DoorState.Opened;
                    }

                    if (chosen == Command.Lock)
                    {
                        state = DoorState.Locked;
                    }

                    if (chosen == Command.Close)
                    {
                        state = DoorState.Closed;
                    }

                    if (chosen == Command.OpenLock)
                    {
                        state = DoorState.Closed;
                    }

                    Console.WriteLine($"You chose {chosen}. The door is now {state}");

                }

                else
                {
                    Console.WriteLine("Command not valid.");
                }
            }
        }
    }
}

//vedit vähä liia kovaa vauhtia nii tipuin kärryiltä