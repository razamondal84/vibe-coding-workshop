# Unity Editor Setup Instructions

Follow these steps to set up the "Simple & Satisfying" 3D flying simulator prototype in the Unity Editor.

## 1. Project Setup

1.  Create a new 3D Unity project.
2.  Import the TextMeshPro package if you haven't already (it should prompt you when you create the UI Text).
3.  Drag the C# scripts from the `Assets/Scripts` folder into your Unity project's `Assets` window.

## 2. Player Setup (The "Flyer")

1.  **Create Player GameObject:**
    *   Create a new empty GameObject and name it "PlayerFlyer".
2.  **Add Rigidbody:**
    *   With "PlayerFlyer" selected, click `Add Component` in the Inspector.
    *   Search for and add a `Rigidbody`.
    *   On the Rigidbody component, **uncheck `Use Gravity`** and set `Drag` to `1`.
3.  **Add Visual:**
    *   Right-click on "PlayerFlyer" in the Hierarchy and select `3D Object > Capsule`.
    *   Name the capsule "Visuals" or something similar.
    *   Rotate the Capsule **90 degrees on the Z-axis** to make it look like a plane.
4.  **Attach Script:**
    *   Drag the `PlayerFlightController.cs` script onto the "PlayerFlyer" GameObject.
    *   Set the `Forward Speed`, `Turn Speed`, and `Roll Speed` values in the Inspector to your liking (the defaults are fine to start).
5.  **Set Tag:**
    *   With "PlayerFlyer" selected, click the `Tag` dropdown in the Inspector and select `Player`. If the "Player" tag doesn't exist, create it by clicking `Add Tag...`.

## 3. Camera Setup

1.  **Select Main Camera:**
    *   Select the "Main Camera" in the Hierarchy.
2.  **Attach Script:**
    *   Drag the `SmoothFollow.cs` script onto the "Main Camera".
3.  **Assign Target:**
    *   In the `Smooth Follow` component in the Inspector, drag the "PlayerFlyer" GameObject from the Hierarchy into the `Target` field.
4.  **Set Offset:**
    *   Adjust the `Offset` `Vector3` to position the camera behind and slightly above the player. A good starting point is `(X: 0, Y: 3, Z: -10)`.

## 4. Environment: Low-Poly Terrain

1.  **Create Terrain:**
    *   In the Hierarchy, right-click and select `3D Object > Terrain`.
2.  **Sculpt Terrain:**
    *   Select the Terrain object and in the Inspector, click the "Paint Terrain" button (the paintbrush icon).
    *   Use the "Raise or Lower Terrain" tool to create some simple mountains and valleys.
3.  **Create Low-Poly Look:**
    *   In the Terrain's Inspector, click the gear icon for "Terrain Settings".
    *   Find the `Heightmap Resolution` setting and change it to a low value like `65`. This will create the faceted, low-poly appearance.
4.  **Add Material:**
    *   Create a new Material in your `Assets` folder (right-click > `Create > Material`).
    *   Name it "TerrainMaterial" and set its `Albedo` color to a green you like.
    *   In the Terrain's Inspector, under the "Paint Terrain" tab, select "Paint Texture".
    *   Click `Edit Terrain Layers... > Create Layer...` and select the green material you just created.

## 5. Collectible Orb

1.  **Create Orb GameObject:**
    *   Create a new `3D Object > Sphere` and name it "Orb".
2.  **Set Collider to Trigger:**
    *   On the "Orb" GameObject, find the `Sphere Collider` component and check the `Is Trigger` box.
3.  **Create Material:**
    *   Create a new Material and name it "OrbMaterial".
    *   Set its `Albedo` color to a bright, glowing yellow or blue.
    *   Drag this material onto the "Orb" in the Scene view.
4.  **Attach Script:**
    *   Drag the `CollectibleOrb.cs` script onto the "Orb" GameObject.
5.  **Create Particle Prefab (Optional but recommended):**
    *   Create a simple particle system (`GameObject > Effects > Particle System`) that looks like an explosion or collection effect.
    *   Save this particle system as a prefab by dragging it from the Hierarchy into your `Assets` folder.
    *   On the "Orb" GameObject, drag this particle prefab into the `Particle Prefab` field in the `Collectible Orb` component.
6.  **Add Collect Sound (Optional):**
    *   Find a sound effect you like for collecting the orb.
    *   On the "Orb" GameObject, drag the audio clip into the `Collect Sound` field.
7.  **Create Prefab and Place Orbs:**
    *   Drag the configured "Orb" GameObject from the Hierarchy into your `Assets` folder to create a prefab.
    *   Duplicate this prefab (`Ctrl+D` or `Cmd+D`) and place the orbs around your scene.

## 6. Game Manager & UI

1.  **Create Canvas:**
    *   In the Hierarchy, right-click and select `UI > Canvas`.
2.  **Create Score Text:**
    *   Right-click on the "Canvas" and select `UI > Text - TextMeshPro`.
    *   Name it "ScoreText".
    *   Anchor it to the top-left corner.
    *   Set its initial text to "Score: 0".
3.  **Create Game Manager:**
    *   Create a new empty GameObject and name it "GameManager".
4.  **Attach Script:**
    *   Drag the `GameManager.cs` script onto the "GameManager" GameObject.
5.  **Assign UI Text:**
    *   On the "GameManager" GameObject, find the `Game Manager` component in the Inspector.
    *   Drag the "ScoreText" UI object from the Hierarchy into the `Score Text` field.

## 7. Final Touches

1.  **Input Axis for Roll (Optional):**
    *   If you want to use a different key for rolling (e.g., Q and E), go to `Edit > Project Settings > Input Manager`.
    *   Expand `Axes` and duplicate one of the existing axes (like "Horizontal").
    *   Rename it to "Roll" and set the `Negative Button` to `q` and the `Positive Button` to `e`.
    *   In `PlayerFlightController.cs`, change `Input.GetAxis("Mouse X")` to `Input.GetAxis("Roll")`.
2.  **Play and Test!**
    *   Fly around and collect the orbs. The score should update, and the orbs should disappear with a sound and particle effect (if you added them).
