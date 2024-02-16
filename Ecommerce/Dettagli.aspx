<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="Ecommerce.Dettagli" %>
<%@ Import Namespace="Ecommerce" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Dettagli Prodotto</title>
   <style>
         body{
    background-color: palegreen;
}
       .container {
    margin-top: 20px;
}

.card {
    border: 1px solid #dee2e6;
    border-radius: 0.25rem;
    box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.15);
}

.card-body {
    padding: 1.25rem;
}

.card-title {
    font-size: 1.25rem;
    margin-bottom: 0.75rem;
}

.card-text {
    margin-bottom: 1rem;
}

.btn {
    width: 100%;
    margin-top: 10px;
}

#Button2, #Button3 {
    margin-top: 10px;
}

   </style>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
     <h1>Dettagli prodotto</h1>
     <div class="row">
             <div class="col-md-4">
                 <div class="card">
                     <asp:Image ID="Image1" runat="server" />
                     <div class="card-body">
                         <h5 id="Label1" runat="server" class="card-title"></h5>
                         <p id="Label2" runat="server" class="card-text"></p>
                         <p id="Label3" runat="server" class="card-text"><strong>Prezzo:</strong></p>
                         <asp:Button ID="Button1" runat="server" Text="Aggiungi al Carrello" OnClick="Button1_Click" />
                     <asp:Button ID="Button2" runat="server" Text="Vai al carrello" OnClick="Button2_Click" />
                     <asp:Button ID="Button3" runat="server" Text="Torna alla Home" OnClick="Button3_Click" />
                     </div>
                 </div>
             </div>
     </div>
 </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
