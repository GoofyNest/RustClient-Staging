internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 1229
{	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x14719B0 Offset: 0x146FFB0 VA: 0x1814719B0
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x1471BD0 Offset: 0x14701D0 VA: 0x181471BD0
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x1471A30 Offset: 0x1470030 VA: 0x181471A30
	internal ArrayList GetArguments() { }

	// RVA: 0x1470E20 Offset: 0x146F420 VA: 0x181470E20
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x1471BC0 Offset: 0x14701C0 VA: 0x181471BC0
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x1471B10 Offset: 0x1470110 VA: 0x181471B10
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_PropertiesCount() { }

}

