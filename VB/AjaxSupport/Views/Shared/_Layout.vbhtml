<!DOCTYPE HTML>

<html>
<head>
    <title>@ViewBag.Title</title>
        @Html.DevExpress().GetStyleSheets(
                    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors},
                    New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView})
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
        @Html.DevExpress().GetScripts(
                    New Script With {.ExtensionSuite = ExtensionSuite.Editors},
                    New Script With {.ExtensionSuite = ExtensionSuite.GridView})
</head>

<body>
    @RenderBody()
</body>
</html>
