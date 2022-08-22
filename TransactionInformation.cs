public class TransactionInformation // TypeDefIndex: 3986
{	// Fields
	private string local_id; // 0x10
	private Guid dtcId; // 0x18
	private DateTime creation_time; // 0x28
	private TransactionStatus status; // 0x30

	// Properties
	public TransactionStatus Status { get; set; }

	// Methods

	// RVA: 0x230CDD0 Offset: 0x230B3D0 VA: 0x18230CDD0
	internal void .ctor() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public TransactionStatus get_Status() { }

	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	internal void set_Status(TransactionStatus value) { }

}

