public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 956
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x17002A0 Offset: 0x16FE8A0 VA: 0x1817002A0
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x1700300 Offset: 0x16FE900 VA: 0x181700300 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1700B10 Offset: 0x16FF110 VA: 0x181700B10 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);

}

