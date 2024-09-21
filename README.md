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

* **user_data** - stores information about user. Sensitive info is protected by using my own encryption methods and hashing.

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
