static void Begin20(int x1, int y1, int x2, int y2)
{
    double step1 = x2 - x1;
    double step2 = y2 - y1;

    double step3 = Math.Pow(step1, 2);
    double step4 = Math.Pow(step2, 2);

    double result = Math.Sqrt(step3 + step4);

    double result_ = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    Console.WriteLine("masofa: " + result);
}

Begin20(10, 20, 30, 40);
