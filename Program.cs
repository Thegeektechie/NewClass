// Console.WriteLine("Build a solution for a subscription company to notify the subscribers to renew their subscription.");
// Console.WriteLine("1. If the number of days remaining is less than or equal to 10 days display message to the user saying Your subscription will soon expire");
// Console.WriteLine("2. If the number of days remaining is less than or equal to 5 days display a message with 10% discount. Your subscription will expire in (noOfDays) days.\nRenew now and get(discount)% discount.");
// Console.WriteLine("3. If the number of days remaining is exactly 2 days display a message with 20% discount. Your subscription will expire in (noOfDays) days.\nenew now and get (discount)% discount.");
// Console.WriteLine("4. If the number of days remaining is exactly 1 day. Display: Your subscription will expire in a day.");

/*Console.Write("Dear Customer, ");
Random random = new Random();

 int noOfDayRemaining = random.Next(12);
//int noOfDayRemaining = 5;


int discount = 0;

 if (noOfDayRemaining == 0)
            {
              Console.WriteLine("Your Subscription has expired");
            }
   else if (noOfDayRemaining == 1)
            {
              Console.WriteLine("Your Subscription will expire in 1 day");
            }
       else if (noOfDayRemaining == 2 )
            {
                discount = 20;
              Console.WriteLine("Your Suscription will expire in 2 days");
              Console.WriteLine("Renew now to get " + discount +" % discount");
            }
               else if(noOfDayRemaining <= 5 )
            {
                discount = 10;
               Console.WriteLine("Your Subscription Will Expire In " + noOfDayRemaining  + " Days");
               Console.Write("Renew now to get " + discount + " % discount");
            }   

        else if(noOfDayRemaining <= 10 )
            {
              Console.WriteLine("Your Subscription Will Soon Expire");
            }



long number = 2349025601704;
var num = number.ToString();


foreach (char character in num)
{
   Console.WriteLine(character); 
}
  *//* rem1 = character % 2;
    if (rem1 == 0){
 Console.WriteLine("{0} is an even integer.\n",character);
     } else
     {
 Console.WriteLine("{0} is an odd integer.\n",character);

     }
*/
Console.WriteLine("Answers");

string[] months = {"January", "February", "March", "April", "May",
  "June", "July", "August", "September", "October", "November", "December"};

Console.WriteLine("Lists of Months");
            foreach (string fullList in months)
            {
                Console.WriteLine(fullList);
            }
Console.WriteLine("  ");
Console.WriteLine("                     1 ");
int TotalMonths = months.Length;
Console.WriteLine("There are " + TotalMonths + " months in a year ");



Console.WriteLine("                     2 ");
Console.WriteLine("  ");
foreach (string month in months)
{
    Console.WriteLine(month);
}


Console.WriteLine("  ");
Console.WriteLine("                     3 ");


Console.WriteLine("  ");
Console.WriteLine("LOOP METHOD  ");
for (int i = months.Length - 1; i >= 0; i--)
{
Console.WriteLine(months[i]);
}


Console.WriteLine("  ");
Console.WriteLine("ARRAY METHOD  ");
Array.Reverse(months);
foreach (string reversedMonths in months)
{
    Console.WriteLine(reversedMonths);

}


    Console.WriteLine("  ");
Console.WriteLine("                     4 ");
Console.WriteLine("   ");

Console.WriteLine("The list of months in alphabetically order ");
Array.Sort(months);
foreach (string sort in months)
{
    Console.WriteLine(sort);
}


Console.WriteLine("                     5 ");


string[] Months = {"January", "February", "March", "April", "May",
  "June", "July", "August", "September", "October", "November", "December"};
string[] InitialHalf = new string[6];
Array.Copy(Months, InitialHalf, 6);
foreach (string Initial6 in InitialHalf)
{
    Console.WriteLine(Initial6);
}


Console.WriteLine("                     6 ");
Console.WriteLine("   ");
string[] cloneMonths = (string[])Months.Clone();
foreach (string clone in cloneMonths)
{
    Console.WriteLine(clone);
}

Console.WriteLine("                     7 ");
Console.WriteLine("   ");
Console.WriteLine("About to clear the months");
Console.WriteLine("Clearing...");
Console.WriteLine("-------------------------------100%--------------------------");
Array.Clear(months, 0, months.Length);
foreach (string clear in months)
{
    Console.WriteLine(clear);
}
Console.WriteLine("Cleared");


Console.WriteLine("                     8 ");
Console.WriteLine("   ");


string[] MonthS = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
Array.Clear(MonthS, 0, 6);
foreach (string clear6 in MonthS)
{
    Console.WriteLine(clear6);
}