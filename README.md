# Social Network Analyser

Social Network Analyser is a Blazor application designed to analyze datasets of social networks. It provides insights into user connections, friendships, and other statistics.

## Features
- **Dataset Management**: Upload, view, edit, and delete datasets.
- **Statistics**: View detailed statistics for each dataset, including the number of users and average number of friendships per user.
- **Interactive UI**: User-friendly interface with real-time updates and validations.

## Installation
1. **Clone the repository**:

`git clone https://github.com/your-repo/social-network-analyser.git`

`cd social-network-analyser`


2. **Set up the database**:
    - Ensure you have a SQL Server instance running.
    - Update the connection string in `appsettings.json`:

`"ConnectionStrings": {
    "DefaultConnection": "YourConnectionStringHere"
}`


3. **Run the application**:
   
`dotnet run --project SocialNetworkAnalyser`


## Usage
1. **Upload a Dataset**:
    - Navigate to the Upload page.
    - Select a file and upload it.

2. **View Statistics**:
    - Navigate to the Stats page.
    - View detailed statistics for the selected dataset.

3. **Edit Dataset Name**:
    - Click the edit icon next to the dataset name.
    - Enter a new name and save.

4. **Delete Dataset**:
    - Click the delete button and confirm the action.

## Dependencies
- .NET 9
- Blazorise
- Entity Framework Core
- SQL Server

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
