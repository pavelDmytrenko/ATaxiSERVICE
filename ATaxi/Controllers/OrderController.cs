﻿    using System.Collections.Generic;
    using ATaxi.BL;
    using Microsoft.AspNetCore.Mvc;

    namespace ATaxi.Controllers
    {
        [ApiController]
        [Route("api/orders")]
        public class OrderController : Controller
        {
            private readonly IOrderService _orderService;
            public OrderController(IOrderService orderService)
            {
                _orderService = orderService;
            }
        [HttpGet]
            public IEnumerable<DL.Order> Get()
            {
                return _orderService.GetOrders();
            }

            [HttpGet("{id}")]
            public DL.Order Get(int id)
            {
                DL.Order order = _orderService.GetOrder(id);
                return order;
            }

            [HttpPost]
            public IActionResult Post(DL.Order order)
            {
                if (ModelState.IsValid)
                {
                    _orderService.AddOrder(order);
                    return Ok(order);
                }
                return BadRequest(ModelState);
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                return Ok(_orderService.DelOrder(id));
            }
        }
    }
