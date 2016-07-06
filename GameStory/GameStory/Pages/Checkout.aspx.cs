﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GameStory.Models;
using GameStory.Models.Repository;
using GameStory.Pages.Helpers;
using System.Web.ModelBinding;

namespace GameStory.Pages
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                checkoutForm.Visible = true;
                checkoutMessage.Visible = false;

                if (IsPostBack)
                {
                    Order myOrder = new Order();
                    if (TryUpdateModel(myOrder,
                       new FormValueProvider(ModelBindingExecutionContext)))
                    {

                        myOrder.OrderLines = new List<OrderLine>();

                        Cart myCart = SessionHelper.GetCart(Session);

                        foreach (CartLine line in myCart.Lines)
                        {
                            myOrder.OrderLines.Add(new OrderLine
                            {
                                Order = myOrder,
                                Game = line.Game,
                                Quantity = line.Quantity
                            });
                        }

                        new Repository().SaveOrder(myOrder);
                        myCart.Clear();

                        checkoutForm.Visible = false;
                        checkoutMessage.Visible = true;
                    }
                }
            }

        }
        //-------------------
    }
}