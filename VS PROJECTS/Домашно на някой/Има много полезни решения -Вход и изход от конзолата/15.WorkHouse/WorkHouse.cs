//
//15.Little Joro likes to build huts. After he built all the huts in his whole village, he decided to go to the big 
//city and start building houses. But his knowledge of how to do this is limited. Help Joro to design the façade of 
//a beautiful house by printing it to the console. The house must have a roof and one floor. The roof must contains 
//only the symbols ‘*’ and ‘-’ and the floor must contains the symbols ‘*’ and ‘|’ 
//


using System;
 class WorkHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
 
        for (int i = 1; i <= n; i+=2)
        {
            string dashes = new string('-', (n - i) / 2);
            string asteriks = new string('*', i);
 
            Console.WriteLine("{0}{1}{0}", dashes, asteriks);
        }
 
        for (int i = 1; i <= n; i++)
        {
            string asterisks = new string('*', n - 2);
 
            Console.WriteLine("|{0}|", asterisks);
        }
    }
}


//    class WorkHouse
// {
//static void Main()
//{
//int n = int.Parse(Console.ReadLine());
//int roofHeight = 0;
//for (int i = 0; i < n; i+=2)
//{
//roofHeight++;
//}
////Console.WriteLine(roohHeight);
//int width = n;
//int floorHeight = n;
//char dash = '-';
//char asterisk = '*';
//char pipe = '|';
////i=roofHeight to 0
////dash(i-1) star(width-2x(i-1)) dash (i-1)
////for i=0 to floorheight
////pipe(1) star (width-2) pipe(1)
//for (int i = roofHeight; i > 0; i--)
//{
//Console.Write(new string(dash,(i-1)));
//Console.Write(new string(asterisk,(width-2*(i-1))));
//Console.WriteLine(new string(dash, (i - 1)));
//}
//for (int i = 0; i < floorHeight; i++)
//{
//Console.Write(new string(pipe,1));
//Console.Write(new string(asterisk,width-2));
//Console.WriteLine(new string (pipe, 1));
//}
//}
//}
