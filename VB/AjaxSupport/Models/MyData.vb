Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Data

Namespace AjaxSupport.Models
	Public Class InMemoryModel
		Private Const DataItemsCount As Integer = 100

		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateQuantity As Integer
		Public Property Quantity() As Integer
			Get
				Return privateQuantity
			End Get
			Set(ByVal value As Integer)
				privateQuantity = value
			End Set
		End Property
		Private privatePrice As Decimal
		Public Property Price() As Decimal
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Decimal)
				privatePrice = value
			End Set
		End Property

		Public Shared Function GetTypedListModel() As List(Of InMemoryModel)
			Dim typedList As New List(Of InMemoryModel)()

			Dim randomizer As New Random()

			For index As Integer = 0 To DataItemsCount - 1
				typedList.Add(New InMemoryModel() With {.ID = index, .Text = "Text" & index.ToString(), .Quantity = randomizer.Next(1, 50), .Price = CDec(Math.Round((randomizer.NextDouble() * 100), 2))})
			Next index

			Return typedList
		End Function
		Public Shared Function GetDataTableModel() As DataTable
			Dim dataTable As New DataTable()

			dataTable.Columns.Add("ID", GetType(Integer))
			dataTable.Columns.Add("Text", GetType(String))
			dataTable.Columns.Add("Quantity", GetType(Integer))
			dataTable.Columns.Add("Price", GetType(Decimal))

			dataTable.PrimaryKey = New DataColumn() { dataTable.Columns("ID") }

			Dim randomizer As New Random()

			For index As Integer = 0 To DataItemsCount - 1
				dataTable.Rows.Add(index, "Text" & index.ToString(), randomizer.Next(1, 50), CDec(Math.Round((randomizer.NextDouble() * 100), 2)))
			Next index

			Return dataTable
		End Function
	End Class
End Namespace
