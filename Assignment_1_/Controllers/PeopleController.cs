using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Assignment_1_.DataAccess;
using Assignment_1_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Assignment_1_.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PeopleController : ControllerBase
	{
        
        public static string text { get; set; } 
        public static List<Adult> adultList { get; set; }
        private List<User> users;
        public PeopleController()
		{
            //text = System.IO.File.ReadAllText(@"adultsAPI.json");
            //adultList = JsonConvert.DeserializeObject<List<Adult>>(text);
            users = new[]
            {
                new User
                {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Teacher",
                    BirthYear = 1986,
                    SecurityLevel = 4,
                    UserName = "Troels"
                },
                new User
                {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "654321",
                    Role = "Student",
                    BirthYear = 1998,
                    SecurityLevel = 2,
                    UserName = "Jakob"
                }
            }.ToList();
        }
        
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<Adult>>> Get()
        {
            List<Adult> adultList = new List<Adult>();
            //adultList = JsonConvert.DeserializeObject<List<Adult>>(text);
            
            using AdultsDBContext dbContext = new AdultsDBContext();
            adultList = await dbContext.Adults.Include(p => p.JobTitle).ToListAsync();
            
            /*foreach (var a in adultList)
            {
                Console.WriteLine(a.FirstName +" / "+a.JobTitle.JobTitle);
            }*/

            /*foreach (var a in adultList)
            {
                await dbContext.Adults.AddAsync(a);
                await dbContext.SaveChangesAsync();
            }*/
            return Ok(adultList);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Adult>> GetSingle(int id)
        {
            using AdultsDBContext dbContext = new AdultsDBContext();
            Adult returnAdult = await dbContext.Adults.Include(p => p.JobTitle).FirstAsync(a => a.Id == id);
            return Ok(returnAdult);
        }
        
        [HttpGet("{userName}/{password}")] 
        public ActionResult<Adult> ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }
            return Ok(first);
        }

        [HttpPost("AddAdult")]
        public async Task<ActionResult<List<Adult>>> AddAdult(Adult newAdult)
        {
            //adultList.Add(newAdult);
            /*string json = JsonConvert.SerializeObject(adultList);
            System.IO.File.WriteAllText(@"adultsAPI.json", json);*/
            
            using AdultsDBContext dbContext = new AdultsDBContext();
            await dbContext.Adults.AddAsync(newAdult);
            await dbContext.SaveChangesAsync();
            return Ok(adultList);
        }

        [HttpPut("ModifyAdult")]
        public async void ModifyAdult(Adult MAdult)
        {
            using AdultsDBContext dbContext = new AdultsDBContext();
            dbContext.Adults.Update(MAdult);
            await dbContext.SaveChangesAsync();
            //return Ok(adultList);
        }

        [HttpDelete("DeleteAdult/{id}")]
        public async Task<ActionResult<List<Adult>>> deleteAdult(int id)
        {
            using AdultsDBContext dbContext = new AdultsDBContext();
            Adult adultToDelete = await dbContext.Adults.Include(p => p.JobTitle).FirstAsync(a => a.Id == id);
            //Console.WriteLine(adultToDelete.JobTitle.Id+" / "+adultToDelete.FirstName);
            
            Job jobToDelete = await dbContext.Joblist.FirstAsync(a => Equals(a.Id, adultToDelete.JobTitle.Id));
            //Console.WriteLine(adultToDelete.JobTitle+" / "+jobToDelete.Id +" / "+jobToDelete.JobTitle);
            
            dbContext.Joblist.Remove(jobToDelete);
            dbContext.Adults.Remove(adultToDelete);
            await dbContext.SaveChangesAsync();
            return Ok(adultList);

        }

    }
}
