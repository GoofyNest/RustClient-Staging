internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 1228
{	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal string get_Uri() { }

	// RVA: 0x1470CA0 Offset: 0x146F2A0 VA: 0x181470CA0
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x1470F10 Offset: 0x146F510 VA: 0x181470F10
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x1470E30 Offset: 0x146F430 VA: 0x181470E30
	internal ArrayList GetArguments() { }

	// RVA: 0x1470E20 Offset: 0x146F420 VA: 0x181470E20
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_PropertiesCount() { }

}

