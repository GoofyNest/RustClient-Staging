internal class DynamicPropertyCollection // TypeDefIndex: 1172
{	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x14777D0 Offset: 0x1475DD0 VA: 0x1814777D0
	public bool get_HasProperties() { }

	// RVA: 0x14773F0 Offset: 0x14759F0 VA: 0x1814773F0
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x1477600 Offset: 0x1475C00 VA: 0x181477600
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x1476F40 Offset: 0x1475540 VA: 0x181476F40
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x1476DC0 Offset: 0x14753C0 VA: 0x181476DC0
	private int FindProperty(string name) { }

	// RVA: 0x1477760 Offset: 0x1475D60 VA: 0x181477760
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

