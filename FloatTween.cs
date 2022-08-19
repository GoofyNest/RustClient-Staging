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

	// RVA: 0x117180 Offset: 0x116580 VA: 0x180117180
	public float get_startValue() { }

	// RVA: 0x1171C0 Offset: 0x1165C0 VA: 0x1801171C0
	public void set_startValue(float value) { }

	// RVA: 0x117190 Offset: 0x116590 VA: 0x180117190
	public float get_targetValue() { }

	// RVA: 0x1171D0 Offset: 0x1165D0 VA: 0x1801171D0
	public void set_targetValue(float value) { }

	// RVA: 0x116AE0 Offset: 0x115EE0 VA: 0x180116AE0 Slot: 6
	public float get_duration() { }

	// RVA: 0x1171A0 Offset: 0x1165A0 VA: 0x1801171A0
	public void set_duration(float value) { }

	// RVA: 0x1170C0 Offset: 0x1164C0 VA: 0x1801170C0 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1171B0 Offset: 0x1165B0 VA: 0x1801171B0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x19E680 Offset: 0x19DA80 VA: 0x18019E680 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x19E670 Offset: 0x19DA70 VA: 0x18019E670
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x1170C0 Offset: 0x1164C0 VA: 0x1801170C0
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116AE0 Offset: 0x115EE0 VA: 0x180116AE0
	public float GetDuration() { }

	// RVA: 0xF4FD0 Offset: 0xF43D0 VA: 0x1800F4FD0 Slot: 7
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

	// RVA: 0x117180 Offset: 0x116580 VA: 0x180117180
	public float get_startValue() { }

	// RVA: 0x1171C0 Offset: 0x1165C0 VA: 0x1801171C0
	public void set_startValue(float value) { }

	// RVA: 0x117190 Offset: 0x116590 VA: 0x180117190
	public float get_targetValue() { }

	// RVA: 0x1171D0 Offset: 0x1165D0 VA: 0x1801171D0
	public void set_targetValue(float value) { }

	// RVA: 0x116AE0 Offset: 0x115EE0 VA: 0x180116AE0 Slot: 6
	public float get_duration() { }

	// RVA: 0x1171A0 Offset: 0x1165A0 VA: 0x1801171A0
	public void set_duration(float value) { }

	// RVA: 0x1170C0 Offset: 0x1164C0 VA: 0x1801170C0 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1171B0 Offset: 0x1165B0 VA: 0x1801171B0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1170D0 Offset: 0x1164D0 VA: 0x1801170D0 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x117010 Offset: 0x116410 VA: 0x180117010
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x1170C0 Offset: 0x1164C0 VA: 0x1801170C0
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116AE0 Offset: 0x115EE0 VA: 0x180116AE0
	public float GetDuration() { }

	// RVA: 0xF4FD0 Offset: 0xF43D0 VA: 0x1800F4FD0 Slot: 7
	public bool ValidTarget() { }

}

public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 6754
{	// Methods

	// RVA: 0xC657B0 Offset: 0xC63DB0 VA: 0x180C657B0
	public void .ctor() { }

}

