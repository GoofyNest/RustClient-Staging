internal class CrossAppDomainData // TypeDefIndex: 1188
{	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0xFE5130 Offset: 0xFE3730 VA: 0x180FE5130
	internal void .ctor(int domainId) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_DomainID() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_ProcessID() { }

}

