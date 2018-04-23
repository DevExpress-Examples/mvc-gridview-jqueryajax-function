using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace AjaxSupport.Models {
    public class InMemoryModel {
        const int DataItemsCount = 100;

        public int ID { get; set; }
        public string Text { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public static List<InMemoryModel> GetTypedListModel() {
            List<InMemoryModel> typedList = new List<InMemoryModel>();

            Random randomizer = new Random();

            for (int index = 0; index < DataItemsCount; index++) {
                typedList.Add(new InMemoryModel() {
                    ID = index,
                    Text = "Text" + index.ToString(),
                    Quantity = randomizer.Next(1, 50),
                    Price = (decimal)Math.Round((randomizer.NextDouble() * 100), 2)
                });
            }

            return typedList;
        }
        public static DataTable GetDataTableModel() {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Text", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Price", typeof(decimal));

            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["ID"] };

            Random randomizer = new Random();

            for (int index = 0; index < DataItemsCount; index++) {
                dataTable.Rows.Add(
                    index,
                    "Text" + index.ToString(),
                    randomizer.Next(1, 50),
                    (decimal)Math.Round((randomizer.NextDouble() * 100), 2)
                );
            }

            return dataTable;
        }
    }
}
