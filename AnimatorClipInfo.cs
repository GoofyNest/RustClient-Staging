public struct AnimatorClipInfo // TypeDefIndex: 4484
{	// Fields
	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4

	// Properties
	public AnimationClip clip { get; }
	public float weight { get; }

	// Methods

	// RVA: 0x23D030 Offset: 0x23C430 VA: 0x18023D030
	public AnimationClip get_clip() { }

	// RVA: 0x211760 Offset: 0x210B60 VA: 0x180211760
	public float get_weight() { }

	[FreeFunctionAttribute] // RVA: 0xC9800 Offset: 0xC8C00 VA: 0x1800C9800
	// RVA: 0x22DBFB0 Offset: 0x22DA5B0 VA: 0x1822DBFB0
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }

}

