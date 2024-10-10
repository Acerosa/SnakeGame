using System;

namespace Snake {
    public class Coords{

        public int X {get; private set;}
        public int Y {get; private set;}

    // this is a construtor use to build objects of this kind wherever they are needed
        public Coords(int x, int y){
            X = x;
            Y = y;
        }

    public void AppleMovementDirecton(Direction direction){
        switch (direction)
        {
            case Direction.Up:
            Y++;
            break;
            case Direction.Down:
            Y--;
            break;
            case Direction.Right:
            X++;
            break;
            case Direction.Left:
            X--;
            break;
        }
    }

    // this is a method that copares the coordinates of two objects
    public bool isCoordEqual(object? obj)
        {
        if(obj is not Coords other){
            return false;
            }
        return X == other.X  && Y == other.Y;
    }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }

}