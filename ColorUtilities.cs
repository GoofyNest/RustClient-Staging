public static class ColorUtilities // TypeDefIndex: 11857
{	// Fields
	private const float logC_cut = 0,011361;
	private const float logC_a = 5,555556;
	private const float logC_b = 0,047996;
	private const float logC_c = 0,244161;
	private const float logC_d = 0,386036;
	private const float logC_e = 5,301883;
	private const float logC_f = 0,092819;

	// Methods

	// RVA: 0x9F8280 Offset: 0x9F6880 VA: 0x1809F8280
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x9F7B70 Offset: 0x9F6170 VA: 0x1809F7B70
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x9F7F90 Offset: 0x9F6590 VA: 0x1809F7F90
	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	// RVA: 0x9F7EB0 Offset: 0x9F64B0 VA: 0x1809F7EB0
	public static Vector3 ColorToLift(Vector4 color) { }

	// RVA: 0x9F7D00 Offset: 0x9F6300 VA: 0x1809F7D00
	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	// RVA: 0x9F7C20 Offset: 0x9F6220 VA: 0x1809F7C20
	public static Vector3 ColorToGain(Vector4 color) { }

	// RVA: 0x9F81D0 Offset: 0x9F67D0 VA: 0x1809F81D0
	public static float LogCToLinear(float x) { }

	// RVA: 0x9F8130 Offset: 0x9F6730 VA: 0x1809F8130
	public static float LinearToLogC(float x) { }

	// RVA: 0x9F82B0 Offset: 0x9F68B0 VA: 0x1809F82B0
	public static uint ToHex(Color c) { }

	// RVA: 0x9F8310 Offset: 0x9F6910 VA: 0x1809F8310
	public static Color ToRGBA(uint hex) { }

}

