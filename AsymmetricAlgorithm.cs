public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 938
{	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x16F66F0 Offset: 0x16F4CF0 VA: 0x1816F66F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F66F0 Offset: 0x16F4CF0 VA: 0x1816F66F0
	public void Clear() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x16F6800 Offset: 0x16F4E00 VA: 0x1816F6800 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x16F6760 Offset: 0x16F4D60 VA: 0x1816F6760 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x16F67B0 Offset: 0x16F4DB0 VA: 0x1816F67B0 Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }

}

