public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 956
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x16FFFE0 Offset: 0x16FE5E0 VA: 0x1816FFFE0
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x1700040 Offset: 0x16FE640 VA: 0x181700040 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1700850 Offset: 0x16FEE50 VA: 0x181700850 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);

}

