<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndividContrInfo.aspx.cs" Inherits="WebFormsContractor.Pages.IndividContrInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /> <br/>

    <table class="nav-justified">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblTitle" runat="server" Text="Individual contractors"></asp:Label>
            </td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px">
                <asp:Label ID="lblIin" runat="server" Text="IIN"></asp:Label>
            </td>
            <td style="width: 279px">
                <asp:TextBox ID="txtIIN" runat="server" Width="178px"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
            <td rowspan="8">
                <asp:GridView ID="dgViewIndividContr" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Height="208px" Width="423px">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="iin" HeaderText="iin" SortExpression="iin" />
                        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                        <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                        <asp:BoundField DataField="created_date" HeaderText="created_date" SortExpression="created_date" DataFormatString="0:MM/dd/yyyy" />
                        <asp:BoundField DataField="edited_date" HeaderText="edited_date" SortExpression="edited_date" DataFormatString="0:MM/dd/yyyy" />
                        <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestDBConnectionString %>" SelectCommand="SELECT * FROM [Individ_contractor]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            </td>
            <td style="width: 279px">
                <asp:TextBox ID="txtName" runat="server" Width="178px"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px">
                <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
            </td>
            <td style="width: 279px">
                <asp:TextBox ID="txtAge" runat="server" Width="178px"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px; height: 33px;">
                <asp:Label ID="lblCrtDate" runat="server" Text="Created date"></asp:Label>
            </td>
            <td style="width: 279px; height: 33px;">
                <asp:TextBox ID="txtCrtDate" runat="server" Width="178px" TextMode="Date"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 100px; height: 33px;"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="height: 20px; width: 189px">
                <asp:Label ID="lblEdtDate" runat="server" Text="Edited date"></asp:Label>
            </td>
            <td style="height: 20px; width: 279px">
                <asp:TextBox ID="txtEdtDate" runat="server" Width="178px" TextMode="Date"></asp:TextBox>
            </td>
            <td class="modal-sm" style="height: 20px; width: 100px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px">
                <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            </td>
            <td style="width: 279px">
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem>Choose any</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px">
                <asp:Label ID="lblid" runat="server" Text="lblIid"></asp:Label>
            </td>
            <td style="width: 279px">
                <asp:Button ID="btnAdd" runat="server" Text="Add" Width="81px" OnClick="btnAdd_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="81px" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="81px" OnClick="btnDelete_Click" />
            </td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px">&nbsp;</td>
            <td style="width: 279px">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel Operation" Width="242px" />
            </td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px">&nbsp;</td>
            <td style="width: 279px">&nbsp;</td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px; height: 20px;"></td>
            <td style="width: 279px; height: 20px;"></td>
            <td class="modal-sm" style="width: 100px; height: 20px;"></td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 189px">&nbsp;</td>
            <td style="width: 279px">&nbsp;</td>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
