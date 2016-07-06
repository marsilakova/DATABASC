using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GameStory.Pages.Admin;
//sida-3
//-http://professorweb.ru/my/ASP_NET/gamestore/level1/1_3.php
namespace GameStory.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }
        //------------
        // Чтение данных из таблицы Orders
        public IEnumerable<Order> Order
        {
            get
            {
                return context.Orders
                    .Include(o => o.OrderLines.Select(ol => ol.Game));
            }
        }

        

        //-----------------
        // Сохранить данные заказа в базе данных
        public void SaveOrder(Order order)
        {
            if (order.OrderId == 0)
            {
                order = context.Orders.Add(order);

                foreach (OrderLine line in order.OrderLines)
                {
                    context.Entry(line.Game).State
                        = EntityState.Modified;
                }

            }
            else
            {
                Order dbOrder = context.Orders.Find(order.OrderId);
                if (dbOrder != null)
                {
                    dbOrder.Name = order.Name;
                    dbOrder.Line1 = order.Line1;
                    dbOrder.Line2 = order.Line2;
                    dbOrder.Line3 = order.Line3;
                    dbOrder.City = order.City;
                    dbOrder.GiftWrap = order.GiftWrap;
                    dbOrder.Dispatched = order.Dispatched;
                }
            }
            context.SaveChanges();
        }

        internal void SaveOrder(Orders myOrder)
        {
            throw new NotImplementedException();
        }

       
        //-----------------
        public void SaveGame(Game game)
        {
            if (game.GameId == 0)
            {
                game = context.Games.Add(game);
            }
            else
            {
                Game dbGame = context.Games.Find(game.GameId);
                if (dbGame != null)
                {
                    dbGame.gName = game.gName;
                    dbGame.Description = game.Description;
                    dbGame.Price = game.Price;
                    dbGame.Category = game.Category;
                }
            }
            context.SaveChanges();
        }
        //----------------------
        public void DeleteGame(Game game)
        {
            IEnumerable<Order> orders = context.Orders
                .Include(o => o.OrderLines.Select(ol => ol.Game))
                .Where(o => o.OrderLines
                    .Count(ol => ol.Game.GameId == game.GameId) > 0)
                .ToArray();

            foreach (Order order in orders)
            {
                context.Orders.Remove(order);
            }
            context.Games.Remove(game);
            context.SaveChanges();
        }
        //--------------------------
    }
}