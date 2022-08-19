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

	[FreeFunctionAttribute] // RVA: 0xF0280 Offset: 0xEF680 VA: 0x1800F0280
	// RVA: 0x181C6E0 Offset: 0x181ACE0 VA: 0x18181C6E0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xF0360 Offset: 0xEF760 VA: 0x1800F0360
	// RVA: 0x181C6A0 Offset: 0x181ACA0 VA: 0x18181C6A0
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xF04C0 Offset: 0xEF8C0 VA: 0x1800F04C0
	// RVA: 0x181C720 Offset: 0x181AD20 VA: 0x18181C720
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x181C4E0 Offset: 0x181AAE0 VA: 0x18181C4E0 Slot: 1
	protected override void Finalize() { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x181C490 Offset: 0x181AA90 VA: 0x18181C490
	public float Evaluate(float time) { }

	// RVA: 0x181C660 Offset: 0x181AC60 VA: 0x18181C660
	public Keyframe[] get_keys() { }

	// RVA: 0x181CA10 Offset: 0x181B010 VA: 0x18181CA10
	public void set_keys(Keyframe[] value) { }

	// RVA: 0x181BF70 Offset: 0x181A570 VA: 0x18181BF70
	public int AddKey(Keyframe key) { }

	[NativeMethodAttribute] // RVA: 0xF06A0 Offset: 0xEFAA0 VA: 0x1800F06A0
	// RVA: 0x181BF20 Offset: 0x181A520 VA: 0x18181BF20
	private int AddKey_Internal(Keyframe key) { }

	// RVA: 0x181CAF0 Offset: 0x181B0F0 VA: 0x18181CAF0
	public Keyframe get_Item(int index) { }

	[NativeMethodAttribute] // RVA: 0xF07C0 Offset: 0xEFBC0 VA: 0x1800F07C0
	// RVA: 0x181CB80 Offset: 0x181B180 VA: 0x18181CB80
	public int get_length() { }

	[FreeFunctionAttribute] // RVA: 0xF0970 Offset: 0xEFD70 VA: 0x1800F0970
	// RVA: 0x181CA10 Offset: 0x181B010 VA: 0x18181CA10
	private void SetKeys(Keyframe[] keys) { }

	[NativeThrowsAttribute] // RVA: 0xF0AB0 Offset: 0xEFEB0 VA: 0x1800F0AB0
	[FreeFunctionAttribute] // RVA: 0xF0AB0 Offset: 0xEFEB0 VA: 0x1800F0AB0
	// RVA: 0x181C5F0 Offset: 0x181ABF0 VA: 0x18181C5F0
	private Keyframe GetKey(int index) { }

	[FreeFunctionAttribute] // RVA: 0xF0D00 Offset: 0xF0100 VA: 0x1800F0D00
	// RVA: 0x181C660 Offset: 0x181AC60 VA: 0x18181C660
	private Keyframe[] GetKeys() { }

	// RVA: 0x181BFD0 Offset: 0x181A5D0 VA: 0x18181BFD0
	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x181C770 Offset: 0x181AD70 VA: 0x18181C770
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x181C000 Offset: 0x181A600 VA: 0x18181C000
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethodAttribute] // RVA: 0xF0EA0 Offset: 0xF02A0 VA: 0x1800F0EA0
	// RVA: 0x181CC00 Offset: 0x181B200 VA: 0x18181CC00
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethodAttribute] // RVA: 0xF0FB0 Offset: 0xF03B0 VA: 0x1800F0FB0
	// RVA: 0x181CBC0 Offset: 0x181B1C0 VA: 0x18181CBC0
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x181CAA0 Offset: 0x181B0A0 VA: 0x18181CAA0
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181CA60 Offset: 0x181B060 VA: 0x18181CA60
	public void .ctor() { }

	// RVA: 0x181C270 Offset: 0x181A870 VA: 0x18181C270 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x181C3D0 Offset: 0x181A9D0 VA: 0x18181C3D0 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x181C590 Offset: 0x181AB90 VA: 0x18181C590 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x181BED0 Offset: 0x181A4D0 VA: 0x18181BED0
	private int AddKey_Internal_Injected(ref Keyframe key) { }

	// RVA: 0x181C5A0 Offset: 0x181ABA0 VA: 0x18181C5A0
	private void GetKey_Injected(int index, out Keyframe ret) { }

}

