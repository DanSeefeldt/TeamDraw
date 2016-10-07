FROM  microsoft/dotnet:latest

COPY ./project.json /TeamDraw/project.json

EXPOSE 5000/tcp

WORKDIR /TeamDraw

RUN dotnet restore

COPY . /TeamDraw

RUN dotnet build

ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:5000"]
