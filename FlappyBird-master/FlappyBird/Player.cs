using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // необходима для подключения картинки 

namespace FlappyBird
{
    

    class Player // этот класс отвечает за птичку
    {
        public float x; // координаты
        public float y;

        public int size; // переменная размера птички 
        public int score; // переменная счёта

        public float gravityValue; // переменная которая отвечает за гравитацию в данный момент

        public Image birdImg; //переменная которая отвечает за картинку

        public bool isAlive;

        public Player(int x,int y) // конструктор
        {
            birdImg = new Bitmap("H:\\Bird.png"); // сама картинка и её путь
            this.x = x; // координаты которые мы получаем на входе
            this.y = y;
            size = 30; // размер птички
            gravityValue = 0.1f; // скорость падения птички 
            isAlive = true;
            score = 0;
        }
    }
}
