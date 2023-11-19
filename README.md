# .NET 8 Aspire App with Automation

## Introduction

This is a demo application that shows how to use the .NET 8 Aspire App with an Automation container provided by [n8n](https://n8n.io/).
I'm doing this because I want to show how easy it is to use n8n with a .NET 8 Aspire App.

n8n is an extendable workflow automation tool that enables you to connect anything to everything via its open, fair-code model. As a result, you can automate your business processes, sync data between different applications, and create custom integrations with ease.

It's also a great tool as an alternative to Microsoft Power Automate.

![Blazor Automation](./assets/img/blazor-automation.png)
![n8n Workflow](./assets/img/n8n-workflow.png)

note for other developers: this is a demo app, not a production app. It's not meant to be a perfect example of how to use n8n, but rather a starting point for you to build your own apps.

## Getting Started

### Prerequisites

- [Docker](https://docs.docker.com/get-docker/)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- .NET Aspire Workload

## n8n Setup

The n8n container is configured to use the following information:

| Key        | Value              |
|------------|--------------------|
| email      | **admin@demo.com** |
| first name | **admin**          |
| last name  | **admin**          |
| password   | **Passw0rd**       |

A SQLite database is used to store the n8n data. The database is stored in the `n8n-data` folder.

