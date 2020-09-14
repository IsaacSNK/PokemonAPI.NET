db.auth("root", "root");

db = db.getSiblingDB("pokemondb");

db.createUser({
    user: "pokemon-api",
    pwd: "pokemon-api",
    roles: [
        {
            role: "readWrite",
            db: "pokemondb",
        },
    ],
});

db.createCollection("Pokemon");

db.Pokemon.createIndex({
    id: 1,
});

db.Pokemon.createIndex({
    name: 1,
});

db.Pokemon.createIndex({
    types: 1,
});
