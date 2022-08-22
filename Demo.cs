public class DemoHeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6464
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint version; // 0x14
	public string level; // 0x18
	public uint levelSeed; // 0x20
	public uint levelSize; // 0x24
	public string checksum; // 0x28
	public ulong localclient; // 0x30
	public Vector3 position; // 0x38
	public Vector3 rotation; // 0x44
	public string levelUrl; // 0x50
	public long recordedTime; // 0x58
	public long length; // 0x60
	public List<FileStorageCacheData> fileStorage; // 0x68

	// Methods

	// RVA: 0x1E61270 Offset: 0x1E5F870 VA: 0x181E61270
	public static void ResetToPool(DemoHeader instance) { }

	// RVA: 0x1E60FA0 Offset: 0x1E5F5A0 VA: 0x181E60FA0
	public void ResetToPool() { }

	// RVA: 0x1E60EE0 Offset: 0x1E5F4E0 VA: 0x181E60EE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5F890 Offset: 0x1E5DE90 VA: 0x181E5F890
	public void CopyTo(DemoHeader instance) { }

	// RVA: 0x1E5FA30 Offset: 0x1E5E030 VA: 0x181E5FA30
	public DemoHeader Copy() { }

	// RVA: 0x1E608B0 Offset: 0x1E5EEB0 VA: 0x181E608B0
	public static DemoHeader Deserialize(Stream stream) { }

	// RVA: 0x1E5FC20 Offset: 0x1E5E220 VA: 0x181E5FC20
	public static DemoHeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E60200 Offset: 0x1E5E800 VA: 0x181E60200
	public static DemoHeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E60930 Offset: 0x1E5EF30 VA: 0x181E60930
	public static DemoHeader Deserialize(byte[] buffer) { }

	// RVA: 0x1E60F60 Offset: 0x1E5F560 VA: 0x181E60F60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E62530 Offset: 0x1E60B30 VA: 0x181E62530 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E62550 Offset: 0x1E60B50 VA: 0x181E62550 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoHeader previous) { }

	// RVA: 0x1E60F80 Offset: 0x1E5F580 VA: 0x181E60F80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E607B0 Offset: 0x1E5EDB0 VA: 0x181E607B0
	public static DemoHeader Deserialize(byte[] buffer, DemoHeader instance, bool isDelta = False) { }

	// RVA: 0x1E60A50 Offset: 0x1E5F050 VA: 0x181E60A50
	public static DemoHeader Deserialize(Stream stream, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E5FCA0 Offset: 0x1E5E2A0 VA: 0x181E5FCA0
	public static DemoHeader DeserializeLengthDelimited(Stream stream, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E60290 Offset: 0x1E5E890 VA: 0x181E60290
	public static DemoHeader DeserializeLength(Stream stream, int length, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E61530 Offset: 0x1E5FB30 VA: 0x181E61530
	public static void SerializeDelta(Stream stream, DemoHeader instance, DemoHeader previous) { }

	// RVA: 0x1E61F40 Offset: 0x1E60540 VA: 0x181E61F40
	public static void Serialize(Stream stream, DemoHeader instance) { }

	// RVA: 0x1E62520 Offset: 0x1E60B20 VA: 0x181E62520
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E62530 Offset: 0x1E60B30 VA: 0x181E62530
	public void ToProto(Stream stream) { }

	// RVA: 0x1E61E30 Offset: 0x1E60430 VA: 0x181E61E30
	public static byte[] SerializeToBytes(DemoHeader instance) { }

	// RVA: 0x1E61D80 Offset: 0x1E60380 VA: 0x181E61D80
	public static void SerializeLengthDelimited(Stream stream, DemoHeader instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class DemoShot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6466
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string shotName; // 0x18
	public string demoName; // 0x20
	public float shotStart; // 0x28
	public float shotLength; // 0x2C
	public DemoShotVectorTrack camPos; // 0x30
	public DemoShotQuaternionTrack camRot; // 0x38
	public DemoShotFloatTrack camFov; // 0x40
	public DemoShotFloatTrack camDofDist; // 0x48
	public DemoShotFloatTrack camDofFocalSize; // 0x50
	public DemoShotFloatTrack camDofAperture; // 0x58
	public DemoShotParentTrack camParent; // 0x60
	public string folderName; // 0x68

	// Methods

	// RVA: 0x1E6D610 Offset: 0x1E6BC10 VA: 0x181E6D610
	public static void ResetToPool(DemoShot instance) { }

	// RVA: 0x1E6D8C0 Offset: 0x1E6BEC0 VA: 0x181E6D8C0
	public void ResetToPool() { }

	// RVA: 0x1E6D550 Offset: 0x1E6BB50 VA: 0x181E6D550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6BEF0 Offset: 0x1E6A4F0 VA: 0x181E6BEF0
	public void CopyTo(DemoShot instance) { }

	// RVA: 0x1E6C210 Offset: 0x1E6A810 VA: 0x181E6C210
	public DemoShot Copy() { }

	// RVA: 0x1E6CE30 Offset: 0x1E6B430 VA: 0x181E6CE30
	public static DemoShot Deserialize(Stream stream) { }

	// RVA: 0x1E6C290 Offset: 0x1E6A890 VA: 0x181E6C290
	public static DemoShot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6CDA0 Offset: 0x1E6B3A0 VA: 0x181E6CDA0
	public static DemoShot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6CEB0 Offset: 0x1E6B4B0 VA: 0x181E6CEB0
	public static DemoShot Deserialize(byte[] buffer) { }

	// RVA: 0x1E6D5D0 Offset: 0x1E6BBD0 VA: 0x181E6D5D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6F030 Offset: 0x1E6D630 VA: 0x181E6F030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6F050 Offset: 0x1E6D650 VA: 0x181E6F050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShot previous) { }

	// RVA: 0x1E6D5F0 Offset: 0x1E6BBF0 VA: 0x181E6D5F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6CFD0 Offset: 0x1E6B5D0 VA: 0x181E6CFD0
	public static DemoShot Deserialize(byte[] buffer, DemoShot instance, bool isDelta = False) { }

	// RVA: 0x1E6D0D0 Offset: 0x1E6B6D0 VA: 0x181E6D0D0
	public static DemoShot Deserialize(Stream stream, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6C310 Offset: 0x1E6A910 VA: 0x181E6C310
	public static DemoShot DeserializeLengthDelimited(Stream stream, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6C870 Offset: 0x1E6AE70 VA: 0x181E6C870
	public static DemoShot DeserializeLength(Stream stream, int length, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6DB70 Offset: 0x1E6C170 VA: 0x181E6DB70
	public static void SerializeDelta(Stream stream, DemoShot instance, DemoShot previous) { }

	// RVA: 0x1E6E720 Offset: 0x1E6CD20 VA: 0x181E6E720
	public static void Serialize(Stream stream, DemoShot instance) { }

	// RVA: 0x1E6F020 Offset: 0x1E6D620 VA: 0x181E6F020
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6F030 Offset: 0x1E6D630 VA: 0x181E6F030
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6E610 Offset: 0x1E6CC10 VA: 0x181E6E610
	public static byte[] SerializeToBytes(DemoShot instance) { }

	// RVA: 0x1E6E560 Offset: 0x1E6CB60 VA: 0x181E6E560
	public static void SerializeLengthDelimited(Stream stream, DemoShot instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class DemoShotVectorTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6467
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotVectorKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E6B750 Offset: 0x1E69D50 VA: 0x181E6B750
	public static void ResetToPool(DemoShotVectorTrack instance) { }

	// RVA: 0x1E6B660 Offset: 0x1E69C60 VA: 0x181E6B660
	public void ResetToPool() { }

	// RVA: 0x1E6B5A0 Offset: 0x1E69BA0 VA: 0x181E6B5A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6A8A0 Offset: 0x1E68EA0 VA: 0x181E6A8A0
	public void CopyTo(DemoShotVectorTrack instance) { }

	// RVA: 0x1E6A9E0 Offset: 0x1E68FE0 VA: 0x181E6A9E0
	public DemoShotVectorTrack Copy() { }

	// RVA: 0x1E6B520 Offset: 0x1E69B20 VA: 0x181E6B520
	public static DemoShotVectorTrack Deserialize(Stream stream) { }

	// RVA: 0x1E6AD40 Offset: 0x1E69340 VA: 0x181E6AD40
	public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6ADC0 Offset: 0x1E693C0 VA: 0x181E6ADC0
	public static DemoShotVectorTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6B400 Offset: 0x1E69A00 VA: 0x181E6B400
	public static DemoShotVectorTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E6B620 Offset: 0x1E69C20 VA: 0x181E6B620
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6BEB0 Offset: 0x1E6A4B0 VA: 0x181E6BEB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6BED0 Offset: 0x1E6A4D0 VA: 0x181E6BED0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotVectorTrack previous) { }

	// RVA: 0x1E6B640 Offset: 0x1E69C40 VA: 0x181E6B640 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6B100 Offset: 0x1E69700 VA: 0x181E6B100
	public static DemoShotVectorTrack Deserialize(byte[] buffer, DemoShotVectorTrack instance, bool isDelta = False) { }

	// RVA: 0x1E6B200 Offset: 0x1E69800 VA: 0x181E6B200
	public static DemoShotVectorTrack Deserialize(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E6AA60 Offset: 0x1E69060 VA: 0x181E6AA60
	public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E6AE50 Offset: 0x1E69450 VA: 0x181E6AE50
	public static DemoShotVectorTrack DeserializeLength(Stream stream, int length, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E6B840 Offset: 0x1E69E40 VA: 0x181E6B840
	public static void SerializeDelta(Stream stream, DemoShotVectorTrack instance, DemoShotVectorTrack previous) { }

	// RVA: 0x1E6BC60 Offset: 0x1E6A260 VA: 0x181E6BC60
	public static void Serialize(Stream stream, DemoShotVectorTrack instance) { }

	// RVA: 0x1E6BEA0 Offset: 0x1E6A4A0 VA: 0x181E6BEA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6BEB0 Offset: 0x1E6A4B0 VA: 0x181E6BEB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6BB50 Offset: 0x1E6A150 VA: 0x181E6BB50
	public static byte[] SerializeToBytes(DemoShotVectorTrack instance) { }

	// RVA: 0x1E6BAA0 Offset: 0x1E6A0A0 VA: 0x181E6BAA0
	public static void SerializeLengthDelimited(Stream stream, DemoShotVectorTrack instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public struct DemoShotVectorKeyframe : IProto // TypeDefIndex: 6468
{	// Fields
	public float keyframeTime; // 0x0
	public Vector3 keyFrameValue; // 0x4

	// Methods

	// RVA: 0x18BB340 Offset: 0x18B9940 VA: 0x1818BB340
	public static void ResetToPool(DemoShotVectorKeyframe instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(DemoShotVectorKeyframe instance) { }

	// RVA: 0xF2950 Offset: 0xF1D50 VA: 0x1800F2950
	public DemoShotVectorKeyframe Copy() { }

	// RVA: 0x1E6A280 Offset: 0x1E68880 VA: 0x181E6A280
	public static DemoShotVectorKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E699B0 Offset: 0x1E67FB0 VA: 0x181E699B0
	public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E69C50 Offset: 0x1E68250 VA: 0x181E69C50
	public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E69ED0 Offset: 0x1E684D0 VA: 0x181E69ED0
	public static DemoShotVectorKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231E50 Offset: 0x231250 VA: 0x180231E50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231ED0 Offset: 0x2312D0 VA: 0x180231ED0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231F00 Offset: 0x231300 VA: 0x180231F00
	public void WriteToStreamDelta(Stream stream, DemoShotVectorKeyframe previous) { }

	// RVA: 0x231E80 Offset: 0x231280 VA: 0x180231E80 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6A150 Offset: 0x1E68750 VA: 0x181E6A150
	public static DemoShotVectorKeyframe Deserialize(byte[] buffer, ref DemoShotVectorKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E69FD0 Offset: 0x1E685D0 VA: 0x181E69FD0
	public static DemoShotVectorKeyframe Deserialize(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E699F0 Offset: 0x1E67FF0 VA: 0x181E699F0
	public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E69C90 Offset: 0x1E68290 VA: 0x181E69C90
	public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E6A2C0 Offset: 0x1E688C0 VA: 0x181E6A2C0
	public static void SerializeDelta(Stream stream, DemoShotVectorKeyframe instance, DemoShotVectorKeyframe previous) { }

	// RVA: 0x1E6A710 Offset: 0x1E68D10 VA: 0x181E6A710
	public static void Serialize(Stream stream, DemoShotVectorKeyframe instance) { }

	// RVA: 0x231EB0 Offset: 0x2312B0 VA: 0x180231EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x231ED0 Offset: 0x2312D0 VA: 0x180231ED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6A5F0 Offset: 0x1E68BF0 VA: 0x181E6A5F0
	public static byte[] SerializeToBytes(DemoShotVectorKeyframe instance) { }

	// RVA: 0x1E6A540 Offset: 0x1E68B40 VA: 0x181E6A540
	public static void SerializeLengthDelimited(Stream stream, DemoShotVectorKeyframe instance) { }

}

public class DemoShotFloatTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6469
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotFloatKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E64260 Offset: 0x1E62860 VA: 0x181E64260
	public static void ResetToPool(DemoShotFloatTrack instance) { }

	// RVA: 0x1E64350 Offset: 0x1E62950 VA: 0x181E64350
	public void ResetToPool() { }

	// RVA: 0x1E641A0 Offset: 0x1E627A0 VA: 0x181E641A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E631C0 Offset: 0x1E617C0 VA: 0x181E631C0
	public void CopyTo(DemoShotFloatTrack instance) { }

	// RVA: 0x1E632D0 Offset: 0x1E618D0 VA: 0x181E632D0
	public DemoShotFloatTrack Copy() { }

	// RVA: 0x1E63CC0 Offset: 0x1E622C0 VA: 0x181E63CC0
	public static DemoShotFloatTrack Deserialize(Stream stream) { }

	// RVA: 0x1E63620 Offset: 0x1E61C20 VA: 0x181E63620
	public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E636A0 Offset: 0x1E61CA0 VA: 0x181E636A0
	public static DemoShotFloatTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E63EE0 Offset: 0x1E624E0 VA: 0x181E63EE0
	public static DemoShotFloatTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E64220 Offset: 0x1E62820 VA: 0x181E64220
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E64A80 Offset: 0x1E63080 VA: 0x181E64A80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E64AA0 Offset: 0x1E630A0 VA: 0x181E64AA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotFloatTrack previous) { }

	// RVA: 0x1E64240 Offset: 0x1E62840 VA: 0x181E64240 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E63BC0 Offset: 0x1E621C0 VA: 0x181E63BC0
	public static DemoShotFloatTrack Deserialize(byte[] buffer, DemoShotFloatTrack instance, bool isDelta = False) { }

	// RVA: 0x1E639D0 Offset: 0x1E61FD0 VA: 0x181E639D0
	public static DemoShotFloatTrack Deserialize(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E63350 Offset: 0x1E61950 VA: 0x181E63350
	public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E63730 Offset: 0x1E61D30 VA: 0x181E63730
	public static DemoShotFloatTrack DeserializeLength(Stream stream, int length, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E64440 Offset: 0x1E62A40 VA: 0x181E64440
	public static void SerializeDelta(Stream stream, DemoShotFloatTrack instance, DemoShotFloatTrack previous) { }

	// RVA: 0x1E64840 Offset: 0x1E62E40 VA: 0x181E64840
	public static void Serialize(Stream stream, DemoShotFloatTrack instance) { }

	// RVA: 0x1E64A70 Offset: 0x1E63070 VA: 0x181E64A70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E64A80 Offset: 0x1E63080 VA: 0x181E64A80
	public void ToProto(Stream stream) { }

	// RVA: 0x1E64730 Offset: 0x1E62D30 VA: 0x181E64730
	public static byte[] SerializeToBytes(DemoShotFloatTrack instance) { }

	// RVA: 0x1E64680 Offset: 0x1E62C80 VA: 0x181E64680
	public static void SerializeLengthDelimited(Stream stream, DemoShotFloatTrack instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public struct DemoShotFloatKeyframe : IProto // TypeDefIndex: 6470
{	// Fields
	public float keyframeTime; // 0x0
	public float keyFrameValue; // 0x4

	// Methods

	// RVA: 0x1E4CCA0 Offset: 0x1E4B2A0 VA: 0x181E4CCA0
	public static void ResetToPool(DemoShotFloatKeyframe instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(DemoShotFloatKeyframe instance) { }

	// RVA: 0xF22B0 Offset: 0xF16B0 VA: 0x1800F22B0
	public DemoShotFloatKeyframe Copy() { }

	// RVA: 0x1E62C20 Offset: 0x1E61220 VA: 0x181E62C20
	public static DemoShotFloatKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E62570 Offset: 0x1E60B70 VA: 0x181E62570
	public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E62A00 Offset: 0x1E61000 VA: 0x181E62A00
	public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E62A30 Offset: 0x1E61030 VA: 0x181E62A30
	public static DemoShotFloatKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231AD0 Offset: 0x230ED0 VA: 0x180231AD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231B30 Offset: 0x230F30 VA: 0x180231B30 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231B50 Offset: 0x230F50 VA: 0x180231B50
	public void WriteToStreamDelta(Stream stream, DemoShotFloatKeyframe previous) { }

	// RVA: 0x231AF0 Offset: 0x230EF0 VA: 0x180231AF0 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E62B20 Offset: 0x1E61120 VA: 0x181E62B20
	public static DemoShotFloatKeyframe Deserialize(byte[] buffer, ref DemoShotFloatKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E62C50 Offset: 0x1E61250 VA: 0x181E62C50
	public static DemoShotFloatKeyframe Deserialize(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E625A0 Offset: 0x1E60BA0 VA: 0x181E625A0
	public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E627E0 Offset: 0x1E60DE0 VA: 0x181E627E0
	public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E62DC0 Offset: 0x1E613C0 VA: 0x181E62DC0
	public static void SerializeDelta(Stream stream, DemoShotFloatKeyframe instance, DemoShotFloatKeyframe previous) { }

	// RVA: 0x1E630E0 Offset: 0x1E616E0 VA: 0x181E630E0
	public static void Serialize(Stream stream, DemoShotFloatKeyframe instance) { }

	// RVA: 0x231B10 Offset: 0x230F10 VA: 0x180231B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x231B30 Offset: 0x230F30 VA: 0x180231B30
	public void ToProto(Stream stream) { }

	// RVA: 0x1E62FC0 Offset: 0x1E615C0 VA: 0x181E62FC0
	public static byte[] SerializeToBytes(DemoShotFloatKeyframe instance) { }

	// RVA: 0x1E62F10 Offset: 0x1E61510 VA: 0x181E62F10
	public static void SerializeLengthDelimited(Stream stream, DemoShotFloatKeyframe instance) { }

}

public class DemoShotQuaternionTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6471
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotQuaternionKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E690E0 Offset: 0x1E676E0 VA: 0x181E690E0
	public static void ResetToPool(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E691D0 Offset: 0x1E677D0 VA: 0x181E691D0
	public void ResetToPool() { }

	// RVA: 0x1E69020 Offset: 0x1E67620 VA: 0x181E69020 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E682E0 Offset: 0x1E668E0 VA: 0x181E682E0
	public void CopyTo(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E683F0 Offset: 0x1E669F0 VA: 0x181E683F0
	public DemoShotQuaternionTrack Copy() { }

	// RVA: 0x1E68FA0 Offset: 0x1E675A0 VA: 0x181E68FA0
	public static DemoShotQuaternionTrack Deserialize(Stream stream) { }

	// RVA: 0x1E68770 Offset: 0x1E66D70 VA: 0x181E68770
	public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E68AD0 Offset: 0x1E670D0 VA: 0x181E68AD0
	public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E68B60 Offset: 0x1E67160 VA: 0x181E68B60
	public static DemoShotQuaternionTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E690A0 Offset: 0x1E676A0 VA: 0x181E690A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E69970 Offset: 0x1E67F70 VA: 0x181E69970 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E69990 Offset: 0x1E67F90 VA: 0x181E69990 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotQuaternionTrack previous) { }

	// RVA: 0x1E690C0 Offset: 0x1E676C0 VA: 0x181E690C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E68C80 Offset: 0x1E67280 VA: 0x181E68C80
	public static DemoShotQuaternionTrack Deserialize(byte[] buffer, DemoShotQuaternionTrack instance, bool isDelta = False) { }

	// RVA: 0x1E68D80 Offset: 0x1E67380 VA: 0x181E68D80
	public static DemoShotQuaternionTrack Deserialize(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E68470 Offset: 0x1E66A70 VA: 0x181E68470
	public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E687F0 Offset: 0x1E66DF0 VA: 0x181E687F0
	public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E692C0 Offset: 0x1E678C0 VA: 0x181E692C0
	public static void SerializeDelta(Stream stream, DemoShotQuaternionTrack instance, DemoShotQuaternionTrack previous) { }

	// RVA: 0x1E69700 Offset: 0x1E67D00 VA: 0x181E69700
	public static void Serialize(Stream stream, DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E69960 Offset: 0x1E67F60 VA: 0x181E69960
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E69970 Offset: 0x1E67F70 VA: 0x181E69970
	public void ToProto(Stream stream) { }

	// RVA: 0x1E695F0 Offset: 0x1E67BF0 VA: 0x181E695F0
	public static byte[] SerializeToBytes(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E69540 Offset: 0x1E67B40 VA: 0x181E69540
	public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public struct DemoShotQuaternionKeyframe : IProto // TypeDefIndex: 6472
{	// Fields
	public float keyframeTime; // 0x0
	public float keyFrameValueX; // 0x4
	public float keyFrameValueY; // 0x8
	public float keyFrameValueZ; // 0xC
	public float keyFrameValueW; // 0x10

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x231D30 Offset: 0x231130 VA: 0x180231D30
	public DemoShotQuaternionKeyframe Copy() { }

	// RVA: 0x1E677C0 Offset: 0x1E65DC0 VA: 0x181E677C0
	public static DemoShotQuaternionKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E67120 Offset: 0x1E65720 VA: 0x181E67120
	public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E67480 Offset: 0x1E65A80 VA: 0x181E67480
	public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E67930 Offset: 0x1E65F30 VA: 0x181E67930
	public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231D40 Offset: 0x231140 VA: 0x180231D40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231DD0 Offset: 0x2311D0 VA: 0x180231DD0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231E00 Offset: 0x231200 VA: 0x180231E00
	public void WriteToStreamDelta(Stream stream, DemoShotQuaternionKeyframe previous) { }

	// RVA: 0x231D70 Offset: 0x231170 VA: 0x180231D70 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E67800 Offset: 0x1E65E00 VA: 0x181E67800
	public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer, ref DemoShotQuaternionKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E67A40 Offset: 0x1E66040 VA: 0x181E67A40
	public static DemoShotQuaternionKeyframe Deserialize(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E67160 Offset: 0x1E65760 VA: 0x181E67160
	public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E674C0 Offset: 0x1E65AC0 VA: 0x181E674C0
	public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E67C80 Offset: 0x1E66280 VA: 0x181E67C80
	public static void SerializeDelta(Stream stream, DemoShotQuaternionKeyframe instance, DemoShotQuaternionKeyframe previous) { }

	// RVA: 0x1E68150 Offset: 0x1E66750 VA: 0x181E68150
	public static void Serialize(Stream stream, DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x231DA0 Offset: 0x2311A0 VA: 0x180231DA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x231DD0 Offset: 0x2311D0 VA: 0x180231DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E68020 Offset: 0x1E66620 VA: 0x181E68020
	public static byte[] SerializeToBytes(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x1E67F60 Offset: 0x1E66560 VA: 0x181E67F60
	public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionKeyframe instance) { }

}

public class DemoShotParentTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6473
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong parentId; // 0x18
	public List<DemoShotParentKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E66880 Offset: 0x1E64E80 VA: 0x181E66880
	public static void ResetToPool(DemoShotParentTrack instance) { }

	// RVA: 0x1E66970 Offset: 0x1E64F70 VA: 0x181E66970
	public void ResetToPool() { }

	// RVA: 0x1E667C0 Offset: 0x1E64DC0 VA: 0x181E667C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E65A70 Offset: 0x1E64070 VA: 0x181E65A70
	public void CopyTo(DemoShotParentTrack instance) { }

	// RVA: 0x1E65C00 Offset: 0x1E64200 VA: 0x181E65C00
	public DemoShotParentTrack Copy() { }

	// RVA: 0x1E66540 Offset: 0x1E64B40 VA: 0x181E66540
	public static DemoShotParentTrack Deserialize(Stream stream) { }

	// RVA: 0x1E65C80 Offset: 0x1E64280 VA: 0x181E65C80
	public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E65FE0 Offset: 0x1E645E0 VA: 0x181E65FE0
	public static DemoShotParentTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E66420 Offset: 0x1E64A20 VA: 0x181E66420
	public static DemoShotParentTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E66840 Offset: 0x1E64E40 VA: 0x181E66840
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E670E0 Offset: 0x1E656E0 VA: 0x181E670E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E67100 Offset: 0x1E65700 VA: 0x181E67100 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotParentTrack previous) { }

	// RVA: 0x1E66860 Offset: 0x1E64E60 VA: 0x181E66860 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E66320 Offset: 0x1E64920 VA: 0x181E66320
	public static DemoShotParentTrack Deserialize(byte[] buffer, DemoShotParentTrack instance, bool isDelta = False) { }

	// RVA: 0x1E665C0 Offset: 0x1E64BC0 VA: 0x181E665C0
	public static DemoShotParentTrack Deserialize(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E65D00 Offset: 0x1E64300 VA: 0x181E65D00
	public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E66070 Offset: 0x1E64670 VA: 0x181E66070
	public static DemoShotParentTrack DeserializeLength(Stream stream, int length, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E66A60 Offset: 0x1E65060 VA: 0x181E66A60
	public static void SerializeDelta(Stream stream, DemoShotParentTrack instance, DemoShotParentTrack previous) { }

	// RVA: 0x1E66E90 Offset: 0x1E65490 VA: 0x181E66E90
	public static void Serialize(Stream stream, DemoShotParentTrack instance) { }

	// RVA: 0x1E670D0 Offset: 0x1E656D0 VA: 0x181E670D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E670E0 Offset: 0x1E656E0 VA: 0x181E670E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E66D80 Offset: 0x1E65380 VA: 0x181E66D80
	public static byte[] SerializeToBytes(DemoShotParentTrack instance) { }

	// RVA: 0x1E66CD0 Offset: 0x1E652D0 VA: 0x181E66CD0
	public static void SerializeLengthDelimited(Stream stream, DemoShotParentTrack instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public struct DemoShotParentKeyframe : IProto // TypeDefIndex: 6474
{	// Fields
	public float keyframeTime; // 0x0
	public uint keyFrameParentId; // 0x4
	public string keyFrameParentName; // 0x8

	// Methods

	// RVA: 0x1E65470 Offset: 0x1E63A70 VA: 0x181E65470
	public static void ResetToPool(DemoShotParentKeyframe instance) { }

	// RVA: 0x231B70 Offset: 0x230F70 VA: 0x180231B70
	public void CopyTo(DemoShotParentKeyframe instance) { }

	// RVA: 0x231BA0 Offset: 0x230FA0 VA: 0x180231BA0
	public DemoShotParentKeyframe Copy() { }

	// RVA: 0x1E65050 Offset: 0x1E63650 VA: 0x181E65050
	public static DemoShotParentKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E64D60 Offset: 0x1E63360 VA: 0x181E64D60
	public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E64DA0 Offset: 0x1E633A0 VA: 0x181E64DA0
	public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E65090 Offset: 0x1E63690 VA: 0x181E65090
	public static DemoShotParentKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231BE0 Offset: 0x230FE0 VA: 0x180231BE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231C60 Offset: 0x231060 VA: 0x180231C60 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231C90 Offset: 0x231090 VA: 0x180231C90
	public void WriteToStreamDelta(Stream stream, DemoShotParentKeyframe previous) { }

	// RVA: 0x231C10 Offset: 0x231010 VA: 0x180231C10 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E65190 Offset: 0x1E63790 VA: 0x181E65190
	public static DemoShotParentKeyframe Deserialize(byte[] buffer, ref DemoShotParentKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E652C0 Offset: 0x1E638C0 VA: 0x181E652C0
	public static DemoShotParentKeyframe Deserialize(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E64AC0 Offset: 0x1E630C0 VA: 0x181E64AC0
	public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E64DE0 Offset: 0x1E633E0 VA: 0x181E64DE0
	public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E654C0 Offset: 0x1E63AC0 VA: 0x181E654C0
	public static void SerializeDelta(Stream stream, DemoShotParentKeyframe instance, DemoShotParentKeyframe previous) { }

	// RVA: 0x1E658D0 Offset: 0x1E63ED0 VA: 0x181E658D0
	public static void Serialize(Stream stream, DemoShotParentKeyframe instance) { }

	// RVA: 0x231C40 Offset: 0x231040 VA: 0x180231C40
	public byte[] ToProtoBytes() { }

	// RVA: 0x231C60 Offset: 0x231060 VA: 0x180231C60
	public void ToProto(Stream stream) { }

	// RVA: 0x1E657B0 Offset: 0x1E63DB0 VA: 0x181E657B0
	public static byte[] SerializeToBytes(DemoShotParentKeyframe instance) { }

	// RVA: 0x1E65700 Offset: 0x1E63D00 VA: 0x181E65700
	public static void SerializeLengthDelimited(Stream stream, DemoShotParentKeyframe instance) { }

}

public class DemoClient : Client, IDisposable // TypeDefIndex: 6692
{	// Fields
	protected Reader demoFile; // 0x70

	// Properties
	public override bool IsPlaying { get; }
	public bool PlayingFinished { get; }

	// Methods

	// RVA: 0x220F740 Offset: 0x220DD40 VA: 0x18220F740
	public void .ctor(Reader demoFile) { }

	// RVA: 0x220EFF0 Offset: 0x220D5F0 VA: 0x18220EFF0 Slot: 14
	public virtual void Dispose() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public override bool get_IsPlaying() { }

	// RVA: 0x220F8F0 Offset: 0x220DEF0 VA: 0x18220F8F0
	public bool get_PlayingFinished() { }

	// RVA: 0x220F620 Offset: 0x220DC20 VA: 0x18220F620
	public void UpdatePlayback(long frameTime) { }

	// RVA: 0x220F580 Offset: 0x220DB80 VA: 0x18220F580
	private bool PlaybackPacket() { }

	// RVA: 0x220F020 Offset: 0x220D620 VA: 0x18220F020
	private void HandleMessage(IntPtr data, int size) { }

}

public class DemoShotPlayback : MonoBehaviour // TypeDefIndex: 9179
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DemoShot <CurrentShot>k__BackingField; // 0x18
	private bool playing; // 0x20
	public static DemoShotPlayback Instance; // 0x0
	public bool ShouldLoop; // 0x21

	// Properties
	public DemoShot CurrentShot { get; set; }
	public static bool IsPlayingShot { get; }
	public float CurrentShotTime { get; }
	public string CurrentShotName { get; }
	public float ShotPlaybackProgress { get; }
	public float ShotLength { get; }
	public float ShotEndTime { get; }
	public bool IsPaused { get; }
	public DemoShotVectorTrack CameraPositionTrack { get; }
	public float ShotStartTime { get; }
	public bool HasDofData { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_CurrentShot(DemoShot value) { }

	// RVA: 0x8558F0 Offset: 0x853EF0 VA: 0x1808558F0
	public static bool get_IsPlayingShot() { }

	// RVA: 0x855800 Offset: 0x853E00 VA: 0x180855800
	public float get_CurrentShotTime() { }

	// RVA: 0x854D10 Offset: 0x853310 VA: 0x180854D10
	public void Setup(DemoShot shot) { }

	// RVA: 0x854BC0 Offset: 0x8531C0 VA: 0x180854BC0
	public void PlayFromStart() { }

	// RVA: 0x854B40 Offset: 0x853140 VA: 0x180854B40
	public void PauseShot() { }

	// RVA: 0x854C20 Offset: 0x853220 VA: 0x180854C20
	public void ResumeShot() { }

	// RVA: 0x8546B0 Offset: 0x852CB0 VA: 0x1808546B0
	public void EndShot() { }

	// RVA: 0x854EE0 Offset: 0x8534E0 VA: 0x180854EE0
	private void Update() { }

	// RVA: 0x8549C0 Offset: 0x852FC0 VA: 0x1808549C0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x8557E0 Offset: 0x853DE0 VA: 0x1808557E0
	public string get_CurrentShotName() { }

	// RVA: 0x8559D0 Offset: 0x853FD0 VA: 0x1808559D0
	public float get_ShotPlaybackProgress() { }

	// RVA: 0x8559B0 Offset: 0x853FB0 VA: 0x1808559B0
	public float get_ShotLength() { }

	// RVA: 0x855980 Offset: 0x853F80 VA: 0x180855980
	public float get_ShotEndTime() { }

	// RVA: 0x8558A0 Offset: 0x853EA0 VA: 0x1808558A0
	public bool get_IsPaused() { }

	// RVA: 0x8557C0 Offset: 0x853DC0 VA: 0x1808557C0
	public DemoShotVectorTrack get_CameraPositionTrack() { }

	// RVA: 0x855A00 Offset: 0x854000 VA: 0x180855A00
	public float get_ShotStartTime() { }

	// RVA: 0x855880 Offset: 0x853E80 VA: 0x180855880
	public bool get_HasDofData() { }

	// RVA: 0x854C70 Offset: 0x853270 VA: 0x180854C70
	public void SetShotTime(float newTime) { }

	// RVA: 0x854600 Offset: 0x852C00 VA: 0x180854600
	public float ClampTimeToShotRange(float val) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class DemoShotRecorder : SingletonComponent<DemoShotRecorder> // TypeDefIndex: 9180
{	// Fields
	private DemoShot recordingShot; // 0x18
	private float lastKeyframe; // 0x20
	private bool hasStarted; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RealTimeUntil <CountdownEnds>k__BackingField; // 0x28
	public const float CountdownDuration = 3;
	private CameraMan.CameraState startSettings; // 0x2C
	private DemoShotRecorder.RecorderSettings settings; // 0x50
	public static string lastSavedShotName; // 0x0
	private string preRecordShotName; // 0x68
	private float countdownStartTime; // 0x70

	// Properties
	public RealTimeUntil CountdownEnds { get; set; }
	public bool IsInCountdown { get; }
	public float CurrentShotTime { get; }
	public string CurrentShotName { get; }
	public float ShotStartTime { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public RealTimeUntil get_CountdownEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	private void set_CountdownEnds(RealTimeUntil value) { }

	// RVA: 0x858C30 Offset: 0x857230 VA: 0x180858C30
	public bool get_IsInCountdown() { }

	// RVA: 0x8567C0 Offset: 0x854DC0 VA: 0x1808567C0
	public static void CreateNewShot(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	// RVA: 0x858BA0 Offset: 0x8571A0 VA: 0x180858BA0
	public float get_CurrentShotTime() { }

	// RVA: 0x858B80 Offset: 0x857180 VA: 0x180858B80
	public string get_CurrentShotName() { }

	// RVA: 0x858C50 Offset: 0x857250 VA: 0x180858C50
	public float get_ShotStartTime() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6670 Offset: 0xD5A70 VA: 0x1800D6670
	// RVA: 0x858950 Offset: 0x856F50 VA: 0x180858950
	private IEnumerator StartRecording(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	// RVA: 0x856750 Offset: 0x854D50 VA: 0x180856750
	public void CancelRecording() { }

	// RVA: 0x856900 Offset: 0x854F00 VA: 0x180856900
	public void FinishRecording() { }

	// RVA: 0x857530 Offset: 0x855B30 VA: 0x180857530
	public static string GetShotDirectory(string demoName, bool createDirectory = False) { }

	// RVA: 0x856FC0 Offset: 0x8555C0 VA: 0x180856FC0
	public static string GetFilePath(string shotName, string demoName, string folderName, bool createDirectory = False) { }

	// RVA: 0x8570B0 Offset: 0x8556B0 VA: 0x1808570B0
	public static Dictionary<string, List<string>> GetPathsOfAllShots(string demoName) { }

	// RVA: 0x858770 Offset: 0x856D70 VA: 0x180858770
	private static int SortWithTrailingNumber(string x, string y) { }

	// RVA: 0x857630 Offset: 0x855C30 VA: 0x180857630
	public static string GetTrailingFolder(string path) { }

	// RVA: 0x858A10 Offset: 0x857010 VA: 0x180858A10
	private void Update() { }

	// RVA: 0x8578F0 Offset: 0x855EF0 VA: 0x1808578F0
	private void RecordCameraState() { }

	// RVA: 0x8582E0 Offset: 0x8568E0 VA: 0x1808582E0
	private void RecordKeyframe(Vector3 value, DemoShotVectorTrack track) { }

	// RVA: 0x8580E0 Offset: 0x8566E0 VA: 0x1808580E0
	private void RecordKeyframe(float value, DemoShotFloatTrack track) { }

	// RVA: 0x857E10 Offset: 0x856410 VA: 0x180857E10
	private void RecordKeyframe(Quaternion value, DemoShotQuaternionTrack track) { }

	// RVA: 0x858570 Offset: 0x856B70 VA: 0x180858570
	private void RecordParent(BaseEntity parent, string bone, DemoShotParentTrack track) { }

	// RVA: 0x857870 Offset: 0x855E70 VA: 0x180857870
	private DemoShotVectorTrack InitialiseKeyframeVectorTrack() { }

	// RVA: 0x8577F0 Offset: 0x855DF0 VA: 0x1808577F0
	private DemoShotQuaternionTrack InitialiseKeyframeQuaternionTrack() { }

	// RVA: 0x8576F0 Offset: 0x855CF0 VA: 0x1808576F0
	private DemoShotFloatTrack InitialiseKeyframeFloatTrack() { }

	// RVA: 0x857770 Offset: 0x855D70 VA: 0x180857770
	private DemoShotParentTrack InitialiseKeyframeParentTrack() { }

	// RVA: 0x858B20 Offset: 0x857120 VA: 0x180858B20
	public void .ctor() { }

	// RVA: 0x858AD0 Offset: 0x8570D0 VA: 0x180858AD0
	private static void .cctor() { }

}

public struct DemoShotRecorder.RecorderSettings // TypeDefIndex: 9181
{	// Fields
	public bool Countdown; // 0x0
	public bool PauseOnSave; // 0x1
	public bool ReturnToShotStart; // 0x2
	public string FolderName; // 0x8
	public bool RecordDof; // 0x10

}

private sealed class DemoShotRecorder.<StartRecording>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9182
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DemoShotRecorder <>4__this; // 0x20
	public DemoShotRecorder.RecorderSettings withSettings; // 0x28
	public string shotName; // 0x40
	private float <waitTime>5__2; // 0x48
	private float <leftover>5__3; // 0x4C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x98B9C0 Offset: 0x989FC0 VA: 0x18098B9C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x98C120 Offset: 0x98A720 VA: 0x18098C120 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public static class DemoShotHelpers // TypeDefIndex: 9183
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8515E0 Offset: 0x84FBE0 VA: 0x1808515E0
	public static Vector3 GetVectorFromTrack(DemoShotVectorTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x851230 Offset: 0x84F830 VA: 0x180851230
	public static Quaternion GetQuaternionFromTrack(DemoShotQuaternionTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8506A0 Offset: 0x84ECA0 VA: 0x1808506A0
	public static float GetFloatFromTrack(DemoShotFloatTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x851080 Offset: 0x84F680 VA: 0x180851080
	public static DemoShotParentKeyframe GetParentFromTrack(DemoShotParentTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850960 Offset: 0x84EF60 VA: 0x180850960
	public static void GetKeyframesInRange(DemoShotVectorTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850BF0 Offset: 0x84F1F0 VA: 0x180850BF0
	public static void GetKeyframesInRange(DemoShotQuaternionTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850E60 Offset: 0x84F460 VA: 0x180850E60
	public static void GetKeyframesInRange(DemoShotFloatTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x851A30 Offset: 0x850030 VA: 0x180851A30
	public static Quaternion ToQuaternion(DemoShotQuaternionKeyframe keyframe) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x851A00 Offset: 0x850000 VA: 0x180851A00
	public static DemoShotQuaternionKeyframe ToKeyframe(Quaternion value, float time) { }

}

public class DemoPlaybackUI : SingletonComponent<DemoPlaybackUI> // TypeDefIndex: 10855
{	// Fields
	public GameObject Root; // 0x18

	// Methods

	// RVA: 0x84D190 Offset: 0x84B790 VA: 0x18084D190
	private void Start() { }

	// RVA: 0x84D250 Offset: 0x84B850 VA: 0x18084D250
	public void Toggle(bool state) { }

	// RVA: 0x84D2D0 Offset: 0x84B8D0 VA: 0x18084D2D0
	public void .ctor() { }

}

public class DemoPlaybackWidget : MonoBehaviour // TypeDefIndex: 10856
{	// Fields
	public RustSlider DemoProgress; // 0x18
	public RustText DemoName; // 0x20
	public RustText DemoDuration; // 0x28
	public RustText DemoCurrentTime; // 0x30
	public GameObject PausedRoot; // 0x38
	public GameObject PlayingRoot; // 0x40
	public RectTransform DemoPlaybackHandle; // 0x48
	public RectTransform ShotPlaybackWindow; // 0x50
	public RustButton LoopButton; // 0x58
	public GameObject ShotButtonRoot; // 0x60
	public RustText ShotNameText; // 0x68
	public GameObject ShotNameRoot; // 0x70
	public RectTransform ShotRecordWindow; // 0x78
	private bool blockProgressInput; // 0x80
	private bool isDraggingSlider; // 0x81
	private RealTimeSince lastDrag; // 0x84
	private bool pausedAtStartOfDrag; // 0x88

	// Methods

	// RVA: 0x84E0F0 Offset: 0x84C6F0 VA: 0x18084E0F0
	private void Update() { }

	// RVA: 0x84E040 Offset: 0x84C640 VA: 0x18084E040
	private void SetRectTransformAnchoredX(float xPos, RectTransform t) { }

	// RVA: 0x84DBE0 Offset: 0x84C1E0 VA: 0x18084DBE0
	public void OnClickedSlider(float value) { }

	// RVA: 0x84E0A0 Offset: 0x84C6A0 VA: 0x18084E0A0
	private void TimelineScrubCheck() { }

	// RVA: 0x84D670 Offset: 0x84BC70 VA: 0x18084D670
	public void OnClickedPlay() { }

	// RVA: 0x84D5E0 Offset: 0x84BBE0 VA: 0x18084D5E0
	public void OnClickedPause() { }

	// RVA: 0x84D330 Offset: 0x84B930 VA: 0x18084D330
	public void OnClickedBackToStart() { }

	// RVA: 0x84DEE0 Offset: 0x84C4E0 VA: 0x18084DEE0
	public void OnClickedToEnd() { }

	// RVA: 0x84D4B0 Offset: 0x84BAB0 VA: 0x18084D4B0
	public void OnClickedLoop() { }

	// RVA: 0x84D430 Offset: 0x84BA30 VA: 0x18084D430
	public void OnClickedCancelShot() { }

	// RVA: 0x84D540 Offset: 0x84BB40 VA: 0x18084D540
	public void OnClickedNextFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x7FF90 Offset: 0x7F390 VA: 0x18007FF90
	// RVA: 0x84EB30 Offset: 0x84D130 VA: 0x18084EB30
	private IEnumerator WaitAndPause() { }

	// RVA: 0x84DA00 Offset: 0x84C000 VA: 0x18084DA00
	public void OnClickedPreviousFrame() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class DemoPlaybackWidget.<WaitAndPause>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10857
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x859840 Offset: 0x857E40 VA: 0x180859840 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x859900 Offset: 0x857F00 VA: 0x180859900 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class DemoRootFade : MonoBehaviour // TypeDefIndex: 10858
{	// Fields
	public CanvasGroup Canvas; // 0x18
	public static bool ToggleHide; // 0x0

	// Methods

	// RVA: 0x84FE20 Offset: 0x84E420 VA: 0x18084FE20
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class DemoShotButton : RustButton, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 10859
{	// Fields
	public bool FireEventOnClicked; // 0x98

	// Methods

	// RVA: 0x84FFD0 Offset: 0x84E5D0 VA: 0x18084FFD0 Slot: 42
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x84FFF0 Offset: 0x84E5F0 VA: 0x18084FFF0 Slot: 43
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x84FFB0 Offset: 0x84E5B0 VA: 0x18084FFB0 Slot: 44
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x6F1F80 Offset: 0x6F0580 VA: 0x1806F1F80
	public void .ctor() { }

}

public class DemoShotEntry : MonoBehaviour, IDraggable // TypeDefIndex: 10860
{	// Fields
	public RustButton PlayButton; // 0x18
	public Sprite DragSprite; // 0x20
	public RustInput RenameInput; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DemoShot <CurrentShot>k__BackingField; // 0x30

	// Properties
	public DemoShot CurrentShot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_CurrentShot(DemoShot value) { }

	// RVA: 0x850580 Offset: 0x84EB80 VA: 0x180850580
	public void Populate(DemoShot shot, string folder) { }

	// RVA: 0x850290 Offset: 0x84E890 VA: 0x180850290
	public void OnClicked() { }

	// RVA: 0x8505E0 Offset: 0x84EBE0 VA: 0x1808505E0
	public void StopShot() { }

	// RVA: 0x8500E0 Offset: 0x84E6E0 VA: 0x1808500E0
	public void OnClickedDelete() { }

	// RVA: 0x850680 Offset: 0x84EC80 VA: 0x180850680
	public void TogglePlayingRoot(bool state) { }

	// RVA: 0x850550 Offset: 0x84EB50 VA: 0x180850550
	public void PopulateRename() { }

	// RVA: 0x850010 Offset: 0x84E610 VA: 0x180850010
	public void ApplyRename() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 4
	public object GetDragData() { }

	// RVA: 0x8500B0 Offset: 0x84E6B0 VA: 0x1808500B0 Slot: 5
	public string GetDragType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public Sprite GetDragSprite() { }

	// RVA: 0x8502F0 Offset: 0x84E8F0 VA: 0x1808502F0
	public void OnDroppedValue(object data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class DemoShotListFolderWidget : MonoBehaviour // TypeDefIndex: 10861
{	// Fields
	public RustButton FolderName; // 0x18
	public Transform ChildRoot; // 0x20
	public GameObject UpArrow; // 0x28
	public GameObject DownArrow; // 0x30
	public RustText CountText; // 0x38
	public GameObject OpenRoot; // 0x40
	public GameObject ModifyRoot; // 0x48
	public RustInput FolderRenameInput; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CurrentState>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <cachedFolderName>k__BackingField; // 0x60

	// Properties
	public bool CurrentState { get; set; }
	public string cachedFolderName { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5925C0 Offset: 0x590BC0 VA: 0x1805925C0
	public bool get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5925D0 Offset: 0x590BD0 VA: 0x1805925D0
	private void set_CurrentState(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public string get_cachedFolderName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	private void set_cachedFolderName(string value) { }

	// RVA: 0x8520E0 Offset: 0x8506E0 VA: 0x1808520E0
	public void Populate(string folderName, bool state) { }

	// RVA: 0x852200 Offset: 0x850800 VA: 0x180852200
	public void ToggleState() { }

	// RVA: 0x852210 Offset: 0x850810 VA: 0x180852210
	public void ToggleState(bool state) { }

	// RVA: 0x851A90 Offset: 0x850090 VA: 0x180851A90
	public void AddChild(DemoShotEntry shot) { }

	// RVA: 0x8522C0 Offset: 0x8508C0 VA: 0x1808522C0
	private void UpdateCountText() { }

	// RVA: 0x851DF0 Offset: 0x8503F0 VA: 0x180851DF0
	public void OnDroppedValue(object data) { }

	// RVA: 0x852040 Offset: 0x850640 VA: 0x180852040
	public void OnRightClick() { }

	// RVA: 0x851AE0 Offset: 0x8500E0 VA: 0x180851AE0
	public void OnClickedDeleteFolder() { }

	// RVA: 0x851C30 Offset: 0x850230 VA: 0x180851C30
	public void OnClickedRenameFolder() { }

	// RVA: 0x852350 Offset: 0x850950 VA: 0x180852350
	public void .ctor() { }

}

public class DemoShotListRootFolder : MonoBehaviour // TypeDefIndex: 10862
{	// Methods

	// RVA: 0x852360 Offset: 0x850960 VA: 0x180852360
	public void OnDroppedValue(object data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class DemoShotListWidget : SingletonComponent<DemoShotListWidget> // TypeDefIndex: 10863
{	// Fields
	public GameObjectRef ShotListEntry; // 0x18
	public GameObjectRef FolderEntry; // 0x20
	public Transform ShotListParent; // 0x28
	public RustInput FolderNameInput; // 0x30
	public GameObject ShotsRoot; // 0x38
	public GameObject NoShotsRoot; // 0x40
	public GameObject TopUpArrow; // 0x48
	public GameObject TopDownArrow; // 0x50
	public Canvas DragCanvas; // 0x58
	private Dictionary<string, List<DemoShot>> foundShots; // 0x60
	private List<DemoShotEntry> spawnedEntries; // 0x68
	private List<DemoShotListFolderWidget> spawnedFolders; // 0x70
	private bool isOpen; // 0x78

	// Properties
	private int TotalShotCount { get; }

	// Methods

	// RVA: 0x852E40 Offset: 0x851440 VA: 0x180852E40
	private void OnEnable() { }

	// RVA: 0x8533E0 Offset: 0x8519E0 VA: 0x1808533E0
	public void UpdateAvailableShots() { }

	// RVA: 0x853170 Offset: 0x851770 VA: 0x180853170
	public void SetCurrentlyPlaying(DemoShot shot) { }

	// RVA: 0x8544D0 Offset: 0x852AD0 VA: 0x1808544D0
	private int get_TotalShotCount() { }

	// RVA: 0x852A50 Offset: 0x851050 VA: 0x180852A50
	public string GetDefaultNewShotName() { }

	// RVA: 0x8527B0 Offset: 0x850DB0 VA: 0x1808527B0
	public void DeleteShot(DemoShot shotName) { }

	// RVA: 0x852FA0 Offset: 0x8515A0 VA: 0x180852FA0
	public void RenameShot(DemoShot shotToRename, string newName) { }

	// RVA: 0x8525B0 Offset: 0x850BB0 VA: 0x1808525B0
	public void CreateFolder() { }

	// RVA: 0x8532D0 Offset: 0x8518D0 VA: 0x1808532D0
	public void ToggleOpen(bool state) { }

	// RVA: 0x8532C0 Offset: 0x8518C0 VA: 0x1808532C0
	public void ToggleOpen() { }

	// RVA: 0x852900 Offset: 0x850F00 VA: 0x180852900
	public List<string> GetCurrentFolders() { }

	// RVA: 0x852C90 Offset: 0x851290 VA: 0x180852C90
	public void MoveShotToFolder(DemoShot shot, string targetFolder) { }

	// RVA: 0x852E50 Offset: 0x851450 VA: 0x180852E50
	public void RenameFolder(string oldName, string newName) { }

	// RVA: 0x8526B0 Offset: 0x850CB0 VA: 0x1808526B0
	public void DeleteFolder(string folderName) { }

	// RVA: 0x8543E0 Offset: 0x8529E0 VA: 0x1808543E0
	public void .ctor() { }

}

public class DemoShotRecordWidget : MonoBehaviour // TypeDefIndex: 10864
{	// Fields
	public RustInput NameInput; // 0x18
	public GameObject RecordingRoot; // 0x20
	public GameObject PreRecordingRoot; // 0x28
	public RustButton CountdownToggle; // 0x30
	public RustButton PauseOnSaveToggle; // 0x38
	public RustButton ReturnToStartToggle; // 0x40
	public RustButton RecordDofToggle; // 0x48
	public RustOption FolderDropdown; // 0x50
	public GameObject RecordingUnderlay; // 0x58
	public AudioSource CountdownAudio; // 0x60
	public GameObject ShotRecordTime; // 0x68
	public RustText ShotRecordTimeText; // 0x70
	public RustText ShotNameText; // 0x78
	public GameObject RecordingInProcessRoot; // 0x80
	public GameObject CountdownActiveRoot; // 0x88
	public GameObject CountdownActiveSliderRoot; // 0x90
	public RustSlider CountdownActiveSlider; // 0x98
	public RustText CountdownActiveText; // 0xA0
	public static DemoShotRecordWidget Instance; // 0x0

	// Methods

	// RVA: 0x856090 Offset: 0x854690 VA: 0x180856090
	private void Start() { }

	// RVA: 0x855D70 Offset: 0x854370 VA: 0x180855D70
	private void OnEnable() { }

	// RVA: 0x856280 Offset: 0x854880 VA: 0x180856280
	public void UpdateShotName() { }

	// RVA: 0x856310 Offset: 0x854910 VA: 0x180856310
	private void Update() { }

	// RVA: 0x855A90 Offset: 0x854090 VA: 0x180855A90
	public void OnClickedStartRecording() { }

	// RVA: 0x855A20 Offset: 0x854020 VA: 0x180855A20
	public void OnClickedFinish() { }

	// RVA: 0x856180 Offset: 0x854780 VA: 0x180856180
	public void Toggle(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class DemoText : MonoBehaviour // TypeDefIndex: 10865
{	// Fields
	public RustText TimeText; // 0x18
	public RustText TotalSecondText; // 0x20
	public RustText TimeScaleText; // 0x28
	public RustText FilenameText; // 0x30
	public RustText DateTimeText; // 0x38
	public RustText ParentText; // 0x40
	public RustText DofText; // 0x48
	public GameObject InternalRoot; // 0x50
	public GameObject ParentRoot; // 0x58
	public GameObject DofRoot; // 0x60

	// Methods

	// RVA: 0x971330 Offset: 0x96F930 VA: 0x180971330
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class DemoRecorder : SingletonComponent<DemoRecorder> // TypeDefIndex: 10870
{	// Fields
	public RustInput Input; // 0x18
	public GameObject RecordingUnderlay; // 0x20
	private bool IsOpen; // 0x28

	// Methods

	// RVA: 0x84F3C0 Offset: 0x84D9C0 VA: 0x18084F3C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x84F710 Offset: 0x84DD10 VA: 0x18084F710
	public void Open() { }

	// RVA: 0x84FBF0 Offset: 0x84E1F0 VA: 0x18084FBF0
	public void Update() { }

	// RVA: 0x84F4D0 Offset: 0x84DAD0 VA: 0x18084F4D0
	public void Close() { }

	// RVA: 0x84FB30 Offset: 0x84E130 VA: 0x18084FB30
	public void SubmitRecord() { }

	// RVA: 0x84FAB0 Offset: 0x84E0B0 VA: 0x18084FAB0
	public void Record() { }

	// RVA: 0x84FDC0 Offset: 0x84E3C0 VA: 0x18084FDC0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	private void <Close>b__6_0() { }

}

public class DemoRecorderProgress : SingletonComponent<DemoRecorderProgress> // TypeDefIndex: 10871
{	// Fields
	public RustText RecordingLabel; // 0x18
	public RustText ProgressLabel; // 0x20
	public GameObject RecordingUnderlay; // 0x28
	private CanvasGroup canvasGroup; // 0x30
	private NeedsCursor needsCursor; // 0x38

	// Methods

	// RVA: 0x84EB80 Offset: 0x84D180 VA: 0x18084EB80 Slot: 6
	protected override void Awake() { }

	// RVA: 0x84ED20 Offset: 0x84D320 VA: 0x18084ED20
	public void Open(string recordingName) { }

	// RVA: 0x84EF70 Offset: 0x84D570 VA: 0x18084EF70
	public void Update() { }

	// RVA: 0x84EC30 Offset: 0x84D230 VA: 0x18084EC30
	public void Close() { }

	// RVA: 0x84ECA0 Offset: 0x84D2A0 VA: 0x18084ECA0
	public void EnableCursor(bool enable) { }

	// RVA: 0x84EEC0 Offset: 0x84D4C0 VA: 0x18084EEC0
	public void Stop() { }

	// RVA: 0x84F360 Offset: 0x84D960 VA: 0x18084F360
	public void .ctor() { }

}

public class DemoItem : RustButton // TypeDefIndex: 11099
{	// Fields
	public Demos demos; // 0x98
	public int itemId; // 0xA0
	public RustText nameText; // 0xA8
	public RustText dateText; // 0xB0
	public RustText lengthText; // 0xB8

	// Methods

	// RVA: 0x84D100 Offset: 0x84B700 VA: 0x18084D100
	public void OnClicked() { }

	// RVA: 0x84CFE0 Offset: 0x84B5E0 VA: 0x18084CFE0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0x6F1F80 Offset: 0x6F0580 VA: 0x1806F1F80
	public void .ctor() { }

}

public class Demos : SingletonComponent<Demos>, VirtualScroll.IDataSource // TypeDefIndex: 11100
{	// Fields
	public VirtualScroll virtualScroll; // 0x18
	public GameObject deletePopup; // 0x20
	private readonly List<Demos.DemoInfo> _demoInfo; // 0x28
	private readonly List<Demos.DemoInfo> _sortedDemoInfo; // 0x30
	private DemoItem _selectedItem; // 0x38
	private string sortOrder; // 0x40

	// Methods

	// RVA: 0x971A50 Offset: 0x970050 VA: 0x180971A50 Slot: 6
	protected override void Awake() { }

	// RVA: 0x971C20 Offset: 0x970220 VA: 0x180971C20
	private void DeselectItem() { }

	// RVA: 0x972690 Offset: 0x970C90 VA: 0x180972690
	private void Populate() { }

	// RVA: 0x972980 Offset: 0x970F80 VA: 0x180972980
	private void Rebuild() { }

	// RVA: 0x972600 Offset: 0x970C00 VA: 0x180972600
	public void OrderBy(string strBy) { }

	// RVA: 0x971CD0 Offset: 0x9702D0 VA: 0x180971CD0 Slot: 8
	public int GetItemCount() { }

	// RVA: 0x972A20 Offset: 0x971020 VA: 0x180972A20 Slot: 9
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x971D10 Offset: 0x970310 VA: 0x180971D10
	private IOrderedEnumerable<Demos.DemoInfo> GetSortedInfo() { }

	// RVA: 0x9723A0 Offset: 0x9709A0 VA: 0x1809723A0
	public void OnItemClicked(DemoItem item) { }

	// RVA: 0x972320 Offset: 0x970920 VA: 0x180972320
	public void OnDeleteItem() { }

	// RVA: 0x971A70 Offset: 0x970070 VA: 0x180971A70
	public void DeleteItem() { }

	// RVA: 0x9724F0 Offset: 0x970AF0 VA: 0x1809724F0
	public void OnPlayItem() { }

	// RVA: 0x9725C0 Offset: 0x970BC0 VA: 0x1809725C0
	public void OpenDemosFolder() { }

	// RVA: 0x972A10 Offset: 0x971010 VA: 0x180972A10
	public void Refresh() { }

	// RVA: 0x972D90 Offset: 0x971390 VA: 0x180972D90
	public void .ctor() { }

}

private struct Demos.DemoInfo // TypeDefIndex: 11101
{	// Fields
	public string path; // 0x0
	public string name; // 0x8
	public DateTime date; // 0x10
	public TimeSpan length; // 0x18

	// Methods

	// RVA: 0xFAC30 Offset: 0xFA030 VA: 0x1800FAC30
	public void .ctor(string path, string name, DateTime date, TimeSpan length) { }

}

private sealed class Demos.<>c // TypeDefIndex: 11102
{	// Fields
	public static readonly Demos.<>c <>9; // 0x0
	public static Func<Demos.DemoInfo, string> <>9__14_0; // 0x8
	public static Func<Demos.DemoInfo, string> <>9__14_1; // 0x10
	public static Func<Demos.DemoInfo, DateTime> <>9__14_2; // 0x18
	public static Func<Demos.DemoInfo, DateTime> <>9__14_3; // 0x20
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_4; // 0x28
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_5; // 0x30
	public static Func<Demos.DemoInfo, string> <>9__14_6; // 0x38

	// Methods

	// RVA: 0x98CA80 Offset: 0x98B080 VA: 0x18098CA80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C8B0 Offset: 0x98AEB0 VA: 0x18098C8B0
	internal string <GetSortedInfo>b__14_0(Demos.DemoInfo x) { }

	// RVA: 0x98C8B0 Offset: 0x98AEB0 VA: 0x18098C8B0
	internal string <GetSortedInfo>b__14_1(Demos.DemoInfo x) { }

	// RVA: 0x98C8D0 Offset: 0x98AED0 VA: 0x18098C8D0
	internal DateTime <GetSortedInfo>b__14_2(Demos.DemoInfo x) { }

	// RVA: 0x98C8D0 Offset: 0x98AED0 VA: 0x18098C8D0
	internal DateTime <GetSortedInfo>b__14_3(Demos.DemoInfo x) { }

	// RVA: 0x98C8F0 Offset: 0x98AEF0 VA: 0x18098C8F0
	internal TimeSpan <GetSortedInfo>b__14_4(Demos.DemoInfo x) { }

	// RVA: 0x98C8F0 Offset: 0x98AEF0 VA: 0x18098C8F0
	internal TimeSpan <GetSortedInfo>b__14_5(Demos.DemoInfo x) { }

	// RVA: 0x98C8B0 Offset: 0x98AEB0 VA: 0x18098C8B0
	internal string <GetSortedInfo>b__14_6(Demos.DemoInfo x) { }

}

private sealed class Demos.<>c__DisplayClass17_0 // TypeDefIndex: 11103
{	// Fields
	public Demos.DemoInfo demoInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98CA60 Offset: 0x98B060 VA: 0x18098CA60
	internal bool <DeleteItem>b__0(Demos.DemoInfo x) { }

}

public class Demo : ConsoleSystem // TypeDefIndex: 11907
{	// Fields
	public static uint Version; // 0x0
	private static bool _hud; // 0x4
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float timescale; // 0x8
	private static bool renableNametags; // 0xC
	[ClientVar] // RVA: 0x96190 Offset: 0x95590 VA: 0x180096190
	public static bool autoDebugCam; // 0xD
	[ClientVar] // RVA: 0x96270 Offset: 0x95670 VA: 0x180096270
	public static bool compressShotKeyframes; // 0xE
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool showLocalPlayerNameTag; // 0xF

	// Properties
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool hud { get; set; }
	public static float TimeScale { get; }
	public static string lastRecordedDemoName { get; set; }

	// Methods

	// RVA: 0x6D9930 Offset: 0x6D7F30 VA: 0x1806D9930
	public static bool get_hud() { }

	// RVA: 0x6DB4C0 Offset: 0x6D9AC0 VA: 0x1806DB4C0
	public static void set_hud(bool value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DBBB0 Offset: 0x6DA1B0 VA: 0x1806DBBB0
	public static void togglehud(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D9890 Offset: 0x6D7E90 VA: 0x1806D9890
	public static float get_TimeScale() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6DACB0 Offset: 0x6D92B0 VA: 0x1806DACB0
	public static string record(string filename) { }

	[ClientVar] // RVA: 0x964E0 Offset: 0x958E0 VA: 0x1800964E0
	// RVA: 0x6DB300 Offset: 0x6D9900 VA: 0x1806DB300
	public static void recorder() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DB860 Offset: 0x6D9E60 VA: 0x1806DB860
	public static string stop() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D9E70 Offset: 0x6D8470 VA: 0x1806D9E70
	public static string play(string filename) { }

	// RVA: 0x6D93E0 Offset: 0x6D79E0 VA: 0x1806D93E0
	public static void TryRunDemoCfg(string demoName) { }

	[ClientVar] // RVA: 0x96670 Offset: 0x95A70 VA: 0x180096670
	// RVA: 0x6DB670 Offset: 0x6D9C70 VA: 0x1806DB670
	public static string skip(float seconds) { }

	[ClientVar] // RVA: 0x96760 Offset: 0x95B60 VA: 0x180096760
	// RVA: 0x6D99D0 Offset: 0x6D7FD0 VA: 0x1806D99D0
	public static string jump(float seconds) { }

	[ClientVar] // RVA: 0x968D0 Offset: 0x95CD0 VA: 0x1800968D0
	// RVA: 0x6DA6E0 Offset: 0x6D8CE0 VA: 0x1806DA6E0
	public static string playernames() { }

	[ClientVar] // RVA: 0x96A50 Offset: 0x95E50 VA: 0x180096A50
	// RVA: 0x6D9740 Offset: 0x6D7D40 VA: 0x1806D9740
	public static void browser() { }

	// RVA: 0x6D9990 Offset: 0x6D7F90 VA: 0x1806D9990
	public static string get_lastRecordedDemoName() { }

	// RVA: 0x6DB630 Offset: 0x6D9C30 VA: 0x1806DB630
	public static void set_lastRecordedDemoName(string value) { }

	[ClientVar] // RVA: 0x96AC0 Offset: 0x95EC0 VA: 0x180096AC0
	// RVA: 0x6DBAF0 Offset: 0x6DA0F0 VA: 0x1806DBAF0
	public static string toggleNVG(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x96B40 Offset: 0x95F40 VA: 0x180096B40
	// RVA: 0x6D9C20 Offset: 0x6D8220 VA: 0x1806D9C20
	public static string pause() { }

	[ClientVar] // RVA: 0x96C60 Offset: 0x96060 VA: 0x180096C60
	// RVA: 0x6DB370 Offset: 0x6D9970 VA: 0x1806DB370
	public static string resume() { }

	// RVA: 0x6D9D00 Offset: 0x6D8300 VA: 0x1806D9D00
	public static string playShot(DemoShot shot) { }

	[ClientVar] // RVA: 0x96E90 Offset: 0x96290 VA: 0x180096E90
	// RVA: 0x6DAC00 Offset: 0x6D9200 VA: 0x1806DAC00
	public static void readcfg() { }

	// RVA: 0x6D96E0 Offset: 0x6D7CE0 VA: 0x1806D96E0
	public void .ctor() { }

	// RVA: 0x6D9630 Offset: 0x6D7C30 VA: 0x1806D9630
	private static void .cctor() { }

}

public class Demo.Header : DemoHeader, IDemoHeader // TypeDefIndex: 11908
{	// Properties
	private long Network.IDemoHeader.Length { get; set; }

	// Methods

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 15
	private long Network.IDemoHeader.get_Length() { }

	// RVA: 0x6E6E10 Offset: 0x6E5410 VA: 0x1806E6E10 Slot: 16
	private void Network.IDemoHeader.set_Length(long value) { }

	// RVA: 0x6E6E20 Offset: 0x6E5420 VA: 0x1806E6E20 Slot: 17
	public void Write(BinaryWriter writer) { }

	// RVA: 0x6E6ED0 Offset: 0x6E54D0 VA: 0x1806E6ED0
	public void .ctor() { }

}

