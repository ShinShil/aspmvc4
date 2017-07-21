using eManager.Domain;
using eManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentID = departmentId;

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single(d => d.Id == model.DepartmentID);
                var employee = new Employee()
                {
                    Name = model.Name,
                    HireDate = model.HireDate
                };
                department.Employess.Add(employee);

                _db.Save();

                return RedirectToAction("detail", "department", new { id = model.DepartmentID });
            }
            return View(model);
        }
    }
}