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

	// RVA: 0x149BE00 Offset: 0x149A400 VA: 0x18149BE00 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x149BD80 Offset: 0x149A380 VA: 0x18149BD80 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void OperationCompleted() { }

	// RVA: 0x149BE30 Offset: 0x149A430 VA: 0x18149BE30
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x149BED0 Offset: 0x149A4D0 VA: 0x18149BED0
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x149BE90 Offset: 0x149A490 VA: 0x18149BE90
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x149BBC0 Offset: 0x149A1C0 VA: 0x18149BBC0
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x149BB70 Offset: 0x149A170 VA: 0x18149BB70 Slot: 8
	public virtual SynchronizationContext CreateCopy() { }

}

