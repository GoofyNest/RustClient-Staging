public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 9950
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA2D0 Offset: 0xA96D0 VA: 0x1800AA2D0
	public ParticleSystemLOD.State[] States; // 0xA8

	// Methods

	// RVA: 0x85F290 Offset: 0x85D890 VA: 0x18085F290 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x85F130 Offset: 0x85D730 VA: 0x18085F130 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x85C2F0 Offset: 0x85A8F0 VA: 0x18085C2F0
	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 9951
{	// Fields
	public float distance; // 0x10
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float emission; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}
