//***********************************
// Student Name : Mohammad Ali Amirkhani
// Lesson Name : Advanced Programming (1)
// Practice Number : 7
//***********************************

using System;
using System.Linq;

//Students names array
string[] Names = new string[100];

//Lessons arrays
int[] AdvancedProgramming = new int[Names.Length];
int[] Quran = new int[Names.Length];
int[] Mathematic = new int[Names.Length];
int[] WorkShop = new int[Names.Length];
int[] English = new int[Names.Length];
int[] AdvancedProgramming2 = new int[Names.Length];
int[] OOP = new int[Names.Length];
int[] PE = new int[Names.Length];
int[] OS = new int[Names.Length];
int[] Algorithm = new int[Names.Length];
//averages array
double[] WrittenAverage = new double[Names.Length];
double[] PracticalAverage = new double[Names.Length];
double[] TheoricalAverage = new double[Names.Length];
double[] MainAverage = new double[Names.Length];
double[] GeneralAverage = new double[Names.Length];

Random Random = new Random();
int Min = 0;
int Max = 21;



void ScoreFill()
{
    for (int i = 0; i < Names.Length; i++)
    {
        AdvancedProgramming[i] = Random.Next(Min, Max);
        AdvancedProgramming2[i] = Random.Next(Min, Max);
        Quran[i] = Random.Next(Min, Max);
        Mathematic[i] = Random.Next(Min, Max);
        WorkShop[i] = Random.Next(Min, Max);
        English[i] = Random.Next(Min, Max);
        OOP[i] = Random.Next(Min, Max);
        PE[i] = Random.Next(Min, Max);
        OS[i] = Random.Next(Min, Max);
        Algorithm[i] = Random.Next(Min, Max);
    }
}

void NamesFill()
{
    Names[0] = "hossein"; Names[1] = "ali";
    Names[2] = "mohsen"; Names[3] = "bahram";
    Names[4] = "kazem"; Names[5] = "behrooz";
    Names[6] = "amir"; Names[7] = "sina";
    Names[8] = "hasan"; Names[9] = "mohammad";
    Names[10] = "eskandar"; Names[11] = "reza";
    Names[12] = "mahram"; Names[13] = "bahram";
    Names[14] = " shahram"; Names[15] = "shadmehr";
    Names[16] = " ebi"; Names[17] = "korosh";
    Names[18] = "ehsan"; Names[19] = "ahmad";
    Names[20] = "salar"; Names[21] = "sorena";
    Names[22] = "avesta"; Names[23] = "ramin";
    Names[24] = "alireza"; Names[25] = "mobin";
    Names[26] = "saeid"; Names[27] = "moein";
    Names[28] = "mehdi"; Names[29] = "sadegh";
    Names[30] = "jalal"; Names[31] = "bohlol";
    Names[32] = "masood"; Names[33] = "erfan";
    Names[34] = "majid"; Names[35] = "omid";
    Names[36] = "mehrdad"; Names[37] = "hesam";
    Names[38] = "iliya"; Names[39] = "ashkan";
    Names[40] = "bardiya"; Names[41] = "benjamin";
    Names[42] = "babak"; Names[43] = "behnam";
    Names[44] = "pooya"; Names[45] = "khosro";
    Names[46] = "daryoosh"; Names[47] = "sirvan";
    Names[48] = "sadra"; Names[49] = "sobhan";
    Names[50] = "shahab"; Names[51] = "zahra";
    Names[52] = "fatemeh"; Names[53] = "reyhaneh";
    Names[54] = "homa"; Names[55] = "sara";
    Names[56] = "mona"; Names[57] = "azita";
    Names[58] = "nazanin"; Names[59] = "niloofar";
    Names[60] = "nastaran"; Names[61] = "helen";
    Names[62] = "asal"; Names[63] = "ava";
    Names[64] = "ghazal"; Names[65] = "hana";
    Names[66] = "mersana"; Names[67] = "aseman";
    Names[68] = "darya"; Names[69] = "donya";
    Names[70] = "baran"; Names[71] = "ayda";
    Names[72] = "maedeh"; Names[73] = "negar";
    Names[74] = "negin"; Names[75] = "samira";
    Names[76] = "elnaz"; Names[77] = "elham";
    Names[78] = "narges"; Names[79] = "ameneh";
    Names[80] = "zeynab"; Names[81] = "nasrin";
    Names[82] = "mahnaz"; Names[83] = "bahar";
    Names[84] = "niki"; Names[85] = "sadaf";
    Names[86] = "nahid"; Names[87] = "akram";
    Names[88] = "james"; Names[89] = "ben";
    Names[90] = "kevin"; Names[91] = "marco";
    Names[92] = "selena"; Names[93] = "antony";
    Names[94] = "taylor"; Names[95] = "alan";
    Names[96] = "maria"; Names[97] = "roze";
    Names[98] = "harry"; Names[99] = "nicolas";
}

