public class NGSS_Directional : MonoBehaviour // TypeDefIndex: 11506
{	// Fields
	[TooltipAttribute] // RVA: 0xB8C90 Offset: 0xB8090 VA: 0x1800B8C90
	[RangeAttribute] // RVA: 0xB8C90 Offset: 0xB8090 VA: 0x1800B8C90
	public float PCSS_GLOBAL_SOFTNESS; // 0x18
	[TooltipAttribute] // RVA: 0xB8D40 Offset: 0xB8140 VA: 0x1800B8D40
	[RangeAttribute] // RVA: 0xB8D40 Offset: 0xB8140 VA: 0x1800B8D40
	public float PCSS_FILTER_DIR_MIN; // 0x1C
	[TooltipAttribute] // RVA: 0xB8EA0 Offset: 0xB82A0 VA: 0x1800B8EA0
	[RangeAttribute] // RVA: 0xB8EA0 Offset: 0xB82A0 VA: 0x1800B8EA0
	public float PCSS_FILTER_DIR_MAX; // 0x20
	[TooltipAttribute] // RVA: 0xB8FC0 Offset: 0xB83C0 VA: 0x1800B8FC0
	[RangeAttribute] // RVA: 0xB8FC0 Offset: 0xB83C0 VA: 0x1800B8FC0
	public float BANDING_NOISE_AMOUNT; // 0x24
	[TooltipAttribute] // RVA: 0xB90D0 Offset: 0xB84D0 VA: 0x1800B90D0
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

