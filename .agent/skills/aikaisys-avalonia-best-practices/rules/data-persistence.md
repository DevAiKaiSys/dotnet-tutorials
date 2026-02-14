# Data Persistence & Caching

- **Local Cache**: Store cached data (e.g., album JSON, cover images) in a `./Cache` directory relative to the executable.
  - **Check Existence**: Always check `Directory.Exists("./Cache")` and create it if missing before saving.
  
- **File Naming**: Sanitize file names to remove invalid characters.
  - **Format**: `{Artist} - {Title}`.
  - **Sanitization**: Use `Path.GetInvalidFileNameChars()` to replace invalid characters (e.g., with `chain`).
  
- **Serialization**: Use `System.Text.Json` for object persistence.
  - **Async**: Use `JsonSerializer.SerializeAsync` and `JsonSerializer.DeserializeAsync`.
  - **Streams**: Prefer working with `Stream` (FileStream, MemoryStream) over loading entire files into strings.
  
- **Binary Data (Images)**:
  - **Loading**: Check if file exists in cache; if so, open stream. If not, download using `HttpClient` and save to cache.
  - **Saving**: Use `File.OpenWrite` to save streams directly to disk.

- **Concurrency**:
  - **Async/Await**: distinct `async` and `await` for all file I/O operations.
  - **ConfigureAwait**: Use `ConfigureAwait(false)` in library code or Models (like `Album.cs`) to avoid capturing the UI context needlessly.
