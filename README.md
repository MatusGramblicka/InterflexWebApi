InterflexWebApi


1. dotnet publish -c Release

2. docker build -t interflexdemo -f Dockerfile .

3. docker-compose up

4. Run BureaucracyAutomator2 https://github.com/MatusGramblicka/BureaucracyAutomator or just call rest requests to docker interflex to get data from Interflex

`curl -X POST http://localhost:3001/interflex -H "Content-Type: application/json" -H "Accept: application/json" -d '{"User": "userName", "Password": "Password"}' -D-`

![](https://github.com/MatusGramblicka/InterflexWebApi/blob/b25c89b7f095c9d74ffe8f80562f4925d96a10fe/sampleImage.png?inline=false)
