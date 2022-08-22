public class FlameTurret : StorageContainer // TypeDefIndex: 8569
{	// Fields
	public Transform upper; // 0x3D0
	public Vector3 aimDir; // 0x3D8
	public float arc; // 0x3E4
	public float triggeredDuration; // 0x3E8
	public float flameRange; // 0x3EC
	public float flameRadius; // 0x3F0
	public float fuelPerSec; // 0x3F4
	public Transform eyeTransform; // 0x3F8
	public List<DamageTypeEntry> damagePerSec; // 0x400
	public GameObjectRef triggeredEffect; // 0x408
	public GameObjectRef fireballPrefab; // 0x410
	public GameObjectRef explosionEffect; // 0x418
	public TargetTrigger trigger; // 0x420

	// Methods

	// RVA: 0x78FF30 Offset: 0x78E530 VA: 0x18078FF30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7381E0 Offset: 0x7367E0 VA: 0x1807381E0
	public bool IsTriggered() { }

	// RVA: 0x78FEF0 Offset: 0x78E4F0 VA: 0x18078FEF0
	public Vector3 GetEyePosition() { }

	// RVA: 0x7905E0 Offset: 0x78EBE0 VA: 0x1807905E0
	public void Update() { }

	// RVA: 0x78FEA0 Offset: 0x78E4A0 VA: 0x18078FEA0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x78FEE0 Offset: 0x78E4E0 VA: 0x18078FEE0
	public void ClientThink() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78FE40 Offset: 0x78E440 VA: 0x18078FE40
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x790390 Offset: 0x78E990 VA: 0x180790390
	public void UpdateAiming() { }

	// RVA: 0x790610 Offset: 0x78EC10 VA: 0x180790610
	public void .ctor() { }

}

