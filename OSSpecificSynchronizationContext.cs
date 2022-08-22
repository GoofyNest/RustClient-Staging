internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 794
{	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x10B5B00 Offset: 0x10B4100 VA: 0x1810B5B00
	private void .ctor(object osContext) { }

	// RVA: 0x1497BC0 Offset: 0x14961C0 VA: 0x181497BC0
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x1497B40 Offset: 0x1496140 VA: 0x181497B40 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x1497FD0 Offset: 0x14965D0 VA: 0x181497FD0 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1497E90 Offset: 0x1496490 VA: 0x181497E90 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute] // RVA: 0xB6940 Offset: 0xB5D40 VA: 0x1800B6940
	// RVA: 0x1497D30 Offset: 0x1496330 VA: 0x181497D30
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x1497BB0 Offset: 0x14961B0 VA: 0x181497BB0
	private static object GetOSContext() { }

	// RVA: 0x1497E80 Offset: 0x1496480 VA: 0x181497E80
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x1498020 Offset: 0x1496620 VA: 0x181498020
	private static void .cctor() { }

}

private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 795
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1494FB0 Offset: 0x14935B0 VA: 0x181494FB0 Slot: 12
	public virtual void Invoke(IntPtr arg) { }

	// RVA: 0x1494F30 Offset: 0x1493530 VA: 0x181494F30 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 796
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor(Type t) { }

}

private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 797
{	// Fields
	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(SendOrPostCallback d, object state) { }

	// RVA: 0x1494F00 Offset: 0x1493500 VA: 0x181494F00
	public void Invoke() { }

}

private sealed class OSSpecificSynchronizationContext.<>c // TypeDefIndex: 798
{	// Fields
	public static readonly OSSpecificSynchronizationContext.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x14A45B0 Offset: 0x14A2BB0 VA: 0x1814A45B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A4430 Offset: 0x14A2A30 VA: 0x1814A4430
	internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

}

