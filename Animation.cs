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
	// RVA: 0x1809DE0 Offset: 0x18083E0 VA: 0x181809DE0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xF0310 Offset: 0xEF710 VA: 0x1800F0310
	// RVA: 0x1809DA0 Offset: 0x18083A0 VA: 0x181809DA0
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xF03F0 Offset: 0xEF7F0 VA: 0x1800F03F0
	// RVA: 0x1809E20 Offset: 0x1808420 VA: 0x181809E20
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x1809BE0 Offset: 0x18081E0 VA: 0x181809BE0 Slot: 1
	protected override void Finalize() { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x1809B90 Offset: 0x1808190 VA: 0x181809B90
	public float Evaluate(float time) { }

	// RVA: 0x1809D60 Offset: 0x1808360 VA: 0x181809D60
	public Keyframe[] get_keys() { }

	// RVA: 0x180A110 Offset: 0x1808710 VA: 0x18180A110
	public void set_keys(Keyframe[] value) { }

	// RVA: 0x1809670 Offset: 0x1807C70 VA: 0x181809670
	public int AddKey(Keyframe key) { }

	[NativeMethodAttribute] // RVA: 0xF05E0 Offset: 0xEF9E0 VA: 0x1800F05E0
	// RVA: 0x1809620 Offset: 0x1807C20 VA: 0x181809620
	private int AddKey_Internal(Keyframe key) { }

	// RVA: 0x180A1F0 Offset: 0x18087F0 VA: 0x18180A1F0
	public Keyframe get_Item(int index) { }

	[NativeMethodAttribute] // RVA: 0xF0730 Offset: 0xEFB30 VA: 0x1800F0730
	// RVA: 0x180A280 Offset: 0x1808880 VA: 0x18180A280
	public int get_length() { }

	[FreeFunctionAttribute] // RVA: 0xF0850 Offset: 0xEFC50 VA: 0x1800F0850
	// RVA: 0x180A110 Offset: 0x1808710 VA: 0x18180A110
	private void SetKeys(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xF0A00 Offset: 0xEFE00 VA: 0x1800F0A00
	[NativeThrowsAttribute] // RVA: 0xF0A00 Offset: 0xEFE00 VA: 0x1800F0A00
	// RVA: 0x1809CF0 Offset: 0x18082F0 VA: 0x181809CF0
	private Keyframe GetKey(int index) { }

	[FreeFunctionAttribute] // RVA: 0xF0C40 Offset: 0xF0040 VA: 0x1800F0C40
	// RVA: 0x1809D60 Offset: 0x1808360 VA: 0x181809D60
	private Keyframe[] GetKeys() { }

	// RVA: 0x18096D0 Offset: 0x1807CD0 VA: 0x1818096D0
	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x1809E70 Offset: 0x1808470 VA: 0x181809E70
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x1809700 Offset: 0x1807D00 VA: 0x181809700
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethodAttribute] // RVA: 0xF0DE0 Offset: 0xF01E0 VA: 0x1800F0DE0
	// RVA: 0x180A300 Offset: 0x1808900 VA: 0x18180A300
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethodAttribute] // RVA: 0xF0F30 Offset: 0xF0330 VA: 0x1800F0F30
	// RVA: 0x180A2C0 Offset: 0x18088C0 VA: 0x18180A2C0
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x180A1A0 Offset: 0x18087A0 VA: 0x18180A1A0
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180A160 Offset: 0x1808760 VA: 0x18180A160
	public void .ctor() { }

	// RVA: 0x1809970 Offset: 0x1807F70 VA: 0x181809970 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1809AD0 Offset: 0x18080D0 VA: 0x181809AD0 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x1809C90 Offset: 0x1808290 VA: 0x181809C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18095D0 Offset: 0x1807BD0 VA: 0x1818095D0
	private int AddKey_Internal_Injected(ref Keyframe key) { }

	// RVA: 0x1809CA0 Offset: 0x18082A0 VA: 0x181809CA0
	private void GetKey_Injected(int index, out Keyframe ret) { }

}

public sealed class AnimationClip : Motion // TypeDefIndex: 4479
{	// Properties
	[NativePropertyAttribute] // RVA: 0xC9230 Offset: 0xC8630 VA: 0x1800C9230
	public float length { get; }

	// Methods

	// RVA: 0x22DB340 Offset: 0x22D9940 VA: 0x1822DB340
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xC9030 Offset: 0xC8430 VA: 0x1800C9030
	// RVA: 0x22DB300 Offset: 0x22D9900 VA: 0x1822DB300
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x22DB3C0 Offset: 0x22D99C0 VA: 0x1822DB3C0
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

