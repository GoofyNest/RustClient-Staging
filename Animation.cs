public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 3353
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { set; }
	public WrapMode postWrapMode { set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xF0200 Offset: 0xEF600 VA: 0x1800F0200
	// RVA: 0x181C9A0 Offset: 0x181AFA0 VA: 0x18181C9A0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xF0310 Offset: 0xEF710 VA: 0x1800F0310
	// RVA: 0x181C960 Offset: 0x181AF60 VA: 0x18181C960
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xF03F0 Offset: 0xEF7F0 VA: 0x1800F03F0
	// RVA: 0x181C9E0 Offset: 0x181AFE0 VA: 0x18181C9E0
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x181C7A0 Offset: 0x181ADA0 VA: 0x18181C7A0 Slot: 1
	protected override void Finalize() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x181C750 Offset: 0x181AD50 VA: 0x18181C750
	public float Evaluate(float time) { }

	// RVA: 0x181C920 Offset: 0x181AF20 VA: 0x18181C920
	public Keyframe[] get_keys() { }

	// RVA: 0x181CCD0 Offset: 0x181B2D0 VA: 0x18181CCD0
	public void set_keys(Keyframe[] value) { }

	// RVA: 0x181C230 Offset: 0x181A830 VA: 0x18181C230
	public int AddKey(Keyframe key) { }

	[NativeMethodAttribute] // RVA: 0xF05E0 Offset: 0xEF9E0 VA: 0x1800F05E0
	// RVA: 0x181C1E0 Offset: 0x181A7E0 VA: 0x18181C1E0
	private int AddKey_Internal(Keyframe key) { }

	// RVA: 0x181CDB0 Offset: 0x181B3B0 VA: 0x18181CDB0
	public Keyframe get_Item(int index) { }

	[NativeMethodAttribute] // RVA: 0xF0730 Offset: 0xEFB30 VA: 0x1800F0730
	// RVA: 0x181CE40 Offset: 0x181B440 VA: 0x18181CE40
	public int get_length() { }

	[FreeFunctionAttribute] // RVA: 0xF0850 Offset: 0xEFC50 VA: 0x1800F0850
	// RVA: 0x181CCD0 Offset: 0x181B2D0 VA: 0x18181CCD0
	private void SetKeys(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xF0A00 Offset: 0xEFE00 VA: 0x1800F0A00
	[NativeThrowsAttribute] // RVA: 0xF0A00 Offset: 0xEFE00 VA: 0x1800F0A00
	// RVA: 0x181C8B0 Offset: 0x181AEB0 VA: 0x18181C8B0
	private Keyframe GetKey(int index) { }

	[FreeFunctionAttribute] // RVA: 0xF0C40 Offset: 0xF0040 VA: 0x1800F0C40
	// RVA: 0x181C920 Offset: 0x181AF20 VA: 0x18181C920
	private Keyframe[] GetKeys() { }

	// RVA: 0x181C290 Offset: 0x181A890 VA: 0x18181C290
	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x181CA30 Offset: 0x181B030 VA: 0x18181CA30
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x181C2C0 Offset: 0x181A8C0 VA: 0x18181C2C0
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethodAttribute] // RVA: 0xF0DE0 Offset: 0xF01E0 VA: 0x1800F0DE0
	// RVA: 0x181CEC0 Offset: 0x181B4C0 VA: 0x18181CEC0
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethodAttribute] // RVA: 0xF0F30 Offset: 0xF0330 VA: 0x1800F0F30
	// RVA: 0x181CE80 Offset: 0x181B480 VA: 0x18181CE80
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x181CD60 Offset: 0x181B360 VA: 0x18181CD60
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181CD20 Offset: 0x181B320 VA: 0x18181CD20
	public void .ctor() { }

	// RVA: 0x181C530 Offset: 0x181AB30 VA: 0x18181C530 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x181C690 Offset: 0x181AC90 VA: 0x18181C690 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x181C850 Offset: 0x181AE50 VA: 0x18181C850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x181C190 Offset: 0x181A790 VA: 0x18181C190
	private int AddKey_Internal_Injected(ref Keyframe key) { }

	// RVA: 0x181C860 Offset: 0x181AE60 VA: 0x18181C860
	private void GetKey_Injected(int index, out Keyframe ret) { }

}

public sealed class AnimationClip : Motion // TypeDefIndex: 4479
{	// Properties
	[NativePropertyAttribute] // RVA: 0xC9230 Offset: 0xC8630 VA: 0x1800C9230
	public float length { get; }

