using System;

public class Simulate7SidedDie
{
    public int rand2()
    {
        int x = rand5();
        if (x == 4||x==5)
            return rand2(); // restart
        else return x % 2;
    }
    public int rand7()
    {
        int x = rand2() * 4 + rand2() * 2 + rand2();
        if (x == 7) return rand7(); // restart
        else return x;

    }

    public int rand5()
    {

        Random rand = new Random();
        return rand.Next(1, 6);
    }

    public void Test()
    {
        Console.WriteLine(rand7());
        
    }


}