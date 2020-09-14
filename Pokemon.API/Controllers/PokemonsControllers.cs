using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pokemon.API.Models;
using Pokemon.API.Services;

namespace Pokemon.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PokemonsController : ControllerBase
    {
        private readonly ILogger<PokemonsController> _logger;
        private readonly PokemonService _pokemonService;

        public PokemonsController(PokemonService pokemonService, ILogger<PokemonsController> logger)
        {
            this._pokemonService = pokemonService;
            this._logger = logger;
        }

        [HttpGet]
        public ActionResult<List<PokemonModel>> GetAllPokemons()
        {
            return this._pokemonService.Get();
        }
    }
}
