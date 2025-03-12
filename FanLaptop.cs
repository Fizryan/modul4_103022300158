namespace modul4_103022300158
{
    class FanLaptop
    {
        private enum State { Balance, Quiet, Performance, Turbo }                                                   // State Fan
        private State currentState;

        public static void runFan()
        {
            State currentState = State.Quiet;                                                                       // Default Fan Quiet
            Console.WriteLine($"Fan Mode {currentState}");

            while (true)
            {
                Console.Write("Enter Command: ");                                                                   
                string command = Console.ReadLine();                                                                // Meminta Perintah
                switch (currentState)
                {
                    case State.Balance:                                                                             // Kalau Fan dalam Mode Balance
                        if (command.ToLower() == "mode up")
                        {
                            currentState = State.Performance;
                            Console.WriteLine("Fan Balance berubah menjadi Performance");
                        }
                        else if (command.ToLower() == "mode down")
                        {
                            currentState = State.Quiet;
                            Console.WriteLine("Fan Balance berubah menjadi Quiet");
                        }
                        break;
                    case State.Quiet:                                                                                // Kalau Fan dalam Mode Quiet
                        if (command.ToLower() == "mode up")
                        {
                            currentState = State.Balance;
                            Console.WriteLine("Fan Quiet berubah menjadi Performance");
                        }
                        else if (command.ToLower() == "turbo shortcut")                                            
                        {
                            currentState = State.Turbo;
                            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                        }
                        break;
                    case State.Performance:                                                                          // Kalau Fan dalam mode Performance
                        if (command.ToLower() == "mode down")
                        {
                            currentState = State.Balance;
                            Console.WriteLine("Fan Performance berubah menjadi Balance");
                        }
                        else if (command.ToLower() == "mode up")
                        {
                            currentState = State.Turbo;
                            Console.WriteLine("Fan Performance berubah menjadi Turbo");
                        }
                        break;
                    case State.Turbo:                                                                                 // Kalau Fan dalam Mode Turbo
                        if (command.ToLower() == "mode down")
                        {
                            currentState = State.Performance;
                            Console.WriteLine("Fan Turbo berubah menjadi Performance");
                        }
                        else if (command.ToLower() == "turbo shortcut")
                        {
                            currentState = State.Quiet;
                            Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                        }
                        break;
                }
            }
        }
    }
}

