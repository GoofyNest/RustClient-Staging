public class NaturalBloomAndDirtyLens : MonoBehaviour // TypeDefIndex: 10098
{	// Fields
	public Shader shader; // 0x18
	public Texture2D lensDirtTexture; // 0x20
	public float range; // 0x28
	public float cutoff; // 0x2C
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float bloomIntensity; // 0x30
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float lensDirtIntensity; // 0x34
	[RangeAttribute] // RVA: 0xB4480 Offset: 0xB3880 VA: 0x1800B4480
	public float spread; // 0x38
	[RangeAttribute] // RVA: 0xB4480 Offset: 0xB3880 VA: 0x1800B4480
	public int iterations; // 0x3C
	[RangeAttribute] // RVA: 0xB4500 Offset: 0xB3900 VA: 0x1800B4500
	public int mips; // 0x40
	public float[] mipWeights; // 0x48
	public bool highPrecision; // 0x50
	public bool downscaleSource; // 0x51
	public bool debug; // 0x52
	public bool temporalFilter; // 0x53
	[RangeAttribute] // RVA: 0xB4570 Offset: 0xB3970 VA: 0x1800B4570
	public float temporalFilterWeight; // 0x54
	private Material material; // 0x58
	private float blurSize; // 0x60
	private RenderTexture temporalHistory; // 0x68
	private static int[] paramID; // 0x0
	private static int[] sourceID; // 0x8

	// Methods

	// RVA: 0x7CA520 Offset: 0x7C8B20 VA: 0x1807CA520
	private void OnDisable() { }

	// RVA: 0x7CB130 Offset: 0x7C9730 VA: 0x1807CB130
	private void UpdateMaterial(bool encoding) { }

	// RVA: 0x7CA680 Offset: 0x7C8C80 VA: 0x1807CA680
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7CB840 Offset: 0x7C9E40 VA: 0x1807CB840
	public void .ctor() { }

	// RVA: 0x7CB510 Offset: 0x7C9B10 VA: 0x1807CB510
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
