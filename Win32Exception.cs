public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 2772
{	// Fields
	private readonly int nativeErrorCode; // 0x88
	private static bool s_ErrorMessagesInitialized; // 0x0
	private static Dictionary<int, string> s_ErrorMessage; // 0x8

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x1741060 Offset: 0x173F660 VA: 0x181741060
	public void .ctor() { }

	// RVA: 0x1740EC0 Offset: 0x173F4C0 VA: 0x181740EC0
	public void .ctor(int error) { }

	// RVA: 0x1741030 Offset: 0x173F630 VA: 0x181741030
	public void .ctor(int error, string message) { }

	// RVA: 0x1741210 Offset: 0x173F810 VA: 0x181741210
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
	public int get_NativeErrorCode() { }

	// RVA: 0x173F9B0 Offset: 0x173DFB0 VA: 0x18173F9B0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x173F8A0 Offset: 0x173DEA0 VA: 0x18173F8A0
	internal static string GetErrorMessage(int error) { }

	// RVA: 0x173FA60 Offset: 0x173E060 VA: 0x18173FA60
	private static void InitializeErrorMessages() { }

	// RVA: 0x1740E40 Offset: 0x173F440 VA: 0x181740E40
	private static void .cctor() { }

}

