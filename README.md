# A template for dotnet core libaries with github actions CI
- [ ] create a repositry using the template
- [ ] clone the repository
- [ ] change the project name and namespaces to yours

## Versioning 
[MinVer](https://github.com/adamralph/minver) is used for versioning 

## Secrets
- create two secrets one for the source and one for the personal access token created [here](https://github.com/settings/tokens/new) and make sure you check box for `write:packages`
- set follwoing in your library `.csproj`
`<RepositoryUrl>https://github.com/[your username]/[your repository]</RepositoryUrl>`
