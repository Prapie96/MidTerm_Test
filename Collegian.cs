class Collegian: People
{
    private string CollegianID; 
  
    public Collegian(string Prefix,string Name,string LastName,string Age,string Allergy,string Religion,string CollegianID)
    : base(Prefix,Name,LastName,Age,Allergy,Religion){
        this.CollegianID = CollegianID;
    }
    public string GetCollgianID(){
        return this.CollegianID;
    }
 
}