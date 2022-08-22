public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7094
{	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1E3D30 Offset: 0x1E3130 VA: 0x1801E3D30
	internal void .ctor(ValueTask value) { }

	// RVA: 0x240910 Offset: 0x23FD10 VA: 0x180240910
	public bool get_IsCompleted() { }

	[StackTraceHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x240660 Offset: 0x23FA60 VA: 0x180240660
	public void GetResult() { }

	// RVA: 0x240670 Offset: 0x23FA70 VA: 0x180240670 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x2407C0 Offset: 0x23FBC0 VA: 0x1802407C0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x2313280 Offset: 0x2311880 VA: 0x182313280
	private static void .cctor() { }

}

private sealed class ValueTaskAwaiter.<>c // TypeDefIndex: 7095
{	// Fields
	public static readonly ValueTaskAwaiter.<>c <>9; // 0x12810

	// Methods

	// RVA: 0x23130D0 Offset: 0x23116D0 VA: 0x1823130D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2313070 Offset: 0x2311670 VA: 0x182313070
	internal void <.cctor>b__9_0(object state) { }

}

