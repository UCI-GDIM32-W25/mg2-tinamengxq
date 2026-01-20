[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
Write about how the plan you wrote in the MG2 break-down activity connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

I planned to check the collision between ground and player to make sure whether _isGrounded is true or false. So I used OnCollisionEnter2D to text _isGrounded and OnCollisionExit2D to text !_isGrounded. I also planned to use IsTrigger to check the collision between coin and player to add point but I planned to use player to detect the collision. But I find that it is sometimes hard for me to figure out the OnCollision and OnTrigger so I moved the collision check from player.cs to coin.cs. What's more, I planned to use random.range() to control the distance between each coin appeared randomly. But I find that it is hard for me to actually measure the same numerical distance under different scales of screens. Thus, I change the distance to the time between each Instantiate() take place. And in the ui script, I created a method to add score when a coin is eaten just like how I planned the game.

## Open-Source Assets
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites