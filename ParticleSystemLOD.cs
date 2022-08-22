public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 9950
{	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public ParticleSystemLOD.State[] States; // 0xA8


	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 9951
{	public float distance; // 0x10
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float emission; // 0x14


	public void .ctor() { }

}

