using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Device.Gpio;


namespace Led_Api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class LedController : ControllerBase
    {
        // GET: /Led/blink
        [HttpGet("blink")]
        public async Task Blink()
        {

            int ledPin = 21;
            using (GpioController controller = new GpioController())
            {
                controller.OpenPin(ledPin, PinMode.Output);
                controller.Write(ledPin, PinValue.High);
                await Task.Delay(3000);
                controller.Write(ledPin, PinValue.Low);

            }



        }

        // GET: /Led/on
        [HttpGet("on")]
        public void LedOn()
        {
            int ledPin = 21;
            GpioController controller = new GpioController();

            controller.OpenPin(ledPin, PinMode.Output);
            controller.Write(ledPin, PinValue.High);


        }

        // POST: api/off
        [HttpGet("off")]
        public void LedOff()
        {

            int ledPin = 21;
            GpioController controller = new GpioController();

            controller.OpenPin(ledPin, PinMode.Output);

            controller.Write(ledPin, PinValue.Low);




        }

    }
}
