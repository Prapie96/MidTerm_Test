class People{
    private string Prefix;
    private string Name;
    private string LastName;
    private string Age;
    private string Allergy;
    private string Religion;

    public People(string Prefix,string Name,string LastName,string Age,string Allergy,
    string Religion){
        this.Prefix = Prefix;
        this.Name =Name;
        this.LastName = LastName;
        this.Age = Age;
        this.Allergy = Allergy;
        this.Religion = Religion;
    }
    public string GetPrefix(){
        return this.Prefix;
    }
    public string GetName(){
        return this.Name;
    }
     public string GetLastName(){
        return this.LastName;
    }
    public string GetAge(){
        return this.Age;
    }
     public string GetAllergy(){
        return this.Allergy;
    }
     public string GetReligion(){
        return this.Religion;
    }


}