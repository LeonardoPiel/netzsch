## Prerequisites

### Desktop Application (Application 1)

To run the desktop application, make sure you have the following prerequisites installed:

-   **.NET Runtime**: The application is built on .NET and requires the .NET Runtime to be installed. The project targets `net7.x`, so ensure you have the appropriate version of .NET runtime for Windows installed.
`<PropertyGroup>
  <OutputType>WinExe</OutputType>
  <TargetFramework>net7.0-windows</TargetFramework>
  <Nullable>enable</Nullable>
  <UseWindowsForms>true</UseWindowsForms>
  <ImplicitUsings>enable</ImplicitUsings>
</PropertyGroup>`

- **System.Net.WebSockets Package**: The application uses WebSockets for communication. Ensure that the `System.Net.WebSockets` package is installed.
`<ItemGroup>
  <PackageReference Include="System.Net.WebSockets" Version="4.3.0" />
</ItemGroup>`

### Web Application (Application 2)

To run the web application, you'll need the following prerequisites:

-   **Node.js**: The project is built using Node.js and npm. Make sure you have Node.js installed on your machine. You can download it [here](https://nodejs.org/).

## Setup Instructions

Follow these steps to set up and run the applications:
-   Clone the repository: `git clone https://github.com/LeonardoPiel/netzsch.git`
1.  **Desktop Application (Application 1)**:
    -   Navigate to the `windows_app` directory.
    -   Open the solution file `netzsch_test.sln` in Visual Studio.
    -   Build and run the application using Visual Studio.
2.  **Web Application (Application 2)**:
    
    -   Navigate to the `app2` directory.
    -   Install dependencies `npm install`.
    -  	Navigate to the `server` directory.
    -   Run `node server.js`
    -   Navigate to the `client` directory.
    -   Install dependencies: `npm install`
    -   Start the server: `npm start`
    -   The web application will be running at `http://localhost:3000`.
## Details
On localhost the websocket is running on port 5500.
