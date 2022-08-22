public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3870
{	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	public static PlayableHandle Null { get; }


	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	public static PlayableHandle get_Null() { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	public override bool Equals(object p) { }

	public bool Equals(PlayableHandle other) { }

	public override int GetHashCode() { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal bool IsValid() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x81410 Offset: 0x80810 VA: 0x180081410
	[FreeFunctionAttribute] // RVA: 0x81410 Offset: 0x80810 VA: 0x180081410
	internal Type GetPlayableType() { }

	private static void .cctor() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

}

