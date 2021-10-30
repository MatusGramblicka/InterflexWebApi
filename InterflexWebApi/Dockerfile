FROM mcr.microsoft.com/dotnet/aspnet:5.0

COPY bin/Release/net5.0/publish/ App/
WORKDIR /App 

ENV ASPNETCORE_ENVIRONMENT Production
EXPOSE 3001 
   
ENTRYPOINT ["dotnet", "InterflexWebApi.dll", "--urls", "http://*:3001"] 
