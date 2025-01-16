namespace Teht1_ovi
{
    internal class Program
    {
        enum DoorState
        {
            Opened = 0,
            Closed = 1,
            Locked = 2,
        }
        
        enum Command
        {
            Open = 0,
            Close = 1,
            Lock = 2,
            OpenLock = 3,
        }

        static void Main(string[] args)
        {
            DoorState state = DoorState.Opened;
            Console.WriteLine("There is an open door in front of you...");
            while (true)
            {

            
                string[] commands = Enum.GetNames<Command>();

                Console.WriteLine("What do you want to do to the door?");

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

                bool sameState;

                if (Enum.TryParse<Command>(response, out chosen))
                {
                    if ((chosen == Command.Open) && (state != DoorState.Opened)) //if helvetti go brrrr
                    {
                        sameState = false;
                        state = DoorState.Opened;
                    }

                    if ((chosen == Command.Lock) && (state != DoorState.Locked))
                    {
                        sameState = false;
                        state = DoorState.Locked;
                    }

                    if ((chosen == Command.Close) && (state != DoorState.Closed))
                    {
                        sameState = false;
                        state = DoorState.Closed;
                    }

                    if ((chosen == Command.OpenLock) && (state == DoorState.Locked))
                    {

                        state = DoorState.Closed;
                    }

                    
                    /*else
                    {
                        Console.WriteLine("The door is already in that state");
                        sameState = true;
                    }
                    */
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

//vedit vähä liia kovaa vauhtia nii tipuin yhdessä vaiheessa kärryiltä ja sitten olin hukassa, koodi ei toimi niinkuin pitäisi kun en tiedä miten korjata kun meni paljon infoa ohi.
//halusin tehä noi tarkistukset ettei esim koiteta avata ovea joka on jo auki, mutta se meni aika hemon perseelleen
