public class ParticleCollisionLOD : LODComponentParticleSystem // TypeDefIndex: 9946
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public ParticleCollisionLOD.State[] States; // 0xA8

	// Methods

	// RVA: 0x85C320 Offset: 0x85A920 VA: 0x18085C320
	private void UpdateLOD(int newlod) { }

	// RVA: 0x85C2C0 Offset: 0x85A8C0 VA: 0x18085C2C0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x85C220 Offset: 0x85A820 VA: 0x18085C220 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x85C400 Offset: 0x85AA00 VA: 0x18085C400
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

	// RVA: 0x8754C0 Offset: 0x873AC0 VA: 0x1808754C0
	public void .ctor() { }

}

