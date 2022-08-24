public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 3353
{	internal IntPtr m_Ptr; // 0x10

	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { set; }
	public WrapMode postWrapMode { set; }


	[FreeFunctionAttribute] // RVA: 0xF0330 Offset: 0xEF730 VA: 0x1800F0330
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xF0440 Offset: 0xEF840 VA: 0x1800F0440
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xF0520 Offset: 0xEF920 VA: 0x1800F0520
	private bool Internal_Equals(IntPtr other) { }

	protected override void Finalize() { }

	[ThreadSafeAttribute] // RVA: 0x93E10 Offset: 0x93210 VA: 0x180093E10
	public float Evaluate(float time) { }

	public Keyframe[] get_keys() { }

	public void set_keys(Keyframe[] value) { }

	public int AddKey(Keyframe key) { }

	[NativeMethodAttribute] // RVA: 0xF0710 Offset: 0xEFB10 VA: 0x1800F0710
	private int AddKey_Internal(Keyframe key) { }

	public Keyframe get_Item(int index) { }

	[NativeMethodAttribute] // RVA: 0xF07D0 Offset: 0xEFBD0 VA: 0x1800F07D0
	public int get_length() { }

	[FreeFunctionAttribute] // RVA: 0xF0980 Offset: 0xEFD80 VA: 0x1800F0980
	private void SetKeys(Keyframe[] keys) { }

	[NativeThrowsAttribute] // RVA: 0xF0A90 Offset: 0xEFE90 VA: 0x1800F0A90
	[FreeFunctionAttribute] // RVA: 0xF0A90 Offset: 0xEFE90 VA: 0x1800F0A90
	private Keyframe GetKey(int index) { }

	[FreeFunctionAttribute] // RVA: 0xF0D00 Offset: 0xF0100 VA: 0x1800F0D00
	private Keyframe[] GetKeys() { }

	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethodAttribute] // RVA: 0xF0EA0 Offset: 0xF02A0 VA: 0x1800F0EA0
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethodAttribute] // RVA: 0xF0FF0 Offset: 0xF03F0 VA: 0x1800F0FF0
	public void set_postWrapMode(WrapMode value) { }

	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor() { }

	public override bool Equals(object o) { }

	public bool Equals(AnimationCurve other) { }

	public override int GetHashCode() { }

	private int AddKey_Internal_Injected(ref Keyframe key) { }

	private void GetKey_Injected(int index, out Keyframe ret) { }

}

public sealed class AnimationClip : Motion // TypeDefIndex: 4479
{	[NativePropertyAttribute] // RVA: 0xC9370 Offset: 0xC8770 VA: 0x1800C9370
	public float length { get; }


	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xC9130 Offset: 0xC8530 VA: 0x1800C9130
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	public float get_length() { }

}

internal enum AnimationEventSource // TypeDefIndex: 4496
{	public int value__; // 0x0
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;

}

public sealed class AnimationEvent // TypeDefIndex: 4497
{	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	public string stringParameter { get; set; }
	public int intParameter { get; }
	public bool isFiredByAnimator { get; }
	public AnimatorClipInfo animatorClipInfo { get; }


	public void .ctor() { }

	public string get_stringParameter() { }

	public void set_stringParameter(string value) { }

	public int get_intParameter() { }

	public bool get_isFiredByAnimator() { }

	public AnimatorClipInfo get_animatorClipInfo() { }

}

public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 4499
{	public bool isPlaying { get; }
	public AnimationState Item { get; }


	public void Stop() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void INTERNAL_CALL_Stop(Animation self) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_isPlaying() { }

	public AnimationState get_Item(string name) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool Play() { }

	public bool Play(PlayMode mode) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool Play(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool PlayDefaultAnimation(PlayMode mode) { }

	public IEnumerator GetEnumerator() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal AnimationState GetState(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal AnimationState GetStateAtIndex(int index) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal int GetStateCount() { }

}

private sealed class Animation.Enumerator : IEnumerator // TypeDefIndex: 4500
{	private Animation m_Outer; // 0x10
	private int m_CurrentIndex; // 0x18

	public object Current { get; }


	internal void .ctor(Animation outer) { }

	public object get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

}

public sealed class AnimationState : TrackedReference // TypeDefIndex: 4501
{	public float time { set; }
	public float speed { get; set; }
	public float length { get; }


	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_time(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_speed() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_speed(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_length() { }

	public void .ctor() { }

}

public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
{
[NativeHeaderAttribute] // RVA: 0xD0A50 Offset: 0xCFE50 VA: 0x1800D0A50
[RequiredByNativeCodeAttribute] // RVA: 0xD0A50 Offset: 0xCFE50 VA: 0x1800D0A50
[StaticAccessorAttribute] // RVA: 0xD0A50 Offset: 0xCFE50 VA: 0x1800D0A50
[NativeHeaderAttribute] // RVA: 0xD0A50 Offset: 0xCFE50 VA: 0x1800D0A50
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
	private PlayableHandle m_Handle; // 0x0


	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationClipPlayable other) { }

}

public struct AnimationHumanStream // TypeDefIndex: 4504
{	private IntPtr stream; // 0x0

}

public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 4505
{	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationLayerMixerPlayable other) { }

	private static void .cctor() { }

}

public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 4506
{	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationMixerPlayable other) { }

	private static void .cctor() { }

}

internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 4507
{	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0


	private void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	private static void .cctor() { }

}

internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 4508
{	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationOffsetPlayable other) { }

	private static void .cctor() { }

}

