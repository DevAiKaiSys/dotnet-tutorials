# Code Style & Best Practices

- **Nullability**: Nullable reference types are enabled (`<Nullable>enable</Nullable>`). Handle nulls explicitly.
- **Async/Await**: Use async/await for I/O operations (network requests, file loading). Avoid `Task.Run` for UI-bound operations unless necessary for offloading.
- **Naming**: Follow standard C# naming conventions (PascalCase for public members, camelCase for private fields/_fields).
