public class ParticleSystemIK : MonoBehaviour, IClientComponent // TypeDefIndex: 11327
{	private ParticleSystem system; // 0x18
	private ParticleSystemIK.ParticleSystemIKJob job; // 0x20


	private void Awake() { }

	private void Update() { }

	private void OnParticleUpdateJobScheduled() { }

	public void .ctor() { }

}

public struct ParticleSystemIK.ParticleSystemIKJob : IJobParticleSystem // TypeDefIndex: 11328
{	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public Vector3 position; // 0x0
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public Vector3 forward; // 0xC
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public float deltaTime; // 0x18


	public void Execute(ParticleSystemJobData particles) { }

}

