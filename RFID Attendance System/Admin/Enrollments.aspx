<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Enrollments.aspx.cs" Inherits="RFID_Attendance_System.Admin.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Enrollments
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    
    <div runat="server" id="fromUser">
        <div class="container">
            <div class="row mt-2">
                <div class="col-12">
                    <button type="button" class="btn btn-fill btn-info" data-toggle="modal" data-target="#exampleModal">
                        Add Enrollment <i class="fas fa-plus text-light"></i>
                    </button>
                </div>
            </div>
            <div class="row mt-2">
                <table class="table table-striped ">
                    <thead class="bg-info text-light">
                        <tr>
                            <th>Course ID</th>
                            <th>Course Name</th>
                            <th>Course CrHr</th>
                            <th>Delete Enrollment</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="showEnroll">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("CourseCode")%>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("CourseName")%>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("CourseCrHr")%>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:LinkButton runat="server" ID="delete" Text="Delete" OnClick="delete_Click" CommandArgument='<%#Eval("CourseCode")%>'><i class="fas fa-2x fa-trash-alt text-danger"></i></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h3 class="modal-title" id="exampleModalLabel">Add Enrollment</h3>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <label class="text-info">Courses</label>
                            <asp:DropDownList ID="courseList" runat="server" class="form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="save" runat="server" Text="Save" OnClick="save_Click" class="btn btn-fill btn-primary" />
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div runat="server" id="fromCourse">
        <div class="container">
            <div class="row mt-2">
                <div class="col-12">
                    <button type="button" class="btn btn-fill btn-info" data-toggle="modal" data-target="#exampleModal2">
                        Enroll User <i class="fas fa-plus text-light"></i>
                    </button>
                </div>
            </div>
            <div class="row mt-2">
                <table class="table table-striped ">
                    <thead class="bg-info text-light">
                        <tr>
                            <th>RFID</th>
                            <th>Name</th>
                            <th>Status</th>
                            <th>Delete Enrollment</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="showUser">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("UserRFID")%>'></asp:Label></td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("UserName")%>'></asp:Label></td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("UserStatus")%>'></asp:Label></td>
                                    <td>
                                        <asp:LinkButton runat="server" ID="delete" Text="Delete" OnClick="delete_Click" CommandArgument='<%#Eval("UserRFID")%>'><i class="fas fa-2x fa-trash-alt text-danger"></i></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h3 class="modal-title" id="exampleModalLabel2">Add Enrollment</h3>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <label class="text-info">User</label>
                            <asp:DropDownList ID="userList" runat="server" class="form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="saveUser" runat="server" Text="Save" OnClick="save_Click" class="btn btn-fill btn-primary" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
