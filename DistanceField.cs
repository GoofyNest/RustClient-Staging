public class DistanceField // TypeDefIndex: 11360
{	// Fields
	private static readonly int[] GaussOffsets; // 0x0
	private static readonly float[] GaussWeights; // 0x8

	// Methods

	// RVA: 0x989EF0 Offset: 0x9884F0 VA: 0x180989EF0
	public static void Generate(in int size, in byte threshold, in byte[] image, ref float[] distanceField) { }

	// RVA: 0x98ADD0 Offset: 0x9893D0 VA: 0x18098ADD0
	private static float SampleClamped(float[] data, int size, int x, int y) { }

	// RVA: 0x98AD50 Offset: 0x989350 VA: 0x18098AD50
	private static Vector3 SampleClamped(Vector3[] data, int size, int x, int y) { }

	// RVA: 0x98ACF0 Offset: 0x9892F0 VA: 0x18098ACF0
	private static ushort SampleClamped(ushort[] data, int size, int x, int y) { }

	// RVA: 0x9897C0 Offset: 0x987DC0 VA: 0x1809897C0
	public static void GenerateVectors(in int size, in float[] distanceField, ref Vector3[] vectorField) { }

	// RVA: 0x9893D0 Offset: 0x9879D0 VA: 0x1809893D0
	public static void ApplyGaussianBlur(int size, float[] distanceField, int steps = 1) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98AE30 Offset: 0x989430 VA: 0x18098AE30
	private static void .cctor() { }

}

