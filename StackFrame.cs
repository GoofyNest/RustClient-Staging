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

	// RVA: 0xD86E20 Offset: 0xD85420 VA: 0x180D86E20
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0xD86D20 Offset: 0xD85320 VA: 0x180D86D20
	public void .ctor() { }

	// RVA: 0xD86D90 Offset: 0xD85390 VA: 0x180D86D90
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0 Slot: 5
	public virtual int GetFileColumnNumber() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 6
	public virtual string GetFileName() { }

	// RVA: 0xD86AF0 Offset: 0xD850F0 VA: 0x180D86AF0
	internal string GetSecureFileName() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 7
	public virtual int GetILOffset() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 8
	public virtual MethodBase GetMethod() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960 Slot: 9
	public virtual int GetNativeOffset() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal long GetMethodAddress() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal uint GetMethodIndex() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal string GetInternalMethodName() { }

	// RVA: 0xD86B60 Offset: 0xD85160 VA: 0x180D86B60 Slot: 3
	public override string ToString() { }

}

