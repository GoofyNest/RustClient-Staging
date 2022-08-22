public class BitUtility // TypeDefIndex: 4819
{	// Fields
	private const float float2byte = 255;
	private const float byte2float = 0,003921569;
	private const float float2short = 32766;
	private const float short2float = 3,051944E-05;

	// Methods

	// RVA: 0x226D460 Offset: 0x226BA60 VA: 0x18226D460
	public static byte Float2Byte(float f) { }

	// RVA: 0x226CE90 Offset: 0x226B490 VA: 0x18226CE90
	public static float Byte2Float(int b) { }

	// RVA: 0x226D490 Offset: 0x226BA90 VA: 0x18226D490
	public static short Float2Short(float f) { }

	// RVA: 0x226D4B0 Offset: 0x226BAB0 VA: 0x18226D4B0
	public static float Short2Float(int b) { }

	// RVA: 0x226D0C0 Offset: 0x226B6C0 VA: 0x18226D0C0
	public static Color32 EncodeFloat(float f) { }

	// RVA: 0x226CEA0 Offset: 0x226B4A0 VA: 0x18226CEA0
	public static float DecodeFloat(Color32 c) { }

	// RVA: 0x226D110 Offset: 0x226B710 VA: 0x18226D110
	public static Color32 EncodeInt(int i) { }

	// RVA: 0x226CED0 Offset: 0x226B4D0 VA: 0x18226CED0
	public static int DecodeInt(Color32 c) { }

	// RVA: 0x226D280 Offset: 0x226B880 VA: 0x18226D280
	public static Color32 EncodeShort(short i) { }

	// RVA: 0x226CFF0 Offset: 0x226B5F0 VA: 0x18226CFF0
	public static short DecodeShort(Color32 c) { }

	// RVA: 0x226D160 Offset: 0x226B760 VA: 0x18226D160
	public static Color EncodeNormal(Vector3 n) { }

	// RVA: 0x226CF00 Offset: 0x226B500 VA: 0x18226CF00
	public static Vector3 DecodeNormal(Color c) { }

	// RVA: 0x226D3A0 Offset: 0x226B9A0 VA: 0x18226D3A0
	public static Color32 EncodeVector(Vector4 v) { }

	// RVA: 0x226D040 Offset: 0x226B640 VA: 0x18226D040
	public static Vector4 DecodeVector(Color32 c) { }

	// RVA: 0x226D2C0 Offset: 0x226B8C0 VA: 0x18226D2C0
	public static Color32 EncodeVector2i(Vector2i v) { }

	// RVA: 0x226D010 Offset: 0x226B610 VA: 0x18226D010
	public static Vector2i DecodeVector2i(Color32 c) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

