# pokemon-mong0-db

Creates a container based on **mongo:latest** to run the Pokemon DB. This is a requirement for [https://github.ibm.com/iramirez/pokemon-loopback-api]()

# How to build the image

Open a terminal and run: `docker build -t pokemon-db-server:latest .`

# How to run the container

Open a terminal and run: `docker run -p 27017:27017 -e MONGO_INITDB_ROOT_USERNAME=root -e MONGO_INITDB_ROOT_PASSWORD=root --name mongo-db -d pokemon-db-server:latest`

# Initialization of the Pokemon DB

On startup, the container will create the pokemondb database and the Pokemon collection. Data will be populate from the pokemon-data.json
