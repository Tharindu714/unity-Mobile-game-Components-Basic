# Unity Mobile Game Components Basic Project 🎮

> **Objective:** Provide a solid foundation for mobile game development in Unity, showcasing a modular Main Menu system, scene management, UI components, and project configuration.

---

## 📁 Project Structure

```
unity-Mobile-game-Components-Basic/
├── **Assets/**                 # Unity assets: Scenes, Scripts, Prefabs, UI, Audio
│   ├── **Scenes/**             # .unity scene files (MainMenu, Level1, etc.)
│   ├── **Scripts/**            # C# scripts controlling game flow and UI
│   ├── **Prefabs/**            # Reusable GameObjects (buttons, panels)
│   ├── **UI/**                 # Canvas, Button, Text, and other UI assets
│   └── **Audio/**              # Background music and SFX clips
│
├── **Logs/**                   # Runtime log files (Editor & device)
├── **Packages/**               # Package manifest (manifest.json)
├── **ProjectSettings/**        # Unity project settings (Input, Tags, Graphics)
├── **UserSettings/**           # Personal editor preferences (EditorUserSettings.asset)
├── **obj/Debug/**              # Local build artifacts
├── Assembly-CSharp.csproj      # C# project definition
├── Assembly-CSharp-Editor.csproj
├── all-files.txt               # Listing of all files (utility)
├── ignore.conf                 # Custom ignore rules
└── mobile-Main-menu game.sln   # Visual Studio solution for IDE support
```

---

## 🛠️ Prerequisites & Setup

1. **Unity**: Version 2020.3 LTS or newer.
2. **Mobile Build Support**: Install Android and/or iOS modules via Unity Hub.
3. **IDE**: Visual Studio or Rider with Unity integration.

**Clone & Open**:

```bash
git clone https://github.com/Tharindu714/unity-Mobile-game-Components-Basic.git
cd unity-Mobile-game-Components-Basic
```

* Open `mobile-Main-menu game.sln` in your IDE (optional).
* Launch **Unity Hub**, click **Add**, select the project folder, and **Open**.

---

## 🎬 Scenes & Navigation Flow

1. **MainMenu.unity**: Entry scene, contains:

   * **Canvas** with Buttons: `Start`, `Options`, `Quit`.
   * **MainMenuManager** script attached to an empty GameObject for handling button callbacks.

2. **GameScene.unity**: Placeholder for gameplay.

   * Load scene with a **SceneLoader** script.

3. **Options.unity** (optional): Audio and control settings UI.

**Scene Management Script** (`SceneLoader.cs`):

```csharp
public class SceneLoader : MonoBehaviour {
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
```

* **Usage**: Hook each button’s **OnClick()** event to `LoadScene("GameScene")` or `LoadScene("MainMenu")`.

---

## 🤖 Core Scripts

### 1. MainMenuManager.cs

Manages menu button logic:

```csharp
public class MainMenuManager : MonoBehaviour {
    public void OnStartGame()   => SceneManager.LoadScene("GameScene");
    public void OnOptions()     => SceneManager.LoadScene("Options");
    public void OnQuitGame()    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
```

* **Attach** to an empty GameObject in `MainMenu.unity`.
* **Assign** UI Buttons to corresponding public methods.

### 2. UIManager.cs

Centralizes UI transitions and notifications:

```csharp
public class UIManager : MonoBehaviour {
    public GameObject panel;
    public void TogglePanel() {
        panel.SetActive(!panel.activeSelf);
    }
}
```

* **Use Case**: Show/hide settings panels, help overlays, or pause menus.

---

## 🎨 Prefabs & UI Artifacts

* **Button\_Prefab**: Standardized Unity UI Button with default font, size, and colors.
* **Panel\_Prefab**: Background panel with `Image` component for grouping UI elements.
* **Text\_Prefab**: Default `TextMeshPro` text styling for titles and labels.

> **Tip:** Keep UI elements as prefabs for consistent look & feel across scenes.

---

## ⚙️ Project & Build Configuration

1. **Player Settings** (`ProjectSettings/ProjectSettings.asset`):

   * **Company Name**: e.g., `Delta Codex`
   * **Product Name**: `MobileGameComponentsBasic`
   * **Default Orientation**: Portrait
   * **API Compatibility Level**: .NET 4.x for modern C# features.

2. **Input Settings** (`InputManager.asset`):

   * Define **Virtual Axes** for `Horizontal`, `Vertical`, and touch controls.

3. **Build Settings**:

   * **Platform**: Switch to **Android** or **iOS**.
   * **Scenes In Build**: Ensure `MainMenu` and `GameScene` are checked.

4. **Package Management**:

   * Check `Packages/manifest.json` for required packages: `com.unity.textmeshpro`, `com.unity.inputsystem`.

---

## 📱 Build & Run on Device

1. **Switch Platform** in **File ▶ Build Settings**.
2. **Connect** Android device via USB (enable USB debugging) or pair iOS device.
3. **Player Settings ▶ Other Settings**: Set **Bundle Identifier** and **Minimum API Level**.
4. **Build And Run**: Choose a location, Unity compiles and installs the APK/IPA.

---

## 📸 Screenshots
<p align="center">
  <img src="https://github.com/user-attachments/assets/91f8c388-1451-43a1-8a41-f2113ccaf672" width="45%" />
  &nbsp;
  <img src="https://github.com/user-attachments/assets/35146390-544c-4130-883f-b7dd32159698" width="45%" />
</p>

---

## 📖 Logging & Diagnostics

* **Runtime Logs**: Stored under `Logs/`, review `output.log` for errors on device.
* **Debugging**: Use `Debug.Log()`, `Debug.Warning()`, and `Debug.Error()` in scripts.

---

## 🚀 Next Steps & Enhancements

* **Gameplay Mechanics**: Implement player controllers, enemy AI, and level progression.
* **Settings Menu**: Add volume sliders and control remapping.
* **Analytics**: Integrate Unity Analytics or Firebase for user metrics.
* **Asset Optimization**: Use **Addressables** for dynamic asset loading.
* **Input System**: Migrate to Unity’s **New Input System** for advanced touch gestures.

---

> This README gives you a clear roadmap to explore each part of the Unity mobile template. Tweak, extend, and build upon it to launch your own mobile game. Happy developing!
