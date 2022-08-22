public class ParticleCollisionLOD : LODComponentParticleSystem // TypeDefIndex: 9946
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public ParticleCollisionLOD.State[] States; // 0xA8

	// Methods

	// RVA: 0x877A80 Offset: 0x876080 VA: 0x180877A80
	private void UpdateLOD(int newlod) { }

	// RVA: 0x877A20 Offset: 0x876020 VA: 0x180877A20 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x877980 Offset: 0x875F80 VA: 0x180877980 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x877B60 Offset: 0x876160 VA: 0x180877B60
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

	// RVA: 0x890BE0 Offset: 0x88F1E0 VA: 0x180890BE0
	public void .ctor() { }

}

