using AutoMapper;
using IsTakip.Core.Classes.KullaniciClasses;
using IsTakip.Core.DTOs.KullaniciDTOs;
using IsTakip.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IsTakip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Kullanici> _service;

        public KullaniciController(IMapper mapper, IService<Kullanici> service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var kullanicilar = await _service.GetAllAsync();
            
            return Ok(kullanicilar);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var kullanici = await _service.GetByIdAsync(id);
            var kullaniciDto = _mapper.Map<KullaniciCreateDto>(kullanici);
            return Ok(kullaniciDto);
        }

        [HttpPost]
        public async Task<IActionResult> KullaniciEkle(KullaniciCreateDto dto)
        {
            var kullanici = await _service.AddAsync(_mapper.Map<Kullanici>(dto));
            return Ok(kullanici);
        }

        [HttpPut]
        public async Task<IActionResult> Guncelle(KullaniciCreateDto dto)
        {
            await _service.UpdateAsync(_mapper.Map<Kullanici>(dto));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Sil(int id)
        {
            var kullanici = await _service.GetByIdAsync(id);
            if(kullanici != null)
            {
                await _service.RemoveAsync(kullanici);
                return Ok();

            }
            return BadRequest("Böyle bir kullanıcı bulunamadı.");
                
        }
    }
}
