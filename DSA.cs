public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 956
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x16FDE90 Offset: 0x16FC490 VA: 0x1816FDE90
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x16FDEF0 Offset: 0x16FC4F0 VA: 0x1816FDEF0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x16FE700 Offset: 0x16FCD00 VA: 0x1816FE700 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);

}

