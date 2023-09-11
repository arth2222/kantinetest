<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
table {
  border-collapse: collapse;
  width: 100%;
}

th, td {
  text-align: left;
  padding: 8px;
}

tr:nth-child(even){background-color: #f2f2f2}

th {
  background-color: #04AA6D;
  color: white;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Din første DB-app</h1>
        <p>Fullfør denne slik at du har et godt eksempelprosjekt for DB-app! Denne bruker vår åpne databaseserver med
            adressen glemmen.bergersen.dk,4729
        <p>Prosjekturl på git er: <a href="https://github.com/arth2222/SimpleWebAppWithDB">https://github.com/arth2222/SimpleWebAppWithDB</a> clone denne til din Visual Studio (ikke code).<br />

        <br />
        søk på etternavn<br />
        <asp:Button ID="ButtonSearchLastName" runat="server" Text="Søk" OnClick="ButtonSearchLastName_Click" />
        <br />
        <br />
        <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        <hr />
        <br />
        søk på fornavn


        <br />
        <asp:Button ID="ButtonSearchFirstName" runat="server" Text="Søk etter fornavn" OnClick="ButtonSearchFirstName_Click" />
        <br />
        <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        <br />
        <hr />
        sett inn ny person<br />
        Fornavn&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Etternavn&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PersNr<br />
        <asp:TextBox ID="TextBoxInsertFirstName" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBoxInsertLastName" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBoxInsertPersNr" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonInsertPerson" runat="server" Text="Sett inn ny person" />
        <br />
        <br />


        <hr />
        Slett person - Hvilken kolonne skal man ta utgangspunkt i? Lag knapp og tekstboks selv. Husk navnekonvensjoner.<br />
        DELETE from Person WHERE .... Sjekk w3schools for sql<br />
        <hr />
        Oppdatere en person<br />
        UPDATE... Sjekk w3schools for sql<br /><br />

        Når denne er klar skal den legges på vår webserver.
        <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
