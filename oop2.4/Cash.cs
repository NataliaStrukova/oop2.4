using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace oop2._4
{
    class Cash//класс кассы
    {
        private const int width = 120;
        private const int height = 10;

        private int x, y;
        private SolidBrush brush;
        private Pen pen;
        private Queue<Buyer> buyers;
        private NormalRandom nr;

        public int Count { get { return buyers.Count; } }

        public Cash(int x, int y)
        {
            brush = new SolidBrush(Color.Yellow);
            pen = Pens.Orange;
            this.x = x;
            this.y = y;
            buyers = new Queue<Buyer>();
            nr = new NormalRandom();
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x, y, width, height);
            g.FillRectangle(brush, x, y, width, height);
            foreach (Buyer buyer in buyers)
                buyer.Draw(g);
        }

        public void Enter(Buyer buyer, int countCash)
        {
            buyer.Move(700 - 10 * buyers.Count, y + 20);//передвижение
            buyers.Enqueue(buyer);//добавление в конец очереди
            if (buyers.Count == 1)
            {
                buyer.Set();
            }
            buyer.locked.WaitOne();//Блокирует текущий поток до получения сигнала
            Thread.Sleep(nr.Next(15, 5) * 100 * countCash); //оплачивает товар
            buyers.Dequeue();//Удаляет объект из начала очереди
            if (buyers.Count != 0)
            {
                foreach (Buyer b in buyers.ToList()) //очередь движется
                    b.Move(5);
                Thread.Sleep(50);
                foreach (Buyer b in buyers.ToList()) //очередь движется
                    b.Move(5);
                buyers.Peek().Set();//Возвращает объект, находящийся в начале очереди Queue, но не удаляет его.
            }

        }
    }
}
