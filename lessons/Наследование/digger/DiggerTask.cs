using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digger
{
    //Напишите здесь классы Player, Terrain и другие.
    class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            throw new NotImplementedException();
        }

        public int GetDrawingPriority()
        {
            throw new NotImplementedException();
        }

        public string GetImageFileName()
        {
            throw new NotImplementedException();
        }
    }

    class Player : ICreature
    {
        public static int X, Y = 0;
        public static int dX, dY = 0;

        public CreatureCommand Act(int x, int y)
        {
            X = x;
            Y = y;
            //Обработка нажатия клавиш присвоение значений дельтам
            switch (Game.KeyPressed)
            {
                case System.Windows.Forms.Keys.Left:
                    dY = 0;
                    dX = -1;
                    break;
                case System.Windows.Forms.Keys.Up:
                    dY = -1;
                    dX = 0;
                    break;
                case System.Windows.Forms.Keys.Right:
                    dY = 0;
                    dX = 1;
                    break;
                case System.Windows.Forms.Keys.Down:
                    dY = 1;
                    dX = 0;
                    break;
                default:
                    Staying();
                    break;
            }
            //Запрет выхода за пределы карты 
            if (!(x + dX >= 0 && x + dX < Game.MapWidth &&
                y + dY >= 0 && y + dY < Game.MapHeight))
                Staying();
            //возвращение следующих координат отрисовки
            return new CreatureCommand() { DeltaX = dX, DeltaY = dY };
        }
        private static void Staying()
        {
            // \0_0/
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            throw new NotImplementedException();
        }

        public int GetDrawingPriority()
        {
            throw new NotImplementedException();
        }

        public string GetImageFileName()
        {
            throw new NotImplementedException();
        }
    }

}
