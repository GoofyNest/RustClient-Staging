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

	// RVA: 0x2149A40 Offset: 0x2148040 VA: 0x182149A40
	private void AllocateHandle(object target) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x2149C00 Offset: 0x2148200 VA: 0x182149C00
	public void .ctor(object target) { }

	// RVA: 0x2149C40 Offset: 0x2148240 VA: 0x182149C40
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x2149C90 Offset: 0x2148290 VA: 0x182149C90
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2149D90 Offset: 0x2148390 VA: 0x182149D90 Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x2149DB0 Offset: 0x21483B0 VA: 0x182149DB0 Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x2149DE0 Offset: 0x21483E0 VA: 0x182149DE0 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x2149A70 Offset: 0x2148070 VA: 0x182149A70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2149B00 Offset: 0x2148100 VA: 0x182149B00 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

