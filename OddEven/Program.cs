class OddEven {
    public static void main (String[]args)
    {

        int number = int.Parse(Console.ReadLine());
        if (number %2==0) {
           Console.WriteLine("even");
        } else {
           Console.WriteLine("odd");
        }
    }
}