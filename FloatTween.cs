internal struct FloatTween : ITweenValue // TypeDefIndex: 5042
{	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x117100 Offset: 0x116500 VA: 0x180117100
	public float get_startValue() { }

	// RVA: 0x117140 Offset: 0x116540 VA: 0x180117140
	public void set_startValue(float value) { }

	// RVA: 0x117110 Offset: 0x116510 VA: 0x180117110
	public float get_targetValue() { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_targetValue(float value) { }

	// RVA: 0x116A60 Offset: 0x115E60 VA: 0x180116A60 Slot: 6
	public float get_duration() { }

	// RVA: 0x117120 Offset: 0x116520 VA: 0x180117120
	public void set_duration(float value) { }

	// RVA: 0x117040 Offset: 0x116440 VA: 0x180117040 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x117130 Offset: 0x116530 VA: 0x180117130
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x19E600 Offset: 0x19DA00 VA: 0x18019E600 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x19E5F0 Offset: 0x19D9F0 VA: 0x18019E5F0
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x117040 Offset: 0x116440 VA: 0x180117040
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116A60 Offset: 0x115E60 VA: 0x180116A60
	public float GetDuration() { }

	// RVA: 0xF4F50 Offset: 0xF4350 VA: 0x1800F4F50 Slot: 7
	public bool ValidTarget() { }

}

public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 5043
{	// Methods

	// RVA: 0x10C60A0 Offset: 0x10C46A0 VA: 0x1810C60A0
	public void .ctor() { }

}

internal struct FloatTween : ITweenValue // TypeDefIndex: 6753
{	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x117100 Offset: 0x116500 VA: 0x180117100
	public float get_startValue() { }

	// RVA: 0x117140 Offset: 0x116540 VA: 0x180117140
	public void set_startValue(float value) { }

	// RVA: 0x117110 Offset: 0x116510 VA: 0x180117110
	public float get_targetValue() { }

	// RVA: 0x117150 Offset: 0x116550 VA: 0x180117150
	public void set_targetValue(float value) { }

	// RVA: 0x116A60 Offset: 0x115E60 VA: 0x180116A60 Slot: 6
	public float get_duration() { }

	// RVA: 0x117120 Offset: 0x116520 VA: 0x180117120
	public void set_duration(float value) { }

	// RVA: 0x117040 Offset: 0x116440 VA: 0x180117040 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x117130 Offset: 0x116530 VA: 0x180117130
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x117050 Offset: 0x116450 VA: 0x180117050 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x117040 Offset: 0x116440 VA: 0x180117040
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116A60 Offset: 0x115E60 VA: 0x180116A60
	public float GetDuration() { }

	// RVA: 0xF4F50 Offset: 0xF4350 VA: 0x1800F4F50 Slot: 7
	public bool ValidTarget() { }

}

public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 6754
{	// Methods

	// RVA: 0xC657B0 Offset: 0xC63DB0 VA: 0x180C657B0
	public void .ctor() { }

}

