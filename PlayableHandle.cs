public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3870
{	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE5E0 Offset: 0xFD9E0 VA: 0x1800FE5E0
	|-PlayableHandle.IsPlayableOfType<object>
	|
	|-RVA: 0xFE1E0 Offset: 0xFD5E0 VA: 0x1800FE1E0
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-RVA: 0xFE260 Offset: 0xFD660 VA: 0x1800FE260
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-RVA: 0xFE2E0 Offset: 0xFD6E0 VA: 0x1800FE2E0
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0xFE360 Offset: 0xFD760 VA: 0x1800FE360
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-RVA: 0xFE3E0 Offset: 0xFD7E0 VA: 0x1800FE3E0
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-RVA: 0xFE460 Offset: 0xFD860 VA: 0x1800FE460
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-RVA: 0xFE4E0 Offset: 0xFD8E0 VA: 0x1800FE4E0
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-RVA: 0xFE560 Offset: 0xFD960 VA: 0x1800FE560
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	*/

	// RVA: 0x18FA700 Offset: 0x18F8D00 VA: 0x1818FA700
	public static PlayableHandle get_Null() { }

	// RVA: 0x18FA770 Offset: 0x18F8D70 VA: 0x1818FA770
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x217150 Offset: 0x216550 VA: 0x180217150 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x217240 Offset: 0x216640 VA: 0x180217240 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x2172E0 Offset: 0x2166E0 VA: 0x1802172E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18FA500 Offset: 0x18F8B00 VA: 0x1818FA500
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x217390 Offset: 0x216790 VA: 0x180217390
	internal bool IsValid() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x81360 Offset: 0x80760 VA: 0x180081360
	[FreeFunctionAttribute] // RVA: 0x81360 Offset: 0x80760 VA: 0x180081360
	// RVA: 0x217320 Offset: 0x216720 VA: 0x180217320
	internal Type GetPlayableType() { }

	// RVA: 0x18FA6C0 Offset: 0x18F8CC0 VA: 0x1818FA6C0
	private static void .cctor() { }

	// RVA: 0x18FA610 Offset: 0x18F8C10 VA: 0x1818FA610
	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x18FA560 Offset: 0x18F8B60 VA: 0x1818FA560
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

}

