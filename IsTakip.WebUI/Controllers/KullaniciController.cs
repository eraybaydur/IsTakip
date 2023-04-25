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
            var kullaniciDto = _mapper.Map<List<KullaniciCreateDto>>(kullanicilar);
            
            if (kullanicilar.Count == 0 || kullanicilar is null)
            {
                ViewBag.Error = "Herhangi bir kullanıcı bulunamadı.";
            }
            return View(kullaniciDto);
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

        public async Task<IActionResult> Delete(int id)
        {
            var deletedUser = await _service.GetByIdAsync(id);
            if (deletedUser != null)
            {
                await _service.RemoveAsync(deletedUser);
                return RedirectToAction(nameof(Index));
            }
           return BadRequest("Hata!");
        }


        public async Task<IActionResult> Edit(int id)
        {
            var user = await _service.GetByIdAsync(id);
            var userDto = _mapper.Map<KullaniciCreateDto>(user);
            if (userDto != null)
            {
                return View(userDto);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(KullaniciCreateDto dto)
        {
            if (ModelState.IsValid && dto !=null)
            {
                dto.GuncellemeTarihi = DateTime.Now;
                await _service.UpdateAsync(_mapper.Map<Kullanici>(dto));
                return RedirectToAction(nameof(Index));
            }

            return View(dto);
        }

    }
}
