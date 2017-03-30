<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="UniversityStudentWebApp.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bootstrap with ASP.NET</title>
    <meta charset="utf-8"/>
   <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
    <div class="container-fluid">
       <fieldset>
           <legend>Student info.</legend>
        <div><table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Registration No: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="registrationNoTextBox" runat="server"></asp:TextBox></td>
                </tr>
            <tr><td>
                <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
            </td><td>
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            </td></tr>
            <tr><td>
                <asp:Label ID="Label3" runat="server" Text="Contact No: "></asp:Label>
            </td><td>
                <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox>
            </td></tr>
            <tr><td>
                <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label>
            </td><td>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            </td></tr>
            <tr><td>
                <asp:Label ID="Label5" runat="server" Text="Department Name: "></asp:Label>
            </td><td>
                <asp:TextBox ID="departmentTextBox" runat="server"></asp:TextBox>
            </td></tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" Width="130px" OnClick="saveButton_Click" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="messageLabel" runat="server" Text="#####"></asp:Label></td>
            </tr>
            </table>
        </div>
           
           
           
           
           
           
           <div class="row">
        <div class="col-sm-4" >
            <label for="Username">Username</label>
            <input id="Username" name="UsrName" type="text" class="form-control" value=""/>
        </div>
        <div class="col-sm-4" >
            <label for="Start">Start</label>
            <input id="Start" type="text" runat="server" class="form-control" value=""/>
        </div>
    </div>
    <br/>
    <div class="row">
        <div class="col-sm-4" >
            <label for="Client">Client</label>
            <input id="Client" type="text" class="form-control"/>
        </div>
        <div class="col-sm-4" >
            <label for="DurationHours">Duration (Hours)</label>
            <input id="DurationHours" type="text" class="form-control"/>
        </div>
    </div>
    <br/>
    <div class="row">
        <div class="col-sm-4" >
            <label for="Category">Category</label>
            <select id="Category" class="form-control">
                <option>Meeting</option>
                <option>Administration</option>
                <option>Analysis/Design</option>
                <option>Development</option>
                <option>Testing</option>
            </select>
        </div>
        <div class="col-sm-4" >
            <label for="DurationMinutes">Duration (Minutes)</label>
            <input id="DurationMinutes" type="text" class="form-control"/>
        </div>
    </div>
    <br/>
    <div class="row">
        <div class="col-sm-8" >
            <label for="Notes">Notes</label>
            <textarea id="Notes" rows="5" class="form-control"></textarea>
        </div>
    </div>
    <br/>
    <div class="row">
        <div class="col-sm-8" >
            <button  type="button" runat="server" class="btn btn-success btn-lg" OnServerClick="SubmitButton_Click">
                <span class="glyphicon glyphicon-send" aria-hidden="true"></span>
                Submit
            </button>
        </div>
    </div>   

          
          
           

           </fieldset>
        
        <div class="row">
    <div class="col-md-4" style="background-color:pink;">
       Of all the animals in the world, my favorite is the sphynx.
    </div>
    <div class="col-md-4" style="background-color:papayawhip;">
       Of all the vegetables in the world, my favorite is the loofah.
    </div>
    <div class="col-md-4" style="background-color:paleturquoise;">
       Of all the minerals in the world, my favorite is the goosecreekite.
    </div>
 </div>

    </div>
    </form>
    
    <form>
        <div class="container-fluid">
   <fieldset >
       <legend>Bootstrap Practice</legend>
       <h1>Time Entry</h1>
       <table>
           <tr>
               <td>
                    Username: 
               </td>
               <td>
                   <input id="Username" type="text" /><br/>
               </td>
           </tr>
<tr>
               <td>
                    Client:
               </td>
               <td>
                    <input id="Client" type="text" /><br/>
               </td>
           </tr>
<tr>
               <td>
                    Category:
               </td>
               <td>
                   <select id="Category">
            <option>Meeting</option>
            <option>Administration</option>
            <option>Analysis/Design</option>
            <option>Development</option>
            <option>Testing</option>
        </select>
               </td>
           </tr>
<tr>
               <td>
                   Start:
               </td>
               <td>
                    <input id="Start" type="text" />
               </td>
           </tr>
<tr>
               <td>
                   Duration:
               </td>
               <td>
                    <input id="DurationHours" type="text" /> hours,<br/>
               </td>
    <td>
        <input id="DurationMinutes" type="text" /> minutes
    </td>
           </tr>
<tr>
               <td>
                   Notes:
               </td>
               <td>
                   <textarea id="Notes" cols="20" rows="2"></textarea>
               </td>
           </tr>
<tr>
    <td></td>

               <td>
                    <input id="Submit" type="submit" value="Submit" />
               </td>
               <td>
                   
               </td>
           </tr>
       </table>
<%--    Username: <br/>
        <input id="Username" type="text" /><br/>
    Client: <br/>
        <input id="Client" type="text" /><br/>
    Category: <br/>
        <select id="Category">
            <option>Meeting</option>
            <option>Administration</option>
            <option>Analysis/Design</option>
            <option>Development</option>
            <option>Testing</option>
        </select><br/>
    Start: <br/>
        <input id="Start" type="text" /><br/>
    Duration: <br/>
        <input id="DurationHours" type="text" /> hours, <br/>
        <input id="DurationMinutes" type="text" /> minutes<br />
    Notes: <br/>
        <textarea id="Notes" cols="20" rows="2"></textarea> <br/>
    <br/>
    <input id="Submit" type="submit" value="Submit" />--%>
   </fieldset>
            </div>
        </form>
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
