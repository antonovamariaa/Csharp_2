Console.Write("Input a three-digits number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1000 & num > 99) {
    num = num/10;
    num = num %10;
    Console.WriteLine(num);
}
else {
    Console.WriteLine("Incorrect input");
}