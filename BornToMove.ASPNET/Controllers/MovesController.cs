﻿using BornToMove.Business;
using BornToMove.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BornToMove.ASPNET.Controllers
{
    public class MovesController : Controller
    {

        //Maak een MovesController met een Random functie en een Index functie
        //en geef de BuMove aan de constructor mee (deze wordt automatisch geïnjecteerd)
        private BuMove _buMove;
        public MovesController(BuMove buMove)
        {
            _buMove = buMove;
        }
        public IActionResult Index()
        {
            // code om de lijst met moves op te halen
            return View();
        }
        public IActionResult Details(int id)
        {
            Move move = // code om een enkele move op te halen met dit id
        return View(move);
        }

        public IActionResult Random()
        {
            Move randomMove = // code om een random move op te halen
        return View("Details", randomMove);
        }
    }
}
