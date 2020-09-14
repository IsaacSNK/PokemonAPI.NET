namespace Pokemon.API.Infraestructure.DB
{
    public class PokemonDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string DatabaseName { get; set; }
        public string Server { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"server={this.Server};username={this.UserName};db={this.DatabaseName}";
        }
    }
}