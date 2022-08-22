public class PatternFirework : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6424
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PatternFirework.Design design; // 0x18
	public int shellFuseLength; // 0x20

	// Methods

	// RVA: 0x1F98CE0 Offset: 0x1F972E0 VA: 0x181F98CE0
	public static void ResetToPool(PatternFirework instance) { }

	// RVA: 0x1F98D90 Offset: 0x1F97390 VA: 0x181F98D90
	public void ResetToPool() { }

	// RVA: 0x1F98B70 Offset: 0x1F97170 VA: 0x181F98B70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F97F10 Offset: 0x1F96510 VA: 0x181F97F10
	public void CopyTo(PatternFirework instance) { }

	// RVA: 0x1F97FA0 Offset: 0x1F965A0 VA: 0x181F97FA0
	public PatternFirework Copy() { }

	// RVA: 0x1F98AF0 Offset: 0x1F970F0 VA: 0x181F98AF0
	public static PatternFirework Deserialize(Stream stream) { }

	// RVA: 0x1F98070 Offset: 0x1F96670 VA: 0x181F98070
	public static PatternFirework DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F98640 Offset: 0x1F96C40 VA: 0x181F98640
	public static PatternFirework DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F986D0 Offset: 0x1F96CD0 VA: 0x181F986D0
	public static PatternFirework Deserialize(byte[] buffer) { }

	// RVA: 0x1F98CA0 Offset: 0x1F972A0 VA: 0x181F98CA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F99400 Offset: 0x1F97A00 VA: 0x181F99400 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F99420 Offset: 0x1F97A20 VA: 0x181F99420 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework previous) { }

	// RVA: 0x1F98CC0 Offset: 0x1F972C0 VA: 0x181F98CC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F989F0 Offset: 0x1F96FF0 VA: 0x181F989F0
	public static PatternFirework Deserialize(byte[] buffer, PatternFirework instance, bool isDelta = False) { }

	// RVA: 0x1F987F0 Offset: 0x1F96DF0 VA: 0x181F987F0
	public static PatternFirework Deserialize(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F980F0 Offset: 0x1F966F0 VA: 0x181F980F0
	public static PatternFirework DeserializeLengthDelimited(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F983B0 Offset: 0x1F969B0 VA: 0x181F983B0
	public static PatternFirework DeserializeLength(Stream stream, int length, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F98E40 Offset: 0x1F97440 VA: 0x181F98E40
	public static void SerializeDelta(Stream stream, PatternFirework instance, PatternFirework previous) { }

	// RVA: 0x1F99210 Offset: 0x1F97810 VA: 0x181F99210
	public static void Serialize(Stream stream, PatternFirework instance) { }

	// RVA: 0x1F993F0 Offset: 0x1F979F0 VA: 0x181F993F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F99400 Offset: 0x1F97A00 VA: 0x181F99400
	public void ToProto(Stream stream) { }

	// RVA: 0x1F99100 Offset: 0x1F97700 VA: 0x181F99100
	public static byte[] SerializeToBytes(PatternFirework instance) { }

	// RVA: 0x1F99050 Offset: 0x1F97650 VA: 0x181F99050
	public static void SerializeLengthDelimited(Stream stream, PatternFirework instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PatternFirework.Design : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6425
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PatternFirework.Star> stars; // 0x18
	public ulong editedBy; // 0x20

	// Methods

	// RVA: 0x1F82240 Offset: 0x1F80840 VA: 0x181F82240
	public static void ResetToPool(PatternFirework.Design instance) { }

	// RVA: 0x1F82060 Offset: 0x1F80660 VA: 0x181F82060
	public void ResetToPool() { }

	// RVA: 0x1F81FA0 Offset: 0x1F805A0 VA: 0x181F81FA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F811A0 Offset: 0x1F7F7A0 VA: 0x181F811A0
	public void CopyTo(PatternFirework.Design instance) { }

	// RVA: 0x1F81350 Offset: 0x1F7F950 VA: 0x181F81350
	public PatternFirework.Design Copy() { }

	// RVA: 0x1F81BF0 Offset: 0x1F801F0 VA: 0x181F81BF0
	public static PatternFirework.Design Deserialize(Stream stream) { }

	// RVA: 0x1F816E0 Offset: 0x1F7FCE0 VA: 0x181F816E0
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F81A40 Offset: 0x1F80040 VA: 0x181F81A40
	public static PatternFirework.Design DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F81AD0 Offset: 0x1F800D0 VA: 0x181F81AD0
	public static PatternFirework.Design Deserialize(byte[] buffer) { }

	// RVA: 0x1F82020 Offset: 0x1F80620 VA: 0x181F82020
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F82A70 Offset: 0x1F81070 VA: 0x181F82A70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F82A90 Offset: 0x1F81090 VA: 0x181F82A90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Design previous) { }

	// RVA: 0x1F82040 Offset: 0x1F80640 VA: 0x181F82040 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F81EA0 Offset: 0x1F804A0 VA: 0x181F81EA0
	public static PatternFirework.Design Deserialize(byte[] buffer, PatternFirework.Design instance, bool isDelta = False) { }

	// RVA: 0x1F81C70 Offset: 0x1F80270 VA: 0x181F81C70
	public static PatternFirework.Design Deserialize(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F813D0 Offset: 0x1F7F9D0 VA: 0x181F813D0
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F81760 Offset: 0x1F7FD60 VA: 0x181F81760
	public static PatternFirework.Design DeserializeLength(Stream stream, int length, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F82420 Offset: 0x1F80A20 VA: 0x181F82420
	public static void SerializeDelta(Stream stream, PatternFirework.Design instance, PatternFirework.Design previous) { }

	// RVA: 0x1F82830 Offset: 0x1F80E30 VA: 0x181F82830
	public static void Serialize(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x1F82A60 Offset: 0x1F81060 VA: 0x181F82A60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F82A70 Offset: 0x1F81070 VA: 0x181F82A70
	public void ToProto(Stream stream) { }

	// RVA: 0x1F82720 Offset: 0x1F80D20 VA: 0x181F82720
	public static byte[] SerializeToBytes(PatternFirework.Design instance) { }

	// RVA: 0x1F82670 Offset: 0x1F80C70 VA: 0x181F82670
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PatternFirework.Star : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6426
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector2 position; // 0x14
	public Color color; // 0x1C

	// Methods

	// RVA: 0x1F9C1D0 Offset: 0x1F9A7D0 VA: 0x181F9C1D0
	public static void ResetToPool(PatternFirework.Star instance) { }

	// RVA: 0x1F9C260 Offset: 0x1F9A860 VA: 0x181F9C260
	public void ResetToPool() { }

	// RVA: 0x1F9BFC0 Offset: 0x1F9A5C0 VA: 0x181F9BFC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F9B210 Offset: 0x1F99810 VA: 0x181F9B210
	public void CopyTo(PatternFirework.Star instance) { }

	// RVA: 0x1F9B240 Offset: 0x1F99840 VA: 0x181F9B240
	public PatternFirework.Star Copy() { }

	// RVA: 0x1F9BBC0 Offset: 0x1F9A1C0 VA: 0x181F9BBC0
	public static PatternFirework.Star Deserialize(Stream stream) { }

	// RVA: 0x1F9B500 Offset: 0x1F99B00 VA: 0x181F9B500
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F9B790 Offset: 0x1F99D90 VA: 0x181F9B790
	public static PatternFirework.Star DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F9BD70 Offset: 0x1F9A370 VA: 0x181F9BD70
	public static PatternFirework.Star Deserialize(byte[] buffer) { }

	// RVA: 0x1F9C040 Offset: 0x1F9A640 VA: 0x181F9C040
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F9CA20 Offset: 0x1F9B020 VA: 0x181F9CA20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F9CA40 Offset: 0x1F9B040 VA: 0x181F9CA40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Star previous) { }

	// RVA: 0x1F9C1B0 Offset: 0x1F9A7B0 VA: 0x181F9C1B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F9B820 Offset: 0x1F99E20 VA: 0x181F9B820
	public static PatternFirework.Star Deserialize(byte[] buffer, PatternFirework.Star instance, bool isDelta = False) { }

	// RVA: 0x1F9BA40 Offset: 0x1F9A040 VA: 0x181F9BA40
	public static PatternFirework.Star Deserialize(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9B2C0 Offset: 0x1F998C0 VA: 0x181F9B2C0
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9B580 Offset: 0x1F99B80 VA: 0x181F9B580
	public static PatternFirework.Star DeserializeLength(Stream stream, int length, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9C2F0 Offset: 0x1F9A8F0 VA: 0x181F9C2F0
	public static void SerializeDelta(Stream stream, PatternFirework.Star instance, PatternFirework.Star previous) { }

	// RVA: 0x1F9C7E0 Offset: 0x1F9ADE0 VA: 0x181F9C7E0
	public static void Serialize(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x1F9CA10 Offset: 0x1F9B010 VA: 0x181F9CA10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F9CA20 Offset: 0x1F9B020 VA: 0x181F9CA20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F9C6D0 Offset: 0x1F9ACD0 VA: 0x181F9C6D0
	public static byte[] SerializeToBytes(PatternFirework.Star instance) { }

	// RVA: 0x1F9C620 Offset: 0x1F9AC20 VA: 0x181F9C620
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PatternFirework.SavedDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6427
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int version; // 0x14
	public string name; // 0x18
	public PatternFirework.Design design; // 0x20

	// Methods

	// RVA: 0x1F9A8D0 Offset: 0x1F98ED0 VA: 0x181F9A8D0
	public static void ResetToPool(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9A9B0 Offset: 0x1F98FB0 VA: 0x181F9A9B0
	public void ResetToPool() { }

	// RVA: 0x1F9A570 Offset: 0x1F98B70 VA: 0x181F9A570 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F99440 Offset: 0x1F97A40 VA: 0x181F99440
	public void CopyTo(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F994C0 Offset: 0x1F97AC0 VA: 0x181F994C0
	public PatternFirework.SavedDesign Copy() { }

	// RVA: 0x1F9A170 Offset: 0x1F98770 VA: 0x181F9A170
	public static PatternFirework.SavedDesign Deserialize(Stream stream) { }

	// RVA: 0x1F99590 Offset: 0x1F97B90 VA: 0x181F99590
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F99B70 Offset: 0x1F98170 VA: 0x181F99B70
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F99C00 Offset: 0x1F98200 VA: 0x181F99C00
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer) { }

	// RVA: 0x1F9A6D0 Offset: 0x1F98CD0 VA: 0x181F9A6D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F9B1D0 Offset: 0x1F997D0 VA: 0x181F9B1D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F9B1F0 Offset: 0x1F997F0 VA: 0x181F9B1F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F9A8B0 Offset: 0x1F98EB0 VA: 0x181F9A8B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F99ED0 Offset: 0x1F984D0 VA: 0x181F99ED0
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer, PatternFirework.SavedDesign instance, bool isDelta = False) { }

	// RVA: 0x1F9A390 Offset: 0x1F98990 VA: 0x181F9A390
	public static PatternFirework.SavedDesign Deserialize(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F99610 Offset: 0x1F97C10 VA: 0x181F99610
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F998D0 Offset: 0x1F97ED0 VA: 0x181F998D0
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F9AA90 Offset: 0x1F99090 VA: 0x181F9AA90
	public static void SerializeDelta(Stream stream, PatternFirework.SavedDesign instance, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F9AF30 Offset: 0x1F99530 VA: 0x181F9AF30
	public static void Serialize(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9B1C0 Offset: 0x1F997C0 VA: 0x181F9B1C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F9B1D0 Offset: 0x1F997D0 VA: 0x181F9B1D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F9AE20 Offset: 0x1F99420 VA: 0x181F9AE20
	public static byte[] SerializeToBytes(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9AD70 Offset: 0x1F99370 VA: 0x181F9AD70
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class PatternFirework : MortarFirework, IUGCBrowserEntity // TypeDefIndex: 8275
{	// Fields
	public const int CurrentVersion = 1;
	[HeaderAttribute] // RVA: 0xA3E90 Offset: 0xA3290 VA: 0x1800A3E90
	public GameObjectRef FireworkDesignerDialog; // 0x270
	public int MaxStars; // 0x278
	public float ShellFuseLengthShort; // 0x27C
	public float ShellFuseLengthMed; // 0x280
	public float ShellFuseLengthLong; // 0x284
	public PatternFirework.Design Design; // 0x288
	public PatternFirework.FuseLength ShellFuseLength; // 0x290
	private Option __menuOption_MenuLongFuse; // 0x298
	private Option __menuOption_MenuMediumFuse; // 0x2F0
	private Option __menuOption_MenuOpenDesigner; // 0x348
	private Option __menuOption_MenuShortFuse; // 0x3A0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x86BDB0 Offset: 0x86A3B0 VA: 0x18086BDB0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x86C860 Offset: 0x86AE60 VA: 0x18086C860 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x86D200 Offset: 0x86B800 VA: 0x18086D200 Slot: 146
	protected override void PreInitShell(FireworkShell shell) { }

	[BaseEntity.Menu] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.Description] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.Icon] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.ShowIf] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	// RVA: 0x86CAC0 Offset: 0x86B0C0 VA: 0x18086CAC0
	public void MenuOpenDesigner(BasePlayer player) { }

	// RVA: 0x86CA40 Offset: 0x86B040 VA: 0x18086CA40
	public bool MenuOpenDesigner_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x86D0E0 Offset: 0x86B6E0 VA: 0x18086D0E0
	private void OpenDesigner(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x86D310 Offset: 0x86B910 VA: 0x18086D310
	public void SetFireworkDesign(PatternFirework.Design design) { }

	[BaseEntity.Menu] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.Description] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.Icon] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	// RVA: 0x86CB40 Offset: 0x86B140 VA: 0x18086CB40
	public void MenuShortFuse(BasePlayer player) { }

	// RVA: 0x86CB00 Offset: 0x86B100 VA: 0x18086CB00
	public bool MenuShortFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.Description] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.Icon] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	// RVA: 0x86C9F0 Offset: 0x86AFF0 VA: 0x18086C9F0
	public void MenuMediumFuse(BasePlayer player) { }

	// RVA: 0x86C9B0 Offset: 0x86AFB0 VA: 0x18086C9B0
	public bool MenuMediumFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.Description] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.Icon] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	// RVA: 0x86C960 Offset: 0x86AF60 VA: 0x18086C960
	public void MenuLongFuse(BasePlayer player) { }

	// RVA: 0x86C920 Offset: 0x86AF20 VA: 0x18086C920
	public bool MenuLongFuse_ShowIf(BasePlayer player) { }

	// RVA: 0x86C830 Offset: 0x86AE30 VA: 0x18086C830
	private float GetShellFuseLength() { }

	// RVA: 0x86BE00 Offset: 0x86A400 VA: 0x18086BE00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x86D3B0 Offset: 0x86B9B0 VA: 0x18086D3B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x86CB90 Offset: 0x86B190 VA: 0x18086CB90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x86D380 Offset: 0x86B980 VA: 0x18086D380
	public void .ctor() { }

}

public enum PatternFirework.FuseLength // TypeDefIndex: 8276
{	// Fields
	public int value__; // 0x0
	public const PatternFirework.FuseLength Short = 0;
	public const PatternFirework.FuseLength Medium = 1;
	public const PatternFirework.FuseLength Long = 2;
	public const PatternFirework.FuseLength Max = 2;

}

