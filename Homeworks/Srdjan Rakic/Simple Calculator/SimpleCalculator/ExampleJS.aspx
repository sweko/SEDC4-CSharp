<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Example.aspx.vb" Inherits="Example" MasterPageFile="~/ourmasterpage.master" %>
<%@ MasterType VirtualPath="~/ourmasterpage.master" %>

<%--This head and links are uneccessary because this is the code from the master file, but I wanted you to be able to see it.--%>
<%--This is where we reference out AJAX script manager as well.  We've also moved a lot of our Register statements to be universal in the web.config file.--%>
<head id="Head1" runat="server">
    <link rel="stylesheet" href="/css/bootstrap.min.css" />
    <link rel="stylesheet" href="/css/main.css" />
    <link rel="stylesheet" href="/css/G3.css" />
    <script src="/scripts/G3.js"></script>
</head>

<asp:Content ID="JavaContent" ContentPlaceHolderID="HtmlHeadPlaceholder" runat="server">
    <script type="text/javascript">

        //Simply opens the appropriate page when certain parameters are passed.
        //In this example, it would open emailClientConcierge.aspx?tid=3 (or some number) in a popup window sized 680x800, and so on with those attributes below.
        function openTravelerEmailOrContact(tid, page) {
            newWindow = window.open(page + ".aspx?tid=" + tid, "newwin", "height=680,width=800,top=0,left=0,toolbars=no,scrollbars=yes,status=no,resizable=yes");
            try {
                newWindow.focus();
            } catch (err) {
                //Not very efficient, because if the try fails for some other reason, it will send the same alert, but advancing this is low priority.
                alert("You have to disable the pop-up blocker in order to view this page!");
            }
        }

    </script>
</asp:Content>

<%--Pulled in the master page so that I could override the ContentPlaceHolders with whatever I need.--%>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <div class="row-fluid">
        <table>
            <tr>
                <td> <%--I've pulled this directly from our code and left it as is just to show how we retrive the JS.
                    Retrieve the Databound value/s with an Eval, then on-click, NavigateURL is triggered.  String.Format is used to build the correct parameters as needed and
                    pass them to the script.--%>
                    Email:&nbsp;
                    <asp:HyperLink ID="hlEmail" runat="server" Font-Underline="true" Font-Bold="true" ForeColor="#990000" Text='<%#Eval("travelerEmail")%>' 
                        NavigateUrl='<%# String.Format("JavaScript:G3.openTravelerEmailOrContact(""{0}"", ""{1}"")", Eval("travelerID"), "emailClientConcierge")%>'></asp:HyperLink>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>