Notes:

React front-end
C# .NET Core API
Integration to SQL database with EntityFramework


Run notes:

1. Run SensitiveWords.API solution. Swagger documentation should load up
2. Open up SensitiveWordsFrontEnd.
	cd sensitivewordsfe
	npm start

SQL database backup is included. Connection String is currently configured to point at: 

Server 'localhost'
Database 'SensitiveWords'
Username 'achin'
Password 'Test1234'


Questions:

Performance: I would generate an index on the table to able to reference the SensitiveWords data more efficiently.
Perhaps think of a way to read from the database once and store the data somewhere in the API temporarily.

Improvements to the solution: 

Next steps would be the add functionality to add, edit and remove words from the SensitiveWords list.
I could also functionality to save and have a history of previously queried phrases.


Thanks I had a great deal of fun with this!
