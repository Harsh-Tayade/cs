
### Step 1: Create the Scene and UI

1. **Create a New 2D Project** in Unity.
2. **Set Up the Scene**:
   - Set the camera's background color to a light blue or any color that resembles the sky.
   - Set the camera's `Projection` to **Orthographic** if it's not already.

3. **Add a UI Canvas for Score and Game Over Panel**:
   - Right-click in the **Hierarchy** > **UI** > **Text** to create a `Text` GameObject. Rename it to `ScoreText`.
     - Set its font size and alignment to be visible in the top corner of the screen.
     - Position it to display at the top center and enter a default text like "Score: 0".
   - Right-click on the **Canvas** > **UI** > **Panel**. Rename it to `GameOverPanel`.
     - Set the `GameOverPanel` to cover the screen and add a `Text` object inside the panel to display "Game Over".
     - Hide the `GameOverPanel` initially by setting it inactive in the inspector.

### Step 2: Create the Bird (Player)

1. **Create the Bird Object**:
   - Right-click in the **Hierarchy** > **2D Object** > **Sprite** and name it `Bird`.
   - Attach an image or sprite for the bird if you have one. You can use any placeholder image for now.
   
2. **Add Components to Bird**:
   - **Rigidbody2D**: Set `Gravity Scale` to **1** (or adjust based on how heavy you want the bird's fall to be).
   - **Circle Collider2D** (or another appropriate collider shape depending on your bird image).
   - Attach the `PlayerController.cs` script to the Bird.

3. **Tag the Bird**:
   - Set the Bird's tag to **Player**.

### Step 3: Create the Pipes (Obstacles)

1. **Create a Pipe Prefab**:
   - Right-click in the **Hierarchy** > **2D Object** > **Sprite** and name it `Pipe`.
   - Attach an image or sprite for the pipe.
   - Add a **Box Collider2D** (uncheck "Is Trigger") to the pipe object so it can collide with the Bird.
   
2. **Create a Score Trigger for Pipes**:
   - Right-click on the Pipe in the **Hierarchy** > **Create Empty** and name it `ScoreTrigger`.
   - Set its `Position` to be in the center between two pipe objects (one on top, one on the bottom).
   - Add a **Box Collider2D** to `ScoreTrigger`, adjust its size to cover the space between the pipes, and set **Is Trigger** to **True**.
   - Attach the `ScoreTrigger.cs` script to `ScoreTrigger`.
   
3. **Save as Prefab**:
   - Drag the `Pipe` object from the Hierarchy to the **Project** panel to create a prefab.
   - Now, delete the `Pipe` from the Hierarchy, as it will be spawned automatically.

### Step 4: Create a Pipe Spawner

1. **Create an Empty GameObject** in the Hierarchy, name it `PipeSpawner`, and position it off-screen to the right.
2. Attach the `PipeSpawner.cs` script to this GameObject.
3. Set the **Pipe Prefab** field in the `PipeSpawner` script to the `Pipe` prefab you created.
4. Adjust `spawnRate`, `minY`, and `maxY` in the Inspector for how often and at what heights pipes spawn.

### Step 5: Create the GameManager

1. **Create an Empty GameObject** in the Hierarchy and name it `GameManager`.
2. Attach the `GameManager.cs` script to it.
3. Assign references in the `GameManager` script:
   - Drag `ScoreText` into the `scoreText` field in the `GameManager`.
   - Drag `GameOverPanel` into the `gameOverPanel` field.

### Step 6: Configure Scene Management for Restarting

- Ensure the scene where you’re setting up the game is added to the **Build Settings** (`File` > `Build Settings...` > `Add Open Scenes`).
  
### Step 7: Adjusting the Game Flow

1. **Time Scale Reset**: Go to the `GameOver()` function in `GameManager.cs` and ensure the game pauses when the bird collides with a pipe.
2. Add a UI Button (optional) to restart the game. This button can call the `RestartGame()` function in `GameManager`.

### Step 8: Testing the Game

1. **Test the Bird's Movement**: Run the game, and ensure the bird jumps when you click or press space.
2. **Check Obstacle Spawning**: Confirm that pipes spawn at regular intervals and move from right to left.
3. **Scoring System**: Pass between pipes and check if the score updates.
4. **Game Over**: Test the collision and game over functionality by hitting a pipe.
