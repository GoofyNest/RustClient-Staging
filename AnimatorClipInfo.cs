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

	// RVA: 0x212330 Offset: 0x211730 VA: 0x180212330
	public float get_weight() { }

	[FreeFunctionAttribute] // RVA: 0xC9800 Offset: 0xC8C00 VA: 0x1800C9800
	// RVA: 0x22DB790 Offset: 0x22D9D90 VA: 0x1822DB790
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }

}

