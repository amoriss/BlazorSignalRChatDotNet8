# 💬 Blazor Chat App

A real-time chat application built with Blazor and SignalR. This project allows users to communicate instantly while managing usernames and messages effortlessly.

✨ **Features**
- 👤 Set your username for personalized chatting.
- 💬 Send and receive messages in real-time.
- 📜 View the chat history with a clean and modern interface.
- 🚀 Responsive design for mobile and desktop users.
- 🔄 Automatic scrolling to the latest messages.

🛠️ **Technologies Used**
- **Blazor**: Framework for building interactive web applications using C#.
- **SignalR**: Library for real-time web functionality, enabling instant message delivery.
- **C#**: Primary programming language used for both front-end and back-end logic.
- **HTML/CSS**: For crafting the user interface and styling the application.

### 📜 How to Use
- **Set Username**: Enter your username in the input box and click "Set Username."
- **Send Message**: Type your message and hit "Send" to share it with everyone.
- **View Messages**: All messages are displayed in real-time, with the latest at the bottom.

### 🔗 API Endpoints
| Method | Endpoint                | Description                               |
|--------|-------------------------|-------------------------------------------|
| POST   | /chathub/sendMessage    | Sends a message to all connected clients. |
| GET    | /chathub/receiveMessage | Receives messages from other users.      |

### 🌟 Special Features
- **Real-Time Updates**: No page refreshes needed—messages appear instantly.
- **Scroll to Bottom**: The chat automatically scrolls to the latest message for easy reading.

Feel free to explore and contribute to enhance the chatting experience! 🎉
