using System;

namespace MyClient.SDK
{
    class LogHandler
    {
        //Log To Console Format: LogHandler.Log(LogHandler.Colors.Color,"message",timeStamp true or false,logToRPC true or false);
        public static void Log(LogHandler.Colors color, string message, bool timeStamp = false, bool logToRpc = false)
        {
            if (timeStamp)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(DateTime.Now.ToString("HH:mm.fff"));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] ");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("My Client");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ~> ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = LogHandler.getColor(color);
            Console.Write(message + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static ConsoleColor getColor(LogHandler.Colors color)
        {
            if (color == LogHandler.Colors.Default)
            {
                return ConsoleColor.White;
            }
            switch (color)
            {
                case LogHandler.Colors.Red:
                    return ConsoleColor.Red;
                case LogHandler.Colors.Blue:
                    return ConsoleColor.Blue;
                case LogHandler.Colors.Black:
                    return ConsoleColor.Black;
                case LogHandler.Colors.Green:
                    return ConsoleColor.Green;
                case LogHandler.Colors.Yellow:
                    return ConsoleColor.Yellow;
                case LogHandler.Colors.Cyan:
                    return ConsoleColor.Cyan;
                case LogHandler.Colors.DarkRed:
                    return ConsoleColor.DarkRed;
                case LogHandler.Colors.DarkGreen:
                    return ConsoleColor.DarkGreen;
                case LogHandler.Colors.DarkBlue:
                    return ConsoleColor.DarkBlue;
                case LogHandler.Colors.Grey:
                    return ConsoleColor.Gray;
            }
            return ConsoleColor.White;
        }
        public enum Colors
        {
            Red,
            Blue,
            Black,
            White,
            Green,
            Yellow,
            Cyan,
            DarkRed,
            DarkGreen,
            DarkBlue,
            Default,
            Grey
        }
    }
}
