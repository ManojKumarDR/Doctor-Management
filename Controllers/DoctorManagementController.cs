using DoctorSampleApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorSampleApp.Controllers
{
    public class DoctorManagementController : Controller
    {
        public IActionResult Index()
        {

            ManojkumarDRContext _context = new ManojkumarDRContext();
            var model = _context.DoctorTable.ToList();
            return View(model);
        }
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Id must be set");
            int aId = int.Parse(id);
            ManojkumarDRContext context = new ManojkumarDRContext();
            var model = context.DoctorTable.FirstOrDefault((a) => a.DoctorId == aId);
            if (model == null) throw new Exception("Customer not found");
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(DoctorTable model)
        {
            ManojkumarDRContext _context = new ManojkumarDRContext();
            var selected = _context.DoctorTable.FirstOrDefault((a) => a.DoctorId == model.DoctorId);
            if (selected == null) throw new Exception("Failed to get the Customer details");
            selected.DoctorImage = model.DoctorImage;
            selected.DoctorName = model.DoctorName;
            selected.DoctorDept = model.DoctorDept;
            selected.DoctorFees = model.DoctorFees;
            _context.SaveChanges();
            return RedirectToAction("Index");





        }

        public IActionResult AddNew()
        {
            return View(new DoctorTable());
        }
        [HttpPost]
        public IActionResult AddNew(DoctorTable model)
        {
            ManojkumarDRContext _context = new ManojkumarDRContext();
            _context.DoctorTable.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("ID Must be set");
            int CId = int.Parse(id);
            ManojkumarDRContext _context = new ManojkumarDRContext();
            var model = _context.DoctorTable.FirstOrDefault((e) => e.DoctorId == CId);

            if (model == null) throw new Exception("Customer not found");

            _context.DoctorTable.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
