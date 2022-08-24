public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3870
{	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	public static PlayableHandle Null { get; }


	[VisibleToOtherModulesAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-PlayableHandle.IsPlayableOfType<object>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	*/

	public static PlayableHandle get_Null() { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	public override bool Equals(object p) { }

	public bool Equals(PlayableHandle other) { }

	public override int GetHashCode() { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal bool IsValid() { }

	[FreeFunctionAttribute] // RVA: 0x814C0 Offset: 0x808C0 VA: 0x1800814C0
	[VisibleToOtherModulesAttribute] // RVA: 0x814C0 Offset: 0x808C0 VA: 0x1800814C0
	internal Type GetPlayableType() { }

	private static void .cctor() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

}

