internal struct ColorTween : ITweenValue // TypeDefIndex: 5039
{	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x116F00 Offset: 0x116300 VA: 0x180116F00
	public Color get_startColor() { }

	// RVA: 0x116F30 Offset: 0x116330 VA: 0x180116F30
	public void set_startColor(Color value) { }

	// RVA: 0x116F10 Offset: 0x116310 VA: 0x180116F10
	public Color get_targetColor() { }

	// RVA: 0x116F40 Offset: 0x116340 VA: 0x180116F40
	public void set_targetColor(Color value) { }

	// RVA: 0xF3ED0 Offset: 0xF32D0 VA: 0x1800F3ED0
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0xF3F00 Offset: 0xF3300 VA: 0x1800F3F00
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x116DE0 Offset: 0x1161E0 VA: 0x180116DE0 Slot: 6
	public float get_duration() { }

	// RVA: 0x116F20 Offset: 0x116320 VA: 0x180116F20
	public void set_duration(float value) { }

	// RVA: 0x116DF0 Offset: 0x1161F0 VA: 0x180116DF0 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0xF1500 Offset: 0xF0900 VA: 0x1800F1500
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x19E1E0 Offset: 0x19D5E0 VA: 0x18019E1E0 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x19E130 Offset: 0x19D530 VA: 0x18019E130
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x116DF0 Offset: 0x1161F0 VA: 0x180116DF0
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116DE0 Offset: 0x1161E0 VA: 0x180116DE0
	public float GetDuration() { }

	// RVA: 0xF4F50 Offset: 0xF4350 VA: 0x1800F4F50 Slot: 7
	public bool ValidTarget() { }

}

public enum ColorTween.ColorTweenMode // TypeDefIndex: 5040
{	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;

}

public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 5041
{	// Methods

	// RVA: 0x10BAD30 Offset: 0x10B9330 VA: 0x1810BAD30
	public void .ctor() { }

}

internal struct ColorTween : ITweenValue // TypeDefIndex: 6750
{	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x116F00 Offset: 0x116300 VA: 0x180116F00
	public Color get_startColor() { }

	// RVA: 0x116F30 Offset: 0x116330 VA: 0x180116F30
	public void set_startColor(Color value) { }

	// RVA: 0x116F10 Offset: 0x116310 VA: 0x180116F10
	public Color get_targetColor() { }

	// RVA: 0x116F40 Offset: 0x116340 VA: 0x180116F40
	public void set_targetColor(Color value) { }

	// RVA: 0xF3ED0 Offset: 0xF32D0 VA: 0x1800F3ED0
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0xF3F00 Offset: 0xF3300 VA: 0x1800F3F00
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x116DE0 Offset: 0x1161E0 VA: 0x180116DE0 Slot: 6
	public float get_duration() { }

	// RVA: 0x116F20 Offset: 0x116320 VA: 0x180116F20
	public void set_duration(float value) { }

	// RVA: 0x116DF0 Offset: 0x1161F0 VA: 0x180116DF0 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0xF1500 Offset: 0xF0900 VA: 0x1800F1500
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x116E00 Offset: 0x116200 VA: 0x180116E00 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x116D30 Offset: 0x116130 VA: 0x180116D30
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x116DF0 Offset: 0x1161F0 VA: 0x180116DF0
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116DE0 Offset: 0x1161E0 VA: 0x180116DE0
	public float GetDuration() { }

	// RVA: 0xF4F50 Offset: 0xF4350 VA: 0x1800F4F50 Slot: 7
	public bool ValidTarget() { }

}

public enum ColorTween.ColorTweenMode // TypeDefIndex: 6751
{	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;

}

public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 6752
{	// Methods

	// RVA: 0xC65810 Offset: 0xC63E10 VA: 0x180C65810
	public void .ctor() { }

}

