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

	// RVA: 0x117D1B0 Offset: 0x117B7B0 VA: 0x18117D1B0
	internal void .ctor(X509Certificate certificate) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x117D830 Offset: 0x117BE30 VA: 0x18117D830
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Oid get_Oid() { }

	// RVA: 0x117D0B0 Offset: 0x117B6B0 VA: 0x18117D0B0
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x117C9C0 Offset: 0x117AFC0 VA: 0x18117C9C0
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x117CDD0 Offset: 0x117B3D0 VA: 0x18117CDD0
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x117D160 Offset: 0x117B760 VA: 0x18117D160
	private static void .cctor() { }

}

