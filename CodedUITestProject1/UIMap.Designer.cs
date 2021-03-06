﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            HtmlCell uIEditDetailsDeleteCell = this.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument.UIItemTable.UIEditDetailsDeleteCell;
            #endregion

            // Verify that the 'InnerText' property of 'Edit | Details | Delete' cell equals 'Edit | Details | Delete '
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIEditDetailsDeleteCellInnerText, uIEditDetailsDeleteCell.InnerText, "Link does not match");
        }
        
        /// <summary>
        /// AssertMethod2 - Use 'AssertMethod2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod2()
        {
            #region Variable Declarations
            HtmlCell uIEditDetailsDeleteCell = this.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument.UIItemTable.UIEditDetailsDeleteCell;
            #endregion

            // Verify that the 'RowIndex' property of 'Edit | Details | Delete' cell equals '1'
            Assert.AreEqual(this.AssertMethod2ExpectedValues.UIEditDetailsDeleteCellRowIndex, uIEditDetailsDeleteCell.RowIndex, "RowIndex does not match");

            // Verify that the 'ColumnIndex' property of 'Edit | Details | Delete' cell equals '3'
            Assert.AreEqual(this.AssertMethod2ExpectedValues.UIEditDetailsDeleteCellColumnIndex, uIEditDetailsDeleteCell.ColumnIndex, "ColumnIndex does not match");
        }
        
        #region Properties
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod2ExpectedValues == null))
                {
                    this.mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return this.mAssertMethod2ExpectedValues;
            }
        }
        
        public UIIndexMyASPNETApplicaWindow UIIndexMyASPNETApplicaWindow
        {
            get
            {
                if ((this.mUIIndexMyASPNETApplicaWindow == null))
                {
                    this.mUIIndexMyASPNETApplicaWindow = new UIIndexMyASPNETApplicaWindow();
                }
                return this.mUIIndexMyASPNETApplicaWindow;
            }
        }
        #endregion
        
        #region Fields
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;
        
        private UIIndexMyASPNETApplicaWindow mUIIndexMyASPNETApplicaWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Edit | Details | Delete' cell equals 'Edit | Details | Delete '
        /// </summary>
        public string UIEditDetailsDeleteCellInnerText = "Edit | Details | Delete ";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AssertMethod2ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'RowIndex' property of 'Edit | Details | Delete' cell equals '1'
        /// </summary>
        public int UIEditDetailsDeleteCellRowIndex = 1;
        
        /// <summary>
        /// Verify that the 'ColumnIndex' property of 'Edit | Details | Delete' cell equals '3'
        /// </summary>
        public int UIEditDetailsDeleteCellColumnIndex = 3;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIIndexMyASPNETApplicaWindow : BrowserWindow
    {
        
        public UIIndexMyASPNETApplicaWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Index - My ASP.NET Application";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Index - My ASP.NET Application");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIIndexMyASPNETApplicaDocument UIIndexMyASPNETApplicaDocument
        {
            get
            {
                if ((this.mUIIndexMyASPNETApplicaDocument == null))
                {
                    this.mUIIndexMyASPNETApplicaDocument = new UIIndexMyASPNETApplicaDocument(this);
                }
                return this.mUIIndexMyASPNETApplicaDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIIndexMyASPNETApplicaDocument mUIIndexMyASPNETApplicaDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIIndexMyASPNETApplicaDocument : HtmlDocument
    {
        
        public UIIndexMyASPNETApplicaDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Index - My ASP.NET Application";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Employees";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:8087/Employees";
            this.WindowTitles.Add("Index - My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public UIItemTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new UIItemTable(this);
                }
                return this.mUIItemTable;
            }
        }
        #endregion
        
        #region Fields
        private UIItemTable mUIItemTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = null;
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties[HtmlTable.PropertyNames.InnerText] = "FirstName \r\n\r\nLastName \r\n\r\nEmail \r\n\r\n\r\nS";
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "class=\"table\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "3";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "4";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "table";
            this.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("Index - My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIEditDetailsDeleteCell
        {
            get
            {
                if ((this.mUIEditDetailsDeleteCell == null))
                {
                    this.mUIEditDetailsDeleteCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIEditDetailsDeleteCell.SearchProperties[HtmlCell.PropertyNames.Id] = null;
                    this.mUIEditDetailsDeleteCell.SearchProperties[HtmlCell.PropertyNames.Name] = null;
                    this.mUIEditDetailsDeleteCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIEditDetailsDeleteCell.SearchProperties[HtmlCell.PropertyNames.InnerText] = "Edit | Details | Delete ";
                    this.mUIEditDetailsDeleteCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "";
                    this.mUIEditDetailsDeleteCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "1";
                    this.mUIEditDetailsDeleteCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "3";
                    this.mUIEditDetailsDeleteCell.FilterProperties[HtmlCell.PropertyNames.Class] = "";
                    this.mUIEditDetailsDeleteCell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "8";
                    this.mUIEditDetailsDeleteCell.WindowTitles.Add("Index - My ASP.NET Application");
                    #endregion
                }
                return this.mUIEditDetailsDeleteCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIEditDetailsDeleteCell;
        #endregion
    }
}
