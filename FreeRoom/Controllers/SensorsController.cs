using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeRoom.Data;
using FreeRoom.Dtos;
using FreeRoom.Entities;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace FreeRoom.Controllers
{
    [Route("api/[controller]")]
    public class SensorsController : Controller
    {
        private readonly FreeRoomContext db;
        
        public SensorsController(FreeRoomContext cxt)
        {
            db = cxt;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task Put(int id,[FromBody] DtoUpdateStatusSensorRequest value)
        {


            try
            {
                await db.Sensors.AddAsync(new Sensors()
                {
                    id = "Sensor de Teste",
                    description = "descricao da localizacao do sensor",
                    status = true


                });



                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}