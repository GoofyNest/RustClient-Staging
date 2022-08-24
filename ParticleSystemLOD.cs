public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 9950
{	[HorizontalAttribute] // RVA: 0xAA500 Offset: 0xA9900 VA: 0x1800AA500
	public ParticleSystemLOD.State[] States; // 0xA8


	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 9951
{	public float distance; // 0x10
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float emission; // 0x14


	public void .ctor() { }

}

