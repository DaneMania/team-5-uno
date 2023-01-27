namespace levelup.cli;


public class Position {
    private int _x = 1, _y = 1;
    public void setPosition(int x, int y){
        _x = x;
        _y = y;
    }


    public int X {
        get { return _x;}
        set { value = _x; }
    }

 public int Y {
        get { return _y;}
        set { value = _y; }
    }
    public Position() {

    }

    public Position(int x, int y) {
        _x = x;
        _y = y;
    }
}

