public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 2772
{	// Fields
	private readonly int nativeErrorCode; // 0x88
	private static bool s_ErrorMessagesInitialized; // 0x0
	private static Dictionary<int, string> s_ErrorMessage; // 0x8

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x17434A0 Offset: 0x1741AA0 VA: 0x1817434A0
	public void .ctor() { }

	// RVA: 0x1743300 Offset: 0x1741900 VA: 0x181743300
	public void .ctor(int error) { }

	// RVA: 0x1743470 Offset: 0x1741A70 VA: 0x181743470
	public void .ctor(int error, string message) { }

	// RVA: 0x1743650 Offset: 0x1741C50 VA: 0x181743650
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public int get_NativeErrorCode() { }

	// RVA: 0x1741DF0 Offset: 0x17403F0 VA: 0x181741DF0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1741CE0 Offset: 0x17402E0 VA: 0x181741CE0
	internal static string GetErrorMessage(int error) { }

	// RVA: 0x1741EA0 Offset: 0x17404A0 VA: 0x181741EA0
	private static void InitializeErrorMessages() { }

	// RVA: 0x1743280 Offset: 0x1741880 VA: 0x181743280
	private static void .cctor() { }

}

