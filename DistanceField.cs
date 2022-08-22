public class DistanceField // TypeDefIndex: 11360
{	// Fields
	private static readonly int[] GaussOffsets; // 0x0
	private static readonly float[] GaussWeights; // 0x8

	// Methods

	// RVA: 0x9899F0 Offset: 0x987FF0 VA: 0x1809899F0
	public static void Generate(in int size, in byte threshold, in byte[] image, ref float[] distanceField) { }

	// RVA: 0x98A8D0 Offset: 0x988ED0 VA: 0x18098A8D0
	private static float SampleClamped(float[] data, int size, int x, int y) { }

	// RVA: 0x98A850 Offset: 0x988E50 VA: 0x18098A850
	private static Vector3 SampleClamped(Vector3[] data, int size, int x, int y) { }

	// RVA: 0x98A7F0 Offset: 0x988DF0 VA: 0x18098A7F0
	private static ushort SampleClamped(ushort[] data, int size, int x, int y) { }

	// RVA: 0x9892C0 Offset: 0x9878C0 VA: 0x1809892C0
	public static void GenerateVectors(in int size, in float[] distanceField, ref Vector3[] vectorField) { }

	// RVA: 0x988ED0 Offset: 0x9874D0 VA: 0x180988ED0
	public static void ApplyGaussianBlur(int size, float[] distanceField, int steps = 1) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98A930 Offset: 0x988F30 VA: 0x18098A930
	private static void .cctor() { }

}

