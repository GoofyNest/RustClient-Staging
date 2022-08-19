public struct AnimatorClipInfo // TypeDefIndex: 4484
{	// Fields
	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4

	// Properties
	public AnimationClip clip { get; }
	public float weight { get; }

	// Methods

	// RVA: 0x23D0B0 Offset: 0x23C4B0 VA: 0x18023D0B0
	public AnimationClip get_clip() { }

	// RVA: 0x2123B0 Offset: 0x2117B0 VA: 0x1802123B0
	public float get_weight() { }

	[FreeFunctionAttribute] // RVA: 0xC9770 Offset: 0xC8B70 VA: 0x1800C9770
	// RVA: 0x22DB690 Offset: 0x22D9C90 VA: 0x1822DB690
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }

}

