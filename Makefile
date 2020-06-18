
restore:
	dotnet restore Codility.Kata.sln

build:
	dotnet build Codility.Kata.sln

test:
	dotnet build Codility.Kata.sln
	dotnet test Codility.Kata.sln

