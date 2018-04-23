@Html.DevExpress().GridView(
            Sub(settings)
            settings.Name = "gridView"
                settings.CallbackRouteValues = New With {
                Key .Controller = "Home",
                Key .Action = "GridViewPartial"
                }
End Sub).Bind(Model).GetHtml()