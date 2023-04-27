using System;

public class KeyListener
{
    public event EventHandler EnterKeyPressed;
    public event EventHandler SpaceKeyPressed;
    public event EventHandler EscapeKeyPressed;
    public event EventHandler F1KeyPressed;
    public event EventHandler LeftKeyPressed;
    public event EventHandler RightKeyPressed;
    public event EventHandler UpKeyPressed;
    public event EventHandler DownKeyPressed;
    public class Person
    {
        public void Zitr(object sender, EventArgs e)
        {
            Console.WriteLine("Space key pressed. Zitr method called.");
        }

        public void Se1ect(object sender, EventArgs e)
        {
            Console.WriteLine("Enter key pressed. Se1ect method called.");
        }

        public void Move(object sender, EventArgs e)
        {
            Console.WriteLine("Arrow key pressed. Move method called.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KeyListener listener = new KeyListener();
            Person person = new Person();

            listener.SpaceKeyPressed += person.Zitr;
            listener.EnterKeyPressed += person.Se1ect;
            listener.LeftKeyPressed += person.Move;
            listener.RightKeyPressed += person.Move;
            listener.UpKeyPressed += person.Move;
            listener.DownKeyPressed += person.Move;

            listener.Listen();
        }
    }
    public void Listen()
    {
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    EnterKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.Spacebar:
                    SpaceKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.Escape:
                    EscapeKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.F1:
                    F1KeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.LeftArrow:
                    LeftKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.RightArrow:
                    RightKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.UpArrow:
                    UpKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.DownArrow:
                    DownKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }
    }
}