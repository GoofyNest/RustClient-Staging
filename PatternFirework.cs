public class PatternFirework : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6424
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PatternFirework.Design design; // 0x18
	public int shellFuseLength; // 0x20

	// Methods

	// RVA: 0x1F98A20 Offset: 0x1F97020 VA: 0x181F98A20
	public static void ResetToPool(PatternFirework instance) { }

	// RVA: 0x1F98AD0 Offset: 0x1F970D0 VA: 0x181F98AD0
	public void ResetToPool() { }

	// RVA: 0x1F988B0 Offset: 0x1F96EB0 VA: 0x181F988B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F97C50 Offset: 0x1F96250 VA: 0x181F97C50
	public void CopyTo(PatternFirework instance) { }

	// RVA: 0x1F97CE0 Offset: 0x1F962E0 VA: 0x181F97CE0
	public PatternFirework Copy() { }

	// RVA: 0x1F98830 Offset: 0x1F96E30 VA: 0x181F98830
	public static PatternFirework Deserialize(Stream stream) { }

	// RVA: 0x1F97DB0 Offset: 0x1F963B0 VA: 0x181F97DB0
	public static PatternFirework DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F98380 Offset: 0x1F96980 VA: 0x181F98380
	public static PatternFirework DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F98410 Offset: 0x1F96A10 VA: 0x181F98410
	public static PatternFirework Deserialize(byte[] buffer) { }

	// RVA: 0x1F989E0 Offset: 0x1F96FE0 VA: 0x181F989E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F99140 Offset: 0x1F97740 VA: 0x181F99140 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F99160 Offset: 0x1F97760 VA: 0x181F99160 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework previous) { }

	// RVA: 0x1F98A00 Offset: 0x1F97000 VA: 0x181F98A00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F98730 Offset: 0x1F96D30 VA: 0x181F98730
	public static PatternFirework Deserialize(byte[] buffer, PatternFirework instance, bool isDelta = False) { }

	// RVA: 0x1F98530 Offset: 0x1F96B30 VA: 0x181F98530
	public static PatternFirework Deserialize(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F97E30 Offset: 0x1F96430 VA: 0x181F97E30
	public static PatternFirework DeserializeLengthDelimited(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F980F0 Offset: 0x1F966F0 VA: 0x181F980F0
	public static PatternFirework DeserializeLength(Stream stream, int length, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F98B80 Offset: 0x1F97180 VA: 0x181F98B80
	public static void SerializeDelta(Stream stream, PatternFirework instance, PatternFirework previous) { }

	// RVA: 0x1F98F50 Offset: 0x1F97550 VA: 0x181F98F50
	public static void Serialize(Stream stream, PatternFirework instance) { }

	// RVA: 0x1F99130 Offset: 0x1F97730 VA: 0x181F99130
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F99140 Offset: 0x1F97740 VA: 0x181F99140
	public void ToProto(Stream stream) { }

	// RVA: 0x1F98E40 Offset: 0x1F97440 VA: 0x181F98E40
	public static byte[] SerializeToBytes(PatternFirework instance) { }

	// RVA: 0x1F98D90 Offset: 0x1F97390 VA: 0x181F98D90
	public static void SerializeLengthDelimited(Stream stream, PatternFirework instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PatternFirework.Design : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6425
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PatternFirework.Star> stars; // 0x18
	public ulong editedBy; // 0x20

	// Methods

	// RVA: 0x1F81F80 Offset: 0x1F80580 VA: 0x181F81F80
	public static void ResetToPool(PatternFirework.Design instance) { }

	// RVA: 0x1F81DA0 Offset: 0x1F803A0 VA: 0x181F81DA0
	public void ResetToPool() { }

	// RVA: 0x1F81CE0 Offset: 0x1F802E0 VA: 0x181F81CE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F80EE0 Offset: 0x1F7F4E0 VA: 0x181F80EE0
	public void CopyTo(PatternFirework.Design instance) { }

	// RVA: 0x1F81090 Offset: 0x1F7F690 VA: 0x181F81090
	public PatternFirework.Design Copy() { }

	// RVA: 0x1F81930 Offset: 0x1F7FF30 VA: 0x181F81930
	public static PatternFirework.Design Deserialize(Stream stream) { }

	// RVA: 0x1F81420 Offset: 0x1F7FA20 VA: 0x181F81420
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F81780 Offset: 0x1F7FD80 VA: 0x181F81780
	public static PatternFirework.Design DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F81810 Offset: 0x1F7FE10 VA: 0x181F81810
	public static PatternFirework.Design Deserialize(byte[] buffer) { }

	// RVA: 0x1F81D60 Offset: 0x1F80360 VA: 0x181F81D60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F827B0 Offset: 0x1F80DB0 VA: 0x181F827B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F827D0 Offset: 0x1F80DD0 VA: 0x181F827D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Design previous) { }

	// RVA: 0x1F81D80 Offset: 0x1F80380 VA: 0x181F81D80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F81BE0 Offset: 0x1F801E0 VA: 0x181F81BE0
	public static PatternFirework.Design Deserialize(byte[] buffer, PatternFirework.Design instance, bool isDelta = False) { }

	// RVA: 0x1F819B0 Offset: 0x1F7FFB0 VA: 0x181F819B0
	public static PatternFirework.Design Deserialize(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F81110 Offset: 0x1F7F710 VA: 0x181F81110
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F814A0 Offset: 0x1F7FAA0 VA: 0x181F814A0
	public static PatternFirework.Design DeserializeLength(Stream stream, int length, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F82160 Offset: 0x1F80760 VA: 0x181F82160
	public static void SerializeDelta(Stream stream, PatternFirework.Design instance, PatternFirework.Design previous) { }

	// RVA: 0x1F82570 Offset: 0x1F80B70 VA: 0x181F82570
	public static void Serialize(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x1F827A0 Offset: 0x1F80DA0 VA: 0x181F827A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F827B0 Offset: 0x1F80DB0 VA: 0x181F827B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F82460 Offset: 0x1F80A60 VA: 0x181F82460
	public static byte[] SerializeToBytes(PatternFirework.Design instance) { }

	// RVA: 0x1F823B0 Offset: 0x1F809B0 VA: 0x181F823B0
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PatternFirework.Star : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6426
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector2 position; // 0x14
	public Color color; // 0x1C

	// Methods

	// RVA: 0x1F9BF10 Offset: 0x1F9A510 VA: 0x181F9BF10
	public static void ResetToPool(PatternFirework.Star instance) { }

	// RVA: 0x1F9BFA0 Offset: 0x1F9A5A0 VA: 0x181F9BFA0
	public void ResetToPool() { }

	// RVA: 0x1F9BD00 Offset: 0x1F9A300 VA: 0x181F9BD00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F9AF50 Offset: 0x1F99550 VA: 0x181F9AF50
	public void CopyTo(PatternFirework.Star instance) { }

	// RVA: 0x1F9AF80 Offset: 0x1F99580 VA: 0x181F9AF80
	public PatternFirework.Star Copy() { }

	// RVA: 0x1F9B900 Offset: 0x1F99F00 VA: 0x181F9B900
	public static PatternFirework.Star Deserialize(Stream stream) { }

	// RVA: 0x1F9B240 Offset: 0x1F99840 VA: 0x181F9B240
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F9B4D0 Offset: 0x1F99AD0 VA: 0x181F9B4D0
	public static PatternFirework.Star DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F9BAB0 Offset: 0x1F9A0B0 VA: 0x181F9BAB0
	public static PatternFirework.Star Deserialize(byte[] buffer) { }

	// RVA: 0x1F9BD80 Offset: 0x1F9A380 VA: 0x181F9BD80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F9C760 Offset: 0x1F9AD60 VA: 0x181F9C760 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F9C780 Offset: 0x1F9AD80 VA: 0x181F9C780 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Star previous) { }

	// RVA: 0x1F9BEF0 Offset: 0x1F9A4F0 VA: 0x181F9BEF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F9B560 Offset: 0x1F99B60 VA: 0x181F9B560
	public static PatternFirework.Star Deserialize(byte[] buffer, PatternFirework.Star instance, bool isDelta = False) { }

	// RVA: 0x1F9B780 Offset: 0x1F99D80 VA: 0x181F9B780
	public static PatternFirework.Star Deserialize(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9B000 Offset: 0x1F99600 VA: 0x181F9B000
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9B2C0 Offset: 0x1F998C0 VA: 0x181F9B2C0
	public static PatternFirework.Star DeserializeLength(Stream stream, int length, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9C030 Offset: 0x1F9A630 VA: 0x181F9C030
	public static void SerializeDelta(Stream stream, PatternFirework.Star instance, PatternFirework.Star previous) { }

	// RVA: 0x1F9C520 Offset: 0x1F9AB20 VA: 0x181F9C520
	public static void Serialize(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x1F9C750 Offset: 0x1F9AD50 VA: 0x181F9C750
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F9C760 Offset: 0x1F9AD60 VA: 0x181F9C760
	public void ToProto(Stream stream) { }

	// RVA: 0x1F9C410 Offset: 0x1F9AA10 VA: 0x181F9C410
	public static byte[] SerializeToBytes(PatternFirework.Star instance) { }

	// RVA: 0x1F9C360 Offset: 0x1F9A960 VA: 0x181F9C360
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F9A610 Offset: 0x1F98C10 VA: 0x181F9A610
	public static void ResetToPool(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9A6F0 Offset: 0x1F98CF0 VA: 0x181F9A6F0
	public void ResetToPool() { }

	// RVA: 0x1F9A2B0 Offset: 0x1F988B0 VA: 0x181F9A2B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F99180 Offset: 0x1F97780 VA: 0x181F99180
	public void CopyTo(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F99200 Offset: 0x1F97800 VA: 0x181F99200
	public PatternFirework.SavedDesign Copy() { }

	// RVA: 0x1F99EB0 Offset: 0x1F984B0 VA: 0x181F99EB0
	public static PatternFirework.SavedDesign Deserialize(Stream stream) { }

	// RVA: 0x1F992D0 Offset: 0x1F978D0 VA: 0x181F992D0
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F998B0 Offset: 0x1F97EB0 VA: 0x181F998B0
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F99940 Offset: 0x1F97F40 VA: 0x181F99940
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer) { }

	// RVA: 0x1F9A410 Offset: 0x1F98A10 VA: 0x181F9A410
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F9AF10 Offset: 0x1F99510 VA: 0x181F9AF10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F9AF30 Offset: 0x1F99530 VA: 0x181F9AF30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F9A5F0 Offset: 0x1F98BF0 VA: 0x181F9A5F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F99C10 Offset: 0x1F98210 VA: 0x181F99C10
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer, PatternFirework.SavedDesign instance, bool isDelta = False) { }

	// RVA: 0x1F9A0D0 Offset: 0x1F986D0 VA: 0x181F9A0D0
	public static PatternFirework.SavedDesign Deserialize(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F99350 Offset: 0x1F97950 VA: 0x181F99350
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F99610 Offset: 0x1F97C10 VA: 0x181F99610
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F9A7D0 Offset: 0x1F98DD0 VA: 0x181F9A7D0
	public static void SerializeDelta(Stream stream, PatternFirework.SavedDesign instance, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F9AC70 Offset: 0x1F99270 VA: 0x181F9AC70
	public static void Serialize(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9AF00 Offset: 0x1F99500 VA: 0x181F9AF00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F9AF10 Offset: 0x1F99510 VA: 0x181F9AF10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F9AB60 Offset: 0x1F99160 VA: 0x181F9AB60
	public static byte[] SerializeToBytes(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9AAB0 Offset: 0x1F990B0 VA: 0x181F9AAB0
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x86BCA0 Offset: 0x86A2A0 VA: 0x18086BCA0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x86C750 Offset: 0x86AD50 VA: 0x18086C750 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x86D0F0 Offset: 0x86B6F0 VA: 0x18086D0F0 Slot: 146
	protected override void PreInitShell(FireworkShell shell) { }

	[BaseEntity.Menu] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.Description] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.Icon] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.ShowIf] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	// RVA: 0x86C9B0 Offset: 0x86AFB0 VA: 0x18086C9B0
	public void MenuOpenDesigner(BasePlayer player) { }

	// RVA: 0x86C930 Offset: 0x86AF30 VA: 0x18086C930
	public bool MenuOpenDesigner_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x86CFD0 Offset: 0x86B5D0 VA: 0x18086CFD0
	private void OpenDesigner(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x86D200 Offset: 0x86B800 VA: 0x18086D200
	public void SetFireworkDesign(PatternFirework.Design design) { }

	[BaseEntity.Menu] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.Description] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.Icon] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	// RVA: 0x86CA30 Offset: 0x86B030 VA: 0x18086CA30
	public void MenuShortFuse(BasePlayer player) { }

	// RVA: 0x86C9F0 Offset: 0x86AFF0 VA: 0x18086C9F0
	public bool MenuShortFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.Description] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.Icon] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	// RVA: 0x86C8E0 Offset: 0x86AEE0 VA: 0x18086C8E0
	public void MenuMediumFuse(BasePlayer player) { }

	// RVA: 0x86C8A0 Offset: 0x86AEA0 VA: 0x18086C8A0
	public bool MenuMediumFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.Description] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.Icon] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	// RVA: 0x86C850 Offset: 0x86AE50 VA: 0x18086C850
	public void MenuLongFuse(BasePlayer player) { }

	// RVA: 0x86C810 Offset: 0x86AE10 VA: 0x18086C810
	public bool MenuLongFuse_ShowIf(BasePlayer player) { }

	// RVA: 0x86C720 Offset: 0x86AD20 VA: 0x18086C720
	private float GetShellFuseLength() { }

	// RVA: 0x86BCF0 Offset: 0x86A2F0 VA: 0x18086BCF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x86D2A0 Offset: 0x86B8A0 VA: 0x18086D2A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x86CA80 Offset: 0x86B080 VA: 0x18086CA80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x86D270 Offset: 0x86B870 VA: 0x18086D270
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

