<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="std_reg.aspx.cs" Inherits="Student_Registration.std_reg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <section id="main-content">
        <section id="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>Student Registration</h1>
                            </div>
                        </header>



                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Student ID"  runat="server"></asp:Label>
                                        <asp:TextBox runat="server"  Enabled="true" ID="txtID" CssClass="form-control input-sm" placeholder="Student ID" ></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Student Name"  runat="server"></asp:Label>
                                        <asp:TextBox runat="server"  Enabled="true" ID="txtSName" CssClass="form-control input-sm" placeholder="Student Name" ></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Father Name" runat="server"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtFName" Enabled="true" CssClass="form-control input-sm" placeholder="Father Name" ></asp:TextBox>
                                    </div>
                                </div>

                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Age" runat="server"></asp:Label>
                                        <asp:TextBox runat="server" Enabled="true" TextMode="Number" ID="txtAge" CssClass="form-control input-sm" placeholder="Age" ></asp:TextBox>
                                        <%--<asp:ListItem Text="Male"></asp:ListItem>
                                            <asp:ListItem Text="Female"></asp:ListItem>--%>
                                    </div>
                                </div>

                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Program" runat="server"></asp:Label>
                                        <asp:TextBox runat="server" Enabled="true" ID="txtProgram" CssClass="form-control input-sm" placeholder="Program" ></asp:TextBox>
                                    </div>
                                </div>

                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Country" runat="server"></asp:Label>
                                        <asp:TextBox runat="server" Enabled="true" ID="txtCountry" CssClass="form-control input-sm" placeholder="Country" ></asp:TextBox>
                                    
                                        <%--<asp:Label Text="Region" runat="server"></asp:Label>
                                        <asp:Label Text="Region" runat="server" CssClass="form-control input-sm" ></asp:Label>
                                        <asp:DropDownList runat="server">
                                            <asp:ListItem Text="India"></asp:ListItem>
                                            <asp:ListItem Text="China"></asp:ListItem>
                                            <asp:ListItem Text="Afghanistan"></asp:ListItem>
                                            <asp:ListItem Text="Bangladesh"></asp:ListItem>
                                            <asp:ListItem Text="France"></asp:ListItem>
                                        </asp:DropDownList>--%>
                                    </div>
                                </div>

                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Address" runat="server"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtAddress" Enabled="true" CssClass="form-control input-sm" placeholder="Address" ></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Contact Number" runat="server"></asp:Label>
                                        <asp:TextBox runat="server" Enabled="true" ID="txtContactNumber" TextMode="Phone" CssClass="form-control input-sm" placeholder="Contact Number" ></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="E-Mail" runat="server"></asp:Label>
                                        <asp:TextBox runat="server" Enabled="true"  TextMode="Email" ID="txtEmail" CssClass="form-control input-sm" placeholder="E-mail" ></asp:TextBox>
                                    </div>
                                </div>

                                 <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Gender:" runat="server"></asp:Label><br />

                                        <asp:RadioButton Text="Male" ID="radioMale"  runat="server" GroupName="Gender">
                                            <%--<asp:ListItem Text="Male"></asp:ListItem>
                                            <asp:ListItem Text="Female"></asp:ListItem>--%>
                                        </asp:RadioButton><br />
                                        <asp:RadioButton Text="Female" ID="radioFemale"  runat="server" GroupName="Gender"></asp:RadioButton>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-md-8 col-md-offset-2">
                                        <asp:Button Text="Insert" ID="btnInsert" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="btnSave_Click" />
                                        <asp:Button Text="Update" ID="btnUpdate" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="btnUpdate_Click" />

                                        <asp:Button Text="Delete" ID="Button2" CssClass="btn btn-danger" Width="170px" runat="server" OnClick="Button2_Click" />
                                        <asp:Button Text="Reset" ID="btnReset" CssClass="btn btn-danger" Width="170px" runat="server" OnClick="reset_click" />

                                    </div>
                                </div><br /><br />
                                <div class="col-md-4 col-md-offset-1">
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
                                         <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                        <asp:BoundField DataField="StudentID" HeaderText="Student ID" />
                                         <asp:TemplateField>
                                             <ItemTemplate>
                                                 <asp:LinkButton ID="linkSelect" Text="Select" runat="server" CommandArgument='<%# Eval("StudentID") %>' OnClick="linkSelect_Click"></asp:LinkButton>
                                             </ItemTemplate>
                                         </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </section>

    </section>



</asp:Content>
