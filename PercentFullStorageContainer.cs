public class PercentFullStorageContainer : StorageContainer // TypeDefIndex: 9515
{	// Fields
	private float _clientPercentFull; // 0x3D0

	// Properties
	protected float ClientPercentFull { get; set; }

	// Methods

	// RVA: 0x888DC0 Offset: 0x8873C0 VA: 0x180888DC0
	public bool IsFull() { }

	// RVA: 0x888D80 Offset: 0x887380 VA: 0x180888D80
	public bool IsEmpty() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 155
	protected virtual void OnPercentFullChanged(float newPercentFull) { }

	// RVA: 0x888D50 Offset: 0x887350 VA: 0x180888D50
	public float GetPercentFull() { }

	// RVA: 0x888E00 Offset: 0x887400 VA: 0x180888E00 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x888EF0 Offset: 0x8874F0 VA: 0x180888EF0
	protected float get_ClientPercentFull() { }

	// RVA: 0x888F00 Offset: 0x887500 VA: 0x180888F00
	protected void set_ClientPercentFull(float value) { }

	// RVA: 0x888E90 Offset: 0x887490 VA: 0x180888E90
	public void .ctor() { }

}

