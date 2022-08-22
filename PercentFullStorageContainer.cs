public class PercentFullStorageContainer : StorageContainer // TypeDefIndex: 9515
{	// Fields
	private float _clientPercentFull; // 0x3D0

	// Properties
	protected float ClientPercentFull { get; set; }

	// Methods

	// RVA: 0x86D660 Offset: 0x86BC60 VA: 0x18086D660
	public bool IsFull() { }

	// RVA: 0x86D620 Offset: 0x86BC20 VA: 0x18086D620
	public bool IsEmpty() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 155
	protected virtual void OnPercentFullChanged(float newPercentFull) { }

	// RVA: 0x86D5F0 Offset: 0x86BBF0 VA: 0x18086D5F0
	public float GetPercentFull() { }

	// RVA: 0x86D6A0 Offset: 0x86BCA0 VA: 0x18086D6A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x86D790 Offset: 0x86BD90 VA: 0x18086D790
	protected float get_ClientPercentFull() { }

	// RVA: 0x86D7A0 Offset: 0x86BDA0 VA: 0x18086D7A0
	protected void set_ClientPercentFull(float value) { }

	// RVA: 0x86D730 Offset: 0x86BD30 VA: 0x18086D730
	public void .ctor() { }

}

