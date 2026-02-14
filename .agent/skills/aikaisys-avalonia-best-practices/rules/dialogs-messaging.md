# Dialogs & Messaging

- **WeakReferenceMessenger**: Use `WeakReferenceMessenger` for loose coupling between ViewModels and Views (e.g., showing dialogs). This follows the pattern found in `MainWindow.axaml.cs` and `MainViewModel.cs`.
  - **ViewModel (Sender)**: Use `WeakReferenceMessenger.Default.Send(new MyMessage())`.
  - **View (Receiver)**: Use `WeakReferenceMessenger.Default.Register<TRecipient, TMessage>(this, (r, m) => ...)` to handle the message.
  - **Example**:
    ```csharp
    // ViewModel
    var result = await WeakReferenceMessenger.Default.Send(new MyMessage());
    
    // View (Code-behind)
    WeakReferenceMessenger.Default.Register<MainWindow, MyMessage>(this, static (r, m) =>
    {
        var dialog = new MyDialog();
        m.Reply(dialog.ShowDialog<MyResult>(r));
    });
    ```

- **Notifications**: Use `WindowNotificationManager` for displaying toast notifications.
  - **Prerequisite**: Declare `<WindowNotificationManager x:Name="NotificationManager" Position="TopRight" />` in your Window's AXAML.
  - **Message**: Define a simple `NotificationMessage` class (e.g. `public class NotificationMessage(string message) { public string Message { get; } = message; }`).
  - **ViewModel (Sender)**: Use `WeakReferenceMessenger.Default.Send(new NotificationMessage("Message"))`.
  - **View (Receiver)**: Register in code-behind to show the notification.
  - **Example**:
    ```csharp
    // ViewModel
    WeakReferenceMessenger.Default.Send(new NotificationMessage("Operation Successful"));
    
    // View (Code-behind)
    WeakReferenceMessenger.Default.Register<MainWindow, NotificationMessage>(this, static (w, m) =>
    {
        w.NotificationManager.Show(m.Message, NotificationType.Information);
    });
    ```
