<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_dataview.aspx.cs" Inherits="Student_Registration.Insert_dataview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="dgvStudentReg" runat="server" AutoGenerateColumns="False" Width="869px">
            <Columns>
                <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
                <asp:BoundField DataField="FatherName" HeaderText="Father Name" />
                <asp:BoundField DataField="Age" HeaderText="Age" />
                <asp:BoundField DataField="Program" HeaderText="Program" />
                <asp:BoundField DataField="Country" HeaderText="Country" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="ContactNumber" HeaderText="Contact Number" />
                <asp:BoundField DataField="Email" HeaderText="E-mail" />
                <asp:BoundField DataField="StudentID" HeaderText="Student ID" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
