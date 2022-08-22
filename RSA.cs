public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 982
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1709940 Offset: 0x1707F40 VA: 0x181709940
	public static RSA Create() { }

	// RVA: 0x1709990 Offset: 0x1707F90 VA: 0x181709990 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1709A00 Offset: 0x1708000 VA: 0x181709A00 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1709F70 Offset: 0x1708570 VA: 0x181709F70 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);

}

