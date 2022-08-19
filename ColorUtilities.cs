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

	// RVA: 0x9F7AD0 Offset: 0x9F60D0 VA: 0x1809F7AD0
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x9F73C0 Offset: 0x9F59C0 VA: 0x1809F73C0
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x9F77E0 Offset: 0x9F5DE0 VA: 0x1809F77E0
	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	// RVA: 0x9F7700 Offset: 0x9F5D00 VA: 0x1809F7700
	public static Vector3 ColorToLift(Vector4 color) { }

	// RVA: 0x9F7550 Offset: 0x9F5B50 VA: 0x1809F7550
	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	// RVA: 0x9F7470 Offset: 0x9F5A70 VA: 0x1809F7470
	public static Vector3 ColorToGain(Vector4 color) { }

	// RVA: 0x9F7A20 Offset: 0x9F6020 VA: 0x1809F7A20
	public static float LogCToLinear(float x) { }

	// RVA: 0x9F7980 Offset: 0x9F5F80 VA: 0x1809F7980
	public static float LinearToLogC(float x) { }

	// RVA: 0x9F7B00 Offset: 0x9F6100 VA: 0x1809F7B00
	public static uint ToHex(Color c) { }

	// RVA: 0x9F7B60 Offset: 0x9F6160 VA: 0x1809F7B60
	public static Color ToRGBA(uint hex) { }

}

