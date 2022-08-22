internal class DynamicPropertyCollection // TypeDefIndex: 1172
{	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x1476B60 Offset: 0x1475160 VA: 0x181476B60
	public bool get_HasProperties() { }

	// RVA: 0x1476780 Offset: 0x1474D80 VA: 0x181476780
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x1476990 Offset: 0x1474F90 VA: 0x181476990
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x14762D0 Offset: 0x14748D0 VA: 0x1814762D0
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x1476150 Offset: 0x1474750 VA: 0x181476150
	private int FindProperty(string name) { }

	// RVA: 0x1476AF0 Offset: 0x14750F0 VA: 0x181476AF0
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

