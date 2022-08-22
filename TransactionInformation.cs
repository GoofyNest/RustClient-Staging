public class TransactionInformation // TypeDefIndex: 3986
{	// Fields
	private string local_id; // 0x10
	private Guid dtcId; // 0x18
	private DateTime creation_time; // 0x28
	private TransactionStatus status; // 0x30

	// Properties
	public TransactionStatus Status { get; set; }

	// Methods

	// RVA: 0x230CB10 Offset: 0x230B110 VA: 0x18230CB10
	internal void .ctor() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public TransactionStatus get_Status() { }

	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	internal void set_Status(TransactionStatus value) { }

}

