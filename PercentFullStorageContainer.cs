public class PercentFullStorageContainer : StorageContainer // TypeDefIndex: 9515
{	// Fields
	private float _clientPercentFull; // 0x3D0

	// Properties
	protected float ClientPercentFull { get; set; }

	// Methods

	// RVA: 0x86D550 Offset: 0x86BB50 VA: 0x18086D550
	public bool IsFull() { }

	// RVA: 0x86D510 Offset: 0x86BB10 VA: 0x18086D510
	public bool IsEmpty() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 155
	protected virtual void OnPercentFullChanged(float newPercentFull) { }

	// RVA: 0x86D4E0 Offset: 0x86BAE0 VA: 0x18086D4E0
	public float GetPercentFull() { }

	// RVA: 0x86D590 Offset: 0x86BB90 VA: 0x18086D590 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x86D680 Offset: 0x86BC80 VA: 0x18086D680
	protected float get_ClientPercentFull() { }

	// RVA: 0x86D690 Offset: 0x86BC90 VA: 0x18086D690
	protected void set_ClientPercentFull(float value) { }

	// RVA: 0x86D620 Offset: 0x86BC20 VA: 0x18086D620
	public void .ctor() { }

}

