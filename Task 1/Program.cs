//1
Console.Write("enter  bill amount : ");
Double amount = Convert.ToDouble(Console.ReadLine());
Double discont = 0;

if (amount >= 500)
{
    discont = amount * 0.20;
}
else if (amount < 499 && amount >= 300)
{
    discont = amount * 0.10;
}
else
{
    discont = 0;

}

Double finalPrice = amount - discont;

Console.WriteLine("this is final price : " + finalPrice);