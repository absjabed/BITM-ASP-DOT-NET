<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jsOOP.aspx.cs" Inherits="JavaScriptIntroApp.jsOOP" %>

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
        var Person = function () {
            this.FirstName = "Elon";
            this.LastName = "Musk";

            this.GetFullName = function () {
                return this.FirstName + " " + this.LastName;
            };
           
        };
        Person.prototype.Country = "Canada";

        var person1 = new Person();
        console.log(person1.GetFullName());

        console.log(person1["FirstName"]);
        console.log(person1.Country);

        document.write(person1.GetFullName());
        document.write(person1["FirstName"]);
        document.write(person1.Country);

        var Vehicle = function(companyName, model, price) {
            this.Company = companyName;
            this.Model = model;
            this.Price = price;

            this.GetVehicleInfo = function() {
                return this.Company + "\n" + this.Model + "\n" + this.Price;
            };
        };

        var car = new Vehicle("AUDI", "Model-R8", "$80k");
        car.WheelNumber = 4;
        document.write(car.GetVehicleInfo());
        document.write(car.WheelNumber);

        

    </script>
</body>
</html>
