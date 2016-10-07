using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TeamDraw 
{ 

    [EnableCors("AllowWebClient")]
    public class DrawingController : Controller
    {
        public static List<DrawingObject> objects = new List<DrawingObject>();

        [Route("api/line/{x1}/{y1}/{x2}/{y2}/{color}")]
        public IActionResult Line(int x1, int y1, int x2, int y2, string color)
        {
            var newObject = new Line(x1, y1, x2, y2, color);
            objects.Add(newObject);
            return Ok(newObject);
        }

        [Route("api/circle/{x}/{y}/{radius}/{color}")]
        public IActionResult Circle(int x, int y, int radius, string color)
        {
            var newObject = new Circle(x, y, radius, color);
            objects.Add(newObject);
            return Ok(newObject);
        }

        [Route("api/getObjects")]
        public IActionResult GetObjects()
        {
            return Ok(objects);
        }

        [Route("api/getCanvasSize")]
        public IActionResult GetCanvasSize()
        {
            int maxX = 0;
            int maxY = 0;
            foreach (var item in objects)
            {
                maxX = Math.Max(maxX, item.GetMaxX());
                maxY = Math.Max(maxY, item.GetMaxY());
            }
            return Ok(new { X = maxX + 5, y = maxY + 5 });
        }
    }
}
