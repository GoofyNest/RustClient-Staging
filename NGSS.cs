public class NGSS_Directional : MonoBehaviour // TypeDefIndex: 11506
{	// Fields
	[TooltipAttribute] // RVA: 0xB8D80 Offset: 0xB8180 VA: 0x1800B8D80
	[RangeAttribute] // RVA: 0xB8D80 Offset: 0xB8180 VA: 0x1800B8D80
	public float PCSS_GLOBAL_SOFTNESS; // 0x18
	[TooltipAttribute] // RVA: 0xB8EE0 Offset: 0xB82E0 VA: 0x1800B8EE0
	[RangeAttribute] // RVA: 0xB8EE0 Offset: 0xB82E0 VA: 0x1800B8EE0
	public float PCSS_FILTER_DIR_MIN; // 0x1C
	[TooltipAttribute] // RVA: 0xB8F70 Offset: 0xB8370 VA: 0x1800B8F70
	[RangeAttribute] // RVA: 0xB8F70 Offset: 0xB8370 VA: 0x1800B8F70
	public float PCSS_FILTER_DIR_MAX; // 0x20
	[TooltipAttribute] // RVA: 0xB90E0 Offset: 0xB84E0 VA: 0x1800B90E0
	[RangeAttribute] // RVA: 0xB90E0 Offset: 0xB84E0 VA: 0x1800B90E0
	public float BANDING_NOISE_AMOUNT; // 0x24
	[TooltipAttribute] // RVA: 0xB9170 Offset: 0xB8570 VA: 0x1800B9170
	public NGSS_Directional.SAMPLER_COUNT SAMPLERS_COUNT; // 0x28

	// Methods

	// RVA: 0x7C3B30 Offset: 0x7C2130 VA: 0x1807C3B30
	private void Update() { }

	// RVA: 0x7C3A80 Offset: 0x7C2080 VA: 0x1807C3A80
	private void SetGlobalSettings(bool enabled) { }

	// RVA: 0x7C3C70 Offset: 0x7C2270 VA: 0x1807C3C70
	public void .ctor() { }

}

public enum NGSS_Directional.SAMPLER_COUNT // TypeDefIndex: 11507
{	// Fields
	public int value__; // 0x0
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_16 = 0;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_25 = 1;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_32 = 2;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_64 = 3;

}

