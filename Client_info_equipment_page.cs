using Project8_HSassets.Models;
using Microsoft.AspNetCore.Mvc;

namespace Project8_HSassets.Controllers
{
    public class Clients: Controller

        //Create 

        //Read
    {
        public IActionResult Index()
        {

            //Go to the database and get all Client's information
            //Have the View list all the Client's information
            return View();
        }

        public IActionResult Details(int clientid = 0)
        {
            //Go to the database and get 1 Client info based on the clientid that i received.
            //Have the view dislay the Client's info


            //For now, Im going to create a bootlegged database.

            Client RobertoRodrigo = new Client();  //Client /Server
            RobertoRodrigo.Name = "Roberto Rodrigo";
            RobertoRodrigo.Branch = "HQ";
            RobertoRodrigo.Clientid = 1;


            Client RafaelGomez;
            RafaelGomez = new Client();
            RafaelGomez.Name = "Rafael Gomez";
            RafaelGomez.Branch = "IT";
            RafaelGomez.Clientid = 2;

            Client AshleyCorrasco = new Client();
            AshleyCorrasco.Name = "Ashley Corrasco";
            AshleyCorrasco.Branch = "Human Resources";
            AshleyCorrasco.Clientid = 3;

            Client JoseAlvarado = new Client();
            JoseAlvarado.Name = " Jose Alvarado";
            JoseAlvarado.Branch = "Sales Manager";
            JoseAlvarado.Clientid = 4;

            Client JackBeanstalk = new Client();
            JackBeanstalk.Name = "Jack Beanstalk";
            JackBeanstalk.Branch = "Recruiter";
            JackBeanstalk.Clientid = 5;

            return View(RafaelGomez);
        }

        //Update

        //Delete
    }
}
