public class ParticleCollisionLOD : LODComponentParticleSystem // TypeDefIndex: 9946
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public ParticleCollisionLOD.State[] States; // 0xA8

	// Methods

	// RVA: 0x85C210 Offset: 0x85A810 VA: 0x18085C210
	private void UpdateLOD(int newlod) { }

	// RVA: 0x85C1B0 Offset: 0x85A7B0 VA: 0x18085C1B0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x85C110 Offset: 0x85A710 VA: 0x18085C110 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x85C2F0 Offset: 0x85A8F0 VA: 0x18085C2F0
	public void .ctor() { }

}

public enum ParticleCollisionLOD.QualityLevel // TypeDefIndex: 9947
{	// Fields
	public int value__; // 0x0
	public const ParticleCollisionLOD.QualityLevel Disabled = -1;
	public const ParticleCollisionLOD.QualityLevel HighQuality = 0;
	public const ParticleCollisionLOD.QualityLevel MediumQuality = 1;
	public const ParticleCollisionLOD.QualityLevel LowQuality = 2;

}

public class ParticleCollisionLOD.State // TypeDefIndex: 9948
{	// Fields
	public float distance; // 0x10
	public ParticleCollisionLOD.QualityLevel quality; // 0x14

	// Methods

	// RVA: 0x8753B0 Offset: 0x8739B0 VA: 0x1808753B0
	public void .ctor() { }

}

