﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FoodSupplementsSystem.Data;
using FoodSupplementsSystem.Services;
using FoodSupplementsSystem.Data.Models;

namespace FoodSupplementsSystem.Web.FoodSupplements
{
    public partial class Details : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.IsPostBack)
            {
                return;
            }

            this.DbContext = new FoodSupplementsSystemDbContext();
            this.UnitOfWork = new UnitOfWork(this.DbContext);
            this.SupplementsServices = new SupplementsServices(this.UnitOfWork.SupplementRepository);

            int suppId = -1;
            if (!int.TryParse(this.Request.Params["id"], out suppId))
            {
                this.Response.Redirect("SupplementsList.aspx");
            }
            this.Id = suppId;

            this.DetailsViewSupplement.DataSource = this.Supplements.ToList();
            this.DetailsViewSupplement.DataBind();
        }

        public FoodSupplementsSystemDbContext DbContext { get; private set; }

        public UnitOfWork UnitOfWork { get; private set; }

        protected SupplementsServices SupplementsServices { get; set; }

        public int Id { get; private set; }

        protected IList<Supplement> Supplements
        {
            get
            {
                IList<Supplement> supplementsToReturn= new List<Supplement>();
                supplementsToReturn.Add(this.SupplementsServices.GetById(this.Id));

                return supplementsToReturn;
            }
        }

        protected void ButtonGoBack_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("SupplementsList.aspx");
        }
    }
}