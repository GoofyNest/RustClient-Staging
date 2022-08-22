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
	// RVA: 0x23136C0 Offset: 0x2311CC0 VA: 0x1823136C0
	internal static Task get_CompletedTask() { }

	// RVA: 0x240A20 Offset: 0x23FE20 VA: 0x180240A20
	public void .ctor(Task task) { }

	// RVA: 0x1205A0 Offset: 0x11F9A0 VA: 0x1801205A0 Slot: 2
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

	// RVA: 0x2313610 Offset: 0x2311C10 VA: 0x182313610
	private static void .cctor() { }

}

