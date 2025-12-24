# Treasure Hunt

**Treasure Hunt** is a 2D narrative point-and-click game, developed using Unity.  
Players navigate through various scenes, interact with objects, and complete tasks to uncover hidden treasure.

🎮 **Play From Here**: [https://seden.itch.io/treasure-hunt](https://seden.itch.io/treasure-hunt)

![0817-ezgif com-video-to-gif-converter (1)](https://github.com/user-attachments/assets/ef96054a-2af0-499f-baa4-dc5075536f82)

**Seden Canpolat**: I worked as the lead developer. I did the coding and worked on the story, game design, audio, and UI.  
 In terms of coding, I worked on:
- Transition system  
- Scene management  
- Game settings  
- Image managers for loading and managing UI and in-game images  
- Cleaning mechanic for subtask actions  
- Inventory system  
- Dialogue system  
- Animations 

![082-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/e341c5aa-e262-4c0b-ae37-89fa24bd3e49)

## 🛠 Key Technical Implementations

### 1. Dual-Layer Scene Management System

Implemented a hybrid architecture optimized for point-and-click gameplay.

**Room-Based System (Intra-Scene):**
```csharp
public void changeScene(int roomId) {
    for (int i = 0; i < sceneArr.Length; i++) {
        sceneArr[i].SetActive(false);
    }
    sceneArr[roomId].SetActive(true);
}
```

Rooms within the same location are pre-loaded GameObjects that activate and deactivate, eliminating loading times. Major location changes use Unity’s `SceneManager` with transition effects. This dual approach balances performance with memory management, which is critical for smooth navigation.

### 2. Reference-Counting Lock System

Solved concurrent state management using a counter-based approach:

```csharp
private int lockCount = 0;

public bool isLocked {
    get { return lockCount > 0; }
    set {
        if (value == true) {
            lockCount++;
            CancelMovement();
        } else {
            lockCount--;
        }
    }
}
```

Multiple systems (dialogs, dragging, settings, image viewer) can lock player movement simultaneously. A simple boolean flag would fail when multiple systems overlap. Reference counting ensures movement only unlocks when **all** systems release their locks.

<!--
### 3. Dialog-Indexed Quest State Machine

Built a multi-stage task system tightly integrated with narrative flow:

```csharp
public class Task {
    public int onMission;    // Dialog index when task becomes available
    public int inMission;    // Dialog index while task is active
    public int afterMission; // Dialog index after completion
    public bool isTaskDone;
}

public int getTaskControl(int dialogIndex) {
    for (int i = 0; i < task.Length; i++) {
        if (task[i].onMission == dialogIndex) {
            dialogIndex = task[i].inMission;
        }
    }
    return dialogIndex;
}
```

Tasks can only be completed at specific dialog stages, creating controlled narrative pacing. When the dialog reaches `onMission`, the task activates. After completion, it advances to `afterMission`, enabling branching dialog paths based on player actions and supporting non-linear storytelling.
-->

### 3. Dictionary-Based Item-Target Matching with Raycasting

Created an inventory puzzle system using drag-and-drop mechanics:

```csharp
public Dictionary<Item, GameObject> ObjectTargetDictionary;

public void OnEndDrag(PointerEventData eventData) {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction, Mathf.Infinity);

    for (int i = 0; i < hits.Length; i++) {
        if (hits[i].collider.gameObject == 
            InventoryManager.instance.rightPlaceInDictionary(item)) {
            Chest2.instance.OpenChest();
        }
    }
}
```

Players drag UI items and release them over world objects. The system raycasts from UI space into world space, checks if the hit object matches the item’s target in the dictionary, and triggers the appropriate response. This bridges UI and world interactions cleanly for inventory-based puzzles.

### 4. Callback-Based Transition System with Time Scaling

Built a flexible transition system using `Action` delegates:

```csharp
public void MakeTransition(Action afterTransitionFunc) { 
    LoadCanvas.LeanAlpha(1f, 0.7f)
        .setIgnoreTimeScale(true)
        .setOnComplete(afterTransitionFunc);
}

public void OpenSettingsMenu() {
    settingmenu.SetActive(true);
    onsettingOpenAction?.Invoke();
    Time.timeScale = 0; // Pause game
}
```

Using `setIgnoreTimeScale(true)` ensures transitions function while the game is paused. Action delegates allow scene changes, state updates, or position changes during fade-outs, while the settings menu uses its own delegates to coordinate player movement locking.

