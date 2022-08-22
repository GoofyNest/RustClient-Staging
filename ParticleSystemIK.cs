public class ParticleSystemIK : MonoBehaviour, IClientComponent // TypeDefIndex: 11327
{	// Fields
	private ParticleSystem system; // 0x18
	private ParticleSystemIK.ParticleSystemIKJob job; // 0x20

	// Methods

	// RVA: 0x85EF90 Offset: 0x85D590 VA: 0x18085EF90
	private void Awake() { }

	// RVA: 0x85F0F0 Offset: 0x85D6F0 VA: 0x18085F0F0
	private void Update() { }

	// RVA: 0x85EFE0 Offset: 0x85D5E0 VA: 0x18085EFE0
	private void OnParticleUpdateJobScheduled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public struct ParticleSystemIK.ParticleSystemIKJob : IJobParticleSystem // TypeDefIndex: 11328
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public Vector3 position; // 0x0
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public Vector3 forward; // 0xC
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public float deltaTime; // 0x18

	// Methods

	// RVA: 0xF9340 Offset: 0xF8740 VA: 0x1800F9340 Slot: 4
	public void Execute(ParticleSystemJobData particles) { }

}

