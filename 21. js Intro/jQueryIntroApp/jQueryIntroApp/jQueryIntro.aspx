<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQueryIntro.aspx.cs" Inherits="jQueryIntroApp.jQueryIntro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <button id="clickButton">Click ME</button>
        <h1 id="message">Hello jQuery</h1>

    <form id="ourForm" runat="server">
        
        <label for="name">Name: </label>
        <input type="text" id="name"/>

        <br/>

        <label for="district">District: </label>
        <select id="district">
            <option value="DHK">Dhaka</option>
            <option value="NH">Noakhali</option>
            <option value="CTG">Chittagong</option>
            <option value="SYL">Sylhet</option>
            <option value="FEN">Feni</option>
        </select>

        <br/>
        <input type="submit" value="Save"/>

    </form>

    <script src="Scripts/jquery-3.1.1.js"></script>

  
    
     <script>

         $(document).ready(function () {

             $("#clickButton").click(function () {
                 //$("#message").hide(2000);
                 $("#message").toggle(2000);
             });


             $("#clickButton").hover(function () {
                 $("#message").hide(1500);
             }, function () {
                 $("#message").show(1500);
             });


             $("#ourForm").submit(function () {
                 var name = $("#name").val();
                 var country = $("#district").val();

                 alert("Name: " + name + " District: " + country);
                 return false;
             });


         });


    </script>

</body>
</html>
