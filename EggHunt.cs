public class EggHunt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6362
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<EggHunt.EggHunter> hunters; // 0x18

	// Methods

	// RVA: 0x1E70970 Offset: 0x1E6EF70 VA: 0x181E70970
	public static void ResetToPool(EggHunt instance) { }

	// RVA: 0x1E70B20 Offset: 0x1E6F120 VA: 0x181E70B20
	public void ResetToPool() { }

	// RVA: 0x1E706F0 Offset: 0x1E6ECF0 VA: 0x181E706F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6F840 Offset: 0x1E6DE40 VA: 0x181E6F840
	public void CopyTo(EggHunt instance) { }

	// RVA: 0x1E6F9E0 Offset: 0x1E6DFE0 VA: 0x181E6F9E0
	public EggHunt Copy() { }

	// RVA: 0x1E70550 Offset: 0x1E6EB50 VA: 0x181E70550
	public static EggHunt Deserialize(Stream stream) { }

	// RVA: 0x1E6FBE0 Offset: 0x1E6E1E0 VA: 0x181E6FBE0
	public static EggHunt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E701D0 Offset: 0x1E6E7D0 VA: 0x181E701D0
	public static EggHunt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E705D0 Offset: 0x1E6EBD0 VA: 0x181E705D0
	public static EggHunt Deserialize(byte[] buffer) { }

	// RVA: 0x1E70930 Offset: 0x1E6EF30 VA: 0x181E70930
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E71260 Offset: 0x1E6F860 VA: 0x181E71260 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E71280 Offset: 0x1E6F880 VA: 0x181E71280 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt previous) { }

	// RVA: 0x1E70950 Offset: 0x1E6EF50 VA: 0x181E70950 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E70450 Offset: 0x1E6EA50 VA: 0x181E70450
	public static EggHunt Deserialize(byte[] buffer, EggHunt instance, bool isDelta = False) { }

	// RVA: 0x1E70260 Offset: 0x1E6E860 VA: 0x181E70260
	public static EggHunt Deserialize(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E6FC60 Offset: 0x1E6E260 VA: 0x181E6FC60
	public static EggHunt DeserializeLengthDelimited(Stream stream, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E6FF30 Offset: 0x1E6E530 VA: 0x181E6FF30
	public static EggHunt DeserializeLength(Stream stream, int length, EggHunt instance, bool isDelta) { }

	// RVA: 0x1E70CD0 Offset: 0x1E6F2D0 VA: 0x181E70CD0
	public static void SerializeDelta(Stream stream, EggHunt instance, EggHunt previous) { }

	// RVA: 0x1E71070 Offset: 0x1E6F670 VA: 0x181E71070
	public static void Serialize(Stream stream, EggHunt instance) { }

	// RVA: 0x1E71250 Offset: 0x1E6F850 VA: 0x181E71250
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E71260 Offset: 0x1E6F860 VA: 0x181E71260
	public void ToProto(Stream stream) { }

	// RVA: 0x1E70F60 Offset: 0x1E6F560 VA: 0x181E70F60
	public static byte[] SerializeToBytes(EggHunt instance) { }

	// RVA: 0x1E70EB0 Offset: 0x1E6F4B0 VA: 0x181E70EB0
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

	// RVA: 0x1E724F0 Offset: 0x1E70AF0 VA: 0x181E724F0
	public static void ResetToPool(EggHunt.EggHunter instance) { }

	// RVA: 0x1E725A0 Offset: 0x1E70BA0 VA: 0x181E725A0
	public void ResetToPool() { }

	// RVA: 0x1E72290 Offset: 0x1E70890 VA: 0x181E72290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E712A0 Offset: 0x1E6F8A0 VA: 0x181E712A0
	public void CopyTo(EggHunt.EggHunter instance) { }

	// RVA: 0x1E712F0 Offset: 0x1E6F8F0 VA: 0x181E712F0
	public EggHunt.EggHunter Copy() { }

	// RVA: 0x1E71DE0 Offset: 0x1E703E0 VA: 0x181E71DE0
	public static EggHunt.EggHunter Deserialize(Stream stream) { }

	// RVA: 0x1E71380 Offset: 0x1E6F980 VA: 0x181E71380
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E71900 Offset: 0x1E6FF00 VA: 0x181E71900
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E71FE0 Offset: 0x1E705E0 VA: 0x181E71FE0
	public static EggHunt.EggHunter Deserialize(byte[] buffer) { }

	// RVA: 0x1E72310 Offset: 0x1E70910 VA: 0x181E72310
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E72B70 Offset: 0x1E71170 VA: 0x181E72B70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E72B90 Offset: 0x1E71190 VA: 0x181E72B90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EggHunt.EggHunter previous) { }

	// RVA: 0x1E724D0 Offset: 0x1E70AD0 VA: 0x181E724D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E71990 Offset: 0x1E6FF90 VA: 0x181E71990
	public static EggHunt.EggHunter Deserialize(byte[] buffer, EggHunt.EggHunter instance, bool isDelta = False) { }

	// RVA: 0x1E71C20 Offset: 0x1E70220 VA: 0x181E71C20
	public static EggHunt.EggHunter Deserialize(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E71400 Offset: 0x1E6FA00 VA: 0x181E71400
	public static EggHunt.EggHunter DeserializeLengthDelimited(Stream stream, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E71690 Offset: 0x1E6FC90 VA: 0x181E71690
	public static EggHunt.EggHunter DeserializeLength(Stream stream, int length, EggHunt.EggHunter instance, bool isDelta) { }

	// RVA: 0x1E72650 Offset: 0x1E70C50 VA: 0x181E72650
	public static void SerializeDelta(Stream stream, EggHunt.EggHunter instance, EggHunt.EggHunter previous) { }

	// RVA: 0x1E729F0 Offset: 0x1E70FF0 VA: 0x181E729F0
	public static void Serialize(Stream stream, EggHunt.EggHunter instance) { }

	// RVA: 0x1E72B60 Offset: 0x1E71160 VA: 0x181E72B60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E72B70 Offset: 0x1E71170 VA: 0x181E72B70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E728E0 Offset: 0x1E70EE0 VA: 0x181E728E0
	public static byte[] SerializeToBytes(EggHunt.EggHunter instance) { }

	// RVA: 0x1E72830 Offset: 0x1E70E30 VA: 0x181E72830
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

