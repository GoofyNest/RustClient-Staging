public class EggHunt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6362
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<EggHunt.EggHunter> hunters; // 0x18

	// Methods

	// RVA: 0x1E707B0 Offset: 0x1E6EDB0 VA: 0x181E707B0
	public static void ResetToPool(EggHunt instance) { }

	// RVA: 0x1E70960 Offset: 0x1E6EF60 VA: 0x181E70960
	public void ResetToPool() { }

	// RVA: 0x1E70530 Offset: 0x1E6EB30 VA: 0x181E70530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6F680 Offset: 0x1E6DC80 VA: 0x181E6F680
	public void CopyTo(EggHunt instance) { }

	// RVA: 0x1E6F820 Offset: 0x1E6DE20 VA: 0x181E6F820
	public EggHunt Copy() { }

	// RVA: 0x1E70390 Offset: 0x1E6E990 VA: 0x181E70390
	public static EggHunt Deserialize(Stream stream) { }

	// RVA: 0x1E6FA20 Offset: 0x1E6E020 VA: 0x181E6FA20
	public static EggHunt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E70010 Offset: 0x1E6E610 VA: 0x181E70010
	public static EggHunt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E70410 Offset: 0x1E6EA10 VA: 0x181E70410
	public static EggHunt Deserialize(byte[] buffer) { }

	// RVA: 0x1E70770 Offset: 0x1E6ED70 VA: 0x181E70770
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E710A0 Offset: 0x1E6F6A0 VA: 0x181E710A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E710C0 Offset: 0x1E6F6C0 VA: 0x181E710C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt previous) { }

	// RVA: 0x1E70790 Offset: 0x1E6ED90 VA: 0x181E70790 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E70290 Offset: 0x1E6E890 VA: 0x181E70290
	public static EggHunt Deserialize(byte[] buffer, EggHunt instance, bool isDelta = False) { }

	// RVA: 0x1E700A0 Offset: 0x1E6E6A0 VA: 0x181E700A0
	public static EggHunt Deserialize(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E6FAA0 Offset: 0x1E6E0A0 VA: 0x181E6FAA0
	public static EggHunt DeserializeLengthDelimited(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E6FD70 Offset: 0x1E6E370 VA: 0x181E6FD70
	public static EggHunt DeserializeLength(Stream stream, int length, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E70B10 Offset: 0x1E6F110 VA: 0x181E70B10
	public static void SerializeDelta(Stream stream, EggHunt instance, EggHunt previous) { }

	// RVA: 0x1E70EB0 Offset: 0x1E6F4B0 VA: 0x181E70EB0
	public static void Serialize(Stream stream, EggHunt instance) { }

	// RVA: 0x1E71090 Offset: 0x1E6F690 VA: 0x181E71090
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E710A0 Offset: 0x1E6F6A0 VA: 0x181E710A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E70DA0 Offset: 0x1E6F3A0 VA: 0x181E70DA0
	public static byte[] SerializeToBytes(EggHunt instance) { }

	// RVA: 0x1E70CF0 Offset: 0x1E6F2F0 VA: 0x181E70CF0
	public static void SerializeLengthDelimited(Stream stream, EggHunt instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E72330 Offset: 0x1E70930 VA: 0x181E72330
	public static void ResetToPool(EggHunt.EggHunter instance) { }

	// RVA: 0x1E723E0 Offset: 0x1E709E0 VA: 0x181E723E0
	public void ResetToPool() { }

	// RVA: 0x1E720D0 Offset: 0x1E706D0 VA: 0x181E720D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E710E0 Offset: 0x1E6F6E0 VA: 0x181E710E0
	public void CopyTo(EggHunt.EggHunter instance) { }

	// RVA: 0x1E71130 Offset: 0x1E6F730 VA: 0x181E71130
	public EggHunt.EggHunter Copy() { }

	// RVA: 0x1E71C20 Offset: 0x1E70220 VA: 0x181E71C20
	public static EggHunt.EggHunter Deserialize(Stream stream) { }

	// RVA: 0x1E711C0 Offset: 0x1E6F7C0 VA: 0x181E711C0
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E71740 Offset: 0x1E6FD40 VA: 0x181E71740
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E71E20 Offset: 0x1E70420 VA: 0x181E71E20
	public static EggHunt.EggHunter Deserialize(byte[] buffer) { }

	// RVA: 0x1E72150 Offset: 0x1E70750 VA: 0x181E72150
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E729B0 Offset: 0x1E70FB0 VA: 0x181E729B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E729D0 Offset: 0x1E70FD0 VA: 0x181E729D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt.EggHunter previous) { }

	// RVA: 0x1E72310 Offset: 0x1E70910 VA: 0x181E72310 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E717D0 Offset: 0x1E6FDD0 VA: 0x181E717D0
	public static EggHunt.EggHunter Deserialize(byte[] buffer, EggHunt.EggHunter instance, bool isDelta = False) { }

	// RVA: 0x1E71A60 Offset: 0x1E70060 VA: 0x181E71A60
	public static EggHunt.EggHunter Deserialize(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E71240 Offset: 0x1E6F840 VA: 0x181E71240
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E714D0 Offset: 0x1E6FAD0 VA: 0x181E714D0
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E72490 Offset: 0x1E70A90 VA: 0x181E72490
	public static void SerializeDelta(Stream stream, EggHunt.EggHunter instance, EggHunt.EggHunter previous) { }

	// RVA: 0x1E72830 Offset: 0x1E70E30 VA: 0x181E72830
	public static void Serialize(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x1E729A0 Offset: 0x1E70FA0 VA: 0x181E729A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E729B0 Offset: 0x1E70FB0 VA: 0x181E729B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E72720 Offset: 0x1E70D20 VA: 0x181E72720
	public static byte[] SerializeToBytes(EggHunt.EggHunter instance) { }

	// RVA: 0x1E72670 Offset: 0x1E70C70 VA: 0x181E72670
	public static void SerializeLengthDelimited(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class EggAmmoRepresentation : MonoBehaviour, IInventoryChanged, IClientComponent // TypeDefIndex: 8779
{	// Fields
	public GameObject[] eggAmmo; // 0x18

	// Methods

	// RVA: 0xABEFB0 Offset: 0xABD5B0 VA: 0x180ABEFB0
	public void OnEnable() { }

	// RVA: 0xABEF30 Offset: 0xABD530 VA: 0x180ABEF30
	public void OnDisable() { }

	// RVA: 0xABF030 Offset: 0xABD630 VA: 0x180ABF030 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class EggSwap : MonoBehaviour // TypeDefIndex: 8780
{	// Fields
	public Renderer[] eggRenderers; // 0x18

	// Methods

	// RVA: 0xABFDC0 Offset: 0xABE3C0 VA: 0x180ABFDC0
	public void Show(int index) { }

	// RVA: 0xABFD60 Offset: 0xABE360 VA: 0x180ABFD60
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

	// RVA: 0xABF4D0 Offset: 0xABDAD0 VA: 0x180ABF4D0
	public bool IsEventActive() { }

	// RVA: 0xABF580 Offset: 0xABDB80 VA: 0x180ABF580 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xABF230 Offset: 0xABD830 VA: 0x180ABF230 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xABF2C0 Offset: 0xABD8C0 VA: 0x180ABF2C0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xABF830 Offset: 0xABDE30 VA: 0x180ABF830
	public void Update() { }

	// RVA: 0xABF370 Offset: 0xABD970 VA: 0x180ABF370
	public float GetTimeRemaining() { }

	// RVA: 0xABF770 Offset: 0xABDD70 VA: 0x180ABF770
	public static bool ShowNotification() { }

	// RVA: 0xABF3E0 Offset: 0xABD9E0 VA: 0x180ABF3E0
	public static float GetWarmupSecondsLeft() { }

	// RVA: 0xABF8F0 Offset: 0xABDEF0 VA: 0x180ABF8F0
	public void .ctor() { }

	// RVA: 0xABF870 Offset: 0xABDE70 VA: 0x180ABF870
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

	// RVA: 0xABF9B0 Offset: 0xABDFB0 VA: 0x180ABF9B0
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

