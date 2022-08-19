public class ParticleSystemIK : MonoBehaviour, IClientComponent // TypeDefIndex: 11327
{	// Fields
	private ParticleSystem system; // 0x18
	private ParticleSystemIK.ParticleSystemIKJob job; // 0x20

	// Methods

	// RVA: 0x85EE80 Offset: 0x85D480 VA: 0x18085EE80
	private void Awake() { }

	// RVA: 0x85EFE0 Offset: 0x85D5E0 VA: 0x18085EFE0
	private void Update() { }

	// RVA: 0x85EED0 Offset: 0x85D4D0 VA: 0x18085EED0
	private void OnParticleUpdateJobScheduled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public struct ParticleSystemIK.ParticleSystemIKJob : IJobParticleSystem // TypeDefIndex: 11328
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public Vector3 position; // 0x0
	[ReadOnlyAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public Vector3 forward; // 0xC
	[ReadOnlyAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public float deltaTime; // 0x18

	// Methods

	// RVA: 0xF93C0 Offset: 0xF87C0 VA: 0x1800F93C0 Slot: 4
	public void Execute(ParticleSystemJobData particles) { }

}

