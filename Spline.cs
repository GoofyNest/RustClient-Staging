public sealed class Spline // TypeDefIndex: 11871
{	// Fields
	public const int k_Precision = 128;
	public const float k_Step = 0,0078125;
	public AnimationCurve curve; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_Loop; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_ZeroValue; // 0x1C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_Range; // 0x20
	private AnimationCurve m_InternalLoopingCurve; // 0x28
	private int frameCount; // 0x30
	public float[] cachedData; // 0x38

	// Methods

	// RVA: 0x11E0EF0 Offset: 0x11DF4F0 VA: 0x1811E0EF0
	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	// RVA: 0x11E0B50 Offset: 0x11DF150 VA: 0x1811E0B50
	public void Cache(int frame) { }

	// RVA: 0x11E0E80 Offset: 0x11DF480 VA: 0x1811E0E80
	public float Evaluate(float t, int length) { }

	// RVA: 0x11E0E10 Offset: 0x11DF410 VA: 0x1811E0E10
	public float Evaluate(float t) { }

	// RVA: 0x11E0EC0 Offset: 0x11DF4C0 VA: 0x1811E0EC0 Slot: 2
	public override int GetHashCode() { }

}

