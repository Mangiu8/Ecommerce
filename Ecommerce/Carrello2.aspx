<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello2.aspx.cs" Inherits="Ecommerce.Carrello2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
     <h1>Carrello</h1>
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
                         </div>
                     </div>
                 </div>
             </ItemTemplate>
         </asp:Repeater>
     </div>
 </div>
    </form>
</body>
</html>
