FROM microsoft/aspnetcore:build:3.1 as build
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o output

FROM microsoft/aspnetcore:3.1
WORKDIR /app
COPY --from=build /app/output .

EXPOSE 5000

ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVİRONMENT docker

ENTRYPOINT [ "dotnet","Meeting.Meeting.dll" ]