	// Methods

	// RVA: 0x22DAB20 Offset: 0x22D9120 VA: 0x1822DAB20
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xC9030 Offset: 0xC8430 VA: 0x1800C9030
	// RVA: 0x22DAAE0 Offset: 0x22D90E0 VA: 0x1822DAAE0
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x22DABA0 Offset: 0x22D91A0 VA: 0x1822DABA0
	public float get_length() { }

}

internal enum AnimationEventSource // TypeDefIndex: 4496
{	// Fields
	public int value__; // 0x0
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;

}

public sealed class AnimationEvent // TypeDefIndex: 4497
{	// Fields
	internal float m_Time; // 0x10
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

	// Properties
	public string stringParameter { get; set; }
	public int intParameter { get; }
	public bool isFiredByAnimator { get; }
	public AnimatorClipInfo animatorClipInfo { get; }

	// Methods

	// RVA: 0x22DABE0 Offset: 0x22D91E0 VA: 0x1822DABE0
	public void .ctor() { }

	// RVA: 0x1A6C9A0 Offset: 0x1A6AFA0 VA: 0x181A6C9A0
	public string get_stringParameter() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_stringParameter(string value) { }

	// RVA: 0x22DACD0 Offset: 0x22D92D0 VA: 0x1822DACD0
	public int get_intParameter() { }

	// RVA: 0x22DACE0 Offset: 0x22D92E0 VA: 0x1822DACE0
	public bool get_isFiredByAnimator() { }

	// RVA: 0x22DAC70 Offset: 0x22D9270 VA: 0x1822DAC70
	public AnimatorClipInfo get_animatorClipInfo() { }

}

public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 4499
{	// Properties
	public bool isPlaying { get; }
	public AnimationState Item { get; }

	// Methods

	// RVA: 0x22DB5E0 Offset: 0x22D9BE0 VA: 0x1822DB5E0
	public void Stop() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB5E0 Offset: 0x22D9BE0 VA: 0x1822DB5E0
	private static void INTERNAL_CALL_Stop(Animation self) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB750 Offset: 0x22D9D50 VA: 0x1822DB750
	public bool get_isPlaying() { }

	// RVA: 0x22DB590 Offset: 0x22D9B90 VA: 0x1822DB590
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB710 Offset: 0x22D9D10 VA: 0x1822DB710
	public bool Play() { }

	// RVA: 0x22DB620 Offset: 0x22D9C20 VA: 0x1822DB620
	public bool Play(PlayMode mode) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB6B0 Offset: 0x22D9CB0 VA: 0x1822DB6B0
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB660 Offset: 0x22D9C60 VA: 0x1822DB660
	public bool Play(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB620 Offset: 0x22D9C20 VA: 0x1822DB620
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x22DB4A0 Offset: 0x22D9AA0 VA: 0x1822DB4A0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB590 Offset: 0x22D9B90 VA: 0x1822DB590
	internal AnimationState GetState(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB510 Offset: 0x22D9B10 VA: 0x1822DB510
	internal AnimationState GetStateAtIndex(int index) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB550 Offset: 0x22D9B50 VA: 0x1822DB550
	internal int GetStateCount() { }

}

private sealed class Animation.Enumerator : IEnumerator // TypeDefIndex: 4500
{	// Fields
	private Animation m_Outer; // 0x10
	private int m_CurrentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B9D20 Offset: 0x11B8320 VA: 0x1811B9D20
	internal void .ctor(Animation outer) { }

	// RVA: 0x22DD4F0 Offset: 0x22DBAF0 VA: 0x1822DD4F0 Slot: 5
	public object get_Current() { }

	// RVA: 0x22DD490 Offset: 0x22DBA90 VA: 0x1822DD490 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x117C6D0 Offset: 0x117ACD0 VA: 0x18117C6D0 Slot: 6
	public void Reset() { }

}

public sealed class AnimationState : TrackedReference // TypeDefIndex: 4501
{	// Properties
	public float time { set; }
	public float speed { get; set; }
	public float length { get; }

	// Methods

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB450 Offset: 0x22D9A50 VA: 0x1822DB450
	public void set_time(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB3C0 Offset: 0x22D99C0 VA: 0x1822DB3C0
	public float get_speed() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB400 Offset: 0x22D9A00 VA: 0x1822DB400
	public void set_speed(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DB380 Offset: 0x22D9980 VA: 0x1822DB380
	public float get_length() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
{
// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0xD0920 Offset: 0xCFD20 VA: 0x1800D0920
[RequiredByNativeCodeAttribute] // RVA: 0xD0920 Offset: 0xCFD20 VA: 0x1800D0920
[StaticAccessorAttribute] // RVA: 0xD0920 Offset: 0xCFD20 VA: 0x1800D0920
[NativeHeaderAttribute] // RVA: 0xD0920 Offset: 0xCFD20 VA: 0x1800D0920
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C6D0 Offset: 0x23BAD0 VA: 0x18023C6D0 Slot: 4
	public bool Equals(AnimationClipPlayable other) { }

}

public struct AnimationHumanStream // TypeDefIndex: 4504
{	// Fields
	private IntPtr stream; // 0x0

}

public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 4505
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23C810 Offset: 0x23BC10 VA: 0x18023C810
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C780 Offset: 0x23BB80 VA: 0x18023C780 Slot: 4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x22DACF0 Offset: 0x22D92F0 VA: 0x1822DACF0
	private static void .cctor() { }

}

public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 4506
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23C940 Offset: 0x23BD40 VA: 0x18023C940
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C8B0 Offset: 0x23BCB0 VA: 0x18023C8B0 Slot: 4
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x22DADE0 Offset: 0x22D93E0 VA: 0x1822DADE0
	private static void .cctor() { }

}

internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 4507
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CA70 Offset: 0x23BE70 VA: 0x18023CA70
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C9E0 Offset: 0x23BDE0 VA: 0x18023C9E0 Slot: 4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x22DAED0 Offset: 0x22D94D0 VA: 0x1822DAED0
	private static void .cctor() { }

}

internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 4508
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CBC0 Offset: 0x23BFC0 VA: 0x18023CBC0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CB10 Offset: 0x23BF10 VA: 0x18023CB10 Slot: 4
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x22DAFC0 Offset: 0x22D95C0 VA: 0x1822DAFC0
	private static void .cctor() { }

}

public struct AnimationPlayableOutput // TypeDefIndex: 4509
{	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

}

internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable> // TypeDefIndex: 4510
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CD10 Offset: 0x23C110 VA: 0x18023CD10
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CC60 Offset: 0x23C060 VA: 0x18023CC60 Slot: 4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x22DB0B0 Offset: 0x22D96B0 VA: 0x1822DB0B0
	private static void .cctor() { }

}

internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 4511
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CE60 Offset: 0x23C260 VA: 0x18023CE60
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CDB0 Offset: 0x23C1B0 VA: 0x18023CDB0 Slot: 4
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x22DB1A0 Offset: 0x22D97A0 VA: 0x1822DB1A0
	private static void .cctor() { }

}

public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 4512
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CF90 Offset: 0x23C390 VA: 0x18023CF90
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212EC0 Offset: 0x2122C0 VA: 0x180212EC0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CF00 Offset: 0x23C300 VA: 0x18023CF00 Slot: 4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x22DB290 Offset: 0x22D9890 VA: 0x1822DB290
	private static void .cctor() { }

}

public struct AnimationStream // TypeDefIndex: 4513
{	// Fields
	private uint m_AnimatorBindingsVersion; // 0x0
	private IntPtr constant; // 0x8
	private IntPtr input; // 0x10
	private IntPtr output; // 0x18
	private IntPtr workspace; // 0x20
	private IntPtr inputStreamAccessor; // 0x28
	private IntPtr animationHandleBinder; // 0x30

}

public class AnimationTriggers // TypeDefIndex: 4904
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104 // TypeDefIndex: 4901

// Namespace: 
internal class <Module> // TypeDefIndex: 4902

// Namespace: 
internal class <Module> // TypeDefIndex: 4903

