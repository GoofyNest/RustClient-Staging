public class SantaSleigh : BaseEntity // TypeDefIndex: 8636
{	// Fields
	public GameObjectRef prefabDrop; // 0x168
	public SpawnFilter filter; // 0x170
	public Transform dropOrigin; // 0x178
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float altitudeAboveTerrain; // 0x0
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static float desiredAltitude; // 0x4
	public Light bigLight; // 0x180
	public SoundPlayer hohoho; // 0x188
	public float hohohospacing; // 0x190
	public float hohoho_additional_spacing; // 0x194

	// Methods

	// RVA: 0x49F770 Offset: 0x49DD70 VA: 0x18049F770 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49F740 Offset: 0x49DD40 VA: 0x18049F740
	public void ClientPlayHoHoHo() { }

	// RVA: 0x49FB40 Offset: 0x49E140 VA: 0x18049FB40
	public void Update() { }

	// RVA: 0x49FCE0 Offset: 0x49E2E0 VA: 0x18049FCE0
	public void .ctor() { }

	// RVA: 0x49FC90 Offset: 0x49E290 VA: 0x18049FC90
	private static void .cctor() { }

}

