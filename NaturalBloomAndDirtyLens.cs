public class NaturalBloomAndDirtyLens : MonoBehaviour // TypeDefIndex: 10098
{	// Fields
	public Shader shader; // 0x18
	public Texture2D lensDirtTexture; // 0x20
	public float range; // 0x28
	public float cutoff; // 0x2C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float bloomIntensity; // 0x30
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float lensDirtIntensity; // 0x34
	[RangeAttribute] // RVA: 0xB4520 Offset: 0xB3920 VA: 0x1800B4520
	public float spread; // 0x38
	[RangeAttribute] // RVA: 0xB4520 Offset: 0xB3920 VA: 0x1800B4520
	public int iterations; // 0x3C
	[RangeAttribute] // RVA: 0xB45A0 Offset: 0xB39A0 VA: 0x1800B45A0
	public int mips; // 0x40
	public float[] mipWeights; // 0x48
	public bool highPrecision; // 0x50
	public bool downscaleSource; // 0x51
	public bool debug; // 0x52
	public bool temporalFilter; // 0x53
	[RangeAttribute] // RVA: 0xB4610 Offset: 0xB3A10 VA: 0x1800B4610
	public float temporalFilterWeight; // 0x54
	private Material material; // 0x58
	private float blurSize; // 0x60
	private RenderTexture temporalHistory; // 0x68
	private static int[] paramID; // 0x0
	private static int[] sourceID; // 0x8

	// Methods

	// RVA: 0x7CA630 Offset: 0x7C8C30 VA: 0x1807CA630
	private void OnDisable() { }

	// RVA: 0x7CB240 Offset: 0x7C9840 VA: 0x1807CB240
	private void UpdateMaterial(bool encoding) { }

	// RVA: 0x7CA790 Offset: 0x7C8D90 VA: 0x1807CA790
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7CB950 Offset: 0x7C9F50 VA: 0x1807CB950
	public void .ctor() { }

	// RVA: 0x7CB620 Offset: 0x7C9C20 VA: 0x1807CB620
	private static void .cctor() { }

}

private static class NaturalBloomAndDirtyLens.Param // TypeDefIndex: 10099
{	// Fields
	public const int _BloomRange = 0;
	public const int _BloomCutoff = 1;
	public const int _BloomIntensity = 2;
	public const int _LensDirtIntensity = 3;
	public const int _MipWeights = 4;
	public const int _LensDirt = 5;
	public const int _BlurSize = 6;
	public const int _TemporalHistory = 7;
	public const int _TemporalFilterWeight = 8;

}

