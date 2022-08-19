public class BitUtility // TypeDefIndex: 4819
{	// Fields
	private const float float2byte = 255;
	private const float byte2float = 0,003921569;
	private const float float2short = 32766;
	private const float short2float = 3,051944E-05;

	// Methods

	// RVA: 0x226CB40 Offset: 0x226B140 VA: 0x18226CB40
	public static byte Float2Byte(float f) { }

	// RVA: 0x226C570 Offset: 0x226AB70 VA: 0x18226C570
	public static float Byte2Float(int b) { }

	// RVA: 0x226CB70 Offset: 0x226B170 VA: 0x18226CB70
	public static short Float2Short(float f) { }

	// RVA: 0x226CB90 Offset: 0x226B190 VA: 0x18226CB90
	public static float Short2Float(int b) { }

	// RVA: 0x226C7A0 Offset: 0x226ADA0 VA: 0x18226C7A0
	public static Color32 EncodeFloat(float f) { }

	// RVA: 0x226C580 Offset: 0x226AB80 VA: 0x18226C580
	public static float DecodeFloat(Color32 c) { }

	// RVA: 0x226C7F0 Offset: 0x226ADF0 VA: 0x18226C7F0
	public static Color32 EncodeInt(int i) { }

	// RVA: 0x226C5B0 Offset: 0x226ABB0 VA: 0x18226C5B0
	public static int DecodeInt(Color32 c) { }

	// RVA: 0x226C960 Offset: 0x226AF60 VA: 0x18226C960
	public static Color32 EncodeShort(short i) { }

	// RVA: 0x226C6D0 Offset: 0x226ACD0 VA: 0x18226C6D0
	public static short DecodeShort(Color32 c) { }

	// RVA: 0x226C840 Offset: 0x226AE40 VA: 0x18226C840
	public static Color EncodeNormal(Vector3 n) { }

	// RVA: 0x226C5E0 Offset: 0x226ABE0 VA: 0x18226C5E0
	public static Vector3 DecodeNormal(Color c) { }

	// RVA: 0x226CA80 Offset: 0x226B080 VA: 0x18226CA80
	public static Color32 EncodeVector(Vector4 v) { }

	// RVA: 0x226C720 Offset: 0x226AD20 VA: 0x18226C720
	public static Vector4 DecodeVector(Color32 c) { }

	// RVA: 0x226C9A0 Offset: 0x226AFA0 VA: 0x18226C9A0
	public static Color32 EncodeVector2i(Vector2i v) { }

	// RVA: 0x226C6F0 Offset: 0x226ACF0 VA: 0x18226C6F0
	public static Vector2i DecodeVector2i(Color32 c) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