	// RVA: 0x22DB400 Offset: 0x22D9A00 VA: 0x1822DB400
	public void .ctor() { }

	// RVA: 0x1A58ED0 Offset: 0x1A574D0 VA: 0x181A58ED0
	public string get_stringParameter() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_stringParameter(string value) { }

	// RVA: 0x22DB4F0 Offset: 0x22D9AF0 VA: 0x1822DB4F0
	public int get_intParameter() { }

	// RVA: 0x22DB500 Offset: 0x22D9B00 VA: 0x1822DB500
	public bool get_isFiredByAnimator() { }

	// RVA: 0x22DB490 Offset: 0x22D9A90 VA: 0x1822DB490
	public AnimatorClipInfo get_animatorClipInfo() { }

}

public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 4499
{	// Properties
	public bool isPlaying { get; }
	public AnimationState Item { get; }

	// Methods

	// RVA: 0x22DBE00 Offset: 0x22DA400 VA: 0x1822DBE00
	public void Stop() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBE00 Offset: 0x22DA400 VA: 0x1822DBE00
	private static void INTERNAL_CALL_Stop(Animation self) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBF70 Offset: 0x22DA570 VA: 0x1822DBF70
	public bool get_isPlaying() { }

	// RVA: 0x22DBDB0 Offset: 0x22DA3B0 VA: 0x1822DBDB0
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBF30 Offset: 0x22DA530 VA: 0x1822DBF30
	public bool Play() { }

	// RVA: 0x22DBE40 Offset: 0x22DA440 VA: 0x1822DBE40
	public bool Play(PlayMode mode) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBED0 Offset: 0x22DA4D0 VA: 0x1822DBED0
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBE80 Offset: 0x22DA480 VA: 0x1822DBE80
	public bool Play(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBE40 Offset: 0x22DA440 VA: 0x1822DBE40
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x22DBCC0 Offset: 0x22DA2C0 VA: 0x1822DBCC0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBDB0 Offset: 0x22DA3B0 VA: 0x1822DBDB0
	internal AnimationState GetState(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBD30 Offset: 0x22DA330 VA: 0x1822DBD30
	internal AnimationState GetStateAtIndex(int index) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBD70 Offset: 0x22DA370 VA: 0x1822DBD70
	internal int GetStateCount() { }

}

private sealed class Animation.Enumerator : IEnumerator // TypeDefIndex: 4500
{	// Fields
	private Animation m_Outer; // 0x10
	private int m_CurrentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11BA3C0 Offset: 0x11B89C0 VA: 0x1811BA3C0
	internal void .ctor(Animation outer) { }

	// RVA: 0x22DDD10 Offset: 0x22DC310 VA: 0x1822DDD10 Slot: 5
	public object get_Current() { }

	// RVA: 0x22DDCB0 Offset: 0x22DC2B0 VA: 0x1822DDCB0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1180FF0 Offset: 0x117F5F0 VA: 0x181180FF0 Slot: 6
	public void Reset() { }

}

public sealed class AnimationState : TrackedReference // TypeDefIndex: 4501
{	// Properties
	public float time { set; }
	public float speed { get; set; }
	public float length { get; }

	// Methods

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBC70 Offset: 0x22DA270 VA: 0x1822DBC70
	public void set_time(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBBE0 Offset: 0x22DA1E0 VA: 0x1822DBBE0
	public float get_speed() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBC20 Offset: 0x22DA220 VA: 0x1822DBC20
	public void set_speed(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22DBBA0 Offset: 0x22DA1A0 VA: 0x1822DBBA0
	public float get_length() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
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

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
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

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C780 Offset: 0x23BB80 VA: 0x18023C780 Slot: 4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x22DB510 Offset: 0x22D9B10 VA: 0x1822DB510
	private static void .cctor() { }

}

public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 4506
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23C940 Offset: 0x23BD40 VA: 0x18023C940
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C8B0 Offset: 0x23BCB0 VA: 0x18023C8B0 Slot: 4
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x22DB600 Offset: 0x22D9C00 VA: 0x1822DB600
	private static void .cctor() { }

}

internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 4507
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CA70 Offset: 0x23BE70 VA: 0x18023CA70
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C9E0 Offset: 0x23BDE0 VA: 0x18023C9E0 Slot: 4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x22DB6F0 Offset: 0x22D9CF0 VA: 0x1822DB6F0
	private static void .cctor() { }

}

internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 4508
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CBC0 Offset: 0x23BFC0 VA: 0x18023CBC0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CB10 Offset: 0x23BF10 VA: 0x18023CB10 Slot: 4
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x22DB7E0 Offset: 0x22D9DE0 VA: 0x1822DB7E0
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

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CC60 Offset: 0x23C060 VA: 0x18023CC60 Slot: 4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x22DB8D0 Offset: 0x22D9ED0 VA: 0x1822DB8D0
	private static void .cctor() { }

}

internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 4511
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CE60 Offset: 0x23C260 VA: 0x18023CE60
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CDB0 Offset: 0x23C1B0 VA: 0x18023CDB0 Slot: 4
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x22DB9C0 Offset: 0x22D9FC0 VA: 0x1822DB9C0
	private static void .cctor() { }

}

