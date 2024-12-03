# Evently

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)
![Docker](https://img.shields.io/badge/docker-compose)

**Evently** is a robust and scalable event management system designed to simplify the creation, management, and participation in events. Built with ASP.NET Core Web API using a Modular Monolith architecture, Evently emphasizes clean architecture, domain-driven design, and modern development practices to deliver a maintainable and high-performance solution.

## Table of Contents

- [Features](#features)
- [Architecture](#architecture)
  - [Modular Monolith](#modular-monolith)
  - [Modules](#modules)
  - [Clean Architecture](#clean-architecture)
	- [Shared Projects](#shared-projects)
  - [Domain-Driven Design](#domain-driven-design)
  - [Application Layer](#application-layer)
- [Error Handling](#error-handling)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running with Docker Compose](#running-with-docker-compose)
- [Logging](#logging)
- [Future Enhancements](#future-enhancements)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Event Management:** create, update, and manage events with scheduling capabilities.
- **Ticketing System:** handle ticket sales, pricing and handle concurrency issues.
- **User Management:** user account handling with roles, permissions, and authentication mechanisms.
- **Attendee Tracking:** Monitor and manage event participants with engagement tracking and statictics.
- **Scalable Architecture:** Designed using Modular Monolith principles to ensure scalability and maintainability.
- **RESTful API:** Intuitive HTTP API adhering to practical and used REST standards for easy integration and usage.

## Architecture

Evently is crafted following a **Modular Monolith** architecture, ensuring a clean separation of concerns while maintaining a unified codebase. This approach facilitates easier navigation, scalability, and maintainability.

### Modular Monolith

A Modular Monolith architecture allows Evently to encapsulate different functionalities within distinct modules. Each module operates independently yet cohesively within the same application, promoting organized and manageable code.

### Modules

Evently is divided into the following bounded contexts, each representing a core domain area:

- **Events:**  
  Manages the lifecycle of events, including creation, scheduling, and updates.
  
- **Ticketing:**  
  Handles all aspects of ticket sales, inventory management, pricing models, and distribution.
  
- **Users:**  
  Manages user authentication, authorization, account settings, and role-based access control.
  
- **Attendees:**  
  Tracks and manages event participants, including registration details and engagement metrics.

### Clean Architecture

Adhering to **Clean Architecture** principles, Evently ensures a clear separation between different layers, enhancing testability and maintainability.

- **Presentation Layer:**  
  An HTTP API that follows REST principles, serving as the entry point for client interactions.
  
- **Application Layer:**  
  Implements business logic using MediatR to facilitate the Command Query Responsibility Segregation (CQRS) pattern.
  
- **Domain Layer:**  
  Encapsulates domain entities, value objects, and domain events, adhering to Domain-Driven Design (DDD) principles.
  
- **Infrastructure Layer:**  
  Manages data access, external service integrations, and other infrastructural concerns.

#### Shared Projects

To promote code reusability and maintain consistency across different modules and layers, Evently utilizes **Shared Projects**. These projects contain common code that can be leveraged by multiple modules, reducing duplication and fostering a cohesive codebase.

- Contains fundamental entities, value objects, common dependency injection and abstractions that are universally applicable across all modules.
 

### Domain-Driven Design

Evently leverages **Domain-Driven Design (DDD)** to model complex business logic and ensure that the software reflects the real-world processes it aims to manage.

- **Entities & Value Objects:**  
  Represent core business concepts with distinct identities and immutable attributes.
  
- **Domain Events & Integration Events:**  
  Facilitate communication within and across modules, ensuring that changes within the domain are appropriately propagated.
  
- **Bounded Contexts:**  
  Clearly define the boundaries within which particular models apply, reducing complexity and enhancing clarity.

### Application Layer

The **Application Layer** is the heart of Evently's business logic, utilizing several key patterns and libraries to ensure robust functionality.

- **MediatR & CQRS:**  
  Implements the CQRS pattern using MediatR to handle commands and queries separately, enhancing scalability and maintainability.
  
- **Pipeline Behaviors:**  
  Manages cross-cutting concerns such as logging, caching, and validation through MediatR's pipeline features.
  
- **FluentValidation:**  
  Ensures input data integrity by validating commands and queries effectively.
  
- **Data Access:**  
  - **Commands:** Utilize Entity Framework Core (EF Core) for robust database interactions.
  - **Queries:** Leverage Dapper for efficient and lightweight data retrieval.
  
- **Future-Proofing:**  
  Plans to integrate MongoDB for enhanced data flexibility and scalability.

## Error Handling

Evently employs a comprehensive error handling strategy centered around the **Fail-Fast Principle**, ensuring that the system fails quickly and predictably when encountering issues.

- **Result Pattern:**  
  Utilizes the Result pattern to explicitly handle errors, distinguishing between expected and exceptional scenarios.
  
- **Problem Details:**  
  Complies with RFC standards by using Problem Details to provide unified and standardized API error responses.
  
- **Global Exception Handler:**  
  Translates exceptions into Problem Details responses, ensuring consistent error messaging across the API.
  
- **Fail-Fast Principle:**  
  Encourages early detection and handling of errors to prevent cascading failures and maintain system integrity.

## Technologies

Evently integrates a suite of modern technologies and frameworks to deliver a high-performance and maintainable system:

- **Backend:**  
  - ASP.NET Core Web API
  - Modular Monolith Architecture
  - Clean Architecture
  - Domain-Driven Design (DDD)
  - Command Query Responsibility Segregation (CQRS)
  
- **Libraries & Frameworks:**  
  - MediatR
  - FluentValidation
  - Entity Framework Core (EF Core)
  - Dapper
  
- **Databases:**  
  - PostgreSQL (primary relational database)
  - MongoDB (planned for future integration)
  
- **Logging:**  
  - Serilog (structured logging)
  - Seq (log aggregation and visualization)
  
- **Containerization:**  
  - Docker Compose (managing multi-container deployments)
  
- **Other Patterns & Practices:**  
  - Result Pattern for error handling
  - Problem Details for RFC-compliant error responses
  - Global Exception Handling

## Future Enhancements
Evently is an evolving project with several planned enhancements to further improve functionality and scalability:

- **MongoDB Integration:**
Incorporate MongoDB to offer enhanced data flexibility and support for unstructured data.

- **Extended Modules:**
Develop additional modules to cover more comprehensive event management features and business needs.

- **Frontend Development:**
Build a user-friendly frontend interface to complement the backend API, enhancing user experience.

- **Advanced Analytics:**
Implement analytics and reporting features to provide valuable insights into event performance and user engagement.

- **Notes:**
*This Project is still under development and get updated reguaruly*
