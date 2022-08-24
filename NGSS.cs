public class NGSS_Directional : MonoBehaviour // TypeDefIndex: 11510
{	[TooltipAttribute] // RVA: 0xB8AF0 Offset: 0xB7EF0 VA: 0x1800B8AF0
	[RangeAttribute] // RVA: 0xB8AF0 Offset: 0xB7EF0 VA: 0x1800B8AF0
	public float PCSS_GLOBAL_SOFTNESS; // 0x18
	[TooltipAttribute] // RVA: 0xB8C20 Offset: 0xB8020 VA: 0x1800B8C20
	[RangeAttribute] // RVA: 0xB8C20 Offset: 0xB8020 VA: 0x1800B8C20
	public float PCSS_FILTER_DIR_MIN; // 0x1C
	[TooltipAttribute] // RVA: 0xB8D40 Offset: 0xB8140 VA: 0x1800B8D40
	[RangeAttribute] // RVA: 0xB8D40 Offset: 0xB8140 VA: 0x1800B8D40
	public float PCSS_FILTER_DIR_MAX; // 0x20
	[TooltipAttribute] // RVA: 0xB8E90 Offset: 0xB8290 VA: 0x1800B8E90
	[RangeAttribute] // RVA: 0xB8E90 Offset: 0xB8290 VA: 0x1800B8E90
	public float BANDING_NOISE_AMOUNT; // 0x24
	[TooltipAttribute] // RVA: 0xB8F70 Offset: 0xB8370 VA: 0x1800B8F70
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

