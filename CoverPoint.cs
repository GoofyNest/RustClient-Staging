public class CoverPoint // TypeDefIndex: 12126
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CoverPointVolume <Volume>k__BackingField; // 0x10
	public CoverPoint.CoverType NormalCoverType; // 0x18
	public bool IsDynamic; // 0x1C
	public Transform SourceTransform; // 0x20
	private Vector3 _staticPosition; // 0x28
	private Vector3 _staticNormal; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseEntity <ReservedFor>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsCompromised>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Score>k__BackingField; // 0x4C

	// Properties
	public CoverPointVolume Volume { get; set; }
	public Vector3 Position { get; set; }
	public Vector3 Normal { get; set; }
	public BaseEntity ReservedFor { get; set; }
	public bool IsReserved { get; }
	public bool IsCompromised { get; set; }
	public float Score { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public CoverPointVolume get_Volume() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Volume(CoverPointVolume value) { }

	// RVA: 0x4BC500 Offset: 0x4BAB00 VA: 0x1804BC500
	public Vector3 get_Position() { }

	// RVA: 0x4BC600 Offset: 0x4BAC00 VA: 0x1804BC600
	public void set_Position(Vector3 value) { }

	// RVA: 0x4BC450 Offset: 0x4BAA50 VA: 0x1804BC450
	public Vector3 get_Normal() { }

	// RVA: 0x4BC5F0 Offset: 0x4BABF0 VA: 0x1804BC5F0
	public void set_Normal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public BaseEntity get_ReservedFor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void set_ReservedFor(BaseEntity value) { }

	// RVA: 0x4BC3F0 Offset: 0x4BA9F0 VA: 0x1804BC3F0
	public bool get_IsReserved() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_IsCompromised() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	public void set_IsCompromised(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public float get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC620 Offset: 0x4BAC20 VA: 0x1804BC620
	public void set_Score(float value) { }

	// RVA: 0x4BC030 Offset: 0x4BA630 VA: 0x1804BC030
	public bool IsValidFor(BaseEntity entity) { }

	// RVA: 0x4BC390 Offset: 0x4BA990 VA: 0x1804BC390
	public void .ctor(CoverPointVolume volume, float score) { }

	// RVA: 0x4BBF30 Offset: 0x4BA530 VA: 0x1804BBF30
	public void CoverIsCompromised(float cooldown) { }

	[IteratorStateMachineAttribute] // RVA: 0xDF880 Offset: 0xDEC80 VA: 0x1800DF880
	// RVA: 0x4BC310 Offset: 0x4BA910 VA: 0x1804BC310
	private IEnumerator StartCooldown(float cooldown) { }

	// RVA: 0x4BC100 Offset: 0x4BA700 VA: 0x1804BC100
	public bool ProvidesCoverFromPoint(Vector3 point, float arcThreshold) { }

}

public enum CoverPoint.CoverType // TypeDefIndex: 12127
{	// Fields
	public int value__; // 0x0
	public const CoverPoint.CoverType Full = 0;
	public const CoverPoint.CoverType Partial = 1;
	public const CoverPoint.CoverType None = 2;

}

private sealed class CoverPoint.<StartCooldown>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12128
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CoverPoint <>4__this; // 0x20
	public float cooldown; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4D18E0 Offset: 0x4CFEE0 VA: 0x1804D18E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D19A0 Offset: 0x4CFFA0 VA: 0x1804D19A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

