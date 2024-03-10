# Book Library

This is a book search project that allows users to search for and manage information about books. It uses a SQL Server database to store book data and Redis as a cache to improve application performance.

## Requirements

- ASP.NET Core 7
- SQL Server
- Redis

## Configuration

1. Clone the repository:

    ```bash
    git clone https://github.com/your-user/book-library.git
    ```

2. Install dependencies:

    ```bash
    dotnet restore
    ```

3. Database configuration:

    - Make sure you have a running SQL Server.
    - Run the `database.sql` script to create the necessary database and tables.

4. Redis configuration:

    - Make sure you have a running Redis server.
    - The Redis connection settings are in the `appsettings.json` file. Make sure the host, port, and password information is correct.

5. Run the application:

    ```bash
    dotnet run
    ```

## Usage

- Access the application through the browser.
- Use the different API routes to search for, add, update, and delete book information.

## Contributing

Contributions are welcome! Feel free to open an issue or send a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more information.



