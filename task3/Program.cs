Console.Write("Input day number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >0 & num<8) {
    if (num>0 & num<6) {
        Console.WriteLine("no, it is a weekday");
    }
    else {
        Console.WriteLine("yes, it is a weekend day");
    }
}
else {
    Console.WriteLine("Incorrect input");
}