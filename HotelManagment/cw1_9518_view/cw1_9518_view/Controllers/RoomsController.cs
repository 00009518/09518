using cw1_9518_view.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_9518_view.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IConfiguration configuration;
        private string ApiUrl;

        public RoomsController(IConfiguration _configuration)
        {
            configuration = _configuration;
            ApiUrl = configuration["ApiUrl"];
        }
        // GET: RoomsContrller
        public async Task<ActionResult> Index()
        {
            var service = new Services.RoomService(ApiUrl);
            return View(await service.FindAll());
        }

        // GET: RoomsContrller/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var service = new Services.RoomService(ApiUrl);
            return View(await service.FindOne(id));
        }

        // GET: RoomsContrller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomsContrller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Room collection)
        {
            if (ModelState.IsValid)
            {
                var service = new Services.RoomService(ApiUrl);
                int type = await service.Create(collection);
                if (type == 1)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }

        // GET: RoomsContrller/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var service = new Services.RoomService(ApiUrl);
            return View(await service.FindOne(id));
        }

        // POST: RoomsContrller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Room collection)
        {
            if (ModelState.IsValid)
            {
                collection.RoomId = id;
                var service = new Services.RoomService(ApiUrl);
                int type = await service.Update(collection, id);
                if (type == 1)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }

        // GET: RoomsContrller/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var service = new Services.RoomService(ApiUrl);
            Room room = await service.FindOne(id);
            return View(room);
        }

        // POST: RoomsContrller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Room collection)
        {
            var service = new Services.RoomService(ApiUrl);
            int type = await service.Delete(id);
            if (type == 1)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(collection);
        }
    }
}
