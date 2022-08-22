public class TransactionInformation // TypeDefIndex: 3986
{	// Fields
	private string local_id; // 0x10
	private Guid dtcId; // 0x18
	private DateTime creation_time; // 0x28
	private TransactionStatus status; // 0x30

	// Properties
	public TransactionStatus Status { get; set; }

	// Methods

	// RVA: 0x230D5F0 Offset: 0x230BBF0 VA: 0x18230D5F0
	internal void .ctor() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public TransactionStatus get_Status() { }

	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	internal void set_Status(TransactionStatus value) { }

}

