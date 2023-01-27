using levelup.cli;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace levelup {
    public class GameMap{
        public Position[,]? positions { get; set; }
        public Position? startingPosition { get; set; } 

        public GameMap()
        {
            CreatePositions();
        }
        private void CreatePositions()
        {
            positions = new Position[10,10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++ )
                {
                   Position pos = Position(x,y);
                   positions[x,y] = pos; 
                }
                startingPosition = positons[0,0];
            }
        }

    }
}