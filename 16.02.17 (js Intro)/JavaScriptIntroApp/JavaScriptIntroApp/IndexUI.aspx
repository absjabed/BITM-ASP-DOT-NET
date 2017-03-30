<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="JavaScriptIntroApp.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    <script>
        var ourVariable = 65;
        console.log(ourVariable);
        console.log(typeof ourVariable);
        Array1 = ["jamil", "Annan", "Dharubo"];
        ourVariable = ["Jamila", 25, 2.6, true, Array1,ourVariable];

        for (var element in ourVariable) {
            console.log(ourVariable[element]);
            console.log(typeof element);
            document.write(" " + ourVariable[element]);
               //if (ourVariable[element]===Array) {
              //    for (var element in Array1) {
             //        document.write(" " + Array1[element]);
            //    }
           // }
        }
    </script>
</body>
</html>
