
Console.Clear(); // очистила терминал
//Console.SetCursorPosition(10, 4);//отступ в терминале 10-слева, 4-сверху
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb; //для определенности положу первую точку

int count = 0; //определю некоторый счетчик count, который будет определять сколько раз нужно находить отрезок и делить его пополам

while(count < 10000) //оператор while 
{
    int what = new Random().Next(0, 3); //[0;3) при таком интервале выведится 0 1 или 2 //сгенерируем случайное число, назовем его what
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y); // выводим на экран с помощью SetCursorPosition
    Console.WriteLine("+");
    count++; // чтобы точка не ушла в бесконечность. так же можно написать count + = 1; или count++;
}