public struct AnimationPlayableOutput // TypeDefIndex: 4509
{	private PlayableOutputHandle m_Handle; // 0x0

}

internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable> // TypeDefIndex: 4510
{	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationPosePlayable other) { }

	private static void .cctor() { }

}

internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 4511
{	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationRemoveScalePlayable other) { }

	private static void .cctor() { }

}

public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 4512
{	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationScriptPlayable other) { }

	private static void .cctor() { }

}

public struct AnimationStream // TypeDefIndex: 4513
{	private uint m_AnimatorBindingsVersion; // 0x0
	private IntPtr constant; // 0x8
	private IntPtr input; // 0x10
	private IntPtr output; // 0x18
	private IntPtr workspace; // 0x20
	private IntPtr inputStreamAccessor; // 0x28
	private IntPtr animationHandleBinder; // 0x30

}

public class AnimationTriggers // TypeDefIndex: 4904
{
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104 // TypeDefIndex: 4901

internal class <Module> // TypeDefIndex: 4902

internal class <Module> // TypeDefIndex: 4903

[Serializable]
public class AnimationTriggers // TypeDefIndex: 4904
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[FormerlySerializedAsAttribute] // RVA: 0xE1AE0 Offset: 0xE0EE0 VA: 0x1800E1AE0
	[SerializeField] // RVA: 0xE1AE0 Offset: 0xE0EE0 VA: 0x1800E1AE0
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE1BE0 Offset: 0xE0FE0 VA: 0x1800E1BE0
	[SerializeField] // RVA: 0xE1BE0 Offset: 0xE0FE0 VA: 0x1800E1BE0
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0xE43F0 Offset: 0xE37F0 VA: 0x1800E43F0
	[SerializeField] // RVA: 0xE43F0 Offset: 0xE37F0 VA: 0x1800E43F0
	private string m_PressedTrigger; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE4860 Offset: 0xE3C60 VA: 0x1800E4860
	[SerializeField] // RVA: 0xE4860 Offset: 0xE3C60 VA: 0x1800E4860
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE49B0 Offset: 0xE3DB0 VA: 0x1800E49B0
	[SerializeField] // RVA: 0xE49B0 Offset: 0xE3DB0 VA: 0x1800E49B0
	private string m_DisabledTrigger; // 0x30

	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }


	public string get_normalTrigger() { }

	public void set_normalTrigger(string value) { }

	public string get_highlightedTrigger() { }

	public void set_highlightedTrigger(string value) { }

	public string get_pressedTrigger() { }

	public void set_pressedTrigger(string value) { }

	public string get_selectedTrigger() { }

	public void set_selectedTrigger(string value) { }

	public string get_disabledTrigger() { }

	public void set_disabledTrigger(string value) { }

	public void .ctor() { }

}

public class AnimationFlagHandler : MonoBehaviour // TypeDefIndex: 8783
{	public Animator animator; // 0x18


	public void SetBoolTrue(string name) { }

	public void SetBoolFalse(string name) { }

	public void .ctor() { }

}

public class AnimationEventForward : MonoBehaviour // TypeDefIndex: 9121
{	public GameObject targetObject; // 0x18


	public void Event(string type) { }

	public void .ctor() { }

}

public class AnimationEvents : BaseMonoBehaviour // TypeDefIndex: 9326
{	public Transform rootObject; // 0x18
	public HeldEntity targetEntity; // 0x20
	[TooltipAttribute] // RVA: 0xE7990 Offset: 0xE6D90 VA: 0x1800E7990
	public string effectFolder; // 0x28
	public bool enforceClipWeights; // 0x30
	public string localFolder; // 0x38
	[TooltipAttribute] // RVA: 0xE7A90 Offset: 0xE6E90 VA: 0x1800E7A90
	public bool customLocalFolder; // 0x40
	public bool IsBusy; // 0x41
	private IAnimationEventReceiver cachedEventReceiver; // 0x48
	private bool hasCachedEventReceiver; // 0x50


	protected void OnEnable() { }

	public void SetBusy(int i) { }

	public void Hide(string childName) { }

	public void Show(string childName) { }

	public void HideGameObject(string childName) { }

	public void ShowGameObject(string childName) { }

	public void DoEffect(AnimationEvent evt) { }

	public void Broadcast(string strEvent) { }

	public void Message(string strEvent) { }

	public void Event(string name) { }

	private void TryCacheEventReceiver() { }

	public void ReliableEvent(string name) { }

	public void Strike() { }

	public void Event_Strike() { }

	public void Throw() { }

	public void Event_Throw() { }

	public void PlaySound(SoundDefinition def) { }

	public void PlaySoundFirstPerson(SoundDefinition def) { }

	public void .ctor() { }

}

