class Program{
    static MainmenuScreen mainmenuScreen;
    static void Main(string[] args){
        PrepareMainMenuScreen();
        ShowMainmenuScreen();
    }
    static void PrepareMainMenuScreen(){
        Program.mainmenuScreen = new MainmenuScreen();
    }
    static void  ShowMainmenuScreen(){
        Program.mainmenuScreen.ShowMainmenu();
    }
}
