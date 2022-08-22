internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 1228
{	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal string get_Uri() { }

	// RVA: 0x146FD70 Offset: 0x146E370 VA: 0x18146FD70
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x146FFE0 Offset: 0x146E5E0 VA: 0x18146FFE0
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x146FF00 Offset: 0x146E500 VA: 0x18146FF00
	internal ArrayList GetArguments() { }

	// RVA: 0x146FEF0 Offset: 0x146E4F0 VA: 0x18146FEF0
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal int get_PropertiesCount() { }

}

