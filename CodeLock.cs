public class CodeLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6306
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public CodeLock.Private pv; // 0x18
	public bool hasCode; // 0x20
	public bool hasGuestCode; // 0x21

	// Methods

	// RVA: 0x20AEF40 Offset: 0x20AD540 VA: 0x1820AEF40
	public static void ResetToPool(CodeLock instance) { }

	// RVA: 0x20AF000 Offset: 0x20AD600 VA: 0x1820AF000
	public void ResetToPool() { }

	// RVA: 0x20AEDC0 Offset: 0x20AD3C0 VA: 0x1820AEDC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20ADFE0 Offset: 0x20AC5E0 VA: 0x1820ADFE0
	public void CopyTo(CodeLock instance) { }

	// RVA: 0x20AE0D0 Offset: 0x20AC6D0 VA: 0x1820AE0D0
	public CodeLock Copy() { }

	// RVA: 0x20AED40 Offset: 0x20AD340 VA: 0x1820AED40
	public static CodeLock Deserialize(Stream stream) { }

	// RVA: 0x20AE210 Offset: 0x20AC810 VA: 0x1820AE210
	public static CodeLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AE860 Offset: 0x20ACE60 VA: 0x1820AE860
	public static CodeLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AEC20 Offset: 0x20AD220 VA: 0x1820AEC20
	public static CodeLock Deserialize(byte[] buffer) { }

	// RVA: 0x20AEF00 Offset: 0x20AD500 VA: 0x1820AEF00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AF6C0 Offset: 0x20ADCC0 VA: 0x1820AF6C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AF6E0 Offset: 0x20ADCE0 VA: 0x1820AF6E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock previous) { }

	// RVA: 0x20AEF20 Offset: 0x20AD520 VA: 0x1820AEF20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AEB20 Offset: 0x20AD120 VA: 0x1820AEB20
	public static CodeLock Deserialize(byte[] buffer, CodeLock instance, bool isDelta = False) { }

	// RVA: 0x20AE8F0 Offset: 0x20ACEF0 VA: 0x1820AE8F0
	public static CodeLock Deserialize(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AE290 Offset: 0x20AC890 VA: 0x1820AE290
	public static CodeLock DeserializeLengthDelimited(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AE590 Offset: 0x20ACB90 VA: 0x1820AE590
	public static CodeLock DeserializeLength(Stream stream, int length, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AF0C0 Offset: 0x20AD6C0 VA: 0x1820AF0C0
	public static void SerializeDelta(Stream stream, CodeLock instance, CodeLock previous) { }

	// RVA: 0x20AF4A0 Offset: 0x20ADAA0 VA: 0x1820AF4A0
	public static void Serialize(Stream stream, CodeLock instance) { }

	// RVA: 0x20AF6B0 Offset: 0x20ADCB0 VA: 0x1820AF6B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AF6C0 Offset: 0x20ADCC0 VA: 0x1820AF6C0
	public void ToProto(Stream stream) { }

	// RVA: 0x20AF390 Offset: 0x20AD990 VA: 0x1820AF390
	public static byte[] SerializeToBytes(CodeLock instance) { }

	// RVA: 0x20AF2E0 Offset: 0x20AD8E0 VA: 0x1820AF2E0
	public static void SerializeLengthDelimited(Stream stream, CodeLock instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x20BE140 Offset: 0x20BC740 VA: 0x1820BE140
	public static void ResetToPool(CodeLock.Private instance) { }

	// RVA: 0x20BDFA0 Offset: 0x20BC5A0 VA: 0x1820BDFA0
	public void ResetToPool() { }

	// RVA: 0x20BDEE0 Offset: 0x20BC4E0 VA: 0x1820BDEE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20BC9E0 Offset: 0x20BAFE0 VA: 0x1820BC9E0
	public void CopyTo(CodeLock.Private instance) { }

	// RVA: 0x20BCC00 Offset: 0x20BB200 VA: 0x1820BCC00
	public CodeLock.Private Copy() { }

	// RVA: 0x20BD5A0 Offset: 0x20BBBA0 VA: 0x1820BD5A0
	public static CodeLock.Private Deserialize(Stream stream) { }

	// RVA: 0x20BD010 Offset: 0x20BB610 VA: 0x1820BD010
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BD090 Offset: 0x20BB690 VA: 0x1820BD090
	public static CodeLock.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BDB30 Offset: 0x20BC130 VA: 0x1820BDB30
	public static CodeLock.Private Deserialize(byte[] buffer) { }

	// RVA: 0x20BDF60 Offset: 0x20BC560 VA: 0x1820BDF60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BEA20 Offset: 0x20BD020 VA: 0x1820BEA20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BEA40 Offset: 0x20BD040 VA: 0x1820BEA40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock.Private previous) { }

	// RVA: 0x20BDF80 Offset: 0x20BC580 VA: 0x1820BDF80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BD4A0 Offset: 0x20BBAA0 VA: 0x1820BD4A0
	public static CodeLock.Private Deserialize(byte[] buffer, CodeLock.Private instance, bool isDelta = False) { }

	// RVA: 0x20BD880 Offset: 0x20BBE80 VA: 0x1820BD880
	public static CodeLock.Private Deserialize(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BCC80 Offset: 0x20BB280 VA: 0x1820BCC80
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BD120 Offset: 0x20BB720 VA: 0x1820BD120
	public static CodeLock.Private DeserializeLength(Stream stream, int length, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BE2E0 Offset: 0x20BC8E0 VA: 0x1820BE2E0
	public static void SerializeDelta(Stream stream, CodeLock.Private instance, CodeLock.Private previous) { }

	// RVA: 0x20BE770 Offset: 0x20BCD70 VA: 0x1820BE770
	public static void Serialize(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x20BEA10 Offset: 0x20BD010 VA: 0x1820BEA10
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BEA20 Offset: 0x20BD020 VA: 0x1820BEA20
	public void ToProto(Stream stream) { }

	// RVA: 0x20BE660 Offset: 0x20BCC60 VA: 0x1820BE660
	public static byte[] SerializeToBytes(CodeLock.Private instance) { }

	// RVA: 0x20BE5B0 Offset: 0x20BCBB0 VA: 0x1820BE5B0
	public static void SerializeLengthDelimited(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

