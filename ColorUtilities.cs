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

	// RVA: 0x9F7D90 Offset: 0x9F6390 VA: 0x1809F7D90
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x9F7680 Offset: 0x9F5C80 VA: 0x1809F7680
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x9F7AA0 Offset: 0x9F60A0 VA: 0x1809F7AA0
	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	// RVA: 0x9F79C0 Offset: 0x9F5FC0 VA: 0x1809F79C0
	public static Vector3 ColorToLift(Vector4 color) { }

	// RVA: 0x9F7810 Offset: 0x9F5E10 VA: 0x1809F7810
	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	// RVA: 0x9F7730 Offset: 0x9F5D30 VA: 0x1809F7730
	public static Vector3 ColorToGain(Vector4 color) { }

	// RVA: 0x9F7CE0 Offset: 0x9F62E0 VA: 0x1809F7CE0
	public static float LogCToLinear(float x) { }

	// RVA: 0x9F7C40 Offset: 0x9F6240 VA: 0x1809F7C40
	public static float LinearToLogC(float x) { }

	// RVA: 0x9F7DC0 Offset: 0x9F63C0 VA: 0x1809F7DC0
	public static uint ToHex(Color c) { }

	// RVA: 0x9F7E20 Offset: 0x9F6420 VA: 0x1809F7E20
	public static Color ToRGBA(uint hex) { }

}

