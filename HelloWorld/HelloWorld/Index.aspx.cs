﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadTheWorld("World!");
        }

        public void loadTheWorld(string strWorld)
        {
            lblWorld.Text = strWorld;
            //change this coment here
        }
    }
}