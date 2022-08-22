public class WeakReference : ISerializable // TypeDefIndex: 421
{
// Namespace: System
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
[Serializable]
public class WeakReference : ISerializable // TypeDefIndex: 421
	// Fields
	private bool isLongReference; // 0x10
	private GCHandle gcHandle; // 0x14

	// Properties
	public virtual bool IsAlive { get; }
	public virtual object Target { get; set; }
	public virtual bool TrackResurrection { get; }

	// Methods

	// RVA: 0x2149780 Offset: 0x2147D80 VA: 0x182149780
	private void AllocateHandle(object target) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x2149940 Offset: 0x2147F40 VA: 0x182149940
	public void .ctor(object target) { }

	// RVA: 0x2149980 Offset: 0x2147F80 VA: 0x182149980
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x21499D0 Offset: 0x2147FD0 VA: 0x1821499D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2149AD0 Offset: 0x21480D0 VA: 0x182149AD0 Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x2149AF0 Offset: 0x21480F0 VA: 0x182149AF0 Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x2149B20 Offset: 0x2148120 VA: 0x182149B20 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x21497B0 Offset: 0x2147DB0 VA: 0x1821497B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2149840 Offset: 0x2147E40 VA: 0x182149840 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

