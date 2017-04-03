FROM progaudi/dotnet:1.0.1-xenial

WORKDIR /app

# copy csproj and restore as distinct layers
COPY . .
RUN dotnet --version
RUN dotnet restore
RUN dotnet build -c Release -f netstandard1.4 src/progaudi.tarantool/progaudi.tarantool.csproj
RUN dotnet build -c Release -f netcoreapp1.0 tests/progaudi.tarantool.tests/progaudi.tarantool.tests.csproj
RUN dotnet build -c Release -f netcoreapp1.1 tests/progaudi.tarantool.tests/progaudi.tarantool.tests.csproj