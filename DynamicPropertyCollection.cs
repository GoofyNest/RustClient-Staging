internal class DynamicPropertyCollection // TypeDefIndex: 1172
{	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x1477A90 Offset: 0x1476090 VA: 0x181477A90
	public bool get_HasProperties() { }

	// RVA: 0x14776B0 Offset: 0x1475CB0 VA: 0x1814776B0
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x14778C0 Offset: 0x1475EC0 VA: 0x1814778C0
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x1477200 Offset: 0x1475800 VA: 0x181477200
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x1477080 Offset: 0x1475680 VA: 0x181477080
	private int FindProperty(string name) { }

	// RVA: 0x1477A20 Offset: 0x1476020 VA: 0x181477A20
	public void .ctor() { }

}

private class DynamicPropertyCollection.DynamicPropertyReg // TypeDefIndex: 1173
{	// Fields
	public IDynamicProperty Property; // 0x10
	public IDynamicMessageSink Sink; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

