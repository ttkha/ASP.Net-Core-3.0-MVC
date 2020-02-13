﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TKBakery.Models;
using TKBakery.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TKBakery.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieReponsitory, ICategoryRepository categoryReponsitory)
        {
            _pieRepository = pieReponsitory;
            _categoryRepository = categoryReponsitory;
        }

        //public ViewResult List()
        //{
        //    PiesListViewModel piesListViewModel = new PiesListViewModel();
        //    piesListViewModel.Pies = _pieRepository.AllPies;

        //    piesListViewModel.CurrentCategory = "Chess cakes";
        //    return View(piesListViewModel);
        //}

        public IActionResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category).OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategoryies.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory

            });
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);

        }
    }
}
