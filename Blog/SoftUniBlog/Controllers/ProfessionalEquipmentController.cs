﻿using SoftUniBlog.Models;
using System.Linq;
using System.Web.Mvc;

namespace SoftUniBlog.Controllers
{
    public class ProfessionalEquipmentController : Controller
    {
        // GET: ProfessionalEquipment
        public ActionResult Index()
        {
            var context = new ApplicationDbContext();
            var equipmentTypes = context.EquipmentTypes.ToList();

            ViewBag.EquipmentTypes = equipmentTypes;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        
        public ActionResult ByType(string id)
        {
            var context = new ApplicationDbContext();

            var equipments = context.Equipments.Where(a => a.Type.Name == id).ToList();

            ViewBag.Equipments = equipments;
            ViewBag.Type = id;

            return View();
        }
    }
}