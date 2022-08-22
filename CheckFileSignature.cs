public enum CheckFileSignature // TypeDefIndex: 5151
{	// Fields
	public int value__; // 0x0
	public const CheckFileSignature InvalidSignature = 0;
	public const CheckFileSignature ValidSignature = 1;
	public const CheckFileSignature FileNotFound = 2;
	public const CheckFileSignature NoSignaturesFoundForThisApp = 3;
	public const CheckFileSignature NoSignaturesFoundForThisFile = 4;

}

internal struct CheckFileSignature_t : ICallbackData // TypeDefIndex: 5331
{	// Fields
	internal CheckFileSignature CheckFileSignature; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4A40 Offset: 0x1E3E40 VA: 0x1801E4A40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4A30 Offset: 0x1E3E30 VA: 0x1801E4A30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D570 Offset: 0x136BB70 VA: 0x18136D570
	private static void .cctor() { }

}

