internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 1228
{	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal string get_Uri() { }

	// RVA: 0x14709E0 Offset: 0x146EFE0 VA: 0x1814709E0
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x1470C50 Offset: 0x146F250 VA: 0x181470C50
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x1470B70 Offset: 0x146F170 VA: 0x181470B70
	internal ArrayList GetArguments() { }

	// RVA: 0x1470B60 Offset: 0x146F160 VA: 0x181470B60
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_PropertiesCount() { }

}

