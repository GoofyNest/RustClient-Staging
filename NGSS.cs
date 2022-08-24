public class NGSS_Directional : MonoBehaviour // TypeDefIndex: 11510
{	[TooltipAttribute] // RVA: 0xB8F90 Offset: 0xB8390 VA: 0x1800B8F90
	[RangeAttribute] // RVA: 0xB8F90 Offset: 0xB8390 VA: 0x1800B8F90
	public float PCSS_GLOBAL_SOFTNESS; // 0x18
	[TooltipAttribute] // RVA: 0xB9020 Offset: 0xB8420 VA: 0x1800B9020
	[RangeAttribute] // RVA: 0xB9020 Offset: 0xB8420 VA: 0x1800B9020
	public float PCSS_FILTER_DIR_MIN; // 0x1C
	[TooltipAttribute] // RVA: 0xB9190 Offset: 0xB8590 VA: 0x1800B9190
	[RangeAttribute] // RVA: 0xB9190 Offset: 0xB8590 VA: 0x1800B9190
	public float PCSS_FILTER_DIR_MAX; // 0x20
	[TooltipAttribute] // RVA: 0xB9260 Offset: 0xB8660 VA: 0x1800B9260
	[RangeAttribute] // RVA: 0xB9260 Offset: 0xB8660 VA: 0x1800B9260
	public float BANDING_NOISE_AMOUNT; // 0x24
	[TooltipAttribute] // RVA: 0xB9370 Offset: 0xB8770 VA: 0x1800B9370
	public NGSS_Directional.SAMPLER_COUNT SAMPLERS_COUNT; // 0x28


	private void Update() { }

	private void SetGlobalSettings(bool enabled) { }

	public void .ctor() { }

}

public enum NGSS_Directional.SAMPLER_COUNT // TypeDefIndex: 11511
{	public int value__; // 0x0
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_16 = 0;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_25 = 1;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_32 = 2;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_64 = 3;

}

