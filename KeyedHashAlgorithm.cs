public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 968
{	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x17029C0 Offset: 0x1700FC0 VA: 0x1817029C0 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1702A40 Offset: 0x1701040 VA: 0x181702A40 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x1702AC0 Offset: 0x17010C0 VA: 0x181702AC0 Slot: 20
	public virtual void set_Key(byte[] value) { }

}

