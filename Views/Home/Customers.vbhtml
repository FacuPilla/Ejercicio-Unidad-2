@Code
    ViewData("Title") = "Customers"
End Code

<h2>@ViewData("Title")</h2>

<table class="table">
    <thead>

        <tr>
            <th>Customers</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>@Html.ActionLink("Jhon Smith", "JhonSmith", "Home")</td>
        </tr>
        <tr>
            <td>@Html.ActionLink("Mary Williams", "MaryWilliams", "Home")</td>
        </tr>

    </tbody>
</table>
