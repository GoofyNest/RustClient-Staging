public class TrainBarricade : BaseCombatEntity, ITrainCollidable // TypeDefIndex: 9767
{	[FormerlySerializedAsAttribute] // RVA: 0x947E0 Offset: 0x93BE0 VA: 0x1800947E0
	[SerializeField] // RVA: 0x947E0 Offset: 0x93BE0 VA: 0x1800947E0
	private float trainDamagePerMPS; // 0x240
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float minVelToDestroy; // 0x244
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float velReduction; // 0x248
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef barricadeDamageEffect; // 0x250
	private float nextEffectTime; // 0x258


	public bool CustomCollision(TrainCar train, TriggerTrainCollisions trainTrigger) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

