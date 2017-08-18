using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject1.PageObjects
{
    class EmployeeDelete
    {
        private UITestControl _parent;
        private const string DeleteEmpButtonValue = "Delete";
        public EmployeeDelete(UITestControl parent)
        {
            _parent = parent;
        }
        public EmployeeHome ClickDeleteButton()
        {
            var empHome = new EmployeeHome(_parent);
            var empCreateButton = Utility.GetHtmlButton(parent: _parent, value: DeleteEmpButtonValue);
            Mouse.Click(empCreateButton);
            return empHome;
        }
    }
}
