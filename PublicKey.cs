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

	// RVA: 0x1181D90 Offset: 0x1180390 VA: 0x181181D90
	internal void .ctor(X509Certificate certificate) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x1182410 Offset: 0x1180A10 VA: 0x181182410
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Oid get_Oid() { }

	// RVA: 0x1181C90 Offset: 0x1180290 VA: 0x181181C90
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x11815A0 Offset: 0x117FBA0 VA: 0x1811815A0
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x11819B0 Offset: 0x117FFB0 VA: 0x1811819B0
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x1181D40 Offset: 0x1180340 VA: 0x181181D40
	private static void .cctor() { }

}

