public abstract class LODComponentParticleSystem : LODComponent // TypeDefIndex: 9933
{	// Fields
	[TooltipAttribute] // RVA: 0xA9FA0 Offset: 0xA93A0 VA: 0x1800A9FA0
	public bool playOnShow; // 0x80
	protected ParticleSystem particleSystem; // 0x88
	protected Renderer particleSystemRenderer; // 0x90
	protected float maxEmission; // 0x98
	protected int curlod; // 0x9C
	protected bool force; // 0xA0
	private bool initialized; // 0xA1

	// Methods

	// RVA: 0x682AC0 Offset: 0x6810C0 VA: 0x180682AC0 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x6829D0 Offset: 0x680FD0 VA: 0x1806829D0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x682C20 Offset: 0x681220 VA: 0x180682C20 Slot: 13
	protected override void Show() { }

	// RVA: 0x682A10 Offset: 0x681010 VA: 0x180682A10 Slot: 14
	protected override void Hide() { }

	// RVA: 0x6829E0 Offset: 0x680FE0 VA: 0x1806829E0
	private void EnableParticleRenderer() { }

	// RVA: 0x6829A0 Offset: 0x680FA0 VA: 0x1806829A0
	private void DisableParticleRenderer() { }

	// RVA: 0x682B80 Offset: 0x681180 VA: 0x180682B80
	protected void SetEmissionRate(float rate) { }

	// RVA: 0x682CD0 Offset: 0x6812D0 VA: 0x180682CD0
	protected void .ctor() { }

}

