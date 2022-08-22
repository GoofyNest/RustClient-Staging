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

	// RVA: 0x11E0850 Offset: 0x11DEE50 VA: 0x1811E0850
	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	// RVA: 0x11E04B0 Offset: 0x11DEAB0 VA: 0x1811E04B0
	public void Cache(int frame) { }

	// RVA: 0x11E07E0 Offset: 0x11DEDE0 VA: 0x1811E07E0
	public float Evaluate(float t, int length) { }

	// RVA: 0x11E0770 Offset: 0x11DED70 VA: 0x1811E0770
	public float Evaluate(float t) { }

	// RVA: 0x11E0820 Offset: 0x11DEE20 VA: 0x1811E0820 Slot: 2
	public override int GetHashCode() { }

}

