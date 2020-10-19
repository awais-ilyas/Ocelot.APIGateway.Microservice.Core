# Introduction

API Gateway is an API Management Tool that usually sits between the external caller (Web or Mobile) and the internal services.
The API Gateway can provide multiple features like:
1. Routing
2. Request Aggregation
3. Authentication
4. Authorization
5. Rate Limiting
6. Caching
7. Load Balancing


# Ocelot

Ocelot is an ASP.NET Core (Supports .NET Core 3.1) API Gateway. It's a NuGet package, which can be added to any ASP.NET Core application to make it an API Gateway.
Ocelot API Gateway supports all the features that any standard API Gateway does.
Following features of Ocelot API Gateway is covered in this repo:
1. Routing (Basic routing to internal service)
2. Authentication (JWT Token-based authentication)
3. Response Caching (Using Ocelot.Cache.CacheManager NuGet package)
4. Rate Limiting