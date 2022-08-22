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

	// RVA: 0x149C0C0 Offset: 0x149A6C0 VA: 0x18149C0C0 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x149C040 Offset: 0x149A640 VA: 0x18149C040 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public virtual void OperationCompleted() { }

	// RVA: 0x149C0F0 Offset: 0x149A6F0 VA: 0x18149C0F0
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x149C190 Offset: 0x149A790 VA: 0x18149C190
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x149C150 Offset: 0x149A750 VA: 0x18149C150
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x149BE80 Offset: 0x149A480 VA: 0x18149BE80
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x149BE30 Offset: 0x149A430 VA: 0x18149BE30 Slot: 8
	public virtual SynchronizationContext CreateCopy() { }

}

