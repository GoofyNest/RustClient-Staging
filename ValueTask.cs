public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 7085
{	// Fields
	private static readonly Task s_canceledTask; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static readonly Task <CompletedTask>k__BackingField; // 0x8
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2313EE0 Offset: 0x23124E0 VA: 0x182313EE0
	internal static Task get_CompletedTask() { }

	// RVA: 0x240A20 Offset: 0x23FE20 VA: 0x180240A20
	public void .ctor(Task task) { }

	// RVA: 0x1F67D0 Offset: 0x1F5BD0 VA: 0x1801F67D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x240940 Offset: 0x23FD40 VA: 0x180240940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2409D0 Offset: 0x23FDD0 VA: 0x1802409D0 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x240A60 Offset: 0x23FE60 VA: 0x180240A60
	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x240A10 Offset: 0x23FE10 VA: 0x180240A10
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x2409F0 Offset: 0x23FDF0 VA: 0x1802409F0
	public ValueTaskAwaiter GetAwaiter() { }

	// RVA: 0x2313E30 Offset: 0x2312430 VA: 0x182313E30
	private static void .cctor() { }

}

