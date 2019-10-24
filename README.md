Runs teamA-simple and teamA-complex in a docker compose setup.
teamA-complex will call teamA-simple twice and return the result.

Run the whole thing:

`docker-compose -f docker-compose-teama.yml up --build`

Open http://localhost:8080/api/values

You should get this:
```
Hello Ernst
Hello Tobias
```


Run only teamA-simple:

docker build -t teama-simple
docker run -p 8080:80 teama-simple
