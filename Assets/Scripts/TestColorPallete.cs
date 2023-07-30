using UnityEngine;
using UnityEngine.InputSystem;

public class TestColorPallete : MonoBehaviour
{
    [SerializeField] private ColorPalette _colorPalette;
    [SerializeField] private InputActionAsset _inputActionAsset;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private InputActionMap _colorPalleteActionMap;

    private readonly string[] _testingColorNames = new string[]
    {
        "Ambar",
        "Ruby",
        "Emerald",
    };

    private void Awake()
    {
        _colorPalleteActionMap = _inputActionAsset.FindActionMap("ColorPalleteActionMap", true);

        for(int i = 1; i < _testingColorNames.Length + 1; i++)
        {
            int lambdaIndex = i - 1;
            _colorPalleteActionMap.FindAction("Color_" + i, true).performed +=
                _ =>
                {
                    _spriteRenderer.color = _colorPalette
                        .GetColor(colorName: _testingColorNames[lambdaIndex]);
                };
        }
    }

    private void OnEnable()
    {
        _colorPalleteActionMap.Enable();
    }

    private void OnDisable()
    {
        _colorPalleteActionMap.Disable();
    }
}
