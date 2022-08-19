public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7094
{	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1E3DB0 Offset: 0x1E31B0 VA: 0x1801E3DB0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x240990 Offset: 0x23FD90 VA: 0x180240990
	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2406E0 Offset: 0x23FAE0 VA: 0x1802406E0
	public void GetResult() { }

	// RVA: 0x2406F0 Offset: 0x23FAF0 VA: 0x1802406F0 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x240840 Offset: 0x23FC40 VA: 0x180240840 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x2313440 Offset: 0x2311A40 VA: 0x182313440
	private static void .cctor() { }

}

private sealed class ValueTaskAwaiter.<>c // TypeDefIndex: 7095
{	// Fields
	public static readonly ValueTaskAwaiter.<>c <>9; // 0x12810

	// Methods

	// RVA: 0x2313290 Offset: 0x2311890 VA: 0x182313290
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2313230 Offset: 0x2311830 VA: 0x182313230
	internal void <.cctor>b__9_0(object state) { }

}

