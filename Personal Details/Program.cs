class Learners

{
    public string firstname;
    public string lastname;
    public string gender;
    public int age;
    public char initial;

    public Learners (string Firstname,string Lastname, string Gender, int Age,char Initial)

    {
        firstname = Firstname;
        lastname = Lastname;
        gender = Gender;
        age = Age;
        initial = Initial;


    }

    static void Main (string [] args)
    {
        Learners learner1 = new Learners("Malesela", "Letsoalo", "Male", 30, 'J');

        Console.WriteLine(learner1.firstname+ " " +learner1.lastname+ " " +learner1.gender+ " " +learner1.age+ " " +learner1.initial);

    }













}