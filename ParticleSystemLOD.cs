public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 9950
{	[HorizontalAttribute] // RVA: 0xAA030 Offset: 0xA9430 VA: 0x1800AA030
	public ParticleSystemLOD.State[] States; // 0xA8


	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 9951
{	public float distance; // 0x10
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float emission; // 0x14


	public void .ctor() { }

}

