# Tennis Match Simulator - interview task

## General information

This application simulates a single tennis game between two players in a console-based environment. 

The main purpose of this task is to assess coding skills, style, readability, and testability of the solution. Take your time, don't rush, and be creative. While correctness of the solution is important, demonstrating your coding skills and potential is equally valued. 

## Git repository and submission
- It is recommended to use a Git repository to manage your project.
- Organize your work into meaningful commits to track the development process.
- Each commit should represent a logical unit of work and include descriptive commit messages.
- Please refrain from proposing Pull Requests (PRs) to the current repository. Instead, we encourage you to submit a link to your repository containing the solution to the task.

## Description of the task
This application simulates a single tennis game between two players in a console-based environment. The game follows standard tennis scoring rules, where players accumulate points to win a game.

## Rules of the Tennis Game
1. The tennis game is played between two players.
2. Players start with a score of 0:0.
3. Points are counted as 0, 15, 30, 40.
4. When a player reaches 40 points:
   - If the opponent also has 40 points (deuce), a player must win the next point to gain advantage.
   - If a player with advantage wins the next point, they win the game.
5. The game continues until one player wins by reaching four points and leading by at least two points, or until one player wins with a point after deuce.

## Usage
1. Start the application to begin a new tennis game.
2. Enter 'A' or 'B' to score a point for Player A or Player B, respectively.
3. The game will display the current score after each point.
4. The game ends when a player wins by scoring the fourth point or breaks the deuce.

## Example interaction

```
Starting a new tennis game.
Current Score: 0:0
Enter 'A' or 'B' for a point (e.g., A for Player A).

A
Current Score: 15:0

B
Current Score: 15:15

A
Current Score: 30:15

A
Current Score: 40:15
Player A wins the game!
```