void Welcome()
{
    Console.WriteLine("*****************************************");
    string Menu = @"Welcome to student manager program:
1.Written Average
2.Practical Average
3.Theorical Average
4.Main Average
5.General Average
6.Top 10 by written average
7.Top 10 by practical average
8.Top 10 by theorical average
9.Top 10 by main average 
10.Top 10 by grade
11.Find prime numbers in lessons marks";
    Console.WriteLine(Menu);
    Console.WriteLine("*****************************************");

}

void SelectOption()
{
    do
    {
        Welcome();
        Console.Write("Please choose one of the options: ");
        NamesFill();
        ScoreFill();
        switch (Console.ReadLine())
        {
            case "1":
                AverageWritten();
                for (int i = 0; i < Names.Length; i++)
                {
                    Console.WriteLine($"{Names[i]} : {WrittenAverage[i]}");
                }
                break;
            case "2":
                AveragePractical();
                for (int i = 0; i < Names.Length; i++)
                {
                    Console.WriteLine($"{Names[i]} : {PracticalAverage[i]}");
                }
                break;
            case "3":
                AverageTheorical();
                for (int i = 0; i < Names.Length; i++)
                {
                    Console.WriteLine($"{Names[i]} : {TheoricalAverage[i]}");
                }
                break;
            case "4":
                AverageMain();
                for (int i = 0; i < Names.Length; i++)
                {
                    Console.WriteLine($"{Names[i]} : {MainAverage[i]}");
                }
                break;
            case "5":
                AverageGeneral();
                for (int i = 0; i < Names.Length; i++)
                {
                    Console.WriteLine($"{Names[i]} : {GeneralAverage[i]}");
                }
                break;
            case "6":
                SortByWritten();
                break;
            case "7":
                SortByPractical();
                break;
            case "8":
                SortByTheorical();
                break;
            case "9":
                SortByMain();
                break;
            case "10":
                SortByGrade();
                break;
            case "11":
                int[][] Input = {  AdvancedProgramming , AdvancedProgramming2, OOP, OS, Algorithm, Mathematic, Quran, WorkShop, English, PE  };
                string[] LessonNames = { "AdvancedProgramming", "AdvancedProgramming2", "OOP", "OS", "Algorithm", "Mathematic", "Quran", "WorkShop", "English", "PE" };
                Console.WriteLine("-------------------------------------");
                for (int i = 0; i < Input.Length; i++)
                {
                    Console.Write($"{LessonNames[i]}: ");
                    PrimeNumbers(Input[i]);
                    Console.WriteLine("\n-------------------------------------");
                    
                }
                break;
            default:
                Console.WriteLine("Please enter a correct number!!!!!");
                break;

        }
    } while (true);
}

void AverageWritten()
{
    
    int TotalMarks = 0;
    WrittenAverage = new double[100];
    for (int i = 0; i < Names.Length; i++)
    {
        TotalMarks = Quran[i] + 
                     Mathematic[i] * 2 + 
                     WorkShop[i] + 
                     English[i] * 2 + 
                     PE[i];    
        WrittenAverage[i] = Math.Round((double)TotalMarks / (double)7, 2);
        TotalMarks = 0;
    }
    
}

void AveragePractical()
{
    
    int TotalMarks = 0;
    PracticalAverage = new double[100];
    for (int i = 0; i < Names.Length; i++)
    {
        TotalMarks = AdvancedProgramming[i] * 3 + 
                     AdvancedProgramming2[i] * 3 + 
                     OOP[i] * 3;
        PracticalAverage[i] = Math.Round((double)TotalMarks / (double)9, 2);
        TotalMarks = 0;
    }

}

void AverageTheorical()
{
    
    int TotalMarks = 0;
    TheoricalAverage = new double[100];
    for (int i = 0; i < Names.Length; i++)
    {
        TotalMarks = OS[i] * 3 + 
                     Algorithm[i] * 3;
        TheoricalAverage[i] = Math.Round((double)TotalMarks / (double)6, 2);
        TotalMarks = 0;
    }

}

