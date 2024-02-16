using System;

namespace Ecommerce
{
    public partial class Carrello2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Popola il Repeater con i dati dalla lista Carrellos
                Repeater1.DataSource = Dettagli.Carrellos;
                Repeater1.DataBind();
            }
        }
    }
}