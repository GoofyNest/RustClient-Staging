public class InstrumentRecording : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6368
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<InstrumentRecordingNote> notes; // 0x18
	public int forInstrument; // 0x20

	// Methods

	// RVA: 0x1C0E6D0 Offset: 0x1C0CCD0 VA: 0x181C0E6D0
	public static void ResetToPool(InstrumentRecording instance) { }

	// RVA: 0x1C0E4F0 Offset: 0x1C0CAF0 VA: 0x181C0E4F0
	public void ResetToPool() { }

	// RVA: 0x1C0E430 Offset: 0x1C0CA30 VA: 0x181C0E430 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0D610 Offset: 0x1C0BC10 VA: 0x181C0D610
	public void CopyTo(InstrumentRecording instance) { }

	// RVA: 0x1C0D7E0 Offset: 0x1C0BDE0 VA: 0x181C0D7E0
	public InstrumentRecording Copy() { }

	// RVA: 0x1C0E080 Offset: 0x1C0C680 VA: 0x181C0E080
	public static InstrumentRecording Deserialize(Stream stream) { }

	// RVA: 0x1C0D860 Offset: 0x1C0BE60 VA: 0x181C0D860
	public static InstrumentRecording DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0DBF0 Offset: 0x1C0C1F0 VA: 0x181C0DBF0
	public static InstrumentRecording DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0DF60 Offset: 0x1C0C560 VA: 0x181C0DF60
	public static InstrumentRecording Deserialize(byte[] buffer) { }

	// RVA: 0x1C0E4B0 Offset: 0x1C0CAB0 VA: 0x181C0E4B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0EF00 Offset: 0x1C0D500 VA: 0x181C0EF00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0EF20 Offset: 0x1C0D520 VA: 0x181C0EF20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecording previous) { }

	// RVA: 0x1C0E4D0 Offset: 0x1C0CAD0 VA: 0x181C0E4D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0E100 Offset: 0x1C0C700 VA: 0x181C0E100
	public static InstrumentRecording Deserialize(byte[] buffer, InstrumentRecording instance, bool isDelta = False) { }

	// RVA: 0x1C0E200 Offset: 0x1C0C800 VA: 0x181C0E200
	public static InstrumentRecording Deserialize(Stream stream, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0D8E0 Offset: 0x1C0BEE0 VA: 0x181C0D8E0
	public static InstrumentRecording DeserializeLengthDelimited(Stream stream, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0DC80 Offset: 0x1C0C280 VA: 0x181C0DC80
	public static InstrumentRecording DeserializeLength(Stream stream, int length, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0E8B0 Offset: 0x1C0CEB0 VA: 0x181C0E8B0
	public static void SerializeDelta(Stream stream, InstrumentRecording instance, InstrumentRecording previous) { }

	// RVA: 0x1C0ECC0 Offset: 0x1C0D2C0 VA: 0x181C0ECC0
	public static void Serialize(Stream stream, InstrumentRecording instance) { }

	// RVA: 0x1C0EEF0 Offset: 0x1C0D4F0 VA: 0x181C0EEF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0EF00 Offset: 0x1C0D500 VA: 0x181C0EF00
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0EBB0 Offset: 0x1C0D1B0 VA: 0x181C0EBB0
	public static byte[] SerializeToBytes(InstrumentRecording instance) { }

	// RVA: 0x1C0EB00 Offset: 0x1C0D100 VA: 0x181C0EB00
	public static void SerializeLengthDelimited(Stream stream, InstrumentRecording instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class InstrumentRecordingNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6369
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float startTime; // 0x14
	public float duration; // 0x18
	public int note; // 0x1C
	public int octave; // 0x20
	public float velocity; // 0x24
	public int noteType; // 0x28
	public bool shouldPlay; // 0x2C
	public bool hasPlayed; // 0x2D

	// Methods

	// RVA: 0x1C0CD00 Offset: 0x1C0B300 VA: 0x181C0CD00
	public static void ResetToPool(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0CDE0 Offset: 0x1C0B3E0 VA: 0x181C0CDE0
	public void ResetToPool() { }

	// RVA: 0x1C0C940 Offset: 0x1C0AF40 VA: 0x181C0C940 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0B080 Offset: 0x1C09680 VA: 0x181C0B080
	public void CopyTo(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0B0D0 Offset: 0x1C096D0 VA: 0x181C0B0D0
	public InstrumentRecordingNote Copy() { }

	// RVA: 0x1C0C5D0 Offset: 0x1C0ABD0 VA: 0x181C0C5D0
	public static InstrumentRecordingNote Deserialize(Stream stream) { }

	// RVA: 0x1C0B570 Offset: 0x1C09B70 VA: 0x181C0B570
	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0B5F0 Offset: 0x1C09BF0 VA: 0x181C0B5F0
	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0C1A0 Offset: 0x1C0A7A0 VA: 0x181C0C1A0
	public static InstrumentRecordingNote Deserialize(byte[] buffer) { }

	// RVA: 0x1C0C9C0 Offset: 0x1C0AFC0 VA: 0x181C0C9C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0D5D0 Offset: 0x1C0BBD0 VA: 0x181C0D5D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0D5F0 Offset: 0x1C0BBF0 VA: 0x181C0D5F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecordingNote previous) { }

	// RVA: 0x1C0CCE0 Offset: 0x1C0B2E0 VA: 0x181C0CCE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0BD90 Offset: 0x1C0A390 VA: 0x181C0BD90
	public static InstrumentRecordingNote Deserialize(byte[] buffer, InstrumentRecordingNote instance, bool isDelta = False) { }

	// RVA: 0x1C0BA60 Offset: 0x1C0A060 VA: 0x181C0BA60
	public static InstrumentRecordingNote Deserialize(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0B170 Offset: 0x1C09770 VA: 0x181C0B170
	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0B680 Offset: 0x1C09C80 VA: 0x181C0B680
	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0CEC0 Offset: 0x1C0B4C0 VA: 0x181C0CEC0
	public static void SerializeDelta(Stream stream, InstrumentRecordingNote instance, InstrumentRecordingNote previous) { }

	// RVA: 0x1C0D3E0 Offset: 0x1C0B9E0 VA: 0x181C0D3E0
	public static void Serialize(Stream stream, InstrumentRecordingNote instance) { }

	// RVA: 0x1C0D5C0 Offset: 0x1C0BBC0 VA: 0x181C0D5C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0D5D0 Offset: 0x1C0BBD0 VA: 0x181C0D5D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0D2D0 Offset: 0x1C0B8D0 VA: 0x181C0D2D0
	public static byte[] SerializeToBytes(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0D220 Offset: 0x1C0B820 VA: 0x181C0D220
	public static void SerializeLengthDelimited(Stream stream, InstrumentRecordingNote instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class InstrumentMidiBindings : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6370
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<InstrumentMidiBinding> bindings; // 0x18
	public uint forInstrument; // 0x20

	// Methods

	// RVA: 0x1C0A810 Offset: 0x1C08E10 VA: 0x181C0A810
	public static void ResetToPool(InstrumentMidiBindings instance) { }

	// RVA: 0x1C0A630 Offset: 0x1C08C30 VA: 0x181C0A630
	public void ResetToPool() { }

	// RVA: 0x1C0A570 Offset: 0x1C08B70 VA: 0x181C0A570 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C09600 Offset: 0x1C07C00 VA: 0x181C09600
	public void CopyTo(InstrumentMidiBindings instance) { }

	// RVA: 0x1C097B0 Offset: 0x1C07DB0 VA: 0x181C097B0
	public InstrumentMidiBindings Copy() { }

	// RVA: 0x1C0A1A0 Offset: 0x1C087A0 VA: 0x181C0A1A0
	public static InstrumentMidiBindings Deserialize(Stream stream) { }

	// RVA: 0x1C09CB0 Offset: 0x1C082B0 VA: 0x181C09CB0
	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C09D30 Offset: 0x1C08330 VA: 0x181C09D30
	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0A220 Offset: 0x1C08820 VA: 0x181C0A220
	public static InstrumentMidiBindings Deserialize(byte[] buffer) { }

	// RVA: 0x1C0A5F0 Offset: 0x1C08BF0 VA: 0x181C0A5F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0B040 Offset: 0x1C09640 VA: 0x181C0B040 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0B060 Offset: 0x1C09660 VA: 0x181C0B060 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBindings previous) { }

	// RVA: 0x1C0A610 Offset: 0x1C08C10 VA: 0x181C0A610 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0A0A0 Offset: 0x1C086A0 VA: 0x181C0A0A0
	public static InstrumentMidiBindings Deserialize(byte[] buffer, InstrumentMidiBindings instance, bool isDelta = False) { }

	// RVA: 0x1C0A340 Offset: 0x1C08940 VA: 0x181C0A340
	public static InstrumentMidiBindings Deserialize(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C099A0 Offset: 0x1C07FA0 VA: 0x181C099A0
	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C09DC0 Offset: 0x1C083C0 VA: 0x181C09DC0
	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C0A9F0 Offset: 0x1C08FF0 VA: 0x181C0A9F0
	public static void SerializeDelta(Stream stream, InstrumentMidiBindings instance, InstrumentMidiBindings previous) { }

	// RVA: 0x1C0AE00 Offset: 0x1C09400 VA: 0x181C0AE00
	public static void Serialize(Stream stream, InstrumentMidiBindings instance) { }

	// RVA: 0x1C0B030 Offset: 0x1C09630 VA: 0x181C0B030
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0B040 Offset: 0x1C09640 VA: 0x181C0B040
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0ACF0 Offset: 0x1C092F0 VA: 0x181C0ACF0
	public static byte[] SerializeToBytes(InstrumentMidiBindings instance) { }

	// RVA: 0x1C0AC40 Offset: 0x1C09240 VA: 0x181C0AC40
	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBindings instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class InstrumentMidiBinding : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6371
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int noteFrom; // 0x14
	public int note; // 0x18
	public int noteOctave; // 0x1C
	public int noteType; // 0x20

	// Methods

	// RVA: 0x1C08F40 Offset: 0x1C07540 VA: 0x181C08F40
	public static void ResetToPool(InstrumentMidiBinding instance) { }

	// RVA: 0x1C08FE0 Offset: 0x1C075E0 VA: 0x181C08FE0
	public void ResetToPool() { }

	// RVA: 0x1C08C90 Offset: 0x1C07290 VA: 0x181C08C90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C07AD0 Offset: 0x1C060D0 VA: 0x181C07AD0
	public void CopyTo(InstrumentMidiBinding instance) { }

	// RVA: 0x1C07B00 Offset: 0x1C06100 VA: 0x181C07B00
	public InstrumentMidiBinding Copy() { }

	// RVA: 0x1C08A40 Offset: 0x1C07040 VA: 0x181C08A40
	public static InstrumentMidiBinding Deserialize(Stream stream) { }

	// RVA: 0x1C07B80 Offset: 0x1C06180 VA: 0x181C07B80
	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C081A0 Offset: 0x1C067A0 VA: 0x181C081A0
	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C08730 Offset: 0x1C06D30 VA: 0x181C08730
	public static InstrumentMidiBinding Deserialize(byte[] buffer) { }

	// RVA: 0x1C08D10 Offset: 0x1C07310 VA: 0x181C08D10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C095C0 Offset: 0x1C07BC0 VA: 0x181C095C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C095E0 Offset: 0x1C07BE0 VA: 0x181C095E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBinding previous) { }

	// RVA: 0x1C08F20 Offset: 0x1C07520 VA: 0x181C08F20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C08230 Offset: 0x1C06830 VA: 0x181C08230
	public static InstrumentMidiBinding Deserialize(byte[] buffer, InstrumentMidiBinding instance, bool isDelta = False) { }

	// RVA: 0x1C08520 Offset: 0x1C06B20 VA: 0x181C08520
	public static InstrumentMidiBinding Deserialize(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C07C00 Offset: 0x1C06200 VA: 0x181C07C00
	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C07EE0 Offset: 0x1C064E0 VA: 0x181C07EE0
	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C09080 Offset: 0x1C07680 VA: 0x181C09080
	public static void SerializeDelta(Stream stream, InstrumentMidiBinding instance, InstrumentMidiBinding previous) { }

	// RVA: 0x1C09460 Offset: 0x1C07A60 VA: 0x181C09460
	public static void Serialize(Stream stream, InstrumentMidiBinding instance) { }

	// RVA: 0x1C095B0 Offset: 0x1C07BB0 VA: 0x181C095B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C095C0 Offset: 0x1C07BC0 VA: 0x181C095C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C09350 Offset: 0x1C07950 VA: 0x181C09350
	public static byte[] SerializeToBytes(InstrumentMidiBinding instance) { }

	// RVA: 0x1C092A0 Offset: 0x1C078A0 VA: 0x181C092A0
	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBinding instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public sealed class InstrumentNameEvent : BaseTextEvent // TypeDefIndex: 7537
{	// Methods

	// RVA: 0x1398570 Offset: 0x1396B70 VA: 0x181398570
	public void .ctor() { }

	// RVA: 0x1398590 Offset: 0x1396B90 VA: 0x181398590
	public void .ctor(string instrumentName) { }

	// RVA: 0x13984B0 Offset: 0x1396AB0 VA: 0x1813984B0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1398520 Offset: 0x1396B20 VA: 0x181398520 Slot: 3
	public override string ToString() { }

}

public class InstrumentTool : HeldEntity // TypeDefIndex: 8586
{	// Fields
	public InstrumentKeyController KeyController; // 0x1F8
	public SoundDefinition DeploySound; // 0x200
	public Vector2 PitchClamp; // 0x208
	public bool UseAnimationSlotEvents; // 0x210
	public Transform MuzzleT; // 0x218
	public bool UsableByAutoTurrets; // 0x220
	private InstrumentViewmodel instrumentView; // 0x228

	// Methods

	// RVA: 0x81EA10 Offset: 0x81D010 VA: 0x18081EA10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x81DC90 Offset: 0x81C290 VA: 0x18081DC90 Slot: 136
	public override void ClampPitch(ref float pitch) { }

	// RVA: 0x81E7F0 Offset: 0x81CDF0 VA: 0x18081E7F0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x81DFF0 Offset: 0x81C5F0 VA: 0x18081DFF0 Slot: 149
	public override float GetMovementMultiplier() { }

	// RVA: 0x81E090 Offset: 0x81C690 VA: 0x18081E090 Slot: 157
	protected virtual void LateUpdate() { }

	// RVA: 0x81E1D0 Offset: 0x81C7D0 VA: 0x18081E1D0 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x81E170 Offset: 0x81C770 VA: 0x18081E170
	private void OnAnimationSlotSet(InstrumentKeyController.AnimationSlot slot) { }

	// RVA: 0x81E650 Offset: 0x81CC50 VA: 0x18081E650 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x81F320 Offset: 0x81D920 VA: 0x18081F320 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x81E480 Offset: 0x81CA80 VA: 0x18081E480 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	protected virtual void RemotePlayerDeploy(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 159
	protected virtual void RemotePlayerHolster(BasePlayer player) { }

	// RVA: 0x81F430 Offset: 0x81DA30 VA: 0x18081F430 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x81F550 Offset: 0x81DB50 VA: 0x18081F550 Slot: 27
	public override void ResetState() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81DD30 Offset: 0x81C330 VA: 0x18081DD30
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81DEB0 Offset: 0x81C4B0 VA: 0x18081DEB0
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 156
	public override bool IsInstrument() { }

	// RVA: 0x81F620 Offset: 0x81DC20 VA: 0x18081F620
	public void .ctor() { }

}

public class InstrumentStateBehaviour : StateMachineBehaviour // TypeDefIndex: 8742
{	// Fields
	private static readonly int[] targetState; // 0x0
	private static readonly int[] states; // 0x8
	public int ignoreIndex; // 0x18
	private float lastCrossfade; // 0x1C
	public float AnimatorCrossfadeDuration; // 0x20

	// Methods

	// RVA: 0x81D770 Offset: 0x81BD70 VA: 0x18081D770 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x81DC70 Offset: 0x81C270 VA: 0x18081DC70
	public void .ctor() { }

	// RVA: 0x81D970 Offset: 0x81BF70 VA: 0x18081D970
	private static void .cctor() { }

}

public class InstrumentViewmodel : MonoBehaviour // TypeDefIndex: 8743
{	// Fields
	public Animator ViewAnimator; // 0x18
	public bool UpdateA; // 0x20
	public bool UpdateB; // 0x21
	public bool UpdateC; // 0x22
	public bool UpdateD; // 0x23
	public bool UpdateE; // 0x24
	public bool UpdateF; // 0x25
	public bool UpdateG; // 0x26
	public bool UpdateRecentlyPlayed; // 0x27
	public bool UpdatePlayedNoteTrigger; // 0x28
	public bool UseTriggers; // 0x29
	private readonly int note_a; // 0x2C
	private readonly int note_b; // 0x30
	private readonly int note_c; // 0x34
	private readonly int note_d; // 0x38
	private readonly int note_e; // 0x3C
	private readonly int note_f; // 0x40
	private readonly int note_g; // 0x44
	private readonly int recentlyPlayedHash; // 0x48
	private readonly int playedNoteHash; // 0x4C

	// Methods

	// RVA: 0xA23F20 Offset: 0xA22520 VA: 0x180A23F20
	public void UpdateSlots(InstrumentKeyController.AnimationSlot currentSlot, bool recentlyPlayed, bool playedNoteThisFrame) { }

	// RVA: 0xA241E0 Offset: 0xA227E0 VA: 0x180A241E0
	private void UpdateState(int param, bool state) { }

	// RVA: 0xA24230 Offset: 0xA22830 VA: 0x180A24230
	public void .ctor() { }

}

public class InstrumentToolGuitar : InstrumentTool // TypeDefIndex: 9468
{	// Fields
	public Transform InUseAligner; // 0x230
	public Transform DeployAligner; // 0x238
	public string DeployBone; // 0x240
	private Transform handBoneTarget; // 0x248
	private static readonly int deployHash; // 0x0

	// Methods

	// RVA: 0xA23AA0 Offset: 0xA220A0 VA: 0x180A23AA0 Slot: 157
	protected override void LateUpdate() { }

	// RVA: 0xA23E20 Offset: 0xA22420 VA: 0x180A23E20 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0xA23CC0 Offset: 0xA222C0 VA: 0x180A23CC0 Slot: 145
	public override void OnReliableEvent(string name) { }

	// RVA: 0xA239E0 Offset: 0xA21FE0 VA: 0x180A239E0
	public void DeployBegin() { }

	// RVA: 0xA23A40 Offset: 0xA22040 VA: 0x180A23A40
	public void DeployComplete() { }

	// RVA: 0xA23DE0 Offset: 0xA223E0 VA: 0x180A23DE0 Slot: 150
	public override void OnSpawnedForWorkshopPreview() { }

	// RVA: 0xA23F10 Offset: 0xA22510 VA: 0x180A23F10
	public void .ctor() { }

	// RVA: 0xA23EC0 Offset: 0xA224C0 VA: 0x180A23EC0
	private static void .cctor() { }

}

public class InstrumentDebugInput : MonoBehaviour // TypeDefIndex: 9549
{	// Fields
	public InstrumentKeyController KeyController; // 0x18
	public InstrumentKeyController.KeySet Note; // 0x20
	public float Frequency; // 0x2C
	public float StopAfter; // 0x30
	public SoundDefinition OverrideDefinition; // 0x38

	// Methods

	// RVA: 0x8163B0 Offset: 0x8149B0 VA: 0x1808163B0
	public void .ctor() { }

}

public class InstrumentIKController : MonoBehaviour // TypeDefIndex: 9550
{	// Fields
	public Vector3 HitRotationVector; // 0x18
	public Transform[] LeftHandIkTargets; // 0x28
	public Transform[] LeftHandIKTargetHitRotations; // 0x30
	public Transform[] RightHandIkTargets; // 0x38
	public Transform[] RightHandIKTargetHitRotations; // 0x40
	public Transform[] RightFootIkTargets; // 0x48
	public AnimationCurve HandHeightCurve; // 0x50
	public float HandHeightMultiplier; // 0x58
	public float HandMoveLerpSpeed; // 0x5C
	public bool DebugHitRotation; // 0x60
	public AnimationCurve HandHitCurve; // 0x68
	public float NoteHitTime; // 0x70
	[HeaderAttribute] // RVA: 0x76FB0 Offset: 0x763B0 VA: 0x180076FB0
	public float BodyLookWeight; // 0x74
	public float HeadLookWeight; // 0x78
	public float LookWeightLimit; // 0x7C
	public bool HoldHandsAtPlay; // 0x80
	private int currentLeftHandTarget; // 0x84
	private float leftHandTargetNoteTime; // 0x88
	private int currentRightHandTarget; // 0x8C
	private float rightHandTargetNoteTime; // 0x90
	private int currentRightFootTarget; // 0x94
	private float rightFootTargetNoteTime; // 0x98
	private Vector3 leftHandIkPos; // 0x9C
	private Vector3 rightHandIkPos; // 0xA8
	private Vector3 rightFootIkPos; // 0xB4
	private Transform iKWorkerTransform; // 0xC0
	private Transform rotationWorker; // 0xC8
	private float totalHandAnimTime; // 0xD0
	private float lastSetLeftHandTime; // 0xD4
	private float lastSetRightHandTime; // 0xD8
	private float lastSetRightFootTime; // 0xDC

	// Methods

	// RVA: 0x8166C0 Offset: 0x814CC0 VA: 0x1808166C0
	public void HoldHandsUpdate(InstrumentKeyController key) { }

	// RVA: 0x816C50 Offset: 0x815250 VA: 0x180816C50
	public void UpdateIK(BasePlayer forPlayer) { }

	// RVA: 0x8163F0 Offset: 0x8149F0 VA: 0x1808163F0
	private Vector3 GetHandHeight(float noteTime) { }

	// RVA: 0x816580 Offset: 0x814B80 VA: 0x180816580
	private Vector3 GetWorldSpaceIkTarget(int target, InstrumentKeyController.IKType type, Vector3 localOffset) { }

	// RVA: 0x8164F0 Offset: 0x814AF0 VA: 0x1808164F0
	private Transform GetHandTransform(int target, InstrumentKeyController.IKType type) { }

	// RVA: 0x816480 Offset: 0x814A80 VA: 0x180816480
	private Transform GetHandRotationTransform(int target, InstrumentKeyController.IKType type) { }

	// RVA: 0x8168E0 Offset: 0x814EE0 VA: 0x1808168E0
	public void SetIkTarget(InstrumentKeyController.IKType type, int target) { }

	// RVA: 0x8175C0 Offset: 0x815BC0 VA: 0x1808175C0
	public void .ctor() { }

}

public class InstrumentIKTargetAttribute : PropertyAttribute // TypeDefIndex: 9551
{	// Methods

	// RVA: 0x5177F0 Offset: 0x515DF0 VA: 0x1805177F0
	public void .ctor() { }

}

public class InstrumentKeyController : MonoBehaviour // TypeDefIndex: 9552
{	// Fields
	public static readonly int PlayingNoteParam; // 0x0
	public static readonly int AnimationSlot1; // 0x4
	public static readonly int AnimationSlot2; // 0x8
	public static readonly int AnimationSlot3; // 0xC
	public static readonly int AnimationSlot4; // 0x10
	public static readonly int AnimationSlot5; // 0x14
	public static readonly int AnimationSlot6; // 0x18
	public static readonly int AnimationSlot7; // 0x1C
	private float lastAnimationSlotTime; // 0x18
	public Action<InstrumentKeyController.AnimationSlot> OnAnimationSlotSet; // 0x20
	private Nullable<InstrumentKeyController.AnimationSlot> setSlot; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MicrophoneStandIOEntity <currentReceiver>k__BackingField; // 0x30
	private bool sustain; // 0x38
	private int lastMidiFrame; // 0x3C
	private int midiNotesThisFrame; // 0x40
	private InstrumentRecording activeRecording; // 0x48
	private string recordingFileName; // 0x50
	private float recordingStartTime; // 0x58
	private List<InstrumentRecordingNote> activeNotes; // 0x60
	private InstrumentRecording playingRecording; // 0x68
	private float playbackElapsedTime; // 0x70
	private List<int> stoppedNotes; // 0x78
	public const float DEFAULT_NOTE_VELOCITY = 1;
	public NoteBindingCollection Bindings; // 0x80
	public InstrumentKeyController.NoteBinding[] NoteBindings; // 0x88
	public Transform[] NoteSoundPositions; // 0x90
	public InstrumentIKController IKController; // 0x98
	public Transform LeftHandProp; // 0xA0
	public Transform RightHandProp; // 0xA8
	public Animator InstrumentAnimator; // 0xB0
	public BaseEntity RPCHandler; // 0xB8
	public uint overrideAchievementId; // 0xC0
	private const string ALL_INSTRUMENTS_ACHIEVEMENT_NAME = "PLAY_ALL_INSTRUMENTS";
	private const int INSTRUMENT_ACHIEVEMENT_COUNT = 11;
	private static HashSet<uint> playedInstruments; // 0x20
	private InstrumentKeyController.NoteBinding workerBinding; // 0xC8
	private BasePlayer midiPlayer; // 0xE0
	private bool playedFirstNote; // 0xE8
	private float teamAchievementCheck; // 0xEC
	private static bool awardedFullCollectionAchievement; // 0x28
	public TimeSince TimeInUse; // 0xF0
	private bool subscribedToMidi; // 0xF4
	private InstrumentMidiBindings activeMidiBindings; // 0xF8
	private bool hasSetupBindings; // 0x100
	private string autoplayPrefString; // 0x108
	private string autoplayDefaultName; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <FullKeyboardMode>k__BackingField; // 0x118
	private List<int> activeMidiNotes; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private InstrumentKeyController.AnimationSlot <CurrentAnimation>k__BackingField; // 0x128
	private BasePlayer OwnerPlayer; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <PlayedNoteThisFrame>k__BackingField; // 0x138

	// Properties
	public MicrophoneStandIOEntity currentReceiver { get; set; }
	public bool FullKeyboardMode { get; set; }
	public InstrumentKeyController.AnimationSlot CurrentAnimation { get; set; }
	public bool RecentlyPlayedNote { get; }
	private bool HeldByLocalPlayer { get; }
	private bool IsPlaying { get; }
	private int CurrentlyPlayingNotes { get; }
	public bool PlayedNoteThisFrame { get; set; }

	// Methods

	// RVA: 0x817A80 Offset: 0x816080 VA: 0x180817A80
	private void DisableProps() { }

	// RVA: 0x81C910 Offset: 0x81AF10 VA: 0x18081C910
	private void UpdateHeldProps(BasePlayer forPlayer) { }

	// RVA: 0x81A820 Offset: 0x818E20 VA: 0x18081A820
	private void RunInstrumentAnimation(BasePlayer forPlayer) { }

	// RVA: 0x81ADA0 Offset: 0x8193A0 VA: 0x18081ADA0
	private void SetAnimationSlot(InstrumentKeyController.AnimationSlot slot, PlayerModel forPlayer) { }

	// RVA: 0x817B70 Offset: 0x816170 VA: 0x180817B70
	private int GetAnimationSlotHash(InstrumentKeyController.AnimationSlot slot) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public MicrophoneStandIOEntity get_currentReceiver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_currentReceiver(MicrophoneStandIOEntity value) { }

	// RVA: 0x81B3F0 Offset: 0x8199F0 VA: 0x18081B3F0
	public bool SetCurrentReceiver(MicrophoneStandIOEntity receiver) { }

	// RVA: 0x817910 Offset: 0x815F10 VA: 0x180817910
	public void ClearReceiver() { }

	// RVA: 0x81C490 Offset: 0x81AA90 VA: 0x18081C490
	public void SubscribeToMidi(BasePlayer forPlayer) { }

	// RVA: 0x81CC40 Offset: 0x81B240 VA: 0x18081CC40
	public void UpdateMidiBindings() { }

	// RVA: 0x81C710 Offset: 0x81AD10 VA: 0x18081C710
	public void UnsubscribeFromMidi() { }

	// RVA: 0x81A7C0 Offset: 0x818DC0 VA: 0x18081A7C0
	public void ResetState() { }

	// RVA: 0x819ED0 Offset: 0x8184D0 VA: 0x180819ED0
	private void PlayNoteViaMIDI(int noteIndex, float velocity) { }

	// RVA: 0x81BCF0 Offset: 0x81A2F0 VA: 0x18081BCF0
	private void StopNoteViaMIDI(int noteIndex) { }

	// RVA: 0x8186A0 Offset: 0x816CA0 VA: 0x1808186A0
	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x818400 Offset: 0x816A00 VA: 0x180818400
	private void NoteOffDelegate(MidiChannel channel, int note) { }

	// RVA: 0x817F00 Offset: 0x816500 VA: 0x180817F00
	private void KnobDelegate(MidiChannel channel, int knobNumber, float knobValue) { }

	// RVA: 0x817750 Offset: 0x815D50 VA: 0x180817750
	private bool ApplyMidiRebinding(int inNote, out int index) { }

	// RVA: 0x817930 Offset: 0x815F30 VA: 0x180817930
	private void ConvertMidiNoteToIndex(int note, out int index) { }

	// RVA: 0x81B8F0 Offset: 0x819EF0 VA: 0x18081B8F0
	public void StartRecording(string fileName) { }

	// RVA: 0x81C270 Offset: 0x81A870 VA: 0x18081C270
	public void StopRecording() { }

	// RVA: 0x81A520 Offset: 0x818B20 VA: 0x18081A520
	private void RecordNoteStart(Notes note, int octave, float velocity, InstrumentKeyController.NoteType type, bool hold) { }

	// RVA: 0x81A610 Offset: 0x818C10 VA: 0x18081A610
	private void RecordNoteStop(Notes note, int octave, InstrumentKeyController.NoteType type) { }

	// RVA: 0x81A290 Offset: 0x818890 VA: 0x18081A290
	public void PlayRecording(InstrumentRecording recording) { }

	// RVA: 0x81CCE0 Offset: 0x81B2E0 VA: 0x18081CCE0
	private void UpdatePlayingRecording(BasePlayer forPlayer) { }

	// RVA: 0x81C230 Offset: 0x81A830 VA: 0x18081C230
	private void StopPlayingRecording() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D450 Offset: 0x81BA50 VA: 0x18081D450
	public bool get_FullKeyboardMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D750 Offset: 0x81BD50 VA: 0x18081D750
	private void set_FullKeyboardMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D380 Offset: 0x81B980 VA: 0x18081D380
	public InstrumentKeyController.AnimationSlot get_CurrentAnimation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D740 Offset: 0x81BD40 VA: 0x18081D740
	private void set_CurrentAnimation(InstrumentKeyController.AnimationSlot value) { }

	// RVA: 0x81D710 Offset: 0x81BD10 VA: 0x18081D710
	public bool get_RecentlyPlayedNote() { }

	// RVA: 0x81D460 Offset: 0x81BA60 VA: 0x18081D460
	private bool get_HeldByLocalPlayer() { }

	// RVA: 0x81D5F0 Offset: 0x81BBF0 VA: 0x18081D5F0
	private bool get_IsPlaying() { }

	// RVA: 0x81D390 Offset: 0x81B990 VA: 0x18081D390
	private int get_CurrentlyPlayingNotes() { }

	// RVA: 0x81B490 Offset: 0x819A90 VA: 0x18081B490
	public void SetFullKeyboardMode(bool state) { }

	// RVA: 0x818B80 Offset: 0x817180 VA: 0x180818B80
	public void OnInput(BasePlayer player) { }

	// RVA: 0x818B60 Offset: 0x817160 VA: 0x180818B60
	private void OnDisable() { }

	// RVA: 0x817E10 Offset: 0x816410 VA: 0x180817E10
	public void InUseUpdate(BasePlayer forPlayer) { }

	// RVA: 0x8181F0 Offset: 0x8167F0 VA: 0x1808181F0
	public void LateUpdateInstrument(BasePlayer forPlayer) { }

	// RVA: 0x819DE0 Offset: 0x8183E0 VA: 0x180819DE0
	public void PlayNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	// RVA: 0x81A0F0 Offset: 0x8186F0 VA: 0x18081A0F0
	public bool PlayNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, bool isLocal) { }

	// RVA: 0x81BE40 Offset: 0x81A440 VA: 0x18081BE40
	public bool StopNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	// RVA: 0x81BC40 Offset: 0x81A240 VA: 0x18081BC40
	public void StopNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	// RVA: 0x81BA70 Offset: 0x81A070 VA: 0x18081BA70
	public void StopAllNotes(bool blockUntilRelease) { }

	// RVA: 0x81BF90 Offset: 0x81A590 VA: 0x18081BF90
	public void StopOldestNote(bool blockUntilRelease, bool isVoiceStealing = False) { }

	// RVA: 0x818A10 Offset: 0x817010 VA: 0x180818A10
	public void OnClientBeginUse(BasePlayer player) { }

	// RVA: 0x81B850 Offset: 0x819E50 VA: 0x18081B850
	public void SetupBindings() { }

	// RVA: 0x818AB0 Offset: 0x8170B0 VA: 0x180818AB0
	public void OnClientEndUse(BasePlayer player) { }

	// RVA: 0x818B70 Offset: 0x817170 VA: 0x180818B70
	public void OnEnable() { }

	// RVA: 0x817DC0 Offset: 0x8163C0 VA: 0x180817DC0
	private GameObject GetNoteSoundPosition(int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D700 Offset: 0x81BD00 VA: 0x18081D700
	public bool get_PlayedNoteThisFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D760 Offset: 0x81BD60 VA: 0x18081D760
	private void set_PlayedNoteThisFrame(bool value) { }

	// RVA: 0x8196A0 Offset: 0x817CA0 VA: 0x1808196A0
	public void OnPlayerPlayedNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, BasePlayer player) { }

	// RVA: 0x818200 Offset: 0x816800 VA: 0x180818200
	private void LoadPlayedInstruments() { }

	// RVA: 0x81ABF0 Offset: 0x8191F0 VA: 0x18081ABF0
	private void SavePlayedInstruments() { }

	// RVA: 0x819BB0 Offset: 0x8181B0 VA: 0x180819BB0
	public void OnPlayerStoppedNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	// RVA: 0x81D230 Offset: 0x81B830 VA: 0x18081D230
	public void .ctor() { }

	// RVA: 0x81D110 Offset: 0x81B710 VA: 0x18081D110
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81C700 Offset: 0x81AD00 VA: 0x18081C700
	private void <SetFullKeyboardMode>b__98_0() { }

}

public struct InstrumentKeyController.NoteBinding // TypeDefIndex: 9553
{	// Fields
	private Sound playingSound; // 0x0
	private float startedPlayingNote; // 0x8
	private float minimumNoteTime; // 0xC
	private float minimumSoundFadeOutTime; // 0x10
	private bool lastNoteState; // 0x14
	private bool blockUntilRelease; // 0x15
	public bool MidiOn; // 0x16
	public bool MouseOn; // 0x17

	// Properties
	public bool Playing { get; }
	public float PlayingDuration { get; }
	public bool RecentlyPlayedNote { get; }

	// Methods

	// RVA: 0xF8F80 Offset: 0xF8380 VA: 0x1800F8F80
	public bool get_Playing() { }

	// RVA: 0xF8F60 Offset: 0xF8360 VA: 0x1800F8F60
	public float get_PlayingDuration() { }

	// RVA: 0xF8FE0 Offset: 0xF83E0 VA: 0x1800F8FE0
	public bool get_RecentlyPlayedNote() { }

	// RVA: 0xF8E30 Offset: 0xF8230 VA: 0x1800F8E30
	private bool ButtonIsDown(Notes note, InstrumentKeyController.NoteType type) { }

	// RVA: 0xF8E40 Offset: 0xF8240 VA: 0x1800F8E40
	private bool ButtonJustPressed(Notes note, InstrumentKeyController.NoteType type) { }

	// RVA: 0xF8F00 Offset: 0xF8300 VA: 0x1800F8F00
	public void Update(BasePlayer player, InstrumentKeyController keyController, int octave, NoteBindingCollection noteCollection, NoteBindingCollection.NoteData data) { }

	// RVA: 0xF8E90 Offset: 0xF8290 VA: 0x1800F8E90
	public bool PlaySound(bool isLocal, float velocity, InstrumentKeyController keyController, NoteBindingCollection noteCollection, NoteBindingCollection.NoteData data) { }

	// RVA: 0x81FF20 Offset: 0x81E520 VA: 0x18081FF20
	public static void SetupSound(bool isLocal, float velocity, NoteBindingCollection noteCollection, Sound forSound) { }

	// RVA: 0xF8EF0 Offset: 0xF82F0 VA: 0x1800F8EF0
	public bool StopPlayingNote(InstrumentKeyController keyController, bool blockUntilKeyRelease = False, bool isVoiceStealing = False) { }

	// RVA: 0xF8E20 Offset: 0xF8220 VA: 0x1800F8E20
	public void BlockKeyUntilRelease() { }

	// RVA: 0xF8E50 Offset: 0xF8250 VA: 0x1800F8E50
	private Sound CreateSound(InstrumentKeyController keyController, NoteBindingCollection.NoteData data) { }

}

public enum InstrumentKeyController.IKType // TypeDefIndex: 9554
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.IKType LeftHand = 0;
	public const InstrumentKeyController.IKType RightHand = 1;
	public const InstrumentKeyController.IKType RightFoot = 2;

}

public enum InstrumentKeyController.NoteType // TypeDefIndex: 9555
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.NoteType Regular = 0;
	public const InstrumentKeyController.NoteType Sharp = 1;

}

public enum InstrumentKeyController.InstrumentType // TypeDefIndex: 9556
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.InstrumentType Note = 0;
	public const InstrumentKeyController.InstrumentType Hold = 1;

}

public enum InstrumentKeyController.AnimationSlot // TypeDefIndex: 9557
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.AnimationSlot None = 0;
	public const InstrumentKeyController.AnimationSlot One = 1;
	public const InstrumentKeyController.AnimationSlot Two = 2;
	public const InstrumentKeyController.AnimationSlot Three = 3;
	public const InstrumentKeyController.AnimationSlot Four = 4;
	public const InstrumentKeyController.AnimationSlot Five = 5;
	public const InstrumentKeyController.AnimationSlot Six = 6;
	public const InstrumentKeyController.AnimationSlot Seven = 7;

}

public struct InstrumentKeyController.KeySet // TypeDefIndex: 9558
{	// Fields
	public Notes Note; // 0x0
	public InstrumentKeyController.NoteType NoteType; // 0x4
	public int OctaveShift; // 0x8

	// Methods

	// RVA: 0xF8D70 Offset: 0xF8170 VA: 0x1800F8D70 Slot: 3
	public override string ToString() { }

}

public struct InstrumentKeyController.NoteOverride // TypeDefIndex: 9559
{	// Fields
	public bool Override; // 0x0
	public InstrumentKeyController.KeySet Note; // 0x4

}

public struct InstrumentKeyController.IKNoteTarget // TypeDefIndex: 9560
{	// Fields
	public InstrumentKeyController.IKType TargetType; // 0x0
	public int IkIndex; // 0x4

}

public abstract class InstrumentTip : BaseTip // TypeDefIndex: 11609
{	// Properties
	public InstrumentKeyController Instrument { get; }

	// Methods

	// RVA: 0xC5C7E0 Offset: 0xC5ADE0 VA: 0x180C5C7E0
	public InstrumentKeyController get_Instrument() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool IsKeypadHostingMusicBinds() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	protected void .ctor() { }

}

