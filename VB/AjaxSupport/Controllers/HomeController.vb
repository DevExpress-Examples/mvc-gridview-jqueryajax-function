Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports AjaxSupport.Models

Namespace AjaxSupport.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function GridViewPartial() As ActionResult
			Return PartialView("GridViewPartial", InMemoryModel.GetDataTableModel())
		End Function
	End Class
End Namespace