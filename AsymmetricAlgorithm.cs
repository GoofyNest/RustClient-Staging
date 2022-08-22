public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 938
{	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x16F42E0 Offset: 0x16F28E0 VA: 0x1816F42E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F42E0 Offset: 0x16F28E0 VA: 0x1816F42E0
	public void Clear() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x16F43F0 Offset: 0x16F29F0 VA: 0x1816F43F0 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x16F4350 Offset: 0x16F2950 VA: 0x1816F4350 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x16F43A0 Offset: 0x16F29A0 VA: 0x1816F43A0 Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }

}

