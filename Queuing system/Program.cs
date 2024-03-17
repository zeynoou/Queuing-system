namespace Queuing_system
{
    class Program
    {
        static Dictionary<int, string> Reservation = new Dictionary<int, string>(); 
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Reserve a table");
                Console.WriteLine("2. View Reservation");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ReserveTable();
                        break;
                    case 2:
                        ViewReservation();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Invalide choice, Please try again");
                        break;  
                }
            }           
        }

        public static void ReserveTable()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            int reservationNumber = Reservation.Count + 1;
            Reservation.Add(reservationNumber, name);

            Console.WriteLine($"Table reserved successfully. Your reservation number is : {reservationNumber}");
        }
        public static void ViewReservation()
        {
            if (Reservation.Count == 0)
                Console.WriteLine("No reservation found.");
            else
                foreach (var reservation in Reservation)
                {
                    Console.WriteLine($"Resevation Number: {reservation.Key}, Name: {reservation.Value}");
                }
        }
    }
}