public class EggHunt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6362
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<EggHunt.EggHunter> hunters; // 0x18

	// Methods

	// RVA: 0x1E70A70 Offset: 0x1E6F070 VA: 0x181E70A70
	public static void ResetToPool(EggHunt instance) { }

	// RVA: 0x1E70C20 Offset: 0x1E6F220 VA: 0x181E70C20
	public void ResetToPool() { }

	// RVA: 0x1E707F0 Offset: 0x1E6EDF0 VA: 0x181E707F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6F940 Offset: 0x1E6DF40 VA: 0x181E6F940
	public void CopyTo(EggHunt instance) { }

	// RVA: 0x1E6FAE0 Offset: 0x1E6E0E0 VA: 0x181E6FAE0
	public EggHunt Copy() { }

	// RVA: 0x1E70650 Offset: 0x1E6EC50 VA: 0x181E70650
	public static EggHunt Deserialize(Stream stream) { }

	// RVA: 0x1E6FCE0 Offset: 0x1E6E2E0 VA: 0x181E6FCE0
	public static EggHunt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E702D0 Offset: 0x1E6E8D0 VA: 0x181E702D0
	public static EggHunt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E706D0 Offset: 0x1E6ECD0 VA: 0x181E706D0
	public static EggHunt Deserialize(byte[] buffer) { }

	// RVA: 0x1E70A30 Offset: 0x1E6F030 VA: 0x181E70A30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E71360 Offset: 0x1E6F960 VA: 0x181E71360 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E71380 Offset: 0x1E6F980 VA: 0x181E71380 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt previous) { }

	// RVA: 0x1E70A50 Offset: 0x1E6F050 VA: 0x181E70A50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E70550 Offset: 0x1E6EB50 VA: 0x181E70550
	public static EggHunt Deserialize(byte[] buffer, EggHunt instance, bool isDelta = False) { }

	// RVA: 0x1E70360 Offset: 0x1E6E960 VA: 0x181E70360
	public static EggHunt Deserialize(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E6FD60 Offset: 0x1E6E360 VA: 0x181E6FD60
	public static EggHunt DeserializeLengthDelimited(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E70030 Offset: 0x1E6E630 VA: 0x181E70030
	public static EggHunt DeserializeLength(Stream stream, int length, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E70DD0 Offset: 0x1E6F3D0 VA: 0x181E70DD0
	public static void SerializeDelta(Stream stream, EggHunt instance, EggHunt previous) { }

	// RVA: 0x1E71170 Offset: 0x1E6F770 VA: 0x181E71170
	public static void Serialize(Stream stream, EggHunt instance) { }

	// RVA: 0x1E71350 Offset: 0x1E6F950 VA: 0x181E71350
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E71360 Offset: 0x1E6F960 VA: 0x181E71360
	public void ToProto(Stream stream) { }

	// RVA: 0x1E71060 Offset: 0x1E6F660 VA: 0x181E71060
	public static byte[] SerializeToBytes(EggHunt instance) { }

	// RVA: 0x1E70FB0 Offset: 0x1E6F5B0 VA: 0x181E70FB0
	public static void SerializeLengthDelimited(Stream stream, EggHunt instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1E725F0 Offset: 0x1E70BF0 VA: 0x181E725F0
	public static void ResetToPool(EggHunt.EggHunter instance) { }

	// RVA: 0x1E726A0 Offset: 0x1E70CA0 VA: 0x181E726A0
	public void ResetToPool() { }

	// RVA: 0x1E72390 Offset: 0x1E70990 VA: 0x181E72390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E713A0 Offset: 0x1E6F9A0 VA: 0x181E713A0
	public void CopyTo(EggHunt.EggHunter instance) { }

	// RVA: 0x1E713F0 Offset: 0x1E6F9F0 VA: 0x181E713F0
	public EggHunt.EggHunter Copy() { }

	// RVA: 0x1E71EE0 Offset: 0x1E704E0 VA: 0x181E71EE0
	public static EggHunt.EggHunter Deserialize(Stream stream) { }

	// RVA: 0x1E71480 Offset: 0x1E6FA80 VA: 0x181E71480
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E71A00 Offset: 0x1E70000 VA: 0x181E71A00
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E720E0 Offset: 0x1E706E0 VA: 0x181E720E0
	public static EggHunt.EggHunter Deserialize(byte[] buffer) { }

	// RVA: 0x1E72410 Offset: 0x1E70A10 VA: 0x181E72410
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E72C70 Offset: 0x1E71270 VA: 0x181E72C70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E72C90 Offset: 0x1E71290 VA: 0x181E72C90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt.EggHunter previous) { }

	// RVA: 0x1E725D0 Offset: 0x1E70BD0 VA: 0x181E725D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E71A90 Offset: 0x1E70090 VA: 0x181E71A90
	public static EggHunt.EggHunter Deserialize(byte[] buffer, EggHunt.EggHunter instance, bool isDelta = False) { }

	// RVA: 0x1E71D20 Offset: 0x1E70320 VA: 0x181E71D20
	public static EggHunt.EggHunter Deserialize(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E71500 Offset: 0x1E6FB00 VA: 0x181E71500
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E71790 Offset: 0x1E6FD90 VA: 0x181E71790
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E72750 Offset: 0x1E70D50 VA: 0x181E72750
	public static void SerializeDelta(Stream stream, EggHunt.EggHunter instance, EggHunt.EggHunter previous) { }

	// RVA: 0x1E72AF0 Offset: 0x1E710F0 VA: 0x181E72AF0
	public static void Serialize(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x1E72C60 Offset: 0x1E71260 VA: 0x181E72C60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E72C70 Offset: 0x1E71270 VA: 0x181E72C70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E729E0 Offset: 0x1E70FE0 VA: 0x181E729E0
	public static byte[] SerializeToBytes(EggHunt.EggHunter instance) { }

	// RVA: 0x1E72930 Offset: 0x1E70F30 VA: 0x181E72930
	public static void SerializeLengthDelimited(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class EggAmmoRepresentation : MonoBehaviour, IInventoryChanged, IClientComponent // TypeDefIndex: 8779
{	// Fields
	public GameObject[] eggAmmo; // 0x18

	// Methods

	// RVA: 0xABF270 Offset: 0xABD870 VA: 0x180ABF270
	public void OnEnable() { }

	// RVA: 0xABF1F0 Offset: 0xABD7F0 VA: 0x180ABF1F0
	public void OnDisable() { }

	// RVA: 0xABF2F0 Offset: 0xABD8F0 VA: 0x180ABF2F0 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class EggSwap : MonoBehaviour // TypeDefIndex: 8780
{	// Fields
	public Renderer[] eggRenderers; // 0x18

	// Methods

	// RVA: 0xAC0080 Offset: 0xABE680 VA: 0x180AC0080
	public void Show(int index) { }

	// RVA: 0xAC0020 Offset: 0xABE620 VA: 0x180AC0020
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

	// RVA: 0xABF790 Offset: 0xABDD90 VA: 0x180ABF790
	public bool IsEventActive() { }

	// RVA: 0xABF840 Offset: 0xABDE40 VA: 0x180ABF840 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xABF4F0 Offset: 0xABDAF0 VA: 0x180ABF4F0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xABF580 Offset: 0xABDB80 VA: 0x180ABF580 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xABFAF0 Offset: 0xABE0F0 VA: 0x180ABFAF0
	public void Update() { }

	// RVA: 0xABF630 Offset: 0xABDC30 VA: 0x180ABF630
	public float GetTimeRemaining() { }

	// RVA: 0xABFA30 Offset: 0xABE030 VA: 0x180ABFA30
	public static bool ShowNotification() { }

	// RVA: 0xABF6A0 Offset: 0xABDCA0 VA: 0x180ABF6A0
	public static float GetWarmupSecondsLeft() { }

	// RVA: 0xABFBB0 Offset: 0xABE1B0 VA: 0x180ABFBB0
	public void .ctor() { }

	// RVA: 0xABFB30 Offset: 0xABE130 VA: 0x180ABFB30
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

	// RVA: 0xABFC70 Offset: 0xABE270 VA: 0x180ABFC70
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

