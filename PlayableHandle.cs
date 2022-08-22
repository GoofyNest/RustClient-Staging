public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3870
{	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE560 Offset: 0xFD960 VA: 0x1800FE560
	|-PlayableHandle.IsPlayableOfType<object>
	|
	|-RVA: 0xFE160 Offset: 0xFD560 VA: 0x1800FE160
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-RVA: 0xFE1E0 Offset: 0xFD5E0 VA: 0x1800FE1E0
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-RVA: 0xFE260 Offset: 0xFD660 VA: 0x1800FE260
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0xFE2E0 Offset: 0xFD6E0 VA: 0x1800FE2E0
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-RVA: 0xFE360 Offset: 0xFD760 VA: 0x1800FE360
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-RVA: 0xFE3E0 Offset: 0xFD7E0 VA: 0x1800FE3E0
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-RVA: 0xFE460 Offset: 0xFD860 VA: 0x1800FE460
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-RVA: 0xFE4E0 Offset: 0xFD8E0 VA: 0x1800FE4E0
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	*/

	// RVA: 0x18FA0A0 Offset: 0x18F86A0 VA: 0x1818FA0A0
	public static PlayableHandle get_Null() { }

	// RVA: 0x18FA110 Offset: 0x18F8710 VA: 0x1818FA110
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x2177A0 Offset: 0x216BA0 VA: 0x1802177A0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x217890 Offset: 0x216C90 VA: 0x180217890 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x217930 Offset: 0x216D30 VA: 0x180217930 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F9EA0 Offset: 0x18F84A0 VA: 0x1818F9EA0
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179E0 Offset: 0x216DE0 VA: 0x1802179E0
	internal bool IsValid() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x81410 Offset: 0x80810 VA: 0x180081410
	[FreeFunctionAttribute] // RVA: 0x81410 Offset: 0x80810 VA: 0x180081410
	// RVA: 0x217970 Offset: 0x216D70 VA: 0x180217970
	internal Type GetPlayableType() { }

	// RVA: 0x18FA060 Offset: 0x18F8660 VA: 0x1818FA060
	private static void .cctor() { }

	// RVA: 0x18F9FB0 Offset: 0x18F85B0 VA: 0x1818F9FB0
	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x18F9F00 Offset: 0x18F8500 VA: 0x1818F9F00
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

}

