public class TakeCollisionDamage : FacepunchBehaviour // TypeDefIndex: 9753
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BaseCombatEntity entity; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float minDamage; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxDamage; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float forceForAnyDamage; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float forceForMaxDamage; // 0x2C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float velocityRestorePercent; // 0x30

	// Properties
	private bool IsServer { get; }
	private bool IsClient { get; }

	// Methods

	// RVA: 0x7C6F90 Offset: 0x7C5590 VA: 0x1807C6F90
	private bool get_IsServer() { }

	// RVA: 0x7C6F70 Offset: 0x7C5570 VA: 0x1807C6F70
	private bool get_IsClient() { }

	// RVA: 0x7C6F40 Offset: 0x7C5540 VA: 0x1807C6F40
	public void .ctor() { }

}