void AverageMain()
{
    
    int TotalMarks = 0;
    MainAverage = new double[100];  
    for (int i = 0; i < Names.Length; i++)
    {
        TotalMarks = OS[i] * 3 + 
                     Algorithm[i] * 3 + 
                     AdvancedProgramming[i] * 3 + 
                     AdvancedProgramming2[i] * 3 + 
                     OOP[i] * 3;
        MainAverage[i] = Math.Round((double)TotalMarks / (double)15, 2);
        TotalMarks = 0;
    }
}


void AverageGeneral()
{
    
    int TotalMarks = 0;
    GeneralAverage = new double[100];   
    for (int i = 0; i < Names.Length; i++)
    {
        TotalMarks = AdvancedProgramming[i] * 3 +
                     AdvancedProgramming2[i] * 3 + 
                     Quran[i] + 
                     Mathematic[i] * 2 +
                     WorkShop[i] +
                     English[i] * 2 +
                     OOP[i] * 3 +
                     PE[i] +
                     OS[i] * 3 +
                     Algorithm[i] * 3;
        GeneralAverage[i] = Math.Round((double)TotalMarks / (double)22, 2);
        TotalMarks = 0;
    }
}

void SortByWritten()
{
    AverageWritten();
     
    double Average = 0;
    string Name = "";
    Console.Write("Please enter the number of students that you want to sort: ");
    string Input = Console.ReadLine();
    if (IsInt(Input))
    {
        int Number = Convert.ToInt32(Input);
        for (int i = 0; i < Number; i++)
        {
            for (int j = 0; j < WrittenAverage.Length; j++)
            {
                if (WrittenAverage[j] > Average)
                {
                    Average = WrittenAverage[j];
                    Name = Names[j];
                }

            }
            Console.WriteLine($"{i + 1}.{Name.Replace(" ", "")} : {Average}");
            int Index = Array.IndexOf(WrittenAverage, Average);
            for (int x = Index + 1; x < WrittenAverage.Length; x++)
            {
                WrittenAverage[x - 1] = WrittenAverage[x];
                Names[x - 1] = Names[x];
            }
            WrittenAverage[WrittenAverage.Length - 1] = 0;
            Names[Names.Length - 1] = "";
            
            Average = 0;
        }
    }
    else
        Console.WriteLine("Please enter a correct number!!!");

}

void SortByPractical()
{
    AveragePractical();
    
    double Average = 0;
    string Name = "";
    Console.Write("Please enter the number of students that you want to sort: ");
    string Input = Console.ReadLine();
    if (IsInt(Input))
    {
        int Number = Convert.ToInt32(Input);
        for (int i = 0; i < Number; i++)
        {
            for (int j = 0; j < PracticalAverage.Length; j++)
            {
                if (PracticalAverage[j] > Average)
                {
                    Average = PracticalAverage[j];
                    Name = Names[j];
                }

            }
            Console.WriteLine($"{i + 1}.{Name.Replace(" ", "")} : {Average}");
            int Index = Array.IndexOf(PracticalAverage, Average);
            for (int x = Index + 1; x < PracticalAverage.Length; x++)
            {
                PracticalAverage[x - 1] = PracticalAverage[x];
                Names[x - 1] = Names[x];
            }
            PracticalAverage[PracticalAverage.Length - 1] = 0;
            Names[Names.Length - 1] = "";

            Average = 0;
        }
    }
    

}

void SortByTheorical()
{
    AverageTheorical();
    
    double Average = 0;
    string Name = "";
    Console.Write("Please enter the number of students that you want to sort: ");
    string Input = Console.ReadLine();
    if (IsInt(Input))
    {
        int Number = Convert.ToInt32(Input);
        for (int i = 0; i < Number; i++)
        {
            for (int j = 0; j < TheoricalAverage.Length; j++)
            {
                if (TheoricalAverage[j] > Average)
                {
                    Average = TheoricalAverage[j];
                    Name = Names[j];
                }

            }
            Console.WriteLine($"{i + 1}.{Name.Replace(" ", "")} : {Average}");

            int Index = Array.IndexOf(TheoricalAverage, Average);
            for (int x = Index + 1; x < TheoricalAverage.Length; x++)
            {
                TheoricalAverage[x - 1] = TheoricalAverage[x];
                Names[x - 1] = Names[x];
            }
            TheoricalAverage[TheoricalAverage.Length - 1] = 0;
            Names[Names.Length - 1] = "";
            Average = 0;
        }
    }
    else
        Console.WriteLine("Please enter a correct number !!!");
    

}

