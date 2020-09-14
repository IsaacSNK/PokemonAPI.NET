FROM mongo:latest

ENV MONGO_INITDB_ROOT_USERNAME root
ENV MONGO_INITDB_ROOT_PASSWORD root

COPY pokemon-data.json /tmp/
COPY db-init.js /tmp/
COPY db-init.sh /docker-entrypoint-initdb.d/
