<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
    <style type="text/css">
        #address {
            width: 295px;
        }
        #email {
            width: 266px;
        }
        #phone {
            width: 168px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="firstName">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Staff Registration Page<br />
            <br />
            First Name:</label>
            <input type="text" id="firstName" name="firstName" required />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <label for="lastName">Last Name:</label>
            <input type="text" id="lastName" name="lastName" required />
        </div>
        <div>
        </div>
        <div>
            <label for="address">Address:</label>
            <input type="text" id="address" name="address" required />
        </div>
        <div>
            <label for="email">Email:</label>
            <input type="email" id="email" name="email" required />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <div>
            <label for="phone">Phone:</label>
            <input type="tel" id="phone" name="phone" required />
        </div>
        <div>
            <label for="gender">Gender:</label>
            <select id="gender" name="gender">
                <option value="male" selected>Male</option>
                <option value="female">Female</option>
                <option value="Other">Other</option>
            </select>
        </div>
        <div>
            Data Entry Date<label for="dateAdded">:</label>
            <input type="date" id="dateAdded" name="dateAdded" required />
        </div>
        
        <div>
            <input type="submit" value="Submit" />
            <input type="button" value="Staff List" onclick="location.href='Stafflist.aspx';" />
        </div>
    </form>

    <p>
        &nbsp;</p>
</body>
</html>
