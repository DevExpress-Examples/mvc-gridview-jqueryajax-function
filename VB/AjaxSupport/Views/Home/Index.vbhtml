<script type="text/javascript">
    function OnClick(s, e) {
        $.ajax({
            type: "POST",
            url: "/Home/GridViewPartial",
            success: function(response) {
                $("#container").html(response);
            }
        });
    }
</script>

@Html.DevExpress().Button(Sub(settings)
                              settings.Name = "MyButton"
                              settings.Text = "Click Me!!!"
                              settings.ClientSideEvents.Click = "OnClick"
                          End Sub).GetHtml()
<div id="container" class="container">
</div>