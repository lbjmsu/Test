<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <header style="text-align:center;font-family:'Berlin Sans FB'">
        <h1>Interactive To-Do List</h1>
    </header>
    <br />

    <div class="body" style="border:2px dashed black;background-color:antiquewhite">
        <div class="bodyItems" style="font-family:'Berlin Sans FB';margin-left:15px">
            <h3>Please enter your name and the items you want to do!</h3>
            <p>Enter your first and last name:</p>
            <asp:TextBox runat="server" ID="nameTextBox"></asp:TextBox>
            <br />
            <p style="margin-top:20px;margin-bottom:5px">Enter your to-do list, one per line:</p>
            <asp:TextBox runat="server" ID="itemsTextBox" Height="150px" Width="400px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="generateButton" Height="50px" Width="150px" OnClick="generateButton_Click" Text="Generate To-Do List!" />
            <div class="toDoList" style="text-align:center">
                <asp:ListBox runat="server" ID="toDoListBox" Height="150px" Width="300px"></asp:ListBox>
                <br />
                <asp:Label runat="server" ID ="doingNowLabel" Font-Size="36px">placeholder</asp:Label>
                <br />
                <asp:Button runat="server" ID="Button1" Height="50px" Width="150px" OnClick="Button1_Click" Text="Do this item!" />
            </div>
        </div>
    </div>
</asp:Content>
