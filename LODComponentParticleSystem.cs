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

	// RVA: 0x682B30 Offset: 0x681130 VA: 0x180682B30 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x682A40 Offset: 0x681040 VA: 0x180682A40 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x682C90 Offset: 0x681290 VA: 0x180682C90 Slot: 13
	protected override void Show() { }

	// RVA: 0x682A80 Offset: 0x681080 VA: 0x180682A80 Slot: 14
	protected override void Hide() { }

	// RVA: 0x682A50 Offset: 0x681050 VA: 0x180682A50
	private void EnableParticleRenderer() { }

	// RVA: 0x682A10 Offset: 0x681010 VA: 0x180682A10
	private void DisableParticleRenderer() { }

	// RVA: 0x682BF0 Offset: 0x6811F0 VA: 0x180682BF0
	protected void SetEmissionRate(float rate) { }

	// RVA: 0x682D40 Offset: 0x681340 VA: 0x180682D40
	protected void .ctor() { }

}

