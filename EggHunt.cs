public class EggHunt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6362
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<EggHunt.EggHunter> hunters; // 0x18

	// Methods

	// RVA: 0x1E71290 Offset: 0x1E6F890 VA: 0x181E71290
	public static void ResetToPool(EggHunt instance) { }

	// RVA: 0x1E71440 Offset: 0x1E6FA40 VA: 0x181E71440
	public void ResetToPool() { }

	// RVA: 0x1E71010 Offset: 0x1E6F610 VA: 0x181E71010 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E70160 Offset: 0x1E6E760 VA: 0x181E70160
	public void CopyTo(EggHunt instance) { }

	// RVA: 0x1E70300 Offset: 0x1E6E900 VA: 0x181E70300
	public EggHunt Copy() { }

	// RVA: 0x1E70E70 Offset: 0x1E6F470 VA: 0x181E70E70
	public static EggHunt Deserialize(Stream stream) { }

	// RVA: 0x1E70500 Offset: 0x1E6EB00 VA: 0x181E70500
	public static EggHunt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E70AF0 Offset: 0x1E6F0F0 VA: 0x181E70AF0
	public static EggHunt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E70EF0 Offset: 0x1E6F4F0 VA: 0x181E70EF0
	public static EggHunt Deserialize(byte[] buffer) { }

	// RVA: 0x1E71250 Offset: 0x1E6F850 VA: 0x181E71250
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E71B80 Offset: 0x1E70180 VA: 0x181E71B80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E71BA0 Offset: 0x1E701A0 VA: 0x181E71BA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt previous) { }

	// RVA: 0x1E71270 Offset: 0x1E6F870 VA: 0x181E71270 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E70D70 Offset: 0x1E6F370 VA: 0x181E70D70
	public static EggHunt Deserialize(byte[] buffer, EggHunt instance, bool isDelta = False) { }

	// RVA: 0x1E70B80 Offset: 0x1E6F180 VA: 0x181E70B80
	public static EggHunt Deserialize(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E70580 Offset: 0x1E6EB80 VA: 0x181E70580
	public static EggHunt DeserializeLengthDelimited(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E70850 Offset: 0x1E6EE50 VA: 0x181E70850
	public static EggHunt DeserializeLength(Stream stream, int length, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E715F0 Offset: 0x1E6FBF0 VA: 0x181E715F0
	public static void SerializeDelta(Stream stream, EggHunt instance, EggHunt previous) { }

	// RVA: 0x1E71990 Offset: 0x1E6FF90 VA: 0x181E71990
	public static void Serialize(Stream stream, EggHunt instance) { }

	// RVA: 0x1E71B70 Offset: 0x1E70170 VA: 0x181E71B70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E71B80 Offset: 0x1E70180 VA: 0x181E71B80
	public void ToProto(Stream stream) { }

	// RVA: 0x1E71880 Offset: 0x1E6FE80 VA: 0x181E71880
	public static byte[] SerializeToBytes(EggHunt instance) { }

	// RVA: 0x1E717D0 Offset: 0x1E6FDD0 VA: 0x181E717D0
	public static void SerializeLengthDelimited(Stream stream, EggHunt instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class EggHunt.EggHunter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6363
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string displayName; // 0x18
	public int numEggs; // 0x20
	public ulong playerID; // 0x28

	// Methods

	// RVA: 0x1E72E10 Offset: 0x1E71410 VA: 0x181E72E10
	public static void ResetToPool(EggHunt.EggHunter instance) { }

	// RVA: 0x1E72EC0 Offset: 0x1E714C0 VA: 0x181E72EC0
	public void ResetToPool() { }

	// RVA: 0x1E72BB0 Offset: 0x1E711B0 VA: 0x181E72BB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E71BC0 Offset: 0x1E701C0 VA: 0x181E71BC0
	public void CopyTo(EggHunt.EggHunter instance) { }

	// RVA: 0x1E71C10 Offset: 0x1E70210 VA: 0x181E71C10
	public EggHunt.EggHunter Copy() { }

	// RVA: 0x1E72700 Offset: 0x1E70D00 VA: 0x181E72700
	public static EggHunt.EggHunter Deserialize(Stream stream) { }

	// RVA: 0x1E71CA0 Offset: 0x1E702A0 VA: 0x181E71CA0
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E72220 Offset: 0x1E70820 VA: 0x181E72220
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E72900 Offset: 0x1E70F00 VA: 0x181E72900
	public static EggHunt.EggHunter Deserialize(byte[] buffer) { }

	// RVA: 0x1E72C30 Offset: 0x1E71230 VA: 0x181E72C30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E73490 Offset: 0x1E71A90 VA: 0x181E73490 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E734B0 Offset: 0x1E71AB0 VA: 0x181E734B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt.EggHunter previous) { }

	// RVA: 0x1E72DF0 Offset: 0x1E713F0 VA: 0x181E72DF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E722B0 Offset: 0x1E708B0 VA: 0x181E722B0
	public static EggHunt.EggHunter Deserialize(byte[] buffer, EggHunt.EggHunter instance, bool isDelta = False) { }

	// RVA: 0x1E72540 Offset: 0x1E70B40 VA: 0x181E72540
	public static EggHunt.EggHunter Deserialize(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E71D20 Offset: 0x1E70320 VA: 0x181E71D20
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E71FB0 Offset: 0x1E705B0 VA: 0x181E71FB0
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E72F70 Offset: 0x1E71570 VA: 0x181E72F70
	public static void SerializeDelta(Stream stream, EggHunt.EggHunter instance, EggHunt.EggHunter previous) { }

	// RVA: 0x1E73310 Offset: 0x1E71910 VA: 0x181E73310
	public static void Serialize(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x1E73480 Offset: 0x1E71A80 VA: 0x181E73480
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E73490 Offset: 0x1E71A90 VA: 0x181E73490
	public void ToProto(Stream stream) { }

	// RVA: 0x1E73200 Offset: 0x1E71800 VA: 0x181E73200
	public static byte[] SerializeToBytes(EggHunt.EggHunter instance) { }

	// RVA: 0x1E73150 Offset: 0x1E71750 VA: 0x181E73150
	public static void SerializeLengthDelimited(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class EggAmmoRepresentation : MonoBehaviour, IInventoryChanged, IClientComponent // TypeDefIndex: 8779
{	// Fields
	public GameObject[] eggAmmo; // 0x18

	// Methods

	// RVA: 0xABF740 Offset: 0xABDD40 VA: 0x180ABF740
	public void OnEnable() { }

	// RVA: 0xABF6C0 Offset: 0xABDCC0 VA: 0x180ABF6C0
	public void OnDisable() { }

	// RVA: 0xABF7C0 Offset: 0xABDDC0 VA: 0x180ABF7C0 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class EggSwap : MonoBehaviour // TypeDefIndex: 8780
{	// Fields
	public Renderer[] eggRenderers; // 0x18

	// Methods

	// RVA: 0xAC0550 Offset: 0xABEB50 VA: 0x180AC0550
	public void Show(int index) { }

	// RVA: 0xAC04F0 Offset: 0xABEAF0 VA: 0x180AC04F0
	public void HideAll() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class EggHuntEvent : BaseHuntEvent // TypeDefIndex: 8781
{	// Fields
	public float warmupTime; // 0x178
	public float cooldownTime; // 0x17C
	public float warnTime; // 0x180
	public float timeAlive; // 0x184
	public static EggHuntEvent serverEvent; // 0x0
	public static EggHuntEvent clientEvent; // 0x8
	public static float durationSeconds; // 0x10
	private Dictionary<ulong, EggHuntEvent.EggHunter> _eggHunters; // 0x188
	public List<EggHuntEvent.EggHunter> clientTopHunters; // 0x190

	// Methods

	// RVA: 0xABFC60 Offset: 0xABE260 VA: 0x180ABFC60
	public bool IsEventActive() { }

	// RVA: 0xABFD10 Offset: 0xABE310 VA: 0x180ABFD10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xABF9C0 Offset: 0xABDFC0 VA: 0x180ABF9C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xABFA50 Offset: 0xABE050 VA: 0x180ABFA50 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xABFFC0 Offset: 0xABE5C0 VA: 0x180ABFFC0
	public void Update() { }

	// RVA: 0xABFB00 Offset: 0xABE100 VA: 0x180ABFB00
	public float GetTimeRemaining() { }

	// RVA: 0xABFF00 Offset: 0xABE500 VA: 0x180ABFF00
	public static bool ShowNotification() { }

	// RVA: 0xABFB70 Offset: 0xABE170 VA: 0x180ABFB70
	public static float GetWarmupSecondsLeft() { }

	// RVA: 0xAC0080 Offset: 0xABE680 VA: 0x180AC0080
	public void .ctor() { }

	// RVA: 0xAC0000 Offset: 0xABE600 VA: 0x180AC0000
	private static void .cctor() { }

}

public class EggHuntEvent.EggHunter // TypeDefIndex: 8782
{	// Fields
	public ulong userid; // 0x10
	public string displayName; // 0x18
	public int numEggs; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class EggHuntNote : MonoBehaviour, IClientComponent // TypeDefIndex: 8788
{	// Fields
	public CanvasGroup mainGroup; // 0x18
	public CanvasGroup timerGroup; // 0x20
	public Text timerText; // 0x28

	// Methods

	// RVA: 0xAC0140 Offset: 0xABE740 VA: 0x180AC0140
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

