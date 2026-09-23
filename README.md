![aspire-app-with-n8n banner](.github/banner.png)

# .NET 8 Aspire App with n8n Automation 🚀

<!-- portfolio-badges:start -->
<!-- Identity -->
[![phmatray - aspire-app-with-n8n](https://img.shields.io/static/v1?label=phmatray&message=aspire-app-with-n8n&color=blue&logo=github)](https://github.com/phmatray/aspire-app-with-n8n)
![Top language](https://img.shields.io/github/languages/top/phmatray/aspire-app-with-n8n)
[![Stars](https://img.shields.io/github/stars/phmatray/aspire-app-with-n8n?style=social)](https://github.com/phmatray/aspire-app-with-n8n/stargazers)
[![Forks](https://img.shields.io/github/forks/phmatray/aspire-app-with-n8n?style=social)](https://github.com/phmatray/aspire-app-with-n8n/network/members)

<!-- Activity -->
[![Issues](https://img.shields.io/github/issues/phmatray/aspire-app-with-n8n)](https://github.com/phmatray/aspire-app-with-n8n/issues)
[![Pull requests](https://img.shields.io/github/issues-pr/phmatray/aspire-app-with-n8n)](https://github.com/phmatray/aspire-app-with-n8n/pulls)
[![Last commit](https://img.shields.io/github/last-commit/phmatray/aspire-app-with-n8n)](https://github.com/phmatray/aspire-app-with-n8n/commits)
<!-- portfolio-badges:end -->

<!-- portfolio-toc:start -->

## Table of Contents

- [Introduction 📖](#introduction-)
- [Note to Developers 👨‍💻](#note-to-developers-)
- [Features 🌟](#features-)
- [Getting Started 🚦](#getting-started-)
- [n8n Setup 🌐](#n8n-setup-)
- [Usage 🧑‍💻](#usage-)
- [Tech Stack](#tech-stack)
- [Roadmap 🗺️](#roadmap-)
- [Contributing 🤝](#contributing-)
- [Support and Contact 📬](#support-and-contact-)
- [License 📜](#license-)

<!-- portfolio-toc:end -->



---

## Introduction 📖

Welcome to the demo application showcasing the integration of the .NET 8 Aspire App with n8n, a powerful workflow automation tool. This project aims to demonstrate the ease of using n8n to create efficient and automated workflows within a .NET 8 environment, offering an alternative to solutions like Microsoft Power Automate.

The .NET 8 Aspire App represents the latest in .NET technology, designed for building high-performance, modern applications. Coupled with n8n's extendable architecture, this demo serves as an ideal starting point for developers looking to explore advanced automation in their apps.

![Blazor Automation](./assets/img/blazor-automation.png)
*Blazor Automation Interface*

![n8n Workflow](./assets/img/n8n-workflow.png)
*n8n Workflow Example*

## Note to Developers 👨‍💻
This application is a demonstration and not intended for production use. It serves as a foundation for you to build and customize your applications using n8n and .NET 8 Aspire App.

## Features 🌟

- **Aspire-orchestrated stack**: `AppHost` wires up the n8n container, the `ApiService`, and the Blazor `Web` frontend into a single distributed application with service discovery, all launched from one entry point.
- **Custom n8n container extension**: `AddN8NContainer()` (`N8NBuilderExtensions`) adds the official `n8nio/n8n` image, mounts a persisted `containers/n8n/data` volume, sets the container's timezone to match the host, and exposes an HTTP service binding on port `5678`.
- **MediatR-based minimal APIs**: `AutomationEndpoints` and `WeatherEndpoints` expose vertical-slice, MediatR-backed minimal API endpoints via a `MediateGet<T>` extension, keeping request/handler/response together per feature.
- **n8n webhook bridge**: `ExecuteAutomationHandler` calls a pre-configured n8n webhook (`search-on-google`) with `first_name`/`last_name` query parameters and relays the workflow's response back to the caller.
- **Interactive Blazor demo page**: The `/automation` page (Interactive Server render mode) submits a name through a form, calls the API, and displays the live n8n URL plus the workflow's returned message.
- **Pre-seeded n8n instance**: A working SQLite-backed n8n database ships in `containers/n8n/data`, so the demo workflow is ready to run without manual workflow setup.

## Getting Started 🚦

### Prerequisites 📋
Before you begin, ensure you have the following installed:
- [Docker](https://docs.docker.com/get-docker/) - For containerization of the n8n workflow.
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) - The software development kit for .NET 8 applications.
- .NET Aspire Workload - Essential for running the Aspire App.

### Installation and Configuration 🛠️
1. **Clone the Repository**: Start by cloning the repository to your local machine.
2. **Open the Solution**: Navigate to the cloned directory and open the solution file in your preferred IDE.
3. **Launch the AspireAppWithAutomation.AppHost Project**: Find and launch the `AspireAppWithAutomation.AppHost` project to get the app up and running.

## n8n Setup 🌐
To configure the n8n container, use the following default settings:

| Key        | Value              |
|------------|--------------------|
| email      | **admin@demo.com** |
| first name | **admin**          |
| last name  | **admin**          |
| password   | **Passw0rd**       |

*Note: These settings can be modified based on your requirements. A SQLite database stores the n8n data, located in the `n8n-data` folder.*

## Usage 🧑‍💻

Launch the whole stack (n8n container + API + Blazor web) through the Aspire AppHost:

```bash
dotnet run --project AspireAppWithAutomation/AspireAppWithAutomation.AppHost
```

This opens the .NET Aspire dashboard and starts the `n8n` container (published on the port configured in `N8NBuilderExtensions`, default `5678`), the `apiservice`, and the `webfrontend` with a reference to it.

Then:
1. Sign in to n8n with the default credentials from [n8n Setup](#n8n-setup-) above (or your own, if changed).
2. Open the Blazor app and go to the `/automation` page.
3. Enter a first and last name and submit. The page calls `ApiServiceHttpClient.ExecuteAutomationAsync`, which hits `GET /api/v1/automation/execute-automation/{firstName}/{lastName}` on the API. The API in turn calls the `search-on-google` n8n webhook and displays the returned message in the results table, alongside the live n8n URL.

<!-- portfolio-techstack:start -->

## Tech Stack

- **.NET 8**
- MediatR
- Microsoft.Extensions.Http
- Swashbuckle.AspNetCore
- Aspire.Hosting
- Microsoft.Extensions.Http.Resilience
- Microsoft.Extensions.ServiceDiscovery
- OpenTelemetry.Exporter.OpenTelemetryProtocol
- OpenTelemetry.Extensions.Hosting

<!-- portfolio-techstack:end -->

## Roadmap 🗺️

- [ ] Add automated tests around the `Automation` and `Weather` MediatR handlers
- [ ] Support configuring/importing additional n8n workflows beyond the bundled `search-on-google` demo
- [ ] Parameterize the n8n container port and credentials via Aspire configuration instead of hard-coded defaults
- [ ] Add authentication/authorization to the ApiService endpoints
- [ ] Publish a docker-compose or Aspire deployment manifest for non-local environments

See the [open issues](https://github.com/phmatray/aspire-app-with-n8n/issues) for the current backlog.

## Contributing 🤝
We welcome contributions! If you would like to contribute, please feel free to submit a pull request or open an issue for discussion.

## Support and Contact 📬
For support or inquiries about this project, please open an issue in the GitHub repository or contact [Your Contact Information].

## License 📜
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
