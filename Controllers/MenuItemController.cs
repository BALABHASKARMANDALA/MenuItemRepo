using MenuItemService.Models;
using MenuItemService.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(MenuItemController));
        private readonly IMenuItemRepository _menuItemRepository;
        public MenuItemController(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        // GET: api/<BankDetailsController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _log4net.Info(" Http GET is accesed");
                IEnumerable<MenuItem> menulist = _menuItemRepository.GetAll();
                return Ok(menulist);
            }
            catch
            {
                _log4net.Error("Error in Get request");
                return new NoContentResult();
            }
        }

        // GET api/<BankDetailsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                _log4net.Info("Http Get by itemid " + id + " is successfull");
                var item = _menuItemRepository.GetMenuItem(id);
                return new OkObjectResult(item);
            }
            catch
            {
                _log4net.Error("Error in Get by itemid:" + id);
                return new NoContentResult();
            }
        }
    }
}