public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 4512
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CF90 Offset: 0x23C390 VA: 0x18023CF90
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x2122F0 Offset: 0x2116F0 VA: 0x1802122F0 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CF00 Offset: 0x23C300 VA: 0x18023CF00 Slot: 4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x22DBAB0 Offset: 0x22DA0B0 VA: 0x1822DBAB0
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

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_normalTrigger() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_normalTrigger(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_highlightedTrigger() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_pressedTrigger() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_pressedTrigger(string value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_selectedTrigger() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_selectedTrigger(string value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_disabledTrigger() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void set_disabledTrigger(string value) { }

	// RVA: 0x10B5D00 Offset: 0x10B4300 VA: 0x1810B5D00
	public void .ctor() { }

}

public class AnimationFlagHandler : MonoBehaviour // TypeDefIndex: 8783
{	// Fields
	public Animator animator; // 0x18

	// Methods

	// RVA: 0x82B1D0 Offset: 0x8297D0 VA: 0x18082B1D0
	public void SetBoolTrue(string name) { }

	// RVA: 0x82B1A0 Offset: 0x8297A0 VA: 0x18082B1A0
	public void SetBoolFalse(string name) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimationEventForward : MonoBehaviour // TypeDefIndex: 9121
{	// Fields
	public GameObject targetObject; // 0x18

	// Methods

	// RVA: 0x82A3B0 Offset: 0x8289B0 VA: 0x18082A3B0
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

	// RVA: 0x82ABB0 Offset: 0x8291B0 VA: 0x18082ABB0
	protected void OnEnable() { }

	// RVA: 0x82AE50 Offset: 0x829450 VA: 0x18082AE50
	public void SetBusy(int i) { }

	// RVA: 0x82AAC0 Offset: 0x8290C0 VA: 0x18082AAC0
	public void Hide(string childName) { }

	// RVA: 0x82AF10 Offset: 0x829510 VA: 0x18082AF10
	public void Show(string childName) { }

	// RVA: 0x82AA10 Offset: 0x829010 VA: 0x18082AA10
	public void HideGameObject(string childName) { }

	// RVA: 0x82AE60 Offset: 0x829460 VA: 0x18082AE60
	public void ShowGameObject(string childName) { }

	// RVA: 0x82A400 Offset: 0x828A00 VA: 0x18082A400
	public void DoEffect(AnimationEvent evt) { }

	// RVA: 0x82A3D0 Offset: 0x8289D0 VA: 0x18082A3D0
	public void Broadcast(string strEvent) { }

	// RVA: 0x82AB80 Offset: 0x829180 VA: 0x18082AB80
	public void Message(string strEvent) { }

	// RVA: 0x82A650 Offset: 0x828C50 VA: 0x18082A650
	public void Event(string name) { }

	// RVA: 0x82B0B0 Offset: 0x8296B0 VA: 0x18082B0B0
	private void TryCacheEventReceiver() { }

	// RVA: 0x82AD30 Offset: 0x829330 VA: 0x18082AD30
	public void ReliableEvent(string name) { }

	// RVA: 0x82AFD0 Offset: 0x8295D0 VA: 0x18082AFD0
	public void Strike() { }

	// RVA: 0x82A5D0 Offset: 0x828BD0 VA: 0x18082A5D0
	public void Event_Strike() { }

	// RVA: 0x82B040 Offset: 0x829640 VA: 0x18082B040
	public void Throw() { }

	// RVA: 0x82A610 Offset: 0x828C10 VA: 0x18082A610
	public void Event_Throw() { }

	// RVA: 0x8290A0 Offset: 0x8276A0 VA: 0x1808290A0
	public void PlaySound(SoundDefinition def) { }

	// RVA: 0x82AC40 Offset: 0x829240 VA: 0x18082AC40
	public void PlaySoundFirstPerson(SoundDefinition def) { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

}

