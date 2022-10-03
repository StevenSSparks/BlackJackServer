# BlackJackServer API and Client Project 
Developer by: Steve Sparks - https://github.com/StevenSSparks

## Project Overview
This is a .NET 6 WebAPI project that utilizes a custom blackjack service to implement playing BlackJack over an API. A simple client calles the POST endpoint passing in a gameid and a move. When the gameID and move are blank the API will return the details to begin a new game. The games are manaaged inside the API using a unique GUID for each game. The Games have a life of 8 hours.

The API project includes a welcome page and a simple web client that allows any browser to play the game. When you run the project locally review the welcome page for instructions on accessing the game. 

# Blackjack Game Features
These are here to help provide as close to real world casino blackjack as possible. 
* Single deck of cards
* Deck is shuffled after the last card is delt
* The game manages the transistion from Ace value from 11 to 1
* Supports INSURANCE
* Currently can not split hands but that feature is next. 

#BlackJack House Rules
* The cards are delt alternating between the one player and the computer.
* If the player gets a face card and an ACE on the deal they win.
* The computer cards are shared first one face down and second face up
* If the computer shows and ACE on the up card the player is offered insurance. 
* Insurance costs equal to the players bet.
* Berring is done with poits. The player gets 10000 points at the beginning of the game.
* Players can bet 100 to max points per hand. 
* When the player gets 50000 or more points the game session ends and the player bankrupts the house
* If the player looses all the points the game session ends. 
* When delt an ACE and the ACE + the total would take then over 21 then the ACE value is changed to 1. 

# Game Play
* The game client simulates a simple terminal. Although you can code any type of client. 
* The client calles the API with no ID or COMMAND and the game begins.


 
