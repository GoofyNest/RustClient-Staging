public class BitUtility // TypeDefIndex: 4819
{	// Fields
	private const float float2byte = 255;
	private const float byte2float = 0,003921569;
	private const float float2short = 32766;
	private const float short2float = 3,051944E-05;

	// Methods

	// RVA: 0x226C980 Offset: 0x226AF80 VA: 0x18226C980
	public static byte Float2Byte(float f) { }

	// RVA: 0x226C3B0 Offset: 0x226A9B0 VA: 0x18226C3B0
	public static float Byte2Float(int b) { }

	// RVA: 0x226C9B0 Offset: 0x226AFB0 VA: 0x18226C9B0
	public static short Float2Short(float f) { }

	// RVA: 0x226C9D0 Offset: 0x226AFD0 VA: 0x18226C9D0
	public static float Short2Float(int b) { }

	// RVA: 0x226C5E0 Offset: 0x226ABE0 VA: 0x18226C5E0
	public static Color32 EncodeFloat(float f) { }

	// RVA: 0x226C3C0 Offset: 0x226A9C0 VA: 0x18226C3C0
	public static float DecodeFloat(Color32 c) { }

	// RVA: 0x226C630 Offset: 0x226AC30 VA: 0x18226C630
	public static Color32 EncodeInt(int i) { }

	// RVA: 0x226C3F0 Offset: 0x226A9F0 VA: 0x18226C3F0
	public static int DecodeInt(Color32 c) { }

	// RVA: 0x226C7A0 Offset: 0x226ADA0 VA: 0x18226C7A0
	public static Color32 EncodeShort(short i) { }

	// RVA: 0x226C510 Offset: 0x226AB10 VA: 0x18226C510
	public static short DecodeShort(Color32 c) { }

	// RVA: 0x226C680 Offset: 0x226AC80 VA: 0x18226C680
	public static Color EncodeNormal(Vector3 n) { }

	// RVA: 0x226C420 Offset: 0x226AA20 VA: 0x18226C420
	public static Vector3 DecodeNormal(Color c) { }

	// RVA: 0x226C8C0 Offset: 0x226AEC0 VA: 0x18226C8C0
	public static Color32 EncodeVector(Vector4 v) { }

	// RVA: 0x226C560 Offset: 0x226AB60 VA: 0x18226C560
	public static Vector4 DecodeVector(Color32 c) { }

	// RVA: 0x226C7E0 Offset: 0x226ADE0 VA: 0x18226C7E0
	public static Color32 EncodeVector2i(Vector2i v) { }

	// RVA: 0x226C530 Offset: 0x226AB30 VA: 0x18226C530
	public static Vector2i DecodeVector2i(Color32 c) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

