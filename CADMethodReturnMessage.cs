internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 1229
{	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x1470A80 Offset: 0x146F080 VA: 0x181470A80
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x1470CA0 Offset: 0x146F2A0 VA: 0x181470CA0
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x1470B00 Offset: 0x146F100 VA: 0x181470B00
	internal ArrayList GetArguments() { }

	// RVA: 0x146FEF0 Offset: 0x146E4F0 VA: 0x18146FEF0
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x1470C90 Offset: 0x146F290 VA: 0x181470C90
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x1470BE0 Offset: 0x146F1E0 VA: 0x181470BE0
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal int get_PropertiesCount() { }

}

