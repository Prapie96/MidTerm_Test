enum Listmainmenu{
    RegisterCamp = 1,
    PeopleInCamp = 2
}
class MainmenuScreen{
    static PeopleList peopleList;
    public void ShowMainmenu(){
        PreparePerpleListWhenProgramIsLoad();
        InsideScreenMainmenu();
        GetInputMenuFromKeyboard();
    }
    static void PreparePerpleListWhenProgramIsLoad()
    {
        MainmenuScreen.peopleList = new PeopleList();
    }
    public static void InsideScreenMainmenu(){
        Console.Clear();
        Console.WriteLine("Welcome To MainMenu Idia camp 2022");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("1). Register to join camp ");
        Console.WriteLine("2). Show exhibitor statistics ");
        Console.WriteLine("3). Login ");
        Console.WriteLine("-----------------------------------");
    }
     public static void GetInputMenuFromKeyboard(){
        Console.Write("Please Input Menu following from List : ");
        Listmainmenu listmainmenu = (Listmainmenu) (int.Parse(Console.ReadLine()));
        AfterGetinputFromKeyboard(listmainmenu);
    }
    static void AfterGetinputFromKeyboard(Listmainmenu listmainmenu){
        switch(listmainmenu){
            case Listmainmenu.RegisterCamp:
            RegisterMenuScreen();
            break;
            case Listmainmenu.PeopleInCamp:
            ListMenuShowPeople();
            break;

        }
        
    }
     public static void RegisterMenuScreen(){
        Console.Clear();
        Console.WriteLine("Welcom To MenuRegister");
        Console.WriteLine("**********************");
        Console.WriteLine("1).Current Collegian");
        Console.WriteLine("2).Student");
        Console.WriteLine("3).Teacher");
        GetInputRegisFromKeyboard();
    }
     static void BackToMenu(){
        InsideScreenMainmenu();
        GetInputMenuFromKeyboard();

    }
    enum ListPerson{
        collegian = 1,
        student =2,
        Teacher =3
    }
     public static void GetInputRegisFromKeyboard(){
        Console.Write("Please Input Menu following from List : ");
        ListPerson listPerson = (ListPerson) (int.Parse(Console.ReadLine()));
        AfterGetinputRegisFromKeyboard(listPerson);
    }
    static void AfterGetinputRegisFromKeyboard( ListPerson listPerson){
        switch(listPerson){
            case ListPerson.collegian:
            RegisterCollegian();
            break;
            case ListPerson.student:
            RegisterStudent();
            break;
            case ListPerson.Teacher:
            RegisterTeacher();
            break;

        }
        
    }
        ///////////////////////// Collegian //////////////////

    public static void RegisterCollegian(){
        Console.Clear();
        Console.WriteLine("Register Collegian  ");
        Console.WriteLine("-------------------------");
        int totalcollegian = TotalCollegain();
        InputNewCollegiantFromKeyboard(totalcollegian);
       
    }
    static int TotalCollegain(){
        Console.Write("Input Total new Collegain: ");

        return int.Parse(Console.ReadLine());

    }
    static void InputNewCollegiantFromKeyboard(int Totalcollegian)
    {
        for(int i=0; i<Totalcollegian; i++)
        {
            Console.Clear();
            Console.WriteLine("Register New Collegain");
            Console.WriteLine("********************");

            Collegian collegian = new Collegian(InputPrefix(),InputName(),InputLastName(),InputAge(),InputAllergy(),InputReligion(),InputCollegianID());
            MainmenuScreen.peopleList.AddNewPerson(collegian);
            
        }
        BackToMenu();
    }
    ///////////////////////// Collegian //////////////////

    ///////////////////////// Student //////////////////
    public static void RegisterStudent(){
        Console.Clear();
        Console.WriteLine("Register Student  ");
        Console.WriteLine("-------------------------");
        int totalcstudent = Totalstudent();
        InputNewStudentFromKeyboard(totalcstudent);
       
    }
     static int Totalstudent(){
        Console.Write("Input Total new student: ");
        return int.Parse(Console.ReadLine());
    }
    static void  InputNewStudentFromKeyboard(int TotalNewStudent)
    {
        for(int i=0; i<TotalNewStudent; i++)
        {
            Console.Clear();
            Console.WriteLine("Register New Student");
            Console.WriteLine("********************");

            Student student = new Student(InputPrefix(),InputName(),InputLastName(),InputAge(),InputAllergy(),InputReligion(),InputSchoolName());
            MainmenuScreen.peopleList.AddNewPerson(student);
            
        }
        BackToMenu();
    }
        ///////////////////////// Student //////////////////

        ///////////////////////// Teacher //////////////////
    public static void RegisterTeacher(){
        Console.Clear();
        Console.WriteLine("Register Teacher ");
        Console.WriteLine("-------------------------");
        int totalcteacher = Totalteacher();
        InputNewTeacherFromKeyboard(totalcteacher);
       
    }
     static int Totalteacher(){
        Console.Write("Input Total new Teacher: ");
        return int.Parse(Console.ReadLine());
    }
    static void InputNewTeacherFromKeyboard(int Totalcteacher)
    {
        for(int i=0; i<Totalcteacher; i++)
        {
            Console.Clear();
            Console.WriteLine("Register New Teacher");
            Console.WriteLine("********************");

            Teacher teacher = new Teacher(InputPrefix(),InputName(),InputLastName(),InputAge(),InputAllergy(),InputReligion(),InputJobtitle());
            MainmenuScreen.peopleList.AddNewPerson(teacher);
            
        }
        BackToMenu();
    }
    ///////////////////////// Teacher //////////////////

    static string InputPrefix(){
        Console.Write("Prefix (Mr./Mr.s/Miss) : ");
        return Console.ReadLine();
    }

    static string InputName()
    {
        Console.Write("Name : ");
        return Console.ReadLine();
    }
    static string InputLastName()
    {
        Console.Write("LastName: ");
        return Console.ReadLine();
    }
    static string InputAge()
    {
        Console.Write("Age: ");
        return Console.ReadLine();
    }
    static string InputAllergy()
    {
        Console.Write("Allergy: ");
        return Console.ReadLine();
    }
     static string InputReligion()
    {
        Console.Write("Religion: ");
        return Console.ReadLine();
    }
    static string InputCollegianID(){
        Console.Write("Collegian ID : ");
        return Console.ReadLine();
    }
    static string InputSchoolName(){
        Console.Write("School Name : ");
        return Console.ReadLine();
    }
     static string InputJobtitle(){
        Console.Write("Job Title (Dean/Head of department/Full-time teacher): ");
        return Console.ReadLine();
    }
    
///////////////////////////////////////////////////////////////

    static void ListMenuShowPeople(){
        Console.Clear();
        Console.WriteLine("Show People In Camp");
        Console.WriteLine("-------------------------");
        MainmenuScreen.peopleList.FecthPeopleList();
        Console.WriteLine("-------------------------");

    }
    /*static void ListMenuPeople(){
        Console.WriteLine("Choose Number that you want ");
        Console.WriteLine("------------------------------");
        Console.WriteLine("1).Show All Current Collegain");
        Console.WriteLine("2).Show All Student");
        Console.WriteLine("3).Show All Teacher");

    }   */
    
}