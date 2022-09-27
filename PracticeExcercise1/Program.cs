namespace PracticeExercise1;

class Program
{
    static void Main(string[] args)
    {

        ArrayList arrayList = new ArrayList();

        arrayList.Prepend(8);
        arrayList.Prepend(4);
        arrayList.RemoveAt(0);
        arrayList.Prepend(2);
        arrayList.Prepend(1);
        arrayList.Prepend(0);

        Console.WriteLine(arrayList);

    }
}

