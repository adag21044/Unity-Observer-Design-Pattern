# Unity Observer Pattern 
This project implements a movement system in Unity using the Observer Pattern. The system includes a panel to send movement commands and a movement system that responds to these commands.

## Project Structure

1. **MovementPanel.cs**: Represents the UI panel with buttons for movement directions.
2. **MovementSystem.cs**: Responds to movement commands and moves the GameObject.
3. **NotificationTypes.cs**: Enumeration of movement commands.
4. **Observer.cs**: Abstract base class for observers.
5. **ObserverManager.cs**: Singleton manager that registers subjects and observers.
6. **Subject.cs**: Abstract base class for subjects.
7. **SubjectTypes.cs**: Enumeration of different subject types.

## MovementPanel.cs

### MovementPanel
UI component that sends notifications based on button clicks.
- **ForwardOnClick()**: Notifies observers of a forward movement command.
- **LeftOnClick()**: Notifies observers of a left movement command.
- **BackOnClick()**: Notifies observers of a backward movement command.
- **RightOnClick()**: Notifies observers of a right movement command.

## MovementSystem.cs

### MovementSystem
Observer that moves the GameObject based on received notifications.
- **OnNotify(NotificationTypes notificationType)**: Responds to movement commands by translating the GameObject in the specified direction.

## NotificationTypes.cs

### NotificationTypes
Enumeration representing different movement commands.
- **W**: Forward command.
- **A**: Left command.
- **S**: Backward command.
- **D**: Right command.

## Observer.cs

### Observer
Abstract base class for observers.
- **OnNotify(NotificationTypes type)**: Abstract method that must be implemented to handle notifications.

## ObserverManager.cs

### ObserverManager
Singleton manager that handles the registration of subjects and observers.
- **RegisterSubject(Subject subject)**: Registers a subject with the manager.
- **RegisterObserver(Observer observer, SubjectTypes subjectType)**: Registers an observer to a specific subject type.

## Subject.cs

### Subject
Abstract base class for subjects that send notifications to observers.
- **RegisterObserver(Observer observer)**: Registers an observer to this subject.
- **Notify(NotificationTypes notificationType)**: Notifies all registered observers of a command.

## SubjectTypes.cs

### SubjectTypes
Enumeration representing different types of subjects.
- **MovementPanel**: Represents the movement panel subject type.
