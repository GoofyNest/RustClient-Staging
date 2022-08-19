public class WeakReference : ISerializable // TypeDefIndex: 421
{
// Namespace: System
[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
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

	// RVA: 0x2149940 Offset: 0x2147F40 VA: 0x182149940
	private void AllocateHandle(object target) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x2149B00 Offset: 0x2148100 VA: 0x182149B00
	public void .ctor(object target) { }

	// RVA: 0x2149B40 Offset: 0x2148140 VA: 0x182149B40
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x2149B90 Offset: 0x2148190 VA: 0x182149B90
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2149C90 Offset: 0x2148290 VA: 0x182149C90 Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x2149CB0 Offset: 0x21482B0 VA: 0x182149CB0 Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x2149CE0 Offset: 0x21482E0 VA: 0x182149CE0 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x2149970 Offset: 0x2147F70 VA: 0x182149970 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2149A00 Offset: 0x2148000 VA: 0x182149A00 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

