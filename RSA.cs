public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 982
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1709680 Offset: 0x1707C80 VA: 0x181709680
	public static RSA Create() { }

	// RVA: 0x17096D0 Offset: 0x1707CD0 VA: 0x1817096D0 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x1709740 Offset: 0x1707D40 VA: 0x181709740 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1709CB0 Offset: 0x17082B0 VA: 0x181709CB0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);

}

