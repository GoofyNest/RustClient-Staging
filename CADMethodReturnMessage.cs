internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 1229
{	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x14716F0 Offset: 0x146FCF0 VA: 0x1814716F0
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x1471910 Offset: 0x146FF10 VA: 0x181471910
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x1471770 Offset: 0x146FD70 VA: 0x181471770
	internal ArrayList GetArguments() { }

	// RVA: 0x1470B60 Offset: 0x146F160 VA: 0x181470B60
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x1471900 Offset: 0x146FF00 VA: 0x181471900
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x1471850 Offset: 0x146FE50 VA: 0x181471850
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_PropertiesCount() { }

}

