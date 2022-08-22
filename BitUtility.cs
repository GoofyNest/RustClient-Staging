public class BitUtility // TypeDefIndex: 4819
{	// Fields
	private const float float2byte = 255;
	private const float byte2float = 0,003921569;
	private const float float2short = 32766;
	private const float short2float = 3,051944E-05;

	// Methods

	// RVA: 0x226CC40 Offset: 0x226B240 VA: 0x18226CC40
	public static byte Float2Byte(float f) { }

	// RVA: 0x226C670 Offset: 0x226AC70 VA: 0x18226C670
	public static float Byte2Float(int b) { }

	// RVA: 0x226CC70 Offset: 0x226B270 VA: 0x18226CC70
	public static short Float2Short(float f) { }

	// RVA: 0x226CC90 Offset: 0x226B290 VA: 0x18226CC90
	public static float Short2Float(int b) { }

	// RVA: 0x226C8A0 Offset: 0x226AEA0 VA: 0x18226C8A0
	public static Color32 EncodeFloat(float f) { }

	// RVA: 0x226C680 Offset: 0x226AC80 VA: 0x18226C680
	public static float DecodeFloat(Color32 c) { }

	// RVA: 0x226C8F0 Offset: 0x226AEF0 VA: 0x18226C8F0
	public static Color32 EncodeInt(int i) { }

	// RVA: 0x226C6B0 Offset: 0x226ACB0 VA: 0x18226C6B0
	public static int DecodeInt(Color32 c) { }

	// RVA: 0x226CA60 Offset: 0x226B060 VA: 0x18226CA60
	public static Color32 EncodeShort(short i) { }

	// RVA: 0x226C7D0 Offset: 0x226ADD0 VA: 0x18226C7D0
	public static short DecodeShort(Color32 c) { }

	// RVA: 0x226C940 Offset: 0x226AF40 VA: 0x18226C940
	public static Color EncodeNormal(Vector3 n) { }

	// RVA: 0x226C6E0 Offset: 0x226ACE0 VA: 0x18226C6E0
	public static Vector3 DecodeNormal(Color c) { }

	// RVA: 0x226CB80 Offset: 0x226B180 VA: 0x18226CB80
	public static Color32 EncodeVector(Vector4 v) { }

	// RVA: 0x226C820 Offset: 0x226AE20 VA: 0x18226C820
	public static Vector4 DecodeVector(Color32 c) { }

	// RVA: 0x226CAA0 Offset: 0x226B0A0 VA: 0x18226CAA0
	public static Color32 EncodeVector2i(Vector2i v) { }

	// RVA: 0x226C7F0 Offset: 0x226ADF0 VA: 0x18226C7F0
	public static Vector2i DecodeVector2i(Color32 c) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

