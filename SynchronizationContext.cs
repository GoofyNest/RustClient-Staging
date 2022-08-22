public class SynchronizationContext // TypeDefIndex: 793
{	// Fields
	private SynchronizationContextProperties _props; // 0x10
	private static Type s_cachedPreparedType1; // 0x0
	private static Type s_cachedPreparedType2; // 0x8
	private static Type s_cachedPreparedType3; // 0x10
	private static Type s_cachedPreparedType4; // 0x18
	private static Type s_cachedPreparedType5; // 0x20

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x149B190 Offset: 0x1499790 VA: 0x18149B190 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x149B110 Offset: 0x1499710 VA: 0x18149B110 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void OperationCompleted() { }

	// RVA: 0x149B1C0 Offset: 0x14997C0 VA: 0x18149B1C0
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x149B260 Offset: 0x1499860 VA: 0x18149B260
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x149B220 Offset: 0x1499820 VA: 0x18149B220
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x149AF50 Offset: 0x1499550 VA: 0x18149AF50
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x149AF00 Offset: 0x1499500 VA: 0x18149AF00 Slot: 8
	public virtual SynchronizationContext CreateCopy() { }

}

