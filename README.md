# Symmetrical Potato
Here is a brief description of some things that are planned to be in the game.  

&nbsp;

## **Gameplay**
PvP, local multiplayer  

The idea for this game originated when I imagined a 2D game in which platforms (as in platformer) fight, instead of characters that represent humanoids (or animals or plants).

So, the playable characters are rectangular objects. The last player standing wins.

There will originally be support for 2 or 3 players. Player 1 and 2 will be on keyboard, and player 3 will be on controller.

Inspired by games like Superfighters, Gun Mayhem, and Brawlhalla.

&nbsp;

## **Controls**
Note: Bindings have not been decided yet.  
&nbsp;

### Movement
#### Basic movement - default
Players will be able to move left and right (relative to world space) and jump if there is something to collide with in very close proximity in the direction of motion.  
Done by setting the linear velocity of the player to a certain value.  
Players can rotate using bindings dedicated to rotation. Done by applying angular acceleration (until a certain maximum angular velocity is reached).

#### Rocket
Players can have a rocket equipped by using a power-up (picked up in game). This will override the basic movement (except rotation) and players can move in any direction.  
Done by accelerating the player (for a certain amount of time if input is received for long enough).

#### Dash
Players can pick up a dash power-up to gain the ability to dash left or right. The basic movement is not overriden. There is a delay between successive dashes.  
Done by setting the magnitude of the linear velocity of the player to a high value for a small amount of time.  
&nbsp;

### Weapons
Note: Weapon names are subject to change

Only one type of weapon can be equipped at one time.

##### RIP conservation of momentum
#### Melee - default
Players have a basic melee attack that can be performed from the right or left side of the player. There is delay between successive attacks. It looks like this:  
![Melee](https://raw.githubusercontent.com/GaryT01000111/SymmetricalPotato_p/master/images/SymmetricalPotatoMelee.png)

#### Assault Rifle
Fully automatic. Attached to the middle of the player. Medium-low spread. Medium-high fire rate. Medium damage. Ammo count: 30

#### Submachine Gun
Fully automatic. Attached to the left or right side of the player. Medium-high spread. High fire rate. Medium-low damage. Ammo count: 40

#### Deagle
Single fire. Attached to the middle of the player. High accuracy. Medium low fire rate. High damage. Ammo count: 7

#### Automatic Pistol
Fully automatic. Attached to the top of the player. Medium-high spread. Medium-high fire rate. Low damage. Ammo count: 20

#### AWP
Bolt action sniper rifle. Attached to the middle of the player. Fully accurate when still. Low accuracy when moving. **Very** high damage. Ammo count: 5

#### Revolver
Single fire. Attached to the end of a stick that protrudes out of the side of the player. Medium-high accuracy. Medium fire rate. Medium-high damage. Ammo count: 6

#### DMR
Single fire. Attached to the left or right side of the player. High accuracy. Between medium and medium-high fire rate. Medium-high damage. Ammo count: 20  
&nbsp;

Note: Only some of these weapons may be implemented at first.

&nbsp;

## **Art style**
A combination of pixel art and non-pixel art

&nbsp;

# Credits
- Unity, Brackeys, Sebastian Lague, Blackthornprod, Sykoo, Code Monkey, Infallible Code, and Jason Weimann

- Heather

&nbsp;

## Extra Credits
Anything I should've put above