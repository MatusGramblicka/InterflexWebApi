InterflexWebApi


1. dotnet publish -c Release

2. docker build -t interflexdemo -f Dockerfile .

3. docker-compose up

4. Run BureaucracyAutomator2 https://github.com/MatusGramblicka/BureaucracyAutomator or just call rest requests to docker interflex to get data from Interflex

`curl -X POST http://localhost:3001/interflex -H "Content-Type: application/json" -H "Accept: application/json" -d '{"User": "userName", "Password": "Password"}' -D-`

![](https://git.kistler.com/Gmt/interflexwebapi/-/raw/master/sampleImage.png?inline=false)
