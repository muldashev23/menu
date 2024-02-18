
using API.Data;
using API.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MenuController:ControllerBase
{
    private DataContext _context;
    private IMapper _mapper;
    public MenuController(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<ActionResult<List<ItemDTO>>> GetAllMenu()
    {
        return await _context.Menu.ProjectTo<ItemDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
    [HttpGet("hookah")]
    public async Task<ActionResult<List<ItemDTO>>> GetHookahMenu()
    {
        return await _context.Menu.Where(menu=>menu.Category=="Hookah").ProjectTo<ItemDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
    [HttpGet("hookahadd")]
    public async Task<ActionResult<List<ItemDTO>>> GetHookahAddMenu()
    {
        return await _context.Menu.Where(menu=>menu.Category=="HookahAdditions").ProjectTo<ItemDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
    [HttpGet("soft")]
    public async Task<ActionResult<List<ItemDTO>>> GetSoftMenu()
    {
        return await _context.Menu.Where(menu=>menu.Category=="Soft").ProjectTo<ItemDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
    [HttpGet("coffee")]
    public async Task<ActionResult<List<ItemDTO>>> GetCoffeeMenu()
    {
        return await _context.Menu.Where(menu=>menu.Category=="Coffee").ProjectTo<ItemDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
    [HttpGet("tea")]
    public async Task<ActionResult<List<ItemDTO>>> GetTeaMenu()
    {
        return await _context.Menu.Where(menu=>menu.Category=="Tea").ProjectTo<ItemDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
    [HttpGet("hotalco")]
    public async Task<ActionResult<List<ItemDTO>>> GetHotAlcoMenu()
    {
        return await _context.Menu.Where(menu=>menu.Category=="HotAlco").ProjectTo<ItemDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}
