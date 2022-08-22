public sealed class PublicKey // TypeDefIndex: 2811
{	// Fields
	private AsymmetricAlgorithm _key; // 0x10
	private AsnEncodedData _keyValue; // 0x18
	private AsnEncodedData _params; // 0x20
	private Oid _oid; // 0x28
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x117D470 Offset: 0x117BA70 VA: 0x18117D470
	internal void .ctor(X509Certificate certificate) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x117DAF0 Offset: 0x117C0F0 VA: 0x18117DAF0
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Oid get_Oid() { }

	// RVA: 0x117D370 Offset: 0x117B970 VA: 0x18117D370
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x117CC80 Offset: 0x117B280 VA: 0x18117CC80
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x117D090 Offset: 0x117B690 VA: 0x18117D090
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x117D420 Offset: 0x117BA20 VA: 0x18117D420
	private static void .cctor() { }

}

