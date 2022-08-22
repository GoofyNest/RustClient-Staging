public class NewYearGong : BaseCombatEntity // TypeDefIndex: 8609
{	// Fields
	public SoundDefinition gongSound; // 0x240
	public float minTimeBetweenSounds; // 0x248
	public GameObject soundRoot; // 0x250
	public Transform gongCentre; // 0x258
	public float gongRadius; // 0x260
	public AnimationCurve pitchCurve; // 0x268
	public Animator gongAnimator; // 0x270
	private static int gongHit_trigger; // 0x0
	private Sound playingSound; // 0x278

	// Methods

	// RVA: 0x9D0BC0 Offset: 0x9CF1C0 VA: 0x1809D0BC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9D1010 Offset: 0x9CF610 VA: 0x1809D1010
	public void PlaySound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9D1270 Offset: 0x9CF870 VA: 0x1809D1270
	public void .ctor() { }

	// RVA: 0x9D1220 Offset: 0x9CF820 VA: 0x1809D1220
	private static void .cctor() { }

}

