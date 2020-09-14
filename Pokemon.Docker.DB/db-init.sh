#!/bin/bash

mongo pokemondb /tmp/db-init.js
mongoimport -u pokemon-api -p pokemon-api -c Pokemon -d pokemondb --file /tmp/pokemon-data.json --jsonArray
