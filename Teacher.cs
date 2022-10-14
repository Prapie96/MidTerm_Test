class Teacher:People
{
    private string Jobtitle;
    public Teacher(string Prefix,string Name,string LastName,string Age,string Allergy,string Religion,string Jobtitle)
    : base(Prefix,Name,LastName,Age,Allergy,Religion){
        this.Jobtitle = Jobtitle;
    }
    public string GetJobtitle()
    {   
        return this.Jobtitle;
    }
}