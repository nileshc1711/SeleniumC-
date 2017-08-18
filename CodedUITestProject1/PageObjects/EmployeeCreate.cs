using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject1.PageObjects
{
    class EmployeeCreate
    {
        private UITestControl _parent;
        private const string createEmpLinkID = "lnkCreateNew";
        private const string inputEmpFirstNameId = "FirstName";
        private const string inputEmpLastNameId = "LastName";
        private const string inputEmpEmailId = "Email";
        private const string CreateEmpButtonValue = "Create";
        public EmployeeCreate(UITestControl parent)
        {
            _parent = parent;
        }

        public EmployeeCreate ClickCreateLink()
        {
            var empCreate = new EmployeeCreate(_parent);
            var empLink = Utility.GetkLink(parent: _parent, Id: createEmpLinkID);
            Mouse.Click(empLink);
            return empCreate;
        }
        public EmployeeCreate FillInputValues(string firstName, string lastName,string email)
        {
            var empCreate = new EmployeeCreate(_parent);
            var empFirstName = Utility.GetHtmlInput(_parent, inputEmpFirstNameId);
            empFirstName.Text = firstName;
            var empLastName = Utility.GetHtmlInput(_parent, inputEmpLastNameId);
            empLastName.Text = lastName;
            var empEmail = Utility.GetHtmlInput(_parent, inputEmpEmailId);
            empEmail.Text = email;
            return empCreate;
        }

        public EmployeeHome ClickCreateButton()
        {
            var empHome = new EmployeeHome(_parent);
            var empCreateButton = Utility.GetHtmlButton(parent: _parent, value: CreateEmpButtonValue);
            Mouse.Click(empCreateButton);
            return empHome;
        }
    }
}
