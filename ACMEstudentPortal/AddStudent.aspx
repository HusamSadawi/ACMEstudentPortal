<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="ACMEstudentPortal.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="//code.jquery.com/jquery-1.12.4.js"></script>
  <script src="//code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>
    $(document).ready(function(){
         $('.datepicker-field').datepicker();        
    });
</script>
   <table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <th  colspan="3">
       <p align="center">Add New Student</p>
        </th>
    </tr>
    <tr>
        <td>
            Full Name:
        </td>
        <td>
            <asp:TextBox ID="textName" runat="server" />
        </td>
        <td style="width: 683px">
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="textName"
                runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Email
        </td>
        <td>
            <asp:TextBox ID="textEmail" runat="server" />
        </td>
        <td style="width: 683px">
            <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Red"
                ControlToValidate="textEmail" runat="server" />
            <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ControlToValidate="textEmail" ForeColor="Red" ErrorMessage="Invalid email address." />
        </td>
    </tr>
    <tr>
        <td>
            Gender
        </td>
        <td>
            <asp:RadioButtonList id="textGender"  runat="server"  >
                    <asp:ListItem Text="Male" Value=Male Selected="true" />
                    <asp:ListItem Text="Female" Value=Female />
                    </asp:RadioButtonList>
        </td>
      
    </tr>
    <tr>
        <td>
            Date of Birth
        </td>
        <td>
         <asp:textbox ID="textDate" runat="server" cssclass="datepicker-field" />
 
        </td>
        <td>
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="textDate"
                runat="server" />
        </td>
       
    </tr>

       <tr>
           <td>
               Nationality
           </td>
           <td>
                <asp:TextBox ID="textNationality" runat="server"  />
           </td>

            <td style="width: 683px">
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="textNationality"
                runat="server" />
        </td>

       </tr>

        <tr>
           <td>
               Mobile
           </td>
           <td>
                <asp:TextBox ID="textMobile" runat="server" />
           </td>

            <td style="width: 683px">
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="textMobile"
                runat="server" />
        </td>

       </tr>

        <tr>
           <td>
               Course
           </td>
           <td>
                <asp:TextBox ID="textCourse" runat="server" />
           </td>

            <td style="width: 683px">
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="textCourse"
                runat="server" />
        </td>

       </tr>

        <tr>
           <td>
               Graduation Year
           </td>
           <td>
                <asp:TextBox ID="textGraduation" runat="server" MaxLength =4/>
           </td>

            <td style="width: 683px">
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="textGraduation"
                runat="server" />
                <asp:RangeValidator runat="server" Type="Integer" 
MinimumValue="1900" MaximumValue="3000" ControlToValidate="textGraduation" 
ErrorMessage="Year must be between 1900 and 3000" />
        </td>

       </tr>

         <tr>
           <td>
               Major
           </td>
           <td>
                <asp:TextBox ID="textMajor" runat="server" />
           </td>

            <td style="width: 683px">
            <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="textMajor"
                runat="server" />
        </td>

       </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:Button Text="Add Student" runat="server" OnClick="addStudent" />
        </td>
        <td style="width: 683px">
        </td>
    </tr>
     
</table>
</asp:Content>