public sealed class AnimationClip : Motion // TypeDefIndex: 4479
{	// Properties
	[NativePropertyAttribute] // RVA: 0xC91D0 Offset: 0xC85D0 VA: 0x1800C91D0
	public float length { get; }

	// Methods

	// RVA: 0x22DAA20 Offset: 0x22D9020 VA: 0x1822DAA20
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xC8F90 Offset: 0xC8390 VA: 0x1800C8F90
	// RVA: 0x22DA9E0 Offset: 0x22D8FE0 VA: 0x1822DA9E0
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x22DAAA0 Offset: 0x22D90A0 VA: 0x1822DAAA0
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

	// RVA: 0x22DAAE0 Offset: 0x22D90E0 VA: 0x1822DAAE0
	public void .ctor() { }

	// RVA: 0x1A6C720 Offset: 0x1A6AD20 VA: 0x181A6C720
	public string get_stringParameter() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_stringParameter(string value) { }

	// RVA: 0x22DABD0 Offset: 0x22D91D0 VA: 0x1822DABD0
	public int get_intParameter() { }

	// RVA: 0x22DABE0 Offset: 0x22D91E0 VA: 0x1822DABE0
	public bool get_isFiredByAnimator() { }

	// RVA: 0x22DAB70 Offset: 0x22D9170 VA: 0x1822DAB70
	public AnimatorClipInfo get_animatorClipInfo() { }

}

