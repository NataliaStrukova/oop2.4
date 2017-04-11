using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace oop2._4
{
    class Store//класс для магазина
    {
        private int countCash;//кол-во касс
        private List<Cash> listCash;
        private List<Buyer> listBuyer;
        private bool stop;

        public Store(int countCash, int width, int height)
        {
            this.countCash = countCash;
            listCash = new List<Cash>();
            for (int i = 0; i < countCash; i++)
            {
                listCash.Add(new Cash(width - 200, height / (2 * countCash + 1) * (2 * i + 1)));
            }
            listBuyer = new List<Buyer>();
            stop = false;
        }

        public void Draw(Graphics g)
        {
            g.Clear(Color.White);
            foreach (Cash cash in listCash)
                cash.Draw(g);
            foreach (Buyer buyer in listBuyer)
                buyer.Draw(g);
        }

        public void Run()
        {
            NormalRandom nrNextBuyer = new NormalRandom();
            NormalRandom nrStore = new NormalRandom();
            Random rn = new Random();
            int waitTime;//время ожидания
            do
            {
                waitTime = nrNextBuyer.Next((33 - 3 * countCash), 3);
                Buyer buyer = new Buyer(rn.Next(500), rn.Next(400));
                listBuyer.Add(buyer);
                new Thread(() =>
                   {
                       Thread.Sleep(100*nrStore.Next((33 - 3 * countCash), 4)); //выбирает товар
                       int minQueueIndex = 0;
                       int minQueue = listCash[minQueueIndex].Count;
                       for (int i = 1; i < countCash; i++)
                       {
                           if (minQueue > listCash[i].Count)
                           {
                               minQueueIndex = i;
                           }
                       }
                       listBuyer.Remove(buyer);//удаляем из списка
                       listCash[minQueueIndex].Enter(buyer,countCash); //становится в кассу
                   }).Start();//запуск потока
                Thread.Sleep(waitTime * 50);
            }
            while (!stop);
        }

        public void Stop()
        {
            stop = true;
        }
    }
}
