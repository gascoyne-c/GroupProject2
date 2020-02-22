# GroupProject2FOR STARTERS:

Current background sounds were compiled from OpenGameArt.org:

- "Ghost Monster Voice Moaning & Growling"
	- https://opengameart.org/content/ghost-monster-voice-moaning-growling

- "Cave Theme"
	- https://opengameart.org/content/cave-theme

Can be changed if need be, I already have a couple of ideas for background music/event sounds such as "game over" or "win" states.

However, I would like to try and implement a more polished 3D version of the sound effect on the enemy, as a measure to allow the player to be more aware of the general distance of the enemy from themselves. Spooky as shit though, right?

_________________________

SCRIPTS:

Ignore Detect.cs entirely. It has been a testing script.

AIPatrol.cs is the main Enemy AI script. It handles all the patrolling behavior of the Enemy character.

AI.cs handles the "move towards the Player" behavior.

PatrolPoints.cs is specifically just to outline the shape of the patrol points that the Enemy follows.

Enemy.cs is currently not being used. Think of it as my first iteration in the pathfinding scripting. Ignore it for now. 

There are comments in parts of the scripts to know what does what, etc.

***Put any SceneManagement code in the PlayerController.cs script. ***
- Part of it is laid out for you in the script, all you have to do is create a new scene in-engine and incorporate it into the main project as a separate Menu scene and link them.

_________________


LEVEL DESIGN:

Texturing is about as good as it's going to get. I've left the hallways untextured because at this point we don't have time to go back and redo that. Instead, I've added decorations with the pipes and lighting and textured the pipes and ground. I don't see any reason that this doesn't go above and beyond the requirements.


_________________

JOYSTICK:

That code should *probably* go into the PlayerController script. Honestly not sure enough to say either way.

_________________


What's left:

Documentation, menus/SceneManagement changes, animation and implementation of final avatars for player/enemy, SFX etc., whatever else is listed on the Webcourses page.

Take care of that, and we are golden. Literally every other major requirement/facet of this project is done.

_____

What I have left is to fix the Enemy State mechanics so the Enemy responds appropriately towards the Player's behavior (i.e. their current position in the level.)

I'll be cracking on with fixing the patrolling/following the player AI mechanics first thing tomorrow.



