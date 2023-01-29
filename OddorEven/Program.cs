Console.WriteLine("enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine()); //muudab string tüübi int tüübiks

//kas kasutaja arv on paaris või paaritu arv

int result = userNum % 2; //otsime jääki, kui jagame kasutaja numbri kahega

if(result != 0) //!= ei ole võrdne
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("User number is even.");
}