// Namespace: UnityEngine.UI
[Serializable]
public class AnimationTriggers // TypeDefIndex: 4904
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[FormerlySerializedAsAttribute] // RVA: 0xE1A70 Offset: 0xE0E70 VA: 0x1800E1A70
	[SerializeField] // RVA: 0xE1A70 Offset: 0xE0E70 VA: 0x1800E1A70
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE1B70 Offset: 0xE0F70 VA: 0x1800E1B70
	[SerializeField] // RVA: 0xE1B70 Offset: 0xE0F70 VA: 0x1800E1B70
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0xE42D0 Offset: 0xE36D0 VA: 0x1800E42D0
	[SerializeField] // RVA: 0xE42D0 Offset: 0xE36D0 VA: 0x1800E42D0
	private string m_PressedTrigger; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE4740 Offset: 0xE3B40 VA: 0x1800E4740
	[SerializeField] // RVA: 0xE4740 Offset: 0xE3B40 VA: 0x1800E4740
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE4890 Offset: 0xE3C90 VA: 0x1800E4890
	[SerializeField] // RVA: 0xE4890 Offset: 0xE3C90 VA: 0x1800E4890
	private string m_DisabledTrigger; // 0x30

	// Properties
	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_normalTrigger() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_normalTrigger(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_highlightedTrigger() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_pressedTrigger() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_pressedTrigger(string value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_selectedTrigger() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_selectedTrigger(string value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_disabledTrigger() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_disabledTrigger(string value) { }

	// RVA: 0x10B5290 Offset: 0x10B3890 VA: 0x1810B5290
	public void .ctor() { }

}

public class AnimationFlagHandler : MonoBehaviour // TypeDefIndex: 8783
{	// Fields
	public Animator animator; // 0x18

	// Methods

	// RVA: 0x82AC80 Offset: 0x829280 VA: 0x18082AC80
	public void SetBoolTrue(string name) { }

	// RVA: 0x82AC50 Offset: 0x829250 VA: 0x18082AC50
	public void SetBoolFalse(string name) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimationEventForward : MonoBehaviour // TypeDefIndex: 9121
{	// Fields
	public GameObject targetObject; // 0x18

	// Methods

	// RVA: 0x829E60 Offset: 0x828460 VA: 0x180829E60
	public void Event(string type) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimationEvents : BaseMonoBehaviour // TypeDefIndex: 9326
{	// Fields
	public Transform rootObject; // 0x18
	public HeldEntity targetEntity; // 0x20
	[TooltipAttribute] // RVA: 0xE7870 Offset: 0xE6C70 VA: 0x1800E7870
	public string effectFolder; // 0x28
	public bool enforceClipWeights; // 0x30
	public string localFolder; // 0x38
	[TooltipAttribute] // RVA: 0xE7970 Offset: 0xE6D70 VA: 0x1800E7970
	public bool customLocalFolder; // 0x40
	public bool IsBusy; // 0x41
	private IAnimationEventReceiver cachedEventReceiver; // 0x48
	private bool hasCachedEventReceiver; // 0x50

	// Methods

	// RVA: 0x82A660 Offset: 0x828C60 VA: 0x18082A660
	protected void OnEnable() { }

	// RVA: 0x82A900 Offset: 0x828F00 VA: 0x18082A900
	public void SetBusy(int i) { }

	// RVA: 0x82A570 Offset: 0x828B70 VA: 0x18082A570
	public void Hide(string childName) { }

	// RVA: 0x82A9C0 Offset: 0x828FC0 VA: 0x18082A9C0
	public void Show(string childName) { }

	// RVA: 0x82A4C0 Offset: 0x828AC0 VA: 0x18082A4C0
	public void HideGameObject(string childName) { }

	// RVA: 0x82A910 Offset: 0x828F10 VA: 0x18082A910
	public void ShowGameObject(string childName) { }

	// RVA: 0x829EB0 Offset: 0x8284B0 VA: 0x180829EB0
	public void DoEffect(AnimationEvent evt) { }

	// RVA: 0x829E80 Offset: 0x828480 VA: 0x180829E80
	public void Broadcast(string strEvent) { }

	// RVA: 0x82A630 Offset: 0x828C30 VA: 0x18082A630
	public void Message(string strEvent) { }

	// RVA: 0x82A100 Offset: 0x828700 VA: 0x18082A100
	public void Event(string name) { }

	// RVA: 0x82AB60 Offset: 0x829160 VA: 0x18082AB60
	private void TryCacheEventReceiver() { }

	// RVA: 0x82A7E0 Offset: 0x828DE0 VA: 0x18082A7E0
	public void ReliableEvent(string name) { }

	// RVA: 0x82AA80 Offset: 0x829080 VA: 0x18082AA80
	public void Strike() { }

	// RVA: 0x82A080 Offset: 0x828680 VA: 0x18082A080
	public void Event_Strike() { }

	// RVA: 0x82AAF0 Offset: 0x8290F0 VA: 0x18082AAF0
	public void Throw() { }

	// RVA: 0x82A0C0 Offset: 0x8286C0 VA: 0x18082A0C0
	public void Event_Throw() { }

	// RVA: 0x828B10 Offset: 0x827110 VA: 0x180828B10
	public void PlaySound(SoundDefinition def) { }

	// RVA: 0x82A6F0 Offset: 0x828CF0 VA: 0x18082A6F0
	public void PlaySoundFirstPerson(SoundDefinition def) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

