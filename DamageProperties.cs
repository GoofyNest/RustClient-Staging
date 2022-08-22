public class DamageProperties : ScriptableObject // TypeDefIndex: 9979
{	// Fields
	public DamageProperties fallback; // 0x18
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public DamageProperties.HitAreaProperty[] bones; // 0x20

	// Methods

	// RVA: 0x6C8050 Offset: 0x6C6650 VA: 0x1806C8050
	public float GetMultiplier(HitArea area) { }

	// RVA: 0x6C8150 Offset: 0x6C6750 VA: 0x1806C8150
	public void ScaleDamage(HitInfo info) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class DamageProperties.HitAreaProperty // TypeDefIndex: 9980
{	// Fields
	public HitArea area; // 0x10
	public float damage; // 0x14

	// Methods

	// RVA: 0x858720 Offset: 0x856D20 VA: 0x180858720
	public void .ctor() { }

}

