public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 2772
{	// Fields
	private readonly int nativeErrorCode; // 0x88
	private static bool s_ErrorMessagesInitialized; // 0x0
	private static Dictionary<int, string> s_ErrorMessage; // 0x8

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x17431E0 Offset: 0x17417E0 VA: 0x1817431E0
	public void .ctor() { }

	// RVA: 0x1743040 Offset: 0x1741640 VA: 0x181743040
	public void .ctor(int error) { }

	// RVA: 0x17431B0 Offset: 0x17417B0 VA: 0x1817431B0
	public void .ctor(int error, string message) { }

	// RVA: 0x1743390 Offset: 0x1741990 VA: 0x181743390
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public int get_NativeErrorCode() { }

	// RVA: 0x1741B30 Offset: 0x1740130 VA: 0x181741B30 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1741A20 Offset: 0x1740020 VA: 0x181741A20
	internal static string GetErrorMessage(int error) { }

	// RVA: 0x1741BE0 Offset: 0x17401E0 VA: 0x181741BE0
	private static void InitializeErrorMessages() { }

	// RVA: 0x1742FC0 Offset: 0x17415C0 VA: 0x181742FC0
	private static void .cctor() { }

}

