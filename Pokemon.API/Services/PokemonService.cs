using System;
using System.Collections.Generic;
using MongoDB.Driver;
using Pokemon.API.Models;
using Pokemon.API.Infraestructure.DB;
using Microsoft.Extensions.Logging;

namespace Pokemon.API.Services
{
    public class PokemonService
    {
        private readonly ILogger<PokemonService> _logger;
        private readonly IMongoCollection<PokemonModel> _pokemons;

        public PokemonService(PokemonDatabaseSettings settings, ILogger<PokemonService> logger)
        {
            this._logger = logger;
            
            var client = new MongoClient(new MongoClientSettings()
            {
                Server = MongoServerAddress.Parse(settings.Server),
                Credential = MongoCredential.CreateCredential(settings.DatabaseName, settings.UserName, settings.Password),
            });
            var database = client.GetDatabase(settings.DatabaseName);
            this._pokemons = database.GetCollection<PokemonModel>(settings.CollectionName);
        }

        public List<PokemonModel> Get() =>
            this._pokemons.Find(book => true).ToList();
    }
}