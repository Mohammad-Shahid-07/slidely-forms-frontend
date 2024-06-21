# Slidely Form Project

This project is a Windows Forms application designed to create, view, edit, and manage submissions stored on a server via HTTP requests.

## Features

- Create new submissions.
- View submissions sequentially or search by email.
- Edit submission details and update them on the server.
- Delete submissions directly from the application.
- Navigate submissions using keyboard shortcuts.

## Prerequisites

- Visual Studio (2019 or later) with VB.NET support.
- .NET Framework 4.5 or higher.
- Access to a server providing RESTful endpoints for CRUD operations on submissions.

## Setup Instructions

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/Mohammad-Shahid-07/slidely-forms.git
   ```

2. **Open Project in Visual Studio:**

   - Launch Visual Studio.
   - Select `File` -> `Open` -> `Project/Solution`.
   - Navigate to the cloned repository and open the solution file (`slidely-forms.sln`).

3. **Build and Run:**

   - Build the solution (`Ctrl + Shift + B`).
   - Start the application (`F5` or `Debug` -> `Start Debugging`).

4. **Usage:**

   - Upon launch, the application will give you 2 options create submission and view submissions
   - `For Create Submissions` you can fill the form and submit the from
   - `For View Submissions`, the application will fetch and display submission data.
   - Use the navigation buttons (`Next`, `Previous`) or keyboard shortcuts to navigate through submissions.
   - Search for submissions by entering an email and clicking `Search`.
   - Edit submission details by clicking `Edit`, making changes, and then clicking `Submit`.
   - Delete a submission by clicking `Delete`.

5. **Customization:**

   - Extend the application's functionality by modifying form design and logic in `Form1.vb`.
   - Enhance error handling or add additional features as needed.

## Troubleshooting

- **Connection Issues:**

  - Ensure the server hosting your API is running and accessible from your development environment.
  - Check firewall settings and network configuration if connection errors persist.

- **API Endpoint Configuration:**
  - Verify that API URLs in the application match the actual endpoints provided by your server.
  - Update API URLs in the application if the server configuration changes.
