namespace levelup.cli;

public class Character
{  
    private string _name;
    private int count = 0;

    // private StartPosition;

    static string DEFAULT_NAME= "Hazzah";

    public Character() {
        _name =DEFAULT_NAME;

    }
    public Character(string name) {
        _name = name;
    }
    public string Name {
        get{return _name;}
    }
    public int moveCount() {
        return count;
    }
}