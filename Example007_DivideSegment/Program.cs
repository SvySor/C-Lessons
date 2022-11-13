// Enter data
Console.Clear();
int N = 10000;
int Count = 0;
int x0 = 60, y0 = 1;
int x1 = 1, y1 = 30;
int x2 = 120, y2 = 30;
Console.SetCursorPosition(x0, y0);
Console.WriteLine("X");
Console.SetCursorPosition(x1, y1);
Console.WriteLine("X");
Console.SetCursorPosition(x2, y2);
Console.WriteLine("X");

int x = x0, y = y0;
while (Count < N)
{
    int WhatPoint = new Random().Next(0,3);
    if(WhatPoint == 0)
    {
        x = (x + x0) / 2;
        y = (y + y0) / 2;
    }
    if(WhatPoint == 1)
    {
        x = (x + x1)/2;
        y = (y + y1)/2;
    }
    if(WhatPoint == 2)
    {   x = (x + x2)/2;
        y = (y + y2)/2;
    }
Console.SetCursorPosition(x, y);
Console.WriteLine("X");
Count++;
}   
Console.SetCursorPosition(x2, y2);