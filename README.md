# Toitumispaevik (Janar) - fitness tracker 

## Description

* Uni project
* Task: to develop a fitness application in .NET framework 
* UI language: Estonian
* Languages and technologies: **Visual Basic, .NET framework & SQLite**
* Authors: Aleksander Laasmägi, Kristofer Mäeots, Carmen Raun, Eeva-Maria Tšernova
* Development place and year: **TalTech 2024**
* Successor: Apexfit_desktop

## How to run

* The app itself is a Windows desktop application which was developed in Visual Studio, so it is just executable from VS.

## Explanation of the structure

### Frontend/UI
As it is Windows application which was created as Visual Studio solution, the UI is completely made in VS itself, using Windows Forms.
No external UI elements were used in this project. 

### Structure of the backend
The application uses component-based architecture which means that the app is divided into 5 parts. Each part is a project on its own and has an interface.

* **UI component** - contains and implements both login and main window and the logic behind UI elements.

* **Analysis component** - performs analysis and calculations specifically related to fitness functionality.

* **Foods'/recipes' component** - handles food and recipe data. 

* **User profile component** - handles user data.

* **Trainings' component** - handles training data.

### Data management
The application uses SQLite database which means that data is stored locally. 

Data is separated between 11 tables. Each table has its own use.

* **user_data** - stores information about user. Sensitive info is protected by using Caesar cipher and hashing.

* **user_daily_data** - stores daily information about user (ig. their calorie daily intake, consumption).

* **food_data** - stores all foods (and their nutritional information) that are available to select. User can also add their own foods.

* **recipe_data** - stores all recipes (and their nutritional information) that are available to select. User can also add their own recipes.

* **recipe_ingredients** - stores ingredients (foods) of recipes that are created.

* **user_food_history** - stores all history related to user's meals.

* **training_data** - stores all training styles (and fitness related information) that are available to select. User can also add their own training styles.

* **user_training_history** - stores all history related to user's training sessions.

* **recovery_questions** - stores all app's security questions used to recover forgotten password.

## Scaling possibilities

### Client-server application
Client application contains only UI and logic behind UI elements. API exchanges information between frontend(UI) and backend which runs on a server.

### Web application
UI is on a web page that runs on a server and backend runs on a different server. This opens a door for larger scalability between different operating systems and platforms.

### iOS/Android application
It is possible to create a phone application which contains UI. Backend still runs on a different server.

## Illustrative images

### Login window:
![Screenshot 2024-11-18 211951](https://github.com/user-attachments/assets/fc056a66-4e53-439f-975b-c89e2ad28afd)

### Home page:
![Screenshot 2024-11-18 211648](https://github.com/user-attachments/assets/967c3a8e-bc7f-48a7-af31-2db02e6dfc60)

### History page:
![Screenshot 2024-11-18 211750](https://github.com/user-attachments/assets/055c5987-4ec7-441b-956f-20b6429d5750)

### Overview page:
![Screenshot 2024-11-18 212037](https://github.com/user-attachments/assets/25d58d5e-ddbf-41b3-84df-19abd2897cab)

### Settings page:
![Screenshot 2024-11-18 211845](https://github.com/user-attachments/assets/1380dd1a-6151-4475-8f08-f0d9640a2b25)

## Detailed Documentation (In Estonian)
[Report_EST](https://github.com/user-attachments/files/18101169/IAS0110_PROJEKT_Toitumispaevik_2024.pdf)




