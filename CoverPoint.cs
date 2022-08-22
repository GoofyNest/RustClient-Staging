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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public CoverPointVolume get_Volume() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Volume(CoverPointVolume value) { }

	// RVA: 0x4BC490 Offset: 0x4BAA90 VA: 0x1804BC490
	public Vector3 get_Position() { }

	// RVA: 0x4BC590 Offset: 0x4BAB90 VA: 0x1804BC590
	public void set_Position(Vector3 value) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public Vector3 get_Normal() { }

	// RVA: 0x4BC580 Offset: 0x4BAB80 VA: 0x1804BC580
	public void set_Normal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public BaseEntity get_ReservedFor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void set_ReservedFor(BaseEntity value) { }

	// RVA: 0x4BC380 Offset: 0x4BA980 VA: 0x1804BC380
	public bool get_IsReserved() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	public bool get_IsCompromised() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC570 Offset: 0x4BAB70 VA: 0x1804BC570
	public void set_IsCompromised(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC550 Offset: 0x4BAB50 VA: 0x1804BC550
	public float get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public void set_Score(float value) { }

	// RVA: 0x4BBFC0 Offset: 0x4BA5C0 VA: 0x1804BBFC0
	public bool IsValidFor(BaseEntity entity) { }

	// RVA: 0x4BC320 Offset: 0x4BA920 VA: 0x1804BC320
	public void .ctor(CoverPointVolume volume, float score) { }

	// RVA: 0x4BBEC0 Offset: 0x4BA4C0 VA: 0x1804BBEC0
	public void CoverIsCompromised(float cooldown) { }

	[IteratorStateMachineAttribute] // RVA: 0xDF880 Offset: 0xDEC80 VA: 0x1800DF880
	// RVA: 0x4BC2A0 Offset: 0x4BA8A0 VA: 0x1804BC2A0
	private IEnumerator StartCooldown(float cooldown) { }

	// RVA: 0x4BC090 Offset: 0x4BA690 VA: 0x1804BC090
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

	// RVA: 0x4D1870 Offset: 0x4CFE70 VA: 0x1804D1870 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D1930 Offset: 0x4CFF30 VA: 0x1804D1930 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