public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 4499
{	// Properties
	public bool isPlaying { get; }
	public AnimationState Item { get; }

	// Methods

	// RVA: 0x22DB4E0 Offset: 0x22D9AE0 VA: 0x1822DB4E0
	public void Stop() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB4E0 Offset: 0x22D9AE0 VA: 0x1822DB4E0
	private static void INTERNAL_CALL_Stop(Animation self) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB650 Offset: 0x22D9C50 VA: 0x1822DB650
	public bool get_isPlaying() { }

	// RVA: 0x22DB490 Offset: 0x22D9A90 VA: 0x1822DB490
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB610 Offset: 0x22D9C10 VA: 0x1822DB610
	public bool Play() { }

	// RVA: 0x22DB520 Offset: 0x22D9B20 VA: 0x1822DB520
	public bool Play(PlayMode mode) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB5B0 Offset: 0x22D9BB0 VA: 0x1822DB5B0
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB560 Offset: 0x22D9B60 VA: 0x1822DB560
	public bool Play(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB520 Offset: 0x22D9B20 VA: 0x1822DB520
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x22DB3A0 Offset: 0x22D99A0 VA: 0x1822DB3A0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB490 Offset: 0x22D9A90 VA: 0x1822DB490
	internal AnimationState GetState(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB410 Offset: 0x22D9A10 VA: 0x1822DB410
	internal AnimationState GetStateAtIndex(int index) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB450 Offset: 0x22D9A50 VA: 0x1822DB450
	internal int GetStateCount() { }

}

private sealed class Animation.Enumerator : IEnumerator // TypeDefIndex: 4500
{	// Fields
	private Animation m_Outer; // 0x10
	private int m_CurrentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B9A60 Offset: 0x11B8060 VA: 0x1811B9A60
	internal void .ctor(Animation outer) { }

	// RVA: 0x22DD3F0 Offset: 0x22DB9F0 VA: 0x1822DD3F0 Slot: 5
	public object get_Current() { }

	// RVA: 0x22DD390 Offset: 0x22DB990 VA: 0x1822DD390 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x117C410 Offset: 0x117AA10 VA: 0x18117C410 Slot: 6
	public void Reset() { }

}

public sealed class AnimationState : TrackedReference // TypeDefIndex: 4501
{	// Properties
	public float time { set; }
	public float speed { get; set; }
	public float length { get; }

	// Methods

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB350 Offset: 0x22D9950 VA: 0x1822DB350
	public void set_time(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB2C0 Offset: 0x22D98C0 VA: 0x1822DB2C0
	public float get_speed() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB300 Offset: 0x22D9900 VA: 0x1822DB300
	public void set_speed(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22DB280 Offset: 0x22D9880 VA: 0x1822DB280
	public float get_length() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
{
// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0xD0890 Offset: 0xCFC90 VA: 0x1800D0890
[RequiredByNativeCodeAttribute] // RVA: 0xD0890 Offset: 0xCFC90 VA: 0x1800D0890
[StaticAccessorAttribute] // RVA: 0xD0890 Offset: 0xCFC90 VA: 0x1800D0890
[NativeHeaderAttribute] // RVA: 0xD0890 Offset: 0xCFC90 VA: 0x1800D0890
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C750 Offset: 0x23BB50 VA: 0x18023C750 Slot: 4
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

	// RVA: 0x23C890 Offset: 0x23BC90 VA: 0x18023C890
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C800 Offset: 0x23BC00 VA: 0x18023C800 Slot: 4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x22DABF0 Offset: 0x22D91F0 VA: 0x1822DABF0
	private static void .cctor() { }

}

public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 4506
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23C9C0 Offset: 0x23BDC0 VA: 0x18023C9C0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C930 Offset: 0x23BD30 VA: 0x18023C930 Slot: 4
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x22DACE0 Offset: 0x22D92E0 VA: 0x1822DACE0
	private static void .cctor() { }

}

internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 4507
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CAF0 Offset: 0x23BEF0 VA: 0x18023CAF0
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CA60 Offset: 0x23BE60 VA: 0x18023CA60 Slot: 4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x22DADD0 Offset: 0x22D93D0 VA: 0x1822DADD0
	private static void .cctor() { }

}

internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 4508
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CC40 Offset: 0x23C040 VA: 0x18023CC40
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CB90 Offset: 0x23BF90 VA: 0x18023CB90 Slot: 4
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x22DAEC0 Offset: 0x22D94C0 VA: 0x1822DAEC0
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

	// RVA: 0x23CD90 Offset: 0x23C190 VA: 0x18023CD90
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CCE0 Offset: 0x23C0E0 VA: 0x18023CCE0 Slot: 4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x22DAFB0 Offset: 0x22D95B0 VA: 0x1822DAFB0
	private static void .cctor() { }

}

internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 4511
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CEE0 Offset: 0x23C2E0 VA: 0x18023CEE0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CE30 Offset: 0x23C230 VA: 0x18023CE30 Slot: 4
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x22DB0A0 Offset: 0x22D96A0 VA: 0x1822DB0A0
	private static void .cctor() { }

}

public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 4512
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23D010 Offset: 0x23C410 VA: 0x18023D010
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CF80 Offset: 0x23C380 VA: 0x18023CF80 Slot: 4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x22DB190 Offset: 0x22D9790 VA: 0x1822DB190
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
	[FormerlySerializedAsAttribute] // RVA: 0xE1A10 Offset: 0xE0E10 VA: 0x1800E1A10
	[SerializeField] // RVA: 0xE1A10 Offset: 0xE0E10 VA: 0x1800E1A10
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE1AA0 Offset: 0xE0EA0 VA: 0x1800E1AA0
	[SerializeField] // RVA: 0xE1AA0 Offset: 0xE0EA0 VA: 0x1800E1AA0
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0xE2EE0 Offset: 0xE22E0 VA: 0x1800E2EE0
	[SerializeField] // RVA: 0xE2EE0 Offset: 0xE22E0 VA: 0x1800E2EE0
	private string m_PressedTrigger; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE43A0 Offset: 0xE37A0 VA: 0x1800E43A0
	[SerializeField] // RVA: 0xE43A0 Offset: 0xE37A0 VA: 0x1800E43A0
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE47D0 Offset: 0xE3BD0 VA: 0x1800E47D0
	[SerializeField] // RVA: 0xE47D0 Offset: 0xE3BD0 VA: 0x1800E47D0
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

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_selectedTrigger() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_selectedTrigger(string value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_disabledTrigger() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_disabledTrigger(string value) { }

	// RVA: 0x10B4FD0 Offset: 0x10B35D0 VA: 0x1810B4FD0
	public void .ctor() { }

}

public class AnimationFlagHandler : MonoBehaviour // TypeDefIndex: 8783
{	// Fields
	public Animator animator; // 0x18

	// Methods

	// RVA: 0x82AB70 Offset: 0x829170 VA: 0x18082AB70
	public void SetBoolTrue(string name) { }

	// RVA: 0x82AB40 Offset: 0x829140 VA: 0x18082AB40
	public void SetBoolFalse(string name) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimationEventForward : MonoBehaviour // TypeDefIndex: 9121
{	// Fields
	public GameObject targetObject; // 0x18

	// Methods

	// RVA: 0x829D50 Offset: 0x828350 VA: 0x180829D50
	public void Event(string type) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimationEvents : BaseMonoBehaviour // TypeDefIndex: 9326
{	// Fields
	public Transform rootObject; // 0x18
	public HeldEntity targetEntity; // 0x20
	[TooltipAttribute] // RVA: 0xE77A0 Offset: 0xE6BA0 VA: 0x1800E77A0
	public string effectFolder; // 0x28
	public bool enforceClipWeights; // 0x30
	public string localFolder; // 0x38
	[TooltipAttribute] // RVA: 0xE78D0 Offset: 0xE6CD0 VA: 0x1800E78D0
	public bool customLocalFolder; // 0x40
	public bool IsBusy; // 0x41
	private IAnimationEventReceiver cachedEventReceiver; // 0x48
	private bool hasCachedEventReceiver; // 0x50

	// Methods

	// RVA: 0x82A550 Offset: 0x828B50 VA: 0x18082A550
	protected void OnEnable() { }

	// RVA: 0x82A7F0 Offset: 0x828DF0 VA: 0x18082A7F0
	public void SetBusy(int i) { }

	// RVA: 0x82A460 Offset: 0x828A60 VA: 0x18082A460
	public void Hide(string childName) { }

	// RVA: 0x82A8B0 Offset: 0x828EB0 VA: 0x18082A8B0
	public void Show(string childName) { }

	// RVA: 0x82A3B0 Offset: 0x8289B0 VA: 0x18082A3B0
	public void HideGameObject(string childName) { }

	// RVA: 0x82A800 Offset: 0x828E00 VA: 0x18082A800
	public void ShowGameObject(string childName) { }

	// RVA: 0x829DA0 Offset: 0x8283A0 VA: 0x180829DA0
	public void DoEffect(AnimationEvent evt) { }

	// RVA: 0x829D70 Offset: 0x828370 VA: 0x180829D70
	public void Broadcast(string strEvent) { }

	// RVA: 0x82A520 Offset: 0x828B20 VA: 0x18082A520
	public void Message(string strEvent) { }

	// RVA: 0x829FF0 Offset: 0x8285F0 VA: 0x180829FF0
	public void Event(string name) { }

	// RVA: 0x82AA50 Offset: 0x829050 VA: 0x18082AA50
	private void TryCacheEventReceiver() { }

	// RVA: 0x82A6D0 Offset: 0x828CD0 VA: 0x18082A6D0
	public void ReliableEvent(string name) { }

	// RVA: 0x82A970 Offset: 0x828F70 VA: 0x18082A970
	public void Strike() { }

	// RVA: 0x829F70 Offset: 0x828570 VA: 0x180829F70
	public void Event_Strike() { }

	// RVA: 0x82A9E0 Offset: 0x828FE0 VA: 0x18082A9E0
	public void Throw() { }

	// RVA: 0x829FB0 Offset: 0x8285B0 VA: 0x180829FB0
	public void Event_Throw() { }

	// RVA: 0x828A00 Offset: 0x827000 VA: 0x180828A00
	public void PlaySound(SoundDefinition def) { }

	// RVA: 0x82A5E0 Offset: 0x828BE0 VA: 0x18082A5E0
	public void PlaySoundFirstPerson(SoundDefinition def) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

