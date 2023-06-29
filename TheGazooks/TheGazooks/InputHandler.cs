namespace TheGazooks
{
    public class InputHandler
    {
        public InputHandler()
        {
        }

        public char GetPlayerMovementInput()
        {
            Console.WriteLine("Which direction would you like to go? Type W for north, A for west, E for east and D for south.");
            return Console.ReadKey().KeyChar;
        }
    }
}