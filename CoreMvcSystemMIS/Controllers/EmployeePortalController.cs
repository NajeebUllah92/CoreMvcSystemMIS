using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using CoreMvcSystemMIS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreMvcSystemMIS.Controllers
{
    public class EmployeePortalController : Controller
    {
        //GET: EmployeePortal
        private readonly cmsnet_cms_uat_dbContext _context;

        public EmployeePortalController(cmsnet_cms_uat_dbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult EmployeeProfile()
        {
            return View();
        }
        public IActionResult Employeepayroll()
        {
            return View();
        }
        public IActionResult EmpPayRoll()
        {
            return View();
        }
        public IActionResult EmployeePayrollPrint()
        {
            return View();
        }
        public IActionResult Employeelogin()
        {
            return View();
        }
        public IActionResult Attendence()
        {
            
            return View();
        }
        public IActionResult Mark()
        {
            return View();
        }
        public IActionResult MarkSheet()
        {
            return View("Index");
        }
        public IActionResult AttendencePrint()
        {
            return View();
        }
        public IActionResult AttPrint()
        {
            return View();
        }
        public IActionResult NewStudent()
        {
            return View();
        }
        public IActionResult DailyAttendence()
        {
            ViewBag.organization = new SelectList(_context.OrgOrganizations, "Id", "OrgName");
            var Classs = (from x in _context.InsClasses
                         join branch in _context.OrgBranches on x.BranchId equals branch.Id
                         where x.BranchId == 5
                         select new InsClass()
                         {
                             Id = x.Id,
                             Name = x.Name
                         }).ToList();
            SelectList classitems = new SelectList(Classs, "Id", "Name");
            ViewBag.Class = classitems;

            var Teach = (from x in _context.HrmEmployees
                            join branch in _context.OrgBranches on x.BranchId equals branch.Id
                            where x.BranchId == 9
                            select new HrmEmployee()
                            {
                                Id = x.Id,
                                EmployeeName = x.EmployeeName
                            }).ToList();
            SelectList Teachlist = new SelectList(Teach, "Id", "EmployeeName");
            ViewBag.Teacher = Teachlist;

            var sessions = (from x in _context.InsSessions
                        join branch in _context.OrgBranches on x.BranchId equals branch.Id
                        where x.BranchId == 18
                        select new InsSession()
                        {
                            Id = x.Id,
                            SessionName = x.SessionName
                        }).ToList();
            SelectList sesslist = new SelectList(sessions, "Id", "SessionName");
            ViewBag.session = sesslist;

            var programlist = (from x in _context.InsPrograms
                        join branch in _context.OrgBranches on x.BranchId equals branch.Id
                        where x.BranchId == 1
                        select new InsProgram()
                        {
                            Id = x.Id,
                            Name = x.Name
                        }).ToList();
            SelectList items = new SelectList(programlist, "Id", "Name");
            ViewBag.Programe = items;

            var batchlist = (from x in _context.InsBatches
                             join branch in _context.OrgBranches on x.BranchId equals branch.Id
                             where x.BranchId == 9
                             select new InsBatch()
                             {
                                 Id = x.Id,
                                 BatchName = x.BatchName
                             }).ToList();
            SelectList batchitems = new SelectList(batchlist, "Id", "BatchName");
            ViewBag.batch = batchitems;

            
            return View();
        }
    }
}
