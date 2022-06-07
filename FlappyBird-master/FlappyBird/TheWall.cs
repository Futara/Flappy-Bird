using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // необходима для подключения картинки 

namespace FlappyBird
{
    class TheWall // этот класс отвечвает за трубы 
    {
        public int x; // координаты появления
        public int y;

        public int sizeX; // переменные размеров труб
        public int sizeY;

        public Image wallImg; //переменная которая отвечает за картинку

        public TheWall(int x, int y,bool isRotatedImage=false) // конструктор
        {
            wallImg = new Bitmap("H:\\Pipe.png"); // сама картинка и её путь
            this.x = x; // координаты которые мы получаем на входе
            this.y = y;
            sizeX = 50; // ширина и длина труб
            sizeY = 250;
            if(isRotatedImage)
                wallImg.RotateFlip(RotateFlipType.Rotate180FlipX); // поворот верхней трубы
        }
    }
}
