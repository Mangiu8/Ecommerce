<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ecommerce.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <style>
      .card {
    margin-bottom: 20px;
}

.card-img-top {
    width: 100%;
    height: 200px; /* Imposta l'altezza dell'immagine */
    object-fit: cover; /* Assicura che l'immagine copra l'intera area senza distorsioni */
    border-top-left-radius: 0.25rem;
    border-top-right-radius: 0.25rem;
}

.card-body {
    padding: 1.25rem;
}

.card-title {
    margin-bottom: 0.75rem;
}

.card-text {
    margin-bottom: 1.25rem;
}

.btn {
    width: 100%;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div class="container">
          <h1>Prodotti</h1>
          <div class="row">
              <asp:Repeater ID="Repeater1" runat="server">
                  <ItemTemplate>
                      <div class="col-md-4">
                          <div class="card">
                              <img src="<%# Eval("Immagine") %>" class="card-img-top" alt="..."/>
                              <div class="card-body">
                                  <h5 class="card-title"><%# Eval("Nome") %></h5>
                                  <p class="card-text"><%# Eval("Descrizione") %></p>
                                  <p class="card-text"><strong>Prezzo:</strong> <%# Eval("Prezzo", "{0:C}") %></p>
                                  <asp:Button ID="BuyButton" runat="server" Text="Dettagli" CssClass="btn btn-primary" OnCommand="BuyButton_Click1" CommandArgument='<%# Eval("Id") %>' />
                              </div>
                          </div>
                      </div>
                  </ItemTemplate>
              </asp:Repeater>
          </div>
      </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
