using System.Reflection;
using System.Threading;
using System;

@model List<YourNamespace.Models.Department>

<h2>Department List</h2>

<table class= "table" >
    < thead >
        < tr >
            < th > ID </ th >
            < th > Name </ th >
            < th > Code </ th >
            < th > Address </ th >
            < th > Room Number </ th >
            < th > Actions </ th >
        </ tr >
    </ thead >
    < tbody >
        @foreach(var department in Model)
        {
            < tr >
                < td > @department.Id </ td >
                < td > @department.DepartmentName </ td >
                < td > @department.DepartmentCode </ td >
                < td > @department.Address </ td >
                < td > @department.RoomNumber </ td >
                < td >
                    < a asp - action = "Edit" asp - route - id = "@department.Id" > Edit </ a > |
                    < a asp - action = "Delete" asp - route - id = "@department.Id" > Delete </ a >
                </ td >
            </ tr >
        }
    </ tbody >
</ table >
