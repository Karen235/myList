<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<asp:GridView ID="GridView1" runat="server" Width="100%"
           AutoGenerateColumns="False">
       <Columns>
           <asp:BoundField DataField="FirstName" HeaderText="First Name"   />
           <asp:BoundField DataField="LastName" HeaderText="Last Name"   />
           <asp:BoundField DataField="Email" HeaderText="Email"  />
           <asp:TemplateField HeaderText="Address" >                
               <ItemTemplate>
                   <asp:Label ID="Label1" runat="server" Text='<%# Bind("Address") %>' ></asp:Label>
               </ItemTemplate>
           </asp:TemplateField>
           <asp:BoundField DataField="Contact" HeaderText="Contact"  />
       </Columns>
   </asp:GridView>
    </div>
    </form>
</body>
</html>