void SortByMain()
{
    AverageMain();
    
    double Average = 0;
    string Name = "";
    Console.Write("Please enter the number of students that you want to sort: ");
    string Input = Console.ReadLine();
    if (IsInt(Input))
    {
        int Number = Convert.ToInt32(Input);
        for (int i = 0; i < Number; i++)
        {
            for (int j = 0; j < MainAverage.Length; j++)
            {
                if (MainAverage[j] > Average)
                {
                    Average = MainAverage[j];
                    Name = Names[j];
                }

            }
            Console.WriteLine($"{i + 1}.{Name.Replace(" ", "")} : {Average}");

            int Index = Array.IndexOf(MainAverage, Average);
            for (int x = Index + 1; x < MainAverage.Length; x++)
            {
                MainAverage[x - 1] = MainAverage[x];
                Names[x - 1] = Names[x];
            }
            MainAverage[MainAverage.Length - 1] = 0;
            Names[Names.Length - 1] = "";
            Average = 0;
        }
    }
    else
        Console.WriteLine("Please enter a correct number!!!");
    
    

}


char Rank(double Average)
{
    char Grade = ' ';
    if (Average >= 17.00 && Average <= 20)
        Grade = 'A';
    else if (Average >= 15.00 && Average < 17.00)
        Grade = 'B';
    else if (Average >= 13.00 && Average < 15.00)
        Grade = 'C';
    else if (Average >= 10.00 && Average < 13.00)
        Grade = 'D';
    else if (Average >= 7.00 && Average < 10.00)
        Grade = 'E';
    else if (Average >= 3.00 && Average < 7.00)
        Grade = 'F';
    else if (Average >= 0.00 && Average < 3.00)
        Grade = 'G';
    return Grade;
}

void SortByGrade()
{
    AverageGeneral();
    double Average = 0;
    string Name = "";
    Console.Write("Please enter the number of students that you want to sort: ");
    string Input = Console.ReadLine();
    if (IsInt(Input))
    {
        int Number = Convert.ToInt32(Input);
        for (int i = 0; i < Number; i++)
        {
            for (int j = 0; j < GeneralAverage.Length; j++)
            {
                if (GeneralAverage[j] > Average)
                {
                    Average = GeneralAverage[j];
                    Name = Names[j];


                }

            }
            Console.WriteLine($"{i + 1}.Name:{Name.Replace(" ", "")}, Average: {Average}, Grade: {Rank(Average)}");

            
            int Index = Array.IndexOf(GeneralAverage, Average);
            for (int x = Index + 1; x < GeneralAverage.Length; x++)
            {
                GeneralAverage[x - 1] = GeneralAverage[x];
                Names[x - 1] = Names[x];
            }
            GeneralAverage[GeneralAverage.Length - 1] = 0;
            Names[Names.Length - 1] = "";
            Average = 0;
        }
    }
    else
        Console.WriteLine("Please enter a correct number!!!!!");
   
    


}

static bool IsInt(string input)
{
    foreach (char c in input)
    {
        if (!Char.IsDigit(c))
        {
            return false;
        }
    }
    return true;
}

void PrimeNumbers(int[] Numbers)
{
    bool Prime = true;
    int[] Output = new int[Numbers.Length];
    int Index = 0;
    for (int i = 0; i < Numbers.Length; i++)
    {
        if (Numbers[i] == 2)
            Prime = true;        
        if (Numbers[i] == 0 || Numbers[i] == 1)
            Prime = false;
        for (int j = 2; j < Numbers[i]; j++)
        {
            if(Numbers[i] % j == 0)
            {
                Prime = false;
                break;
            }
        }
        if (Prime)
        {
            Output[Index] = Numbers[i];
            
        }
        Index++;
           

        Numbers = Numbers.Where(n => n != Numbers[i]).ToArray();
    }
    Array.Sort(Output);
    for (int i = 0; i < Output.Length; i++)
    {
        if(Output[i] != 0)
            Console.Write($"{Output[i]}  ");
    }
    
}

SelectOption();