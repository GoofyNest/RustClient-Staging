public class TakeCollisionDamage : FacepunchBehaviour // TypeDefIndex: 9753
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	private bool IsServer { get; }
	private bool IsClient { get; }


	private bool get_IsServer() { }

	private bool get_IsClient() { }

	public void .ctor() { }

}

