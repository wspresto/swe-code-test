# Data


## Local Postgres DB
If you would like to quickly start debugging and run a local instance of postgres db using docker, then run the following.
```
    docker build -t localdb -f ./Dockerfile.postgres .
    docker run -e POSTGRES_PASSWORD=<yoursecretpassword> -e PGDATA=/var/lib/postgresql/data/pgdata -v <path to your local db files e.g. C:\mypostgresdb>:/var/lib/postgresql/data -p 5432:5432 -it localdb
```