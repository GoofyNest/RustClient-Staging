public class StackFrame // TypeDefIndex: 1502
{	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0xD860B0 Offset: 0xD846B0 VA: 0x180D860B0
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0xD85FB0 Offset: 0xD845B0 VA: 0x180D85FB0
	public void .ctor() { }

	// RVA: 0xD86020 Offset: 0xD84620 VA: 0x180D86020
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50 Slot: 5
	public virtual int GetFileColumnNumber() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 6
	public virtual string GetFileName() { }

	// RVA: 0xD85D80 Offset: 0xD84380 VA: 0x180D85D80
	internal string GetSecureFileName() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 7
	public virtual int GetILOffset() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 8
	public virtual MethodBase GetMethod() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 9
	public virtual int GetNativeOffset() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal long GetMethodAddress() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal uint GetMethodIndex() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal string GetInternalMethodName() { }

	// RVA: 0xD85DF0 Offset: 0xD843F0 VA: 0x180D85DF0 Slot: 3
	public override string ToString() { }

}

