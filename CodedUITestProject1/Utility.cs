using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUITestProject1
{
    class Utility
    {
        public static HtmlHyperlink GetkLink(UITestControl parent, string Id)
        {
            var htmlLink = new HtmlHyperlink(parent);
            htmlLink.SearchProperties.Add(HtmlControl.PropertyNames.Id, Id);
            return htmlLink;

        }

        public static HtmlEdit GetHtmlInput(UITestControl parent, string Id)
        {
            var htmlInput = new HtmlEdit(parent);
            htmlInput.SearchProperties.Add(HtmlControl.PropertyNames.Id, Id);
            return htmlInput;
            
        }

        public static HtmlInputButton GetHtmlButton(UITestControl parent, string value)
        {
            var htmlButton = new HtmlInputButton(parent);
            htmlButton.SearchProperties.Add(HtmlControl.PropertyNames.ValueAttribute, value);
            return htmlButton;
        }

        
        public static HtmlCell GetHtmlCell(UITestControl parent,int rowIndex,int colIndex)
        {
            var htmlCell = new HtmlCell(parent);
            htmlCell.SearchProperties.Add(HtmlCell.PropertyNames.RowIndex, rowIndex.ToString());
            htmlCell.SearchProperties.Add(HtmlCell.PropertyNames.ColumnIndex, colIndex.ToString());
            return htmlCell;
        }
    }
}
