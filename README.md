## README ##

Starter C# bot for riddle.io Artificial Intelligence competition "Ms. Hack-man"

More info about the game:
https://booking.riddles.io/competitions/ms.-hack-man/

### Bot description ###
Bot makes random move each turn, so you can check that it is actually working.
Code your own logic in Brain.cs

Bot fire Events each time he receive any updates from Game Engine.
Other objects (eg GameState) then Listens for that Events and updates their own state (bomb counts, player disposition etc).

Bot designed to be stateful, so you can save your "strategy" between turns if you want (instead of recalculation whole situation each time).

### Debugging ###
You can save game dump from riddles.io in "dump.txt" at the root of that project.
Then run bot with "test" parameter and it will read all commands from text file and skip those not recognized.

### Useful links ###
* Game rules: https://docs.riddles.io/ms-hack-man/rules
* API description: https://docs.riddles.io/ms-hack-man/api
* How to play: https://booking.riddles.io/competitions/ms.-hack-man/how-to-play

### Now, make something great... ###
