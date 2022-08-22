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

	// RVA: 0x214A260 Offset: 0x2148860 VA: 0x18214A260
	private void AllocateHandle(object target) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x214A420 Offset: 0x2148A20 VA: 0x18214A420
	public void .ctor(object target) { }

	// RVA: 0x214A460 Offset: 0x2148A60 VA: 0x18214A460
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x214A4B0 Offset: 0x2148AB0 VA: 0x18214A4B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x214A5B0 Offset: 0x2148BB0 VA: 0x18214A5B0 Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x214A5D0 Offset: 0x2148BD0 VA: 0x18214A5D0 Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x214A600 Offset: 0x2148C00 VA: 0x18214A600 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x214A290 Offset: 0x2148890 VA: 0x18214A290 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x214A320 Offset: 0x2148920 VA: 0x18214A320 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

