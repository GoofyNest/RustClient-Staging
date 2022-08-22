public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 982
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1707530 Offset: 0x1705B30 VA: 0x181707530
	public static RSA Create() { }

	// RVA: 0x1707580 Offset: 0x1705B80 VA: 0x181707580 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x17075F0 Offset: 0x1705BF0 VA: 0x1817075F0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1707B60 Offset: 0x1706160 VA: 0x181707B60 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);

}

