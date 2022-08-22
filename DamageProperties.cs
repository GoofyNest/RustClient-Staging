public class DamageProperties : ScriptableObject // TypeDefIndex: 9979
{	public DamageProperties fallback; // 0x18
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public DamageProperties.HitAreaProperty[] bones; // 0x20


	public float GetMultiplier(HitArea area) { }

	public void ScaleDamage(HitInfo info) { }

	public void .ctor() { }

}

public class DamageProperties.HitAreaProperty // TypeDefIndex: 9980
{	public HitArea area; // 0x10
	public float damage; // 0x14


	public void .ctor() { }

}

