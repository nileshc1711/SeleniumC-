using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject1.PageObjects
{
    class EmployeeHome
    {
        private UITestControl _parent;
        private const string EmpoyeeLinkID = "lnkEmployee";
        public EmployeeHome(UITestControl parent)
        {
            _parent = parent;
        }

        public EmployeeCreate ClickEmployeeLink()
        {
            var empCreate = new EmployeeCreate(_parent);
            var empLink = Utility.GetkLink(parent: _parent, Id: EmpoyeeLinkID);
            Mouse.Click(empLink);
            return empCreate;
        }

        public EmployeeDelete ClickDeleteEmpLink(UIMap UIMap)
        {
            var empDelete = new EmployeeDelete(_parent);
            var cell = Utility.GetHtmlCell(_parent, 
                UIMap.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument.UIItemTable.UIEditDetailsDeleteCell.RowIndex, 
                UIMap.UIIndexMyASPNETApplicaWindow.UIIndexMyASPNETApplicaDocument.UIItemTable.UIEditDetailsDeleteCell.ColumnIndex);
            var deleteLink = Utility.GetkLink(cell, "Delete");
            Mouse.Click(deleteLink);
            return empDelete;
        }
    }
}
