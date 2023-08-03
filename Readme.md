# ColorPalette System

## Overview

The `ColorPalette` system is designed to allow artists to easily create a custom palette of colors and name or tag them within Unity. These colors can be accessed in scripts through their names or tags.

## Components

### `ColorPalette`

The `ColorPalette` is a ScriptableObject that holds a collection of `ColorPaletteEntry` objects. Each entry represents a named color.

#### Creating a ColorPalette

1. Right-click in the Project panel.
2. Select Create > ScriptableObjects > ColorPalette.
3. Name the new ColorPalette asset.
4. Select the ColorPalette to edit it in the Inspector.
5. Add, edit, or remove color entries as needed.

#### Accessing Colors in Scripts

Use the `GetColor(string name)` method to retrieve a color by its name or tag.

```csharp
Color color = colorPalette.GetColor("TagName");

### `ColorPaletteEntry`

This class defines a color entry within the `ColorPalette`. It includes two public fields:

- `ColorName`: The name of tag of the color.
- `Color`: The color itself.

These fields can be edited directly within the Unity inspector when editing a `ColorPalette`.

## Limitations and Notes

- Colors cannot be added to the palette at runtime in the editor.
- Changes to colors in the palette while the game is running in the editor will be reflected in real time, but will revert to their original values when the games stops. This behaviour is consistent with Unity's handling of all game objects and is not specific to the `ColorPalette` system.