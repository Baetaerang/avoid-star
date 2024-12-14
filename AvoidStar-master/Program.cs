namespace KDH
{
    class Program
    {
        static void Main(string[] args)
        {
            // 다음은 콘솔 창에 Hello World를 뛰우는 코드입니다.
            // Console.WriteLine("Hello, World!");
            Study.MyProgram.Play();

            // 게임 시작
            // 타이틀 변경
            //Console.Title = "별 피하기";
            // 콘솔 크기를 변경
            //Console.SetWindowSize(30, 30);
            // 콘솔창의 가장 아래에 중앙에 O 그려줘
            // -> 콘솔의 X좌표 14, Y좌표 28에 그려줘
            //Console.SetCursorPosition(14, 28);
            //Console.Write("●");
            // 콘솔 커서를 안보이게 해줘 
            //Console.CursorVisible = false;

            //Console.ReadKey();
        }
    }
}

namespace Study
{
    class MyProgram
    {
        public static void Play()
        {
            // 게임 시작
            // 타이틀 변경
            Console.Title = "별 피하기";
            // 콘솔 크기를 변경
            Console.SetWindowSize(30, 30);
            // 콘솔창의 가장 아래에 중앙에 O 그려줘
            // -> 콘솔의 X좌표 14, Y좌표 28에 그려줘
            Console.SetCursorPosition(14, 28);
            Console.Write("●");
            // 콘솔 커서를 안보이게 해줘 
            Console.CursorVisible = false;

            int x = 14, y = 28;
         
            while(true)
            {
                Console.SetCursorPosition(x, y);
                // 플레이어의 위치를 그린다.
                Console.Write("●");

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ");
                    // 플레이어의 좌표를 변경한다.
                    if(key == ConsoleKey.UpArrow)
                    {
                        y--;
                        if (y < 0) y = 0;
                    }

                    // 아래 이동
                    if (key == ConsoleKey.DownArrow)
                    {
                        y++;
                        if (y > 28) y = 28;
                    }
                    // 왼쪽 이동

                    if(key == ConsoleKey.LeftArrow)
                    {
                        x--;
                        if (x < 0) x = 0;
                    }

                    if(key == ConsoleKey.RightArrow)
                    {
                        x++;
                        if (x > 28) x = 28;
                    }

                    // 오른쪽 이동
                }
            }

            Console.ReadKey();

        }
    }
}
