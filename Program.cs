using System;
class Program
{
    static void Main()
    {
        string str32 = "????????????????????????????????";
        char[] chr32 = str32.ToCharArray();
        //foreach(char c in chr32)
        //{
        //    Console.WriteLine(c);
        //}
        
        Console.WriteLine("OUT WHILE");
        int n = int.Parse(Console.ReadLine()); ;
        while (n != 0)
        {
            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine("entered for x = " + x);
                string instr = Console.ReadLine();
                string[] split = instr.Split(new char[] { ' ' }, StringSplitOptions.None);
                foreach (string i in split)
                {
                    Console.WriteLine("split content " + i);
                }

                switch (split[0])
                {
                    case "CLEAR":
                        int i = int.Parse(split[1]);
                        chr32[i] = '0';
                        //foreach (char c in chr32)
                        //{
                        //    Console.WriteLine(c);
                        //}
                        break;
                    case "SET":
                        i = int.Parse(split[1]);
                        chr32[i] = '1';
                        break;
                    case "OR":
                        i = int.Parse(split[1]);
                        int j = int.Parse(split[2]);
                        if ((chr32[i] != '?') && (chr32[j] !='?'))
                        {
                            if (!((chr32[i].Equals('0')) && (chr32[j].Equals('0'))))
                            {
                                chr32[i] = '1';
                            }
                            else
                            {
                                chr32[i] = '0';
                            }
                        }
                        break;
                    case "AND":
                        i = int.Parse(split[1]);
                        j = int.Parse(split[2]);
                        if ((chr32[i] != '?') && (chr32[j] != '?'))
                        {
                            if (((chr32[i].Equals('1')) && (chr32[j].Equals('1'))))
                            {
                                chr32[i] = '1';
                            }
                            else
                            {
                                chr32[i] = '0';
                            }

                        }
                        break;
                    default:
                            n = 0;
                        break;
                }
            }
            foreach (char c in chr32)
            {
                Console.Write(c);
            }
        }
    }
}

