public class DamageProperties : ScriptableObject // TypeDefIndex: 9979
{	// Fields
	public DamageProperties fallback; // 0x18
	[HorizontalAttribute] // RVA: 0xAA2D0 Offset: 0xA96D0 VA: 0x1800AA2D0
	public DamageProperties.HitAreaProperty[] bones; // 0x20

	// Methods

	// RVA: 0x6C7F40 Offset: 0x6C6540 VA: 0x1806C7F40
	public float GetMultiplier(HitArea area) { }

	// RVA: 0x6C8040 Offset: 0x6C6640 VA: 0x1806C8040
	public void ScaleDamage(HitInfo info) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class DamageProperties.HitAreaProperty // TypeDefIndex: 9980
{	// Fields
	public HitArea area; // 0x10
	public float damage; // 0x14

	// Methods

	// RVA: 0x858610 Offset: 0x856C10 VA: 0x180858610
	public void .ctor() { }

}

