public class CodeLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6306
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public CodeLock.Private pv; // 0x18
	public bool hasCode; // 0x20
	public bool hasGuestCode; // 0x21

	// Methods

	// RVA: 0x20AF200 Offset: 0x20AD800 VA: 0x1820AF200
	public static void ResetToPool(CodeLock instance) { }

	// RVA: 0x20AF2C0 Offset: 0x20AD8C0 VA: 0x1820AF2C0
	public void ResetToPool() { }

	// RVA: 0x20AF080 Offset: 0x20AD680 VA: 0x1820AF080 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20AE2A0 Offset: 0x20AC8A0 VA: 0x1820AE2A0
	public void CopyTo(CodeLock instance) { }

	// RVA: 0x20AE390 Offset: 0x20AC990 VA: 0x1820AE390
	public CodeLock Copy() { }

	// RVA: 0x20AF000 Offset: 0x20AD600 VA: 0x1820AF000
	public static CodeLock Deserialize(Stream stream) { }

	// RVA: 0x20AE4D0 Offset: 0x20ACAD0 VA: 0x1820AE4D0
	public static CodeLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AEB20 Offset: 0x20AD120 VA: 0x1820AEB20
	public static CodeLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AEEE0 Offset: 0x20AD4E0 VA: 0x1820AEEE0
	public static CodeLock Deserialize(byte[] buffer) { }

	// RVA: 0x20AF1C0 Offset: 0x20AD7C0 VA: 0x1820AF1C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AF980 Offset: 0x20ADF80 VA: 0x1820AF980 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AF9A0 Offset: 0x20ADFA0 VA: 0x1820AF9A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock previous) { }

	// RVA: 0x20AF1E0 Offset: 0x20AD7E0 VA: 0x1820AF1E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AEDE0 Offset: 0x20AD3E0 VA: 0x1820AEDE0
	public static CodeLock Deserialize(byte[] buffer, CodeLock instance, bool isDelta = False) { }

	// RVA: 0x20AEBB0 Offset: 0x20AD1B0 VA: 0x1820AEBB0
	public static CodeLock Deserialize(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AE550 Offset: 0x20ACB50 VA: 0x1820AE550
	public static CodeLock DeserializeLengthDelimited(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AE850 Offset: 0x20ACE50 VA: 0x1820AE850
	public static CodeLock DeserializeLength(Stream stream, int length, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AF380 Offset: 0x20AD980 VA: 0x1820AF380
	public static void SerializeDelta(Stream stream, CodeLock instance, CodeLock previous) { }

	// RVA: 0x20AF760 Offset: 0x20ADD60 VA: 0x1820AF760
	public static void Serialize(Stream stream, CodeLock instance) { }

	// RVA: 0x20AF970 Offset: 0x20ADF70 VA: 0x1820AF970
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AF980 Offset: 0x20ADF80 VA: 0x1820AF980
	public void ToProto(Stream stream) { }

	// RVA: 0x20AF650 Offset: 0x20ADC50 VA: 0x1820AF650
	public static byte[] SerializeToBytes(CodeLock instance) { }

	// RVA: 0x20AF5A0 Offset: 0x20ADBA0 VA: 0x1820AF5A0
	public static void SerializeLengthDelimited(Stream stream, CodeLock instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CodeLock.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6307
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string code; // 0x18
	public List<ulong> users; // 0x20
	public string guestCode; // 0x28
	public List<ulong> guestUsers; // 0x30

	// Methods

	// RVA: 0x20BE400 Offset: 0x20BCA00 VA: 0x1820BE400
	public static void ResetToPool(CodeLock.Private instance) { }

	// RVA: 0x20BE260 Offset: 0x20BC860 VA: 0x1820BE260
	public void ResetToPool() { }

	// RVA: 0x20BE1A0 Offset: 0x20BC7A0 VA: 0x1820BE1A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20BCCA0 Offset: 0x20BB2A0 VA: 0x1820BCCA0
	public void CopyTo(CodeLock.Private instance) { }

	// RVA: 0x20BCEC0 Offset: 0x20BB4C0 VA: 0x1820BCEC0
	public CodeLock.Private Copy() { }

	// RVA: 0x20BD860 Offset: 0x20BBE60 VA: 0x1820BD860
	public static CodeLock.Private Deserialize(Stream stream) { }

	// RVA: 0x20BD2D0 Offset: 0x20BB8D0 VA: 0x1820BD2D0
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BD350 Offset: 0x20BB950 VA: 0x1820BD350
	public static CodeLock.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BDDF0 Offset: 0x20BC3F0 VA: 0x1820BDDF0
	public static CodeLock.Private Deserialize(byte[] buffer) { }

	// RVA: 0x20BE220 Offset: 0x20BC820 VA: 0x1820BE220
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BECE0 Offset: 0x20BD2E0 VA: 0x1820BECE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BED00 Offset: 0x20BD300 VA: 0x1820BED00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock.Private previous) { }

	// RVA: 0x20BE240 Offset: 0x20BC840 VA: 0x1820BE240 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BD760 Offset: 0x20BBD60 VA: 0x1820BD760
	public static CodeLock.Private Deserialize(byte[] buffer, CodeLock.Private instance, bool isDelta = False) { }

	// RVA: 0x20BDB40 Offset: 0x20BC140 VA: 0x1820BDB40
	public static CodeLock.Private Deserialize(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BCF40 Offset: 0x20BB540 VA: 0x1820BCF40
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BD3E0 Offset: 0x20BB9E0 VA: 0x1820BD3E0
	public static CodeLock.Private DeserializeLength(Stream stream, int length, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BE5A0 Offset: 0x20BCBA0 VA: 0x1820BE5A0
	public static void SerializeDelta(Stream stream, CodeLock.Private instance, CodeLock.Private previous) { }

	// RVA: 0x20BEA30 Offset: 0x20BD030 VA: 0x1820BEA30
	public static void Serialize(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x20BECD0 Offset: 0x20BD2D0 VA: 0x1820BECD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BECE0 Offset: 0x20BD2E0 VA: 0x1820BECE0
	public void ToProto(Stream stream) { }

	// RVA: 0x20BE920 Offset: 0x20BCF20 VA: 0x1820BE920
	public static byte[] SerializeToBytes(CodeLock.Private instance) { }

	// RVA: 0x20BE870 Offset: 0x20BCE70 VA: 0x1820BE870
	public static void SerializeLengthDelimited(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class CodeLock : BaseLock // TypeDefIndex: 8373
{	// Fields
	private Option __menuOption_Menu_ChangeGuestCode; // 0x1C8
	private Option __menuOption_Menu_ChangeLockCode; // 0x220
	private Option __menuOption_Menu_Lock; // 0x278
	private Option __menuOption_Menu_Unlock; // 0x2D0
	public GameObjectRef keyEnterDialog; // 0x328
	public GameObjectRef effectUnlocked; // 0x330
	public GameObjectRef effectLocked; // 0x338
	public GameObjectRef effectDenied; // 0x340
	public GameObjectRef effectCodeChanged; // 0x348
	public GameObjectRef effectShock; // 0x350
	private bool hasCode; // 0x358
	public const BaseEntity.Flags Flag_CodeEntryBlocked = 524288;
	public static readonly Translate.Phrase blockwarning; // 0x0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x579BE0 Offset: 0x5781E0 VA: 0x180579BE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x57B140 Offset: 0x579740 VA: 0x18057B140 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x57AA20 Offset: 0x579020 VA: 0x18057AA20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x57A590 Offset: 0x578B90 VA: 0x18057A590
	public bool IsCodeEntryBlocked() { }

	// RVA: 0x57A5A0 Offset: 0x578BA0 VA: 0x18057A5A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xD3ED0 Offset: 0xD32D0 VA: 0x1800D3ED0
	[BaseEntity.Menu.Description] // RVA: 0xD3ED0 Offset: 0xD32D0 VA: 0x1800D3ED0
	[BaseEntity.Menu.Icon] // RVA: 0xD3ED0 Offset: 0xD32D0 VA: 0x1800D3ED0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD3ED0 Offset: 0xD32D0 VA: 0x1800D3ED0
	// RVA: 0x57A9E0 Offset: 0x578FE0 VA: 0x18057A9E0
	public void Menu_Unlock(BasePlayer player) { }

	// RVA: 0x57A9A0 Offset: 0x578FA0 VA: 0x18057A9A0
	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5430 Offset: 0xD4830 VA: 0x1800D5430
	[BaseEntity.Menu.Description] // RVA: 0xD5430 Offset: 0xD4830 VA: 0x1800D5430
	[BaseEntity.Menu.Icon] // RVA: 0xD5430 Offset: 0xD4830 VA: 0x1800D5430
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5430 Offset: 0xD4830 VA: 0x1800D5430
	// RVA: 0x57A960 Offset: 0x578F60 VA: 0x18057A960
	public void Menu_Lock(BasePlayer player) { }

	// RVA: 0x57A930 Offset: 0x578F30 VA: 0x18057A930
	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5660 Offset: 0xD4A60 VA: 0x1800D5660
	[BaseEntity.Menu.Description] // RVA: 0xD5660 Offset: 0xD4A60 VA: 0x1800D5660
	[BaseEntity.Menu.Icon] // RVA: 0xD5660 Offset: 0xD4A60 VA: 0x1800D5660
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5660 Offset: 0xD4A60 VA: 0x1800D5660
	// RVA: 0x57A7D0 Offset: 0x578DD0 VA: 0x18057A7D0
	public void Menu_ChangeLockCode(BasePlayer player) { }

	// RVA: 0x57A790 Offset: 0x578D90 VA: 0x18057A790
	public bool Menu_ChangeLockCode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD58A0 Offset: 0xD4CA0 VA: 0x1800D58A0
	[BaseEntity.Menu.Description] // RVA: 0xD58A0 Offset: 0xD4CA0 VA: 0x1800D58A0
	[BaseEntity.Menu.Icon] // RVA: 0xD58A0 Offset: 0xD4CA0 VA: 0x1800D58A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD58A0 Offset: 0xD4CA0 VA: 0x1800D58A0
	// RVA: 0x57A630 Offset: 0x578C30 VA: 0x18057A630
	public void Menu_ChangeGuestCode(BasePlayer player) { }

	// RVA: 0x57A600 Offset: 0x578C00 VA: 0x18057A600
	public bool Menu_ChangeGuestCode_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x579A60 Offset: 0x578060 VA: 0x180579A60
	private void EnterUnlockCode(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x57B130 Offset: 0x579730 VA: 0x18057B130
	public void .ctor() { }

	// RVA: 0x57B0C0 Offset: 0x5796C0 VA: 0x18057B0C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57B060 Offset: 0x579660 VA: 0x18057B060
	private void <Menu_ChangeLockCode>b__23_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57B000 Offset: 0x579600 VA: 0x18057B000
	private void <Menu_ChangeGuestCode>b__25_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57AFB0 Offset: 0x5795B0 VA: 0x18057AFB0
	private void <EnterUnlockCode>b__27_0(string str) { }

}

