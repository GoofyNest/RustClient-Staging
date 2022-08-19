public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 7085
{	// Fields
	private static readonly Task s_canceledTask; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static readonly Task <CompletedTask>k__BackingField; // 0x8
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23135C0 Offset: 0x2311BC0 VA: 0x1823135C0
	internal static Task get_CompletedTask() { }

	// RVA: 0x240AA0 Offset: 0x23FEA0 VA: 0x180240AA0
	public void .ctor(Task task) { }

	// RVA: 0x120620 Offset: 0x11FA20 VA: 0x180120620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2409C0 Offset: 0x23FDC0 VA: 0x1802409C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x240A50 Offset: 0x23FE50 VA: 0x180240A50 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x240AE0 Offset: 0x23FEE0 VA: 0x180240AE0
	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x240A90 Offset: 0x23FE90 VA: 0x180240A90
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x240A70 Offset: 0x23FE70 VA: 0x180240A70
	public ValueTaskAwaiter GetAwaiter() { }

	// RVA: 0x2313510 Offset: 0x2311B10 VA: 0x182313510
	private static void .cctor() { }

}

