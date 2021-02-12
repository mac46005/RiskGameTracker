# RiskGameTracker
A simple **Risk** Tracker mobile application.

###**NOTES**###
*FOR CLASSIC RISK ONLY - FOR NOW*
When app starts shows options for new game or continue current game.
Will only save one game data. Pressing new game will overwrite the game.
When new game is clicked you have the option for selecting 2 - 5 players.
When players are selected it will populate the list of players with the
amount of areas the person would have. It will calculate the amount of 
soldiers recieved per turn. **Must enter data manually when player recieves new *areas***.
Will have have optons under player data to choose bonus areas *CLASSIC RISK*.
Depending on what bonus areas player has it will grey out for other players.
Maybe automatically save data when data changes

###**Technologies Used**###
-SqLite: *System.Data.SqLite.Core*
-Dapper
-Mobile Application
-Xamarin
-Android


/////////////////////////////////////
###**Models**###

**Player**
-int Id-
-*Maybe*=====>string PlayerName-
-int ZonesOccupied-
-int BonusAmount-


*Maybe IF SAVING PLAYER DATA AND SAVING FINSISHED GAME*
**GameData**
-int Id-
/////////////////////////////////////
###**Views**
-NavigationPage-
-MainPage-
-NewGameSetUp-
-CurrentGame-
-*Maybe*=====>Depending if saving player data-
