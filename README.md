# FINSHARK
### The project is designed as a stock management system. This system allows users to manage their stock trades, monitor their portfolios and comment on stocks.
The project's data structures are represented in the Models folder. The Stock.cs file defines the basic properties of stocks on the stock exchange, while the Portfolio.cs file manages the stocks in users' portfolios. Comment.cs contains stock comments and AppUser.cs contains user information.
ApplicationDBContext.cs enables interaction with the database using Entity Framework Core. This file specifies the database tables and their configuration.
Controllers that manage API endpoints ensure the functionality of the application.
The structures used for data transfer contain the information required for various operations. AccountDto and CommentDto files structure user and comment data, while StockDto files contain stock information.
ClaimExtensions.cs is used to retrieve user information, while QueryObject.cs manages parameters for stock queries.
Mappers enable data transformation between the model and DTOs, thus ensuring data consistency and compatibility within the application.
![Ekran görüntüsü 2024-08-30 140130](https://github.com/user-attachments/assets/8f76087d-968c-43df-8d19-584a359a3c5a)
![Ekran görüntüsü 2024-08-30 140142](https://github.com/user-attachments/assets/453f113f-1122-4aca-8417-a5c954342eee)
### For the Controllers that I have given the Authorize attribute, you now have authorization when you take the token to be given after the correct username and password from the Account/login section and paste it into the Authorize section.  
![Ekran görüntüsü 2024-08-30 140220](https://github.com/user-attachments/assets/671db168-1471-46dc-aa09-3632b6e8448b)
![Ekran görüntüsü 2024-08-30 140252](https://github.com/user-attachments/assets/3a2baad4-5fc0-4cff-b460-7f96625cdfd9)
![Ekran görüntüsü 2024-08-30 140307](https://github.com/user-attachments/assets/201a4848-d3d0-4e9c-a0f5-68fbd34d38e2)
![Ekran görüntüsü 2024-08-30 140327](https://github.com/user-attachments/assets/f1ae4604-1e1a-4ec5-9c6f-21c9b3239cec)
