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

	// RVA: 0x11E0590 Offset: 0x11DEB90 VA: 0x1811E0590
	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	// RVA: 0x11E01F0 Offset: 0x11DE7F0 VA: 0x1811E01F0
	public void Cache(int frame) { }

	// RVA: 0x11E0520 Offset: 0x11DEB20 VA: 0x1811E0520
	public float Evaluate(float t, int length) { }

	// RVA: 0x11E04B0 Offset: 0x11DEAB0 VA: 0x1811E04B0
	public float Evaluate(float t) { }

	// RVA: 0x11E0560 Offset: 0x11DEB60 VA: 0x1811E0560 Slot: 2
	public override int GetHashCode() { }

}

