using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace oop2._4
{
    class Buyer//класс покупателя
    {
        private const int r = 12;
        private int x, y;
        private Pen pen;
        private SolidBrush brush;
        public AutoResetEvent locked;//Auto...уведомляет ожидающий поток о том, что произошло событие

        public Buyer(int x, int y)
        {
            pen = Pens.Red;
            brush = new SolidBrush(Color.Red);
            this.x = x;
            this.y = y;
            locked = new AutoResetEvent(false);//блокировка
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x, y, r, r);
            g.FillEllipse(brush, x, y, r, r);
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int dx)
        {
            x += dx;
        }

        public void Set()
        {
            locked.Set();//Устанавливает сигнальное состояние события, что позволяет продолжить выполнение одному или нескольким ожидающим потокам
            brush = new SolidBrush(Color.DarkRed);
        }
    }
}
