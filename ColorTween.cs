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

	// RVA: 0x116F80 Offset: 0x116380 VA: 0x180116F80
	public Color get_startColor() { }

	// RVA: 0x116FB0 Offset: 0x1163B0 VA: 0x180116FB0
	public void set_startColor(Color value) { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public Color get_targetColor() { }

	// RVA: 0x116FC0 Offset: 0x1163C0 VA: 0x180116FC0
	public void set_targetColor(Color value) { }

	// RVA: 0xF3F50 Offset: 0xF3350 VA: 0x1800F3F50
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0xF3F80 Offset: 0xF3380 VA: 0x1800F3F80
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x116E60 Offset: 0x116260 VA: 0x180116E60 Slot: 6
	public float get_duration() { }

	// RVA: 0x116FA0 Offset: 0x1163A0 VA: 0x180116FA0
	public void set_duration(float value) { }

	// RVA: 0x116E70 Offset: 0x116270 VA: 0x180116E70 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0xF1580 Offset: 0xF0980 VA: 0x1800F1580
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x19E570 Offset: 0x19D970 VA: 0x18019E570 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x19E4C0 Offset: 0x19D8C0 VA: 0x18019E4C0
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x116E70 Offset: 0x116270 VA: 0x180116E70
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116E60 Offset: 0x116260 VA: 0x180116E60
	public float GetDuration() { }

	// RVA: 0xF4FD0 Offset: 0xF43D0 VA: 0x1800F4FD0 Slot: 7
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

	// RVA: 0x10BA000 Offset: 0x10B8600 VA: 0x1810BA000
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

	// RVA: 0x116F80 Offset: 0x116380 VA: 0x180116F80
	public Color get_startColor() { }

	// RVA: 0x116FB0 Offset: 0x1163B0 VA: 0x180116FB0
	public void set_startColor(Color value) { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public Color get_targetColor() { }

	// RVA: 0x116FC0 Offset: 0x1163C0 VA: 0x180116FC0
	public void set_targetColor(Color value) { }

	// RVA: 0xF3F50 Offset: 0xF3350 VA: 0x1800F3F50
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0xF3F80 Offset: 0xF3380 VA: 0x1800F3F80
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x116E60 Offset: 0x116260 VA: 0x180116E60 Slot: 6
	public float get_duration() { }

	// RVA: 0x116FA0 Offset: 0x1163A0 VA: 0x180116FA0
	public void set_duration(float value) { }

	// RVA: 0x116E70 Offset: 0x116270 VA: 0x180116E70 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0xF1580 Offset: 0xF0980 VA: 0x1800F1580
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x116E80 Offset: 0x116280 VA: 0x180116E80 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x116DB0 Offset: 0x1161B0 VA: 0x180116DB0
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x116E70 Offset: 0x116270 VA: 0x180116E70
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116E60 Offset: 0x116260 VA: 0x180116E60
	public float GetDuration() { }

	// RVA: 0xF4FD0 Offset: 0xF43D0 VA: 0x1800F4FD0 Slot: 7
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

	// RVA: 0xC65080 Offset: 0xC63680 VA: 0x180C65080
	public void .ctor() { }

}

