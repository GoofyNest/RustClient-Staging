public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 968
{	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1702C80 Offset: 0x1701280 VA: 0x181702C80 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1702D00 Offset: 0x1701300 VA: 0x181702D00 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x1702D80 Offset: 0x1701380 VA: 0x181702D80 Slot: 20
	public virtual void set_Key(byte[] value) { }

}

