public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 9950
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public ParticleSystemLOD.State[] States; // 0xA8

	// Methods

	// RVA: 0x85F3A0 Offset: 0x85D9A0 VA: 0x18085F3A0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x85F240 Offset: 0x85D840 VA: 0x18085F240 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x85C400 Offset: 0x85AA00 VA: 0x18085C400
	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 9951
{	// Fields
	public float distance; // 0x10
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float emission; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

