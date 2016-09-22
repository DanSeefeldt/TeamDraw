FROM  microsoft/dotnet:latest

ADD . /TeamDraw

EXPOSE 5000/tcp

WORKDIR /TeamDraw

RUN dotnet restore

RUN dotnet build

ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:5000"]
