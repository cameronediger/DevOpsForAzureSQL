# DevOpsForAzureSQL

[<img src="https://github.com/cameronediger/DevOpsForAzureSQL/actions/workflows/sidecar-azuresql.yml/badge.svg" />](https://github.com/cameronediger/DevOpsForAzureSQL/actions/workflows/sidecar-azuresql.yml)
[<img src="https://github.com/cameronediger/DevOpsForAzureSQL/actions/workflows/build-test-sidecar.yml/badge.svg" />](https://github.com/cameronediger/DevOpsForAzureSQL/actions/workflows/build-test-sidecar.yml)

## Details
The reason for this project is to spin up a SQL Server/AzureSQL container, seed data, and run integration tests against that DB using GitHub Actions. 

This is a very simple Razor Pages web application that shows a list of customers from a SQL Server/Azure SQL database using Entity Framework Core. There is also a SQL Server database project used to create the DB and insert data. There are a couple integration tests in a test project that are run to verify the data. 

_NOTE: Yes, I know these type of integration tests are not best practice. I just needed tests to run from the GitHub Actions without building out too much complexity._
