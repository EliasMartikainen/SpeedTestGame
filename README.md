# Speed Test Game

## Speed Button Game is a reaction-based game where player must quickly press the correct buttons as they light up. Test your speed and intuition!

## How it works
### The game consists of a series of colored buttons that light up randomly. The player must press the corresponding button before it is too late. The score increments with each successful press and the game ends after a miss.

## Technicalities
### The game is developed using C# and Windows Forms.
#### - GameLogic.cs handles game flow, button sequences and scoring logic.
#### - GameWindow.cs manages the user interface, including button click events and game status.
#### - DigitalCounterControl.cs displays the players score using a custom digital font.
#### - Button.cs defines button behavior and states.
#### - ButtonColorType.cs and ButtonLightState.cs manages button properties.
#### - Background images and button graphics are loaded from embedded resources. 

## Installation instructions
### 1. Download "release_speedtest" folder.
### 2. Run the game by double-clicking on SpeedTestGame.exe
#### - The game is optimized for 1920x1080 screen resolution. Using other resolutions might cause display stretching.

## Controls
#### - Use the mouse to click on the colored buttons.
#### - Press the "start" button to begin the game.
#### - Press the "reset" button to restart after game over.
#### - Click "exit" to close the application

## Troubleshooting
#### - Ensure your display resolution is set to 1920x1080 for intended experience.
#### - If the game does not launch, ensure that .NET runtime dependencies are installed.

## Feel free to use or modify this project as you wish.
