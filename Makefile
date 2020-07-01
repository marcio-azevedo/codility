
restore:
	@echo restoring packages...
	dotnet restore Codility.Kata.sln

build:
	@echo building solution...
	dotnet build Codility.Kata.sln

test:
	@echo running unit tests...
	dotnet test Codility.Kata.sln

