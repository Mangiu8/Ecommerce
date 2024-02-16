using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce
{
    public partial class Dettagli : System.Web.UI.Page
    {
        static public List<Carrello> Carrellos = new List<Carrello>();

        public Articolo currentArticolo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["id"], out int itemId))
                {
                    currentArticolo = Home.listaArticoli.FirstOrDefault(a => a.Id == itemId);

                    if (currentArticolo != null)
                    {

                        Label1.InnerText = currentArticolo.Nome;
                        Label2.InnerText = currentArticolo.Descrizione;
                        Label3.InnerText = currentArticolo.GetFormattedPrezzo();
                        Image1.ImageUrl = currentArticolo.Immagine;


                        Session["CurrentArticolo"] = currentArticolo;
                    }
                    else
                    {
                        Response.Write("Qualcosa è andato storto");
                    }
                }
                else
                {
                    Response.Write("Qualcosa è andato storto");
                }
            }
            else
            {
                currentArticolo = Session["CurrentArticolo"] as Articolo;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (currentArticolo != null)
            {

                Carrellos.Add(new Carrello
                {
                    Nome = currentArticolo.Nome,
                    Descrizione = currentArticolo.Descrizione,
                    Prezzo = currentArticolo.Prezzo,
                    Immagine = currentArticolo.Immagine
                });


                Response.Write("Prodotto aggiunto");
            }
            else
            {

                Response.Write("Qualcosa e' andato storto");
                //Response.Redirect("Home.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello2");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}