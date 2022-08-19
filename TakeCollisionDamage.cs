public class TakeCollisionDamage : FacepunchBehaviour // TypeDefIndex: 9753
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BaseCombatEntity entity; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float minDamage; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float maxDamage; // 0x24
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float forceForAnyDamage; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float forceForMaxDamage; // 0x2C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float velocityRestorePercent; // 0x30

	// Properties
	private bool IsServer { get; }
	private bool IsClient { get; }

	// Methods

	// RVA: 0x7A8A80 Offset: 0x7A7080 VA: 0x1807A8A80
	private bool get_IsServer() { }

	// RVA: 0x7A8A60 Offset: 0x7A7060 VA: 0x1807A8A60
	private bool get_IsClient() { }

	// RVA: 0x7A8A30 Offset: 0x7A7030 VA: 0x1807A8A30
	public void .ctor() { }

}

