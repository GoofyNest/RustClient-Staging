public class DamageProperties : ScriptableObject // TypeDefIndex: 9979
{	// Fields
	public DamageProperties fallback; // 0x18
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public DamageProperties.HitAreaProperty[] bones; // 0x20

	// Methods

	// RVA: 0x6C7FE0 Offset: 0x6C65E0 VA: 0x1806C7FE0
	public float GetMultiplier(HitArea area) { }

	// RVA: 0x6C80E0 Offset: 0x6C66E0 VA: 0x1806C80E0
	public void ScaleDamage(HitInfo info) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class DamageProperties.HitAreaProperty // TypeDefIndex: 9980
{	// Fields
	public HitArea area; // 0x10
	public float damage; // 0x14

	// Methods

	// RVA: 0x858C70 Offset: 0x857270 VA: 0x180858C70
	public void .ctor() { }

}

