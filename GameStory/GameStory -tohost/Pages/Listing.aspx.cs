using System;
using System.Collections.Generic;
using System.Linq;
using GameStory.Models;
using GameStory.Models.Repository;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Отображать фиксированное количество товаров на странице можно за счет применения запросов LINQ к коллекции
//объектов Game, извлекаемых из базы данных. Для этого необходимо знать,
//сколько товаров должно отображаться на странице, и какую страницу пользователь желает просмотреть.
//http://professorweb.ru/my/ASP_NET/gamestore/level1/1_4.php

using GameStory.Pages.Helpers;
using System.Web.Routing;



namespace GameStory.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Models.Repository.Repository repository = new Models.Repository.Repository();
        private int pageSize = 4;

        protected int CurrentPage
        {
            get
            {
                int page;
                //page = int.TryParse(Request.QueryString["page"], out page) ? page : 1;
                page = GetPageFromRequest();
                return page > MaxPage ? MaxPage : page;
            }
        }
        ///-------------------
        private int GetPageFromRequest()
        {
            int page;
            string reqValue = (string)RouteData.Values["page"] ??
                Request.QueryString["page"];
            return reqValue != null && int.TryParse(reqValue, out page) ? page : 1;
        }
        //-----------------------

        // Новое свойство, возвращающее наибольший номер допустимой страницы
        protected int MaxPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)repository.Games.Count() / pageSize);
            }
        }
        public IEnumerable<GameStory.Models.Game> GetGames()
        {
            return repository.Games
            .OrderBy(g => g.GameId)
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize);
        }
        //--------------
        // Новый вспомогательный метод для фильтрации игр по категориям
        private IEnumerable<Game> FilterGames()
        {
            IEnumerable<Game> games = repository.Games;
            string currentCategory = (string)RouteData.Values["category"] ??
                Request.QueryString["category"];
            return currentCategory == null ? games :
                games.Where(p => p.Category == currentCategory);
        }
        //--------------------------------------------


        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (IsPostBack)
                {
                    int selectedGameId;
                    if (int.TryParse(Request.Form["add"], out selectedGameId))
                    {
                        Game selectedGame = repository.Games
                            .Where(g => g.GameId == selectedGameId).FirstOrDefault();

                        if (selectedGame != null)
                        {
                            SessionHelper.GetCart(Session).AddItem(selectedGame, 1);
                            SessionHelper.Set(Session, SessionKey.RETURN_URL,
                                Request.RawUrl);

                            Response.Redirect(RouteTable.Routes
                                .GetVirtualPath(null, "cart", null).VirtualPath);
                        }
                    }
                }
            }
        }
        //---------------------
    }
}