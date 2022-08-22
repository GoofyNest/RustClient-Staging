internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 794
{	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x10B6570 Offset: 0x10B4B70 VA: 0x1810B6570
	private void .ctor(object osContext) { }

	// RVA: 0x1496C90 Offset: 0x1495290 VA: 0x181496C90
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x1496C10 Offset: 0x1495210 VA: 0x181496C10 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x14970A0 Offset: 0x14956A0 VA: 0x1814970A0 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1496F60 Offset: 0x1495560 VA: 0x181496F60 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute] // RVA: 0xB6940 Offset: 0xB5D40 VA: 0x1800B6940
	// RVA: 0x1496E00 Offset: 0x1495400 VA: 0x181496E00
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x1496C80 Offset: 0x1495280 VA: 0x181496C80
	private static object GetOSContext() { }

	// RVA: 0x1496F50 Offset: 0x1495550 VA: 0x181496F50
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x14970F0 Offset: 0x14956F0 VA: 0x1814970F0
	private static void .cctor() { }

}

private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 795
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1494080 Offset: 0x1492680 VA: 0x181494080 Slot: 12
	public virtual void Invoke(IntPtr arg) { }

	// RVA: 0x1494000 Offset: 0x1492600 VA: 0x181494000 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 796
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor(Type t) { }

}

private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 797
{	// Fields
	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(SendOrPostCallback d, object state) { }

	// RVA: 0x1493FD0 Offset: 0x14925D0 VA: 0x181493FD0
	public void Invoke() { }

}

private sealed class OSSpecificSynchronizationContext.<>c // TypeDefIndex: 798
{	// Fields
	public static readonly OSSpecificSynchronizationContext.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x14A3680 Offset: 0x14A1C80 VA: 0x1814A3680
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A3500 Offset: 0x14A1B00 VA: 0x1814A3500
	internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

}

