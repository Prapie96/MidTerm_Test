class PeopleList{
    private List<People>peoplelist;
    public PeopleList(){
        this.peoplelist = new List<People>();
    }
    public void AddNewPerson(People people){
        this.peoplelist.Add(people);
    }
    
    public void FecthPeopleList(){
       
        foreach(People people in this.peoplelist)
        {   
            if(people is Collegian)
            {   
                Console.WriteLine("Name {0} {1} {2} \n Type: Collegian \n",people.GetPrefix(),people.GetName(),people.GetLastName());
                Console.WriteLine();
                
            }           
            else if (people is Student)
            {
                Console.WriteLine("Name {0} {1} {2} \n Type: Student \n",people.GetPrefix(),people.GetName(),people.GetLastName());
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Name {0} {1} {2} \n Type: Teacher \n",people.GetPrefix(),people.GetName(),people.GetLastName());
                Console.WriteLine();
            }
    }
}
}