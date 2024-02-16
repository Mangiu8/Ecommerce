using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public class Articolo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string Immagine { get; set; }
        public string GetFormattedPrezzo()
        {
            return Prezzo.ToString("C2");
        }
    }

    public partial class Home : System.Web.UI.Page
    {
        static public List<Articolo> listaArticoli = new List<Articolo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaArticoli.Clear();
                listaArticoli.Add(new Articolo { Id = 1, Nome = "Playstation 5", Descrizione = "Descrizione articolo 1", Prezzo = 499.99m, Immagine = "Content/img/play5.jpeg" });
                listaArticoli.Add(new Articolo { Id = 2, Nome = "Xbox One", Descrizione = "Descrizione articolo 2", Prezzo = 299.99m, Immagine = "Content/img/xbox.jpeg" });
                listaArticoli.Add(new Articolo { Id = 3, Nome = "Playstation 4", Descrizione = "Descrizione articolo 3", Prezzo = 150.75m, Immagine = "Content/img/play4.jpeg" });
                listaArticoli.Add(new Articolo { Id = 4, Nome = "Nintendo Switch", Descrizione = "Descrizione articolo 4", Prezzo = 249.99m, Immagine = "Content/img/switch.jpeg" });
                listaArticoli.Add(new Articolo { Id = 5, Nome = "PC Gaming", Descrizione = "Descrizione PC Gaming", Prezzo = 899.99m, Immagine = "Content/img/pc.jpeg" });
                listaArticoli.Add(new Articolo { Id = 6, Nome = "Smartphone", Descrizione = "Descrizione Smartphone", Prezzo = 699.99m, Immagine = "Content/img/download.jpeg" });
                listaArticoli.Add(new Articolo { Id = 7, Nome = "Smart TV", Descrizione = "Descrizione Smart TV", Prezzo = 799.99m, Immagine = "Content/img/smart.jpeg" });
                listaArticoli.Add(new Articolo { Id = 8, Nome = "MacBook Pro", Descrizione = "Descrizione MacBook Pro", Prezzo = 1299.99m, Immagine = "Content/img/mac.jpeg" });
                listaArticoli.Add(new Articolo { Id = 9, Nome = "Cuffie Wireless", Descrizione = "Descrizione Cuffie Wireless", Prezzo = 199.99m, Immagine = "Content/img/cuffie.jpeg" });
                listaArticoli.Add(new Articolo { Id = 10, Nome = "Fotocamera DSLR", Descrizione = "Descrizione Fotocamera DSLR", Prezzo = 799.99m, Immagine = "Content/img/foto.jpeg" });
                listaArticoli.Add(new Articolo { Id = 11, Nome = "Drone", Descrizione = "Descrizione Drone", Prezzo = 499.99m, Immagine = "Content/img/drone.jpeg" });
                listaArticoli.Add(new Articolo { Id = 12, Nome = "Soundbar", Descrizione = "Descrizione Soundbar", Prezzo = 299.99m, Immagine = "Content/img/sound.png" });
                listaArticoli.Add(new Articolo { Id = 13, Nome = "Monitor Ultrawide", Descrizione = "Descrizione Monitor Ultrawide", Prezzo = 599.99m, Immagine = "Content/img/monitor.jpeg" });
                listaArticoli.Add(new Articolo { Id = 14, Nome = "Stampante Multifunzione", Descrizione = "Descrizione Stampante Multifunzione", Prezzo = 199.99m, Immagine = "Content/img/stamp.jpeg" });
                Repeater1.DataSource = Home.listaArticoli;
                Repeater1.DataBind();
            }
        }

        protected void BuyButton_Click1(object sender, CommandEventArgs e)
        {
            Button button = (Button)sender;
            string itemId = button.CommandArgument;
            Response.Redirect($"Dettagli.aspx?id={itemId}");
        }
    }
}
