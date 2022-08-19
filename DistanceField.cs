public class DistanceField // TypeDefIndex: 11360
{	// Fields
	private static readonly int[] GaussOffsets; // 0x0
	private static readonly float[] GaussWeights; // 0x8

	// Methods

	// RVA: 0x9898E0 Offset: 0x987EE0 VA: 0x1809898E0
	public static void Generate(in int size, in byte threshold, in byte[] image, ref float[] distanceField) { }

	// RVA: 0x98A7C0 Offset: 0x988DC0 VA: 0x18098A7C0
	private static float SampleClamped(float[] data, int size, int x, int y) { }

	// RVA: 0x98A740 Offset: 0x988D40 VA: 0x18098A740
	private static Vector3 SampleClamped(Vector3[] data, int size, int x, int y) { }

	// RVA: 0x98A6E0 Offset: 0x988CE0 VA: 0x18098A6E0
	private static ushort SampleClamped(ushort[] data, int size, int x, int y) { }

	// RVA: 0x9891B0 Offset: 0x9877B0 VA: 0x1809891B0
	public static void GenerateVectors(in int size, in float[] distanceField, ref Vector3[] vectorField) { }

	// RVA: 0x988DC0 Offset: 0x9873C0 VA: 0x180988DC0
	public static void ApplyGaussianBlur(int size, float[] distanceField, int steps = 1) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98A820 Offset: 0x988E20 VA: 0x18098A820
	private static void .cctor() { }

}

