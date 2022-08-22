public class CodeLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6306
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public CodeLock.Private pv; // 0x18
	public bool hasCode; // 0x20
	public bool hasGuestCode; // 0x21

	// Methods

	// RVA: 0x20AFA20 Offset: 0x20AE020 VA: 0x1820AFA20
	public static void ResetToPool(CodeLock instance) { }

	// RVA: 0x20AFAE0 Offset: 0x20AE0E0 VA: 0x1820AFAE0
	public void ResetToPool() { }

	// RVA: 0x20AF8A0 Offset: 0x20ADEA0 VA: 0x1820AF8A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20AEAC0 Offset: 0x20AD0C0 VA: 0x1820AEAC0
	public void CopyTo(CodeLock instance) { }

	// RVA: 0x20AEBB0 Offset: 0x20AD1B0 VA: 0x1820AEBB0
	public CodeLock Copy() { }

	// RVA: 0x20AF820 Offset: 0x20ADE20 VA: 0x1820AF820
	public static CodeLock Deserialize(Stream stream) { }

	// RVA: 0x20AECF0 Offset: 0x20AD2F0 VA: 0x1820AECF0
	public static CodeLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AF340 Offset: 0x20AD940 VA: 0x1820AF340
	public static CodeLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AF700 Offset: 0x20ADD00 VA: 0x1820AF700
	public static CodeLock Deserialize(byte[] buffer) { }

	// RVA: 0x20AF9E0 Offset: 0x20ADFE0 VA: 0x1820AF9E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B01A0 Offset: 0x20AE7A0 VA: 0x1820B01A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B01C0 Offset: 0x20AE7C0 VA: 0x1820B01C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock previous) { }

	// RVA: 0x20AFA00 Offset: 0x20AE000 VA: 0x1820AFA00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AF600 Offset: 0x20ADC00 VA: 0x1820AF600
	public static CodeLock Deserialize(byte[] buffer, CodeLock instance, bool isDelta = False) { }

	// RVA: 0x20AF3D0 Offset: 0x20AD9D0 VA: 0x1820AF3D0
	public static CodeLock Deserialize(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AED70 Offset: 0x20AD370 VA: 0x1820AED70
	public static CodeLock DeserializeLengthDelimited(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AF070 Offset: 0x20AD670 VA: 0x1820AF070
	public static CodeLock DeserializeLength(Stream stream, int length, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AFBA0 Offset: 0x20AE1A0 VA: 0x1820AFBA0
	public static void SerializeDelta(Stream stream, CodeLock instance, CodeLock previous) { }

	// RVA: 0x20AFF80 Offset: 0x20AE580 VA: 0x1820AFF80
	public static void Serialize(Stream stream, CodeLock instance) { }

	// RVA: 0x20B0190 Offset: 0x20AE790 VA: 0x1820B0190
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B01A0 Offset: 0x20AE7A0 VA: 0x1820B01A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20AFE70 Offset: 0x20AE470 VA: 0x1820AFE70
	public static byte[] SerializeToBytes(CodeLock instance) { }

	// RVA: 0x20AFDC0 Offset: 0x20AE3C0 VA: 0x1820AFDC0
	public static void SerializeLengthDelimited(Stream stream, CodeLock instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x20BEC20 Offset: 0x20BD220 VA: 0x1820BEC20
	public static void ResetToPool(CodeLock.Private instance) { }

	// RVA: 0x20BEA80 Offset: 0x20BD080 VA: 0x1820BEA80
	public void ResetToPool() { }

	// RVA: 0x20BE9C0 Offset: 0x20BCFC0 VA: 0x1820BE9C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20BD4C0 Offset: 0x20BBAC0 VA: 0x1820BD4C0
	public void CopyTo(CodeLock.Private instance) { }

	// RVA: 0x20BD6E0 Offset: 0x20BBCE0 VA: 0x1820BD6E0
	public CodeLock.Private Copy() { }

	// RVA: 0x20BE080 Offset: 0x20BC680 VA: 0x1820BE080
	public static CodeLock.Private Deserialize(Stream stream) { }

	// RVA: 0x20BDAF0 Offset: 0x20BC0F0 VA: 0x1820BDAF0
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BDB70 Offset: 0x20BC170 VA: 0x1820BDB70
	public static CodeLock.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BE610 Offset: 0x20BCC10 VA: 0x1820BE610
	public static CodeLock.Private Deserialize(byte[] buffer) { }

	// RVA: 0x20BEA40 Offset: 0x20BD040 VA: 0x1820BEA40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BF500 Offset: 0x20BDB00 VA: 0x1820BF500 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BF520 Offset: 0x20BDB20 VA: 0x1820BF520 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock.Private previous) { }

	// RVA: 0x20BEA60 Offset: 0x20BD060 VA: 0x1820BEA60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BDF80 Offset: 0x20BC580 VA: 0x1820BDF80
	public static CodeLock.Private Deserialize(byte[] buffer, CodeLock.Private instance, bool isDelta = False) { }

	// RVA: 0x20BE360 Offset: 0x20BC960 VA: 0x1820BE360
	public static CodeLock.Private Deserialize(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BD760 Offset: 0x20BBD60 VA: 0x1820BD760
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BDC00 Offset: 0x20BC200 VA: 0x1820BDC00
	public static CodeLock.Private DeserializeLength(Stream stream, int length, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BEDC0 Offset: 0x20BD3C0 VA: 0x1820BEDC0
	public static void SerializeDelta(Stream stream, CodeLock.Private instance, CodeLock.Private previous) { }

	// RVA: 0x20BF250 Offset: 0x20BD850 VA: 0x1820BF250
	public static void Serialize(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x20BF4F0 Offset: 0x20BDAF0 VA: 0x1820BF4F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BF500 Offset: 0x20BDB00 VA: 0x1820BF500
	public void ToProto(Stream stream) { }

	// RVA: 0x20BF140 Offset: 0x20BD740 VA: 0x1820BF140
	public static byte[] SerializeToBytes(CodeLock.Private instance) { }

	// RVA: 0x20BF090 Offset: 0x20BD690 VA: 0x1820BF090
	public static void SerializeLengthDelimited(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x579B70 Offset: 0x578170 VA: 0x180579B70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x57B0D0 Offset: 0x5796D0 VA: 0x18057B0D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x57A9B0 Offset: 0x578FB0 VA: 0x18057A9B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x57A520 Offset: 0x578B20 VA: 0x18057A520
	public bool IsCodeEntryBlocked() { }

	// RVA: 0x57A530 Offset: 0x578B30 VA: 0x18057A530 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xD3ED0 Offset: 0xD32D0 VA: 0x1800D3ED0
	[BaseEntity.Menu.Description] // RVA: 0xD3ED0 Offset: 0xD32D0 VA: 0x1800D3ED0
	[BaseEntity.Menu.Icon] // RVA: 0xD3ED0 Offset: 0xD32D0 VA: 0x1800D3ED0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD3ED0 Offset: 0xD32D0 VA: 0x1800D3ED0
	// RVA: 0x57A970 Offset: 0x578F70 VA: 0x18057A970
	public void Menu_Unlock(BasePlayer player) { }

	// RVA: 0x57A930 Offset: 0x578F30 VA: 0x18057A930
	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5430 Offset: 0xD4830 VA: 0x1800D5430
	[BaseEntity.Menu.Description] // RVA: 0xD5430 Offset: 0xD4830 VA: 0x1800D5430
	[BaseEntity.Menu.Icon] // RVA: 0xD5430 Offset: 0xD4830 VA: 0x1800D5430
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5430 Offset: 0xD4830 VA: 0x1800D5430
	// RVA: 0x57A8F0 Offset: 0x578EF0 VA: 0x18057A8F0
	public void Menu_Lock(BasePlayer player) { }

	// RVA: 0x57A8C0 Offset: 0x578EC0 VA: 0x18057A8C0
	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5660 Offset: 0xD4A60 VA: 0x1800D5660
	[BaseEntity.Menu.Description] // RVA: 0xD5660 Offset: 0xD4A60 VA: 0x1800D5660
	[BaseEntity.Menu.Icon] // RVA: 0xD5660 Offset: 0xD4A60 VA: 0x1800D5660
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5660 Offset: 0xD4A60 VA: 0x1800D5660
	// RVA: 0x57A760 Offset: 0x578D60 VA: 0x18057A760
	public void Menu_ChangeLockCode(BasePlayer player) { }

	// RVA: 0x57A720 Offset: 0x578D20 VA: 0x18057A720
	public bool Menu_ChangeLockCode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD58A0 Offset: 0xD4CA0 VA: 0x1800D58A0
	[BaseEntity.Menu.Description] // RVA: 0xD58A0 Offset: 0xD4CA0 VA: 0x1800D58A0
	[BaseEntity.Menu.Icon] // RVA: 0xD58A0 Offset: 0xD4CA0 VA: 0x1800D58A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD58A0 Offset: 0xD4CA0 VA: 0x1800D58A0
	// RVA: 0x57A5C0 Offset: 0x578BC0 VA: 0x18057A5C0
	public void Menu_ChangeGuestCode(BasePlayer player) { }

	// RVA: 0x57A590 Offset: 0x578B90 VA: 0x18057A590
	public bool Menu_ChangeGuestCode_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5799F0 Offset: 0x577FF0 VA: 0x1805799F0
	private void EnterUnlockCode(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x57B0C0 Offset: 0x5796C0 VA: 0x18057B0C0
	public void .ctor() { }

	// RVA: 0x57B050 Offset: 0x579650 VA: 0x18057B050
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57AFF0 Offset: 0x5795F0 VA: 0x18057AFF0
	private void <Menu_ChangeLockCode>b__23_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57AF90 Offset: 0x579590 VA: 0x18057AF90
	private void <Menu_ChangeGuestCode>b__25_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57AF40 Offset: 0x579540 VA: 0x18057AF40
	private void <EnterUnlockCode>b__27_0(string str) { }

}

