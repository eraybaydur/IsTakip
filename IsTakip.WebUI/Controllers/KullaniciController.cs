using AutoMapper;
using IsTakip.Core.Classes.KullaniciClasses;
using IsTakip.Core.DTOs.KullaniciDTOs;
using IsTakip.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace IsTakip.WebUI.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IService<Kullanici> _service;

        public KullaniciController(IMapper mapper, IService<Kullanici> service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var kullanicilar = _service.Where(k=> k.RolTanim != "Yönetici").ToList();
            if(kullanicilar.Count == 0 || kullanicilar is null)
            {
                ViewBag.Error = "Herhangi bir kullanıcı bulunamadı.";
            }
            return View(kullanicilar);
        }
         
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(KullaniciCreateDto dto)
        {
            await _service.AddAsync(_mapper.Map<Kullanici>(dto));
            return RedirectToAction(nameof(Index));
        }
    }
}
