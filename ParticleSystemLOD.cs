public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 11698
{
	[HorizontalAttribute]
	public ParticleSystemLOD.State[] States;


	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 11699
{
	public float distance;
	[RangeAttribute]
	public float emission;


	public void .ctor() { }

}

