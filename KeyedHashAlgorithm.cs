public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 968
{	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1700870 Offset: 0x16FEE70 VA: 0x181700870 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17008F0 Offset: 0x16FEEF0 VA: 0x1817008F0 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x1700970 Offset: 0x16FEF70 VA: 0x181700970 Slot: 20
	public virtual void set_Key(byte[] value) { }

}

