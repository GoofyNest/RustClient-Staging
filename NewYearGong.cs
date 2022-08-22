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

	// RVA: 0x9D0900 Offset: 0x9CEF00 VA: 0x1809D0900 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9D0D50 Offset: 0x9CF350 VA: 0x1809D0D50
	public void PlaySound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9D0FB0 Offset: 0x9CF5B0 VA: 0x1809D0FB0
	public void .ctor() { }

	// RVA: 0x9D0F60 Offset: 0x9CF560 VA: 0x1809D0F60
	private static void .cctor() { }

}

