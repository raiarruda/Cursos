using AutoMapper;
using Cursos.Data;
using Cursos.Models;
using Cursos.Models.Entidades;
using Cursos.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cursos.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public HomeController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            List<Curso> cursos = _context.Curso.ToList();
            List<PostagemBlog> postagens = _context.PostagemBlogs.ToList();

            homeViewModel.Cursos = _mapper.Map<List<CursoViewModel>>(cursos);
            homeViewModel.Postagens = _mapper.Map<List<PostagemBlogViewModel>>(postagens);

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}