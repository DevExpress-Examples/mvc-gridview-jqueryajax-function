<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128567137/20.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4063)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Grid View for APS.NET MVC - How to use the jQuery.ajax function with DevExpress MVC extensions



This example demonstrates how to use the [jQuery.ajax](https://api.jquery.com/jquery.ajax/) function to load the [GridView extension](https://docs.devexpress.com/AspNetMvc/8966/components/grid-view) on a callback.

![A sample grid](images/grid-created-on-callback.png)

In this example, we handle a button's [Click](https://docs.devexpress.com/AspNet/DevExpress.Web.ButtonClientSideEvents.Click) event to call the `$.ajax()` function. The function sends an AJAX (asynchronous HTTP) request to the [GridViewPartial action](https://github.com/DevExpress-Examples/mvc-gridview-jqueryajax-function/blob/aefdc4cc44f29d8f03a8a4a0ed518bccb9143b48/CS/AjaxSupport/Controllers/HomeController.cs#L13) and renders the action result ([GridViewPartial.cshtml](./CS/AjaxSupport/Views/Home/GridViewPartial.cshtml)) to the `div` container.

```cshtml
<script type="text/javascript">
    function OnClick(s, e) {
        $.ajax({
            type: "POST",
            url: "@Url.Action("GridViewPartial")",
            success: function(response) {
                $("#container").html(response);
            }
        });
    }
</script>
@Html.DevExpress().Button(settings => {
    settings.Name = "MyButton";
    settings.Text = "Click Me!!!";
    settings.ClientSideEvents.Click = "OnClick";
}).GetHtml()
```

## Files to Look At

* [Index.cshtml](./CS/AjaxSupport/Views/Home/Index.cshtml)(VB: [Index.vbhtml](./VB/AjaxSupport/Views/Home/Index.vbhtml))
* [HomeController.cs](./CS/AjaxSupport/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/AjaxSupport/Controllers/HomeController.vb))
* [GridViewPartial.cshtml](./CS/AjaxSupport/Views/Home/GridViewPartial.cshtml)(VB: [GridViewPartial.vbhtml](./VB/AjaxSupport/Views/Home/GridViewPartial.vbhtml))

## Documentation

* [GridViewExtension](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.GridViewExtension)
* [ButtonSettings.ClientSideEvents](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.ButtonSettings.ClientSideEvents)

## More Examples

* [How to use the GridView extension in Full Screen mode (100% browser Width and Height)](https://github.com/DevExpress-Examples/how-to-use-the-gridview-extension-in-a-full-screen-mode-100-browser-width-and-height-e3958)
* [GridView - How to edit in memory data source](https://github.com/DevExpress-Examples/gridview-how-to-edit-in-memory-data-source-e3983)
* [How to bind GridView to XPO in Server Mode](https://github.com/DevExpress-Examples/how-to-bind-gridview-to-xpo-in-server-mode-e2836)
* [How to load MVC extensions using the CallbackPanel extension](https://github.com/DevExpress-Examples/how-to-load-mvc-extensions-using-the-callbackpanel-extension-e2927)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-gridview-jqueryajax-function&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-gridview-jqueryajax-function&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
