<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApptest._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>현재 시간</h1>
        <p>
            <asp:Label ID="Label2" runat="server" OnLoad="Label2_Load"></asp:Label>
        </p>
        <p><a href="https://postfiles.pstatic.net/20150811_43/red4575_1439267338635DkBKR_JPEG/1.jpg?type=w2" class="btn btn-primary btn-lg">Learn stop &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Right now!</h2>
            <p>
                지금부터 외쳐 볼란다</p>
            <p>
                <a class="btn btn-default" href="https://vibe.naver.com/track/2285182">&nbsp;Now &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Grid View!</h2>
            <p>
                you can use gridview after login~
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="269px">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:Chart ID="Chart1" runat="server" OnLoad="Chart1_Load">
                    <series>
                        <asp:Series ChartType="Spline" Name="Series1" YValuesPerPoint="4">
                        </asp:Series>
                    </series>
                    <chartareas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </chartareas>
                </asp:Chart>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">use it &raquo;</a>
            </p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>Testing...</h2>
            <asp:Label ID="Label3" runat="server" Text="User ID" Font-Size="18"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="114px" BorderColor="#CCCCCC" ForeColor="Black" Height="22px"></asp:TextBox>
                &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Log In"  OnClick ="Button1_Click"/>
                <br />
            <asp:Label ID="Label4" runat="server" Text="PW" Font-Size="18pt"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="114px" Height="22px" BorderColor="#CCCCCC" ForeColor="Black" TextMode="Password"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="NEXT"  OnClick ="Button2_Click"/>
                &nbsp;<p>
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Label" Font-Size="20"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <a class="btn btn-default" href="https://localhost:44366/WebForm1"> 정말? &raquo;</a></p>
             </p>
        </div>
    </div>

</asp:Content>
