# Icy Tower Gameplay

This project is a 2D platformer game inspired by the mechanics of *Icy Tower*. The game involves controlling a player who must jump from platform to platform, avoiding falling off the screen while attempting to achieve the highest score possible.

## Features

- **Player Movement**: The player moves left and right using arrow keys. The player can jump onto platforms, and the jump height is customizable.
- **Platform Generation**: Platforms are generated at random positions and move upwards to simulate climbing a tower.
- **Background Scrolling**: The background moves upwards to simulate the player's ascent up the tower.
- **Sound Effects**: Background music and sound effects are used for jumping, game over, and other interactions.
- **Game Over Mechanism**: When the player falls off the screen, the game ends, and the score is displayed.
- **Restart Option**: The game can be restarted after a game over by pressing the 'R' key.

## Requirements

To run this project, you'll need:
- **Python 3**: Make sure Python 3 is installed on your machine.
- **Pygame**: This project uses Pygame for creating the game. Install it using pip:

    ```bash
    pip install pygame
    ```

- **Assets**: You'll need the following assets for the game:
  - `background.jpg`: A background image for the game (replace with your own).
  - `jump.wav`: A sound effect for jumping (replace with your own).
  - `game_over.wav`: A sound effect for game over (replace with your own).
  - `background_music.wav`: Background music for the game (replace with your own).

## How to Run

1. Clone or download the project.
2. Make sure all required assets (background image, sound effects, music) are placed in the project directory.
3. Run the script using Python:

    ```bash
    python icy_tower_game.py
    ```

4. The game window will open, and you can play the game. Use the left and right arrow keys to move, and jump on platforms to stay alive and increase your score.

## Game Controls

- **Left Arrow (←)**: Move left
- **Right Arrow (→)**: Move right
- **Spacebar or Up Arrow (↑)**: Jump (if on a platform)
- **R**: Restart the game after a game over

## Game Objective

The objective of the game is to jump from platform to platform while avoiding falling off the screen. Each time a platform moves off the screen, a new platform will be created, and the player earns a point. The game continues until the player falls past the bottom of the screen.

## License

This project is open-source and free to use, modify, and distribute. All assets (background image, sound effects, music) are to be replaced with your own or appropriately licensed content.

---

For any questions or contributions, feel free to open an issue or submit a pull request on the repository! Enjoy the game!
