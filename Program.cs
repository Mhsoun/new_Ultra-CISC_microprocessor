using System;
class Program
{
    static void Main()
    {
        int n = 1;
        while (n != 0)
        {
            n = int.Parse(Console.ReadLine());
            string str32 = "????????????????????????????????";
            char[] chr32 = str32.ToCharArray();
            for (int x = 1; x <= n; x++)
            {
                string instr = Console.ReadLine();
                string[] split = instr.Split(new char[] { ' ' }, StringSplitOptions.None);
                switch (split[0])
                {
                    case "CLEAR":
                        int clearI = 31- int.Parse(split[1]);
                        chr32[clearI] = '0';
                        break;

                    case "SET":
                        int setI = 31- int.Parse(split[1]);
                        chr32[setI] = '1';
                        break;

                    case "OR":
                        int orI = 31- int.Parse(split[1]);
                        int orJ = 31- int.Parse(split[2]);
                        if ((chr32[orI] == '?') || (chr32[orJ] == '?'))
                        {
                            if (chr32[orI].Equals('1') || chr32[orJ].Equals('1'))
                            {
                                chr32[orI] = '1';
                            }  else if (chr32[orI].Equals('0') || chr32[orJ].Equals('0'))
                            {
                                chr32[orI] = '?';
                            } else
                            {
                                chr32[orI] = '?';
                            }
                        }
                        else if (chr32[orI].Equals('1') || chr32[orJ].Equals('1'))
                        {
                            chr32[orI] = '1';
                        } else
                        {
                            chr32[orI] = '0';
                        } 
                        break;

                    case "AND":
                        int andI = 31- int.Parse(split[1]);
                        int andJ = 31- int.Parse(split[2]);
                        if ((chr32[andI] == '1') && (chr32[andJ] == '1'))
                        {
                            chr32[andI] = '1';
                        }
                        else if ((chr32[andI] == '0') || (chr32[andJ] == '0'))
                        {
                            chr32[andI] = '0';
                        } else if ((chr32[andI] == '?') && (chr32[andJ] == '?'))
                        {
                            chr32[andI] = '?';
                        } else
                        {
                            chr32[andI] = '?';
                        }
                        break;

                    case "0":
                        n = 0;
                        break;
                }
                if (x == n)
                {
                    string result = new string(chr32);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
