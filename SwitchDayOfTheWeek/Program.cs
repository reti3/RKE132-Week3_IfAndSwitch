int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //väärtus on vahemiks 0-6

switch (weekDay) //väärtus, mida kontrollitakse
{
    case 0:  //case 0 = if(weekDay == 0)
        Console.WriteLine("It's Sunday!");
        break; //kui väärtus on 0, siis lõpetab ploki ära, ei kontrolli enam edasi
    case 1:  
        Console.WriteLine("It's Monday!");
        break;
    case 2:
        Console.WriteLine("It's Tuesday!");
        break;
    case 3:
        Console.WriteLine("It's Wednesday!");
        break;
    case 4:
        Console.WriteLine("It's Thursday!");
        break;
    case 5:
        Console.WriteLine("It's Friday!");
        break;
    case 6:
        Console.WriteLine("It's Saturday!");
        break;
    default:
        Console.WriteLine("Oops! Your calendar must be broken."); //kasutatakse, et haldada juhtumeid, kui väärtus ei ole võrdne eelpool pakutavate väärtustega
        break;
}

Console.WriteLine("Have a nice day!");