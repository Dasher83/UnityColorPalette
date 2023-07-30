using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorPalette", menuName = "ScriptableObjects/ColorPalette")]
public class ColorPalette : ScriptableObject
{
    [SerializeField] private List<ColorPaletteEntry> _colors;
    private Dictionary<string, Color> _nameToColorMap;

    void OnEnable()
    {
        if (_colors == null || _colors.Count == 0) return;
        _nameToColorMap = _colors.ToDictionary(e => e.ColorName, e => e.Color);
    }

    public Color GetColor(string colorName)
    {
        if (_nameToColorMap.TryGetValue(colorName, out Color color)) return color;

        throw new KeyNotFoundException("Color not found in palette: " + colorName);
    }
}

[Serializable]
public class ColorPaletteEntry
{
    [SerializeField] private string colorName;
    [SerializeField] private Color color;

    public string ColorName { get { return colorName; } }
    public Color Color { get { return color; } }

    public ColorPaletteEntry(string colorName, Color color)
    {
        this.colorName = colorName;
        this.color = color;
    }
}
