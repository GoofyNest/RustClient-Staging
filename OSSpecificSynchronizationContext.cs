internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 794
{	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x10B5840 Offset: 0x10B3E40 VA: 0x1810B5840
	private void .ctor(object osContext) { }

	// RVA: 0x1497900 Offset: 0x1495F00 VA: 0x181497900
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x1497880 Offset: 0x1495E80 VA: 0x181497880 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x1497D10 Offset: 0x1496310 VA: 0x181497D10 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1497BD0 Offset: 0x14961D0 VA: 0x181497BD0 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute] // RVA: 0xB6940 Offset: 0xB5D40 VA: 0x1800B6940
	// RVA: 0x1497A70 Offset: 0x1496070 VA: 0x181497A70
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x14978F0 Offset: 0x1495EF0 VA: 0x1814978F0
	private static object GetOSContext() { }

	// RVA: 0x1497BC0 Offset: 0x14961C0 VA: 0x181497BC0
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x1497D60 Offset: 0x1496360 VA: 0x181497D60
	private static void .cctor() { }

}

private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 795
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1494CF0 Offset: 0x14932F0 VA: 0x181494CF0 Slot: 12
	public virtual void Invoke(IntPtr arg) { }

	// RVA: 0x1494C70 Offset: 0x1493270 VA: 0x181494C70 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 796
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor(Type t) { }

}

private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 797
{	// Fields
	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(SendOrPostCallback d, object state) { }

	// RVA: 0x1494C40 Offset: 0x1493240 VA: 0x181494C40
	public void Invoke() { }

}

private sealed class OSSpecificSynchronizationContext.<>c // TypeDefIndex: 798
{	// Fields
	public static readonly OSSpecificSynchronizationContext.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x14A42F0 Offset: 0x14A28F0 VA: 0x1814A42F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14A4170 Offset: 0x14A2770 VA: 0x1814A4170
	internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

}

