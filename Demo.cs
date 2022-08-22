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

	// RVA: 0x1E60790 Offset: 0x1E5ED90 VA: 0x181E60790
	public static void ResetToPool(DemoHeader instance) { }

	// RVA: 0x1E604C0 Offset: 0x1E5EAC0 VA: 0x181E604C0
	public void ResetToPool() { }

	// RVA: 0x1E60400 Offset: 0x1E5EA00 VA: 0x181E60400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5EDB0 Offset: 0x1E5D3B0 VA: 0x181E5EDB0
	public void CopyTo(DemoHeader instance) { }

	// RVA: 0x1E5EF50 Offset: 0x1E5D550 VA: 0x181E5EF50
	public DemoHeader Copy() { }

	// RVA: 0x1E5FDD0 Offset: 0x1E5E3D0 VA: 0x181E5FDD0
	public static DemoHeader Deserialize(Stream stream) { }

	// RVA: 0x1E5F140 Offset: 0x1E5D740 VA: 0x181E5F140
	public static DemoHeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5F720 Offset: 0x1E5DD20 VA: 0x181E5F720
	public static DemoHeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5FE50 Offset: 0x1E5E450 VA: 0x181E5FE50
	public static DemoHeader Deserialize(byte[] buffer) { }

	// RVA: 0x1E60480 Offset: 0x1E5EA80 VA: 0x181E60480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E61A50 Offset: 0x1E60050 VA: 0x181E61A50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E61A70 Offset: 0x1E60070 VA: 0x181E61A70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoHeader previous) { }

	// RVA: 0x1E604A0 Offset: 0x1E5EAA0 VA: 0x181E604A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5FCD0 Offset: 0x1E5E2D0 VA: 0x181E5FCD0
	public static DemoHeader Deserialize(byte[] buffer, DemoHeader instance, bool isDelta = False) { }

	// RVA: 0x1E5FF70 Offset: 0x1E5E570 VA: 0x181E5FF70
	public static DemoHeader Deserialize(Stream stream, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E5F1C0 Offset: 0x1E5D7C0 VA: 0x181E5F1C0
	public static DemoHeader DeserializeLengthDelimited(Stream stream, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E5F7B0 Offset: 0x1E5DDB0 VA: 0x181E5F7B0
	public static DemoHeader DeserializeLength(Stream stream, int length, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E60A50 Offset: 0x1E5F050 VA: 0x181E60A50
	public static void SerializeDelta(Stream stream, DemoHeader instance, DemoHeader previous) { }

	// RVA: 0x1E61460 Offset: 0x1E5FA60 VA: 0x181E61460
	public static void Serialize(Stream stream, DemoHeader instance) { }

	// RVA: 0x1E61A40 Offset: 0x1E60040 VA: 0x181E61A40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E61A50 Offset: 0x1E60050 VA: 0x181E61A50
	public void ToProto(Stream stream) { }

	// RVA: 0x1E61350 Offset: 0x1E5F950 VA: 0x181E61350
	public static byte[] SerializeToBytes(DemoHeader instance) { }

	// RVA: 0x1E612A0 Offset: 0x1E5F8A0 VA: 0x181E612A0
	public static void SerializeLengthDelimited(Stream stream, DemoHeader instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E6CB30 Offset: 0x1E6B130 VA: 0x181E6CB30
	public static void ResetToPool(DemoShot instance) { }

	// RVA: 0x1E6CDE0 Offset: 0x1E6B3E0 VA: 0x181E6CDE0
	public void ResetToPool() { }

	// RVA: 0x1E6CA70 Offset: 0x1E6B070 VA: 0x181E6CA70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6B410 Offset: 0x1E69A10 VA: 0x181E6B410
	public void CopyTo(DemoShot instance) { }

	// RVA: 0x1E6B730 Offset: 0x1E69D30 VA: 0x181E6B730
	public DemoShot Copy() { }

	// RVA: 0x1E6C350 Offset: 0x1E6A950 VA: 0x181E6C350
	public static DemoShot Deserialize(Stream stream) { }

	// RVA: 0x1E6B7B0 Offset: 0x1E69DB0 VA: 0x181E6B7B0
	public static DemoShot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6C2C0 Offset: 0x1E6A8C0 VA: 0x181E6C2C0
	public static DemoShot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6C3D0 Offset: 0x1E6A9D0 VA: 0x181E6C3D0
	public static DemoShot Deserialize(byte[] buffer) { }

	// RVA: 0x1E6CAF0 Offset: 0x1E6B0F0 VA: 0x181E6CAF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6E550 Offset: 0x1E6CB50 VA: 0x181E6E550 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6E570 Offset: 0x1E6CB70 VA: 0x181E6E570 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShot previous) { }

	// RVA: 0x1E6CB10 Offset: 0x1E6B110 VA: 0x181E6CB10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6C4F0 Offset: 0x1E6AAF0 VA: 0x181E6C4F0
	public static DemoShot Deserialize(byte[] buffer, DemoShot instance, bool isDelta = False) { }

	// RVA: 0x1E6C5F0 Offset: 0x1E6ABF0 VA: 0x181E6C5F0
	public static DemoShot Deserialize(Stream stream, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6B830 Offset: 0x1E69E30 VA: 0x181E6B830
	public static DemoShot DeserializeLengthDelimited(Stream stream, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6BD90 Offset: 0x1E6A390 VA: 0x181E6BD90
	public static DemoShot DeserializeLength(Stream stream, int length, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6D090 Offset: 0x1E6B690 VA: 0x181E6D090
	public static void SerializeDelta(Stream stream, DemoShot instance, DemoShot previous) { }

	// RVA: 0x1E6DC40 Offset: 0x1E6C240 VA: 0x181E6DC40
	public static void Serialize(Stream stream, DemoShot instance) { }

	// RVA: 0x1E6E540 Offset: 0x1E6CB40 VA: 0x181E6E540
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6E550 Offset: 0x1E6CB50 VA: 0x181E6E550
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6DB30 Offset: 0x1E6C130 VA: 0x181E6DB30
	public static byte[] SerializeToBytes(DemoShot instance) { }

	// RVA: 0x1E6DA80 Offset: 0x1E6C080 VA: 0x181E6DA80
	public static void SerializeLengthDelimited(Stream stream, DemoShot instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class DemoShotVectorTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6467
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotVectorKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E6AC70 Offset: 0x1E69270 VA: 0x181E6AC70
	public static void ResetToPool(DemoShotVectorTrack instance) { }

	// RVA: 0x1E6AB80 Offset: 0x1E69180 VA: 0x181E6AB80
	public void ResetToPool() { }

	// RVA: 0x1E6AAC0 Offset: 0x1E690C0 VA: 0x181E6AAC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E69DC0 Offset: 0x1E683C0 VA: 0x181E69DC0
	public void CopyTo(DemoShotVectorTrack instance) { }

	// RVA: 0x1E69F00 Offset: 0x1E68500 VA: 0x181E69F00
	public DemoShotVectorTrack Copy() { }

	// RVA: 0x1E6AA40 Offset: 0x1E69040 VA: 0x181E6AA40
	public static DemoShotVectorTrack Deserialize(Stream stream) { }

	// RVA: 0x1E6A260 Offset: 0x1E68860 VA: 0x181E6A260
	public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6A2E0 Offset: 0x1E688E0 VA: 0x181E6A2E0
	public static DemoShotVectorTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6A920 Offset: 0x1E68F20 VA: 0x181E6A920
	public static DemoShotVectorTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E6AB40 Offset: 0x1E69140 VA: 0x181E6AB40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6B3D0 Offset: 0x1E699D0 VA: 0x181E6B3D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6B3F0 Offset: 0x1E699F0 VA: 0x181E6B3F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotVectorTrack previous) { }

	// RVA: 0x1E6AB60 Offset: 0x1E69160 VA: 0x181E6AB60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6A620 Offset: 0x1E68C20 VA: 0x181E6A620
	public static DemoShotVectorTrack Deserialize(byte[] buffer, DemoShotVectorTrack instance, bool isDelta = False) { }

	// RVA: 0x1E6A720 Offset: 0x1E68D20 VA: 0x181E6A720
	public static DemoShotVectorTrack Deserialize(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E69F80 Offset: 0x1E68580 VA: 0x181E69F80
	public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E6A370 Offset: 0x1E68970 VA: 0x181E6A370
	public static DemoShotVectorTrack DeserializeLength(Stream stream, int length, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E6AD60 Offset: 0x1E69360 VA: 0x181E6AD60
	public static void SerializeDelta(Stream stream, DemoShotVectorTrack instance, DemoShotVectorTrack previous) { }

	// RVA: 0x1E6B180 Offset: 0x1E69780 VA: 0x181E6B180
	public static void Serialize(Stream stream, DemoShotVectorTrack instance) { }

	// RVA: 0x1E6B3C0 Offset: 0x1E699C0 VA: 0x181E6B3C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6B3D0 Offset: 0x1E699D0 VA: 0x181E6B3D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6B070 Offset: 0x1E69670 VA: 0x181E6B070
	public static byte[] SerializeToBytes(DemoShotVectorTrack instance) { }

	// RVA: 0x1E6AFC0 Offset: 0x1E695C0 VA: 0x181E6AFC0
	public static void SerializeLengthDelimited(Stream stream, DemoShotVectorTrack instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public struct DemoShotVectorKeyframe : IProto // TypeDefIndex: 6468
{	// Fields
	public float keyframeTime; // 0x0
	public Vector3 keyFrameValue; // 0x4

	// Methods

	// RVA: 0x18BB960 Offset: 0x18B9F60 VA: 0x1818BB960
	public static void ResetToPool(DemoShotVectorKeyframe instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(DemoShotVectorKeyframe instance) { }

	// RVA: 0xF2950 Offset: 0xF1D50 VA: 0x1800F2950
	public DemoShotVectorKeyframe Copy() { }

	// RVA: 0x1E697A0 Offset: 0x1E67DA0 VA: 0x181E697A0
	public static DemoShotVectorKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E68ED0 Offset: 0x1E674D0 VA: 0x181E68ED0
	public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E69170 Offset: 0x1E67770 VA: 0x181E69170
	public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E693F0 Offset: 0x1E679F0 VA: 0x181E693F0
	public static DemoShotVectorKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231E50 Offset: 0x231250 VA: 0x180231E50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231ED0 Offset: 0x2312D0 VA: 0x180231ED0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231F00 Offset: 0x231300 VA: 0x180231F00
	public void WriteToStreamDelta(Stream stream, DemoShotVectorKeyframe previous) { }

	// RVA: 0x231E80 Offset: 0x231280 VA: 0x180231E80 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E69670 Offset: 0x1E67C70 VA: 0x181E69670
	public static DemoShotVectorKeyframe Deserialize(byte[] buffer, ref DemoShotVectorKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E694F0 Offset: 0x1E67AF0 VA: 0x181E694F0
	public static DemoShotVectorKeyframe Deserialize(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E68F10 Offset: 0x1E67510 VA: 0x181E68F10
	public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E691B0 Offset: 0x1E677B0 VA: 0x181E691B0
	public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E697E0 Offset: 0x1E67DE0 VA: 0x181E697E0
	public static void SerializeDelta(Stream stream, DemoShotVectorKeyframe instance, DemoShotVectorKeyframe previous) { }

	// RVA: 0x1E69C30 Offset: 0x1E68230 VA: 0x181E69C30
	public static void Serialize(Stream stream, DemoShotVectorKeyframe instance) { }

	// RVA: 0x231EB0 Offset: 0x2312B0 VA: 0x180231EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x231ED0 Offset: 0x2312D0 VA: 0x180231ED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E69B10 Offset: 0x1E68110 VA: 0x181E69B10
	public static byte[] SerializeToBytes(DemoShotVectorKeyframe instance) { }

	// RVA: 0x1E69A60 Offset: 0x1E68060 VA: 0x181E69A60
	public static void SerializeLengthDelimited(Stream stream, DemoShotVectorKeyframe instance) { }

}

public class DemoShotFloatTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6469
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotFloatKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E63780 Offset: 0x1E61D80 VA: 0x181E63780
	public static void ResetToPool(DemoShotFloatTrack instance) { }

	// RVA: 0x1E63870 Offset: 0x1E61E70 VA: 0x181E63870
	public void ResetToPool() { }

	// RVA: 0x1E636C0 Offset: 0x1E61CC0 VA: 0x181E636C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E626E0 Offset: 0x1E60CE0 VA: 0x181E626E0
	public void CopyTo(DemoShotFloatTrack instance) { }

	// RVA: 0x1E627F0 Offset: 0x1E60DF0 VA: 0x181E627F0
	public DemoShotFloatTrack Copy() { }

	// RVA: 0x1E631E0 Offset: 0x1E617E0 VA: 0x181E631E0
	public static DemoShotFloatTrack Deserialize(Stream stream) { }

	// RVA: 0x1E62B40 Offset: 0x1E61140 VA: 0x181E62B40
	public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E62BC0 Offset: 0x1E611C0 VA: 0x181E62BC0
	public static DemoShotFloatTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E63400 Offset: 0x1E61A00 VA: 0x181E63400
	public static DemoShotFloatTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E63740 Offset: 0x1E61D40 VA: 0x181E63740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E63FA0 Offset: 0x1E625A0 VA: 0x181E63FA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E63FC0 Offset: 0x1E625C0 VA: 0x181E63FC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotFloatTrack previous) { }

	// RVA: 0x1E63760 Offset: 0x1E61D60 VA: 0x181E63760 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E630E0 Offset: 0x1E616E0 VA: 0x181E630E0
	public static DemoShotFloatTrack Deserialize(byte[] buffer, DemoShotFloatTrack instance, bool isDelta = False) { }

	// RVA: 0x1E62EF0 Offset: 0x1E614F0 VA: 0x181E62EF0
	public static DemoShotFloatTrack Deserialize(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E62870 Offset: 0x1E60E70 VA: 0x181E62870
	public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E62C50 Offset: 0x1E61250 VA: 0x181E62C50
	public static DemoShotFloatTrack DeserializeLength(Stream stream, int length, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E63960 Offset: 0x1E61F60 VA: 0x181E63960
	public static void SerializeDelta(Stream stream, DemoShotFloatTrack instance, DemoShotFloatTrack previous) { }

	// RVA: 0x1E63D60 Offset: 0x1E62360 VA: 0x181E63D60
	public static void Serialize(Stream stream, DemoShotFloatTrack instance) { }

	// RVA: 0x1E63F90 Offset: 0x1E62590 VA: 0x181E63F90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E63FA0 Offset: 0x1E625A0 VA: 0x181E63FA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E63C50 Offset: 0x1E62250 VA: 0x181E63C50
	public static byte[] SerializeToBytes(DemoShotFloatTrack instance) { }

	// RVA: 0x1E63BA0 Offset: 0x1E621A0 VA: 0x181E63BA0
	public static void SerializeLengthDelimited(Stream stream, DemoShotFloatTrack instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public struct DemoShotFloatKeyframe : IProto // TypeDefIndex: 6470
{	// Fields
	public float keyframeTime; // 0x0
	public float keyFrameValue; // 0x4

	// Methods

	// RVA: 0x1E4C1C0 Offset: 0x1E4A7C0 VA: 0x181E4C1C0
	public static void ResetToPool(DemoShotFloatKeyframe instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(DemoShotFloatKeyframe instance) { }

	// RVA: 0xF22B0 Offset: 0xF16B0 VA: 0x1800F22B0
	public DemoShotFloatKeyframe Copy() { }

	// RVA: 0x1E62140 Offset: 0x1E60740 VA: 0x181E62140
	public static DemoShotFloatKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E61A90 Offset: 0x1E60090 VA: 0x181E61A90
	public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E61F20 Offset: 0x1E60520 VA: 0x181E61F20
	public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E61F50 Offset: 0x1E60550 VA: 0x181E61F50
	public static DemoShotFloatKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231AD0 Offset: 0x230ED0 VA: 0x180231AD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231B30 Offset: 0x230F30 VA: 0x180231B30 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231B50 Offset: 0x230F50 VA: 0x180231B50
	public void WriteToStreamDelta(Stream stream, DemoShotFloatKeyframe previous) { }

	// RVA: 0x231AF0 Offset: 0x230EF0 VA: 0x180231AF0 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E62040 Offset: 0x1E60640 VA: 0x181E62040
	public static DemoShotFloatKeyframe Deserialize(byte[] buffer, ref DemoShotFloatKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E62170 Offset: 0x1E60770 VA: 0x181E62170
	public static DemoShotFloatKeyframe Deserialize(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E61AC0 Offset: 0x1E600C0 VA: 0x181E61AC0
	public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E61D00 Offset: 0x1E60300 VA: 0x181E61D00
	public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E622E0 Offset: 0x1E608E0 VA: 0x181E622E0
	public static void SerializeDelta(Stream stream, DemoShotFloatKeyframe instance, DemoShotFloatKeyframe previous) { }

	// RVA: 0x1E62600 Offset: 0x1E60C00 VA: 0x181E62600
	public static void Serialize(Stream stream, DemoShotFloatKeyframe instance) { }

	// RVA: 0x231B10 Offset: 0x230F10 VA: 0x180231B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x231B30 Offset: 0x230F30 VA: 0x180231B30
	public void ToProto(Stream stream) { }

	// RVA: 0x1E624E0 Offset: 0x1E60AE0 VA: 0x181E624E0
	public static byte[] SerializeToBytes(DemoShotFloatKeyframe instance) { }

	// RVA: 0x1E62430 Offset: 0x1E60A30 VA: 0x181E62430
	public static void SerializeLengthDelimited(Stream stream, DemoShotFloatKeyframe instance) { }

}

public class DemoShotQuaternionTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6471
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotQuaternionKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E68600 Offset: 0x1E66C00 VA: 0x181E68600
	public static void ResetToPool(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E686F0 Offset: 0x1E66CF0 VA: 0x181E686F0
	public void ResetToPool() { }

	// RVA: 0x1E68540 Offset: 0x1E66B40 VA: 0x181E68540 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E67800 Offset: 0x1E65E00 VA: 0x181E67800
	public void CopyTo(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E67910 Offset: 0x1E65F10 VA: 0x181E67910
	public DemoShotQuaternionTrack Copy() { }

	// RVA: 0x1E684C0 Offset: 0x1E66AC0 VA: 0x181E684C0
	public static DemoShotQuaternionTrack Deserialize(Stream stream) { }

	// RVA: 0x1E67C90 Offset: 0x1E66290 VA: 0x181E67C90
	public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E67FF0 Offset: 0x1E665F0 VA: 0x181E67FF0
	public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E68080 Offset: 0x1E66680 VA: 0x181E68080
	public static DemoShotQuaternionTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E685C0 Offset: 0x1E66BC0 VA: 0x181E685C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E68E90 Offset: 0x1E67490 VA: 0x181E68E90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E68EB0 Offset: 0x1E674B0 VA: 0x181E68EB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotQuaternionTrack previous) { }

	// RVA: 0x1E685E0 Offset: 0x1E66BE0 VA: 0x181E685E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E681A0 Offset: 0x1E667A0 VA: 0x181E681A0
	public static DemoShotQuaternionTrack Deserialize(byte[] buffer, DemoShotQuaternionTrack instance, bool isDelta = False) { }

	// RVA: 0x1E682A0 Offset: 0x1E668A0 VA: 0x181E682A0
	public static DemoShotQuaternionTrack Deserialize(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E67990 Offset: 0x1E65F90 VA: 0x181E67990
	public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E67D10 Offset: 0x1E66310 VA: 0x181E67D10
	public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E687E0 Offset: 0x1E66DE0 VA: 0x181E687E0
	public static void SerializeDelta(Stream stream, DemoShotQuaternionTrack instance, DemoShotQuaternionTrack previous) { }

	// RVA: 0x1E68C20 Offset: 0x1E67220 VA: 0x181E68C20
	public static void Serialize(Stream stream, DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E68E80 Offset: 0x1E67480 VA: 0x181E68E80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E68E90 Offset: 0x1E67490 VA: 0x181E68E90
	public void ToProto(Stream stream) { }

	// RVA: 0x1E68B10 Offset: 0x1E67110 VA: 0x181E68B10
	public static byte[] SerializeToBytes(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E68A60 Offset: 0x1E67060 VA: 0x181E68A60
	public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1E66CE0 Offset: 0x1E652E0 VA: 0x181E66CE0
	public static DemoShotQuaternionKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E66640 Offset: 0x1E64C40 VA: 0x181E66640
	public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E669A0 Offset: 0x1E64FA0 VA: 0x181E669A0
	public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E66E50 Offset: 0x1E65450 VA: 0x181E66E50
	public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231D40 Offset: 0x231140 VA: 0x180231D40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231DD0 Offset: 0x2311D0 VA: 0x180231DD0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231E00 Offset: 0x231200 VA: 0x180231E00
	public void WriteToStreamDelta(Stream stream, DemoShotQuaternionKeyframe previous) { }

	// RVA: 0x231D70 Offset: 0x231170 VA: 0x180231D70 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E66D20 Offset: 0x1E65320 VA: 0x181E66D20
	public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer, ref DemoShotQuaternionKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E66F60 Offset: 0x1E65560 VA: 0x181E66F60
	public static DemoShotQuaternionKeyframe Deserialize(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E66680 Offset: 0x1E64C80 VA: 0x181E66680
	public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E669E0 Offset: 0x1E64FE0 VA: 0x181E669E0
	public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E671A0 Offset: 0x1E657A0 VA: 0x181E671A0
	public static void SerializeDelta(Stream stream, DemoShotQuaternionKeyframe instance, DemoShotQuaternionKeyframe previous) { }

	// RVA: 0x1E67670 Offset: 0x1E65C70 VA: 0x181E67670
	public static void Serialize(Stream stream, DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x231DA0 Offset: 0x2311A0 VA: 0x180231DA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x231DD0 Offset: 0x2311D0 VA: 0x180231DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E67540 Offset: 0x1E65B40 VA: 0x181E67540
	public static byte[] SerializeToBytes(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x1E67480 Offset: 0x1E65A80 VA: 0x181E67480
	public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionKeyframe instance) { }

}

public class DemoShotParentTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6473
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong parentId; // 0x18
	public List<DemoShotParentKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E65DA0 Offset: 0x1E643A0 VA: 0x181E65DA0
	public static void ResetToPool(DemoShotParentTrack instance) { }

	// RVA: 0x1E65E90 Offset: 0x1E64490 VA: 0x181E65E90
	public void ResetToPool() { }

	// RVA: 0x1E65CE0 Offset: 0x1E642E0 VA: 0x181E65CE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E64F90 Offset: 0x1E63590 VA: 0x181E64F90
	public void CopyTo(DemoShotParentTrack instance) { }

	// RVA: 0x1E65120 Offset: 0x1E63720 VA: 0x181E65120
	public DemoShotParentTrack Copy() { }

	// RVA: 0x1E65A60 Offset: 0x1E64060 VA: 0x181E65A60
	public static DemoShotParentTrack Deserialize(Stream stream) { }

	// RVA: 0x1E651A0 Offset: 0x1E637A0 VA: 0x181E651A0
	public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E65500 Offset: 0x1E63B00 VA: 0x181E65500
	public static DemoShotParentTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E65940 Offset: 0x1E63F40 VA: 0x181E65940
	public static DemoShotParentTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E65D60 Offset: 0x1E64360 VA: 0x181E65D60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E66600 Offset: 0x1E64C00 VA: 0x181E66600 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E66620 Offset: 0x1E64C20 VA: 0x181E66620 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotParentTrack previous) { }

	// RVA: 0x1E65D80 Offset: 0x1E64380 VA: 0x181E65D80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E65840 Offset: 0x1E63E40 VA: 0x181E65840
	public static DemoShotParentTrack Deserialize(byte[] buffer, DemoShotParentTrack instance, bool isDelta = False) { }

	// RVA: 0x1E65AE0 Offset: 0x1E640E0 VA: 0x181E65AE0
	public static DemoShotParentTrack Deserialize(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E65220 Offset: 0x1E63820 VA: 0x181E65220
	public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E65590 Offset: 0x1E63B90 VA: 0x181E65590
	public static DemoShotParentTrack DeserializeLength(Stream stream, int length, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E65F80 Offset: 0x1E64580 VA: 0x181E65F80
	public static void SerializeDelta(Stream stream, DemoShotParentTrack instance, DemoShotParentTrack previous) { }

	// RVA: 0x1E663B0 Offset: 0x1E649B0 VA: 0x181E663B0
	public static void Serialize(Stream stream, DemoShotParentTrack instance) { }

	// RVA: 0x1E665F0 Offset: 0x1E64BF0 VA: 0x181E665F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E66600 Offset: 0x1E64C00 VA: 0x181E66600
	public void ToProto(Stream stream) { }

	// RVA: 0x1E662A0 Offset: 0x1E648A0 VA: 0x181E662A0
	public static byte[] SerializeToBytes(DemoShotParentTrack instance) { }

	// RVA: 0x1E661F0 Offset: 0x1E647F0 VA: 0x181E661F0
	public static void SerializeLengthDelimited(Stream stream, DemoShotParentTrack instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public struct DemoShotParentKeyframe : IProto // TypeDefIndex: 6474
{	// Fields
	public float keyframeTime; // 0x0
	public uint keyFrameParentId; // 0x4
	public string keyFrameParentName; // 0x8

	// Methods

	// RVA: 0x1E64990 Offset: 0x1E62F90 VA: 0x181E64990
	public static void ResetToPool(DemoShotParentKeyframe instance) { }

	// RVA: 0x231B70 Offset: 0x230F70 VA: 0x180231B70
	public void CopyTo(DemoShotParentKeyframe instance) { }

	// RVA: 0x231BA0 Offset: 0x230FA0 VA: 0x180231BA0
	public DemoShotParentKeyframe Copy() { }

	// RVA: 0x1E64570 Offset: 0x1E62B70 VA: 0x181E64570
	public static DemoShotParentKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E64280 Offset: 0x1E62880 VA: 0x181E64280
	public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E642C0 Offset: 0x1E628C0 VA: 0x181E642C0
	public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E645B0 Offset: 0x1E62BB0 VA: 0x181E645B0
	public static DemoShotParentKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231BE0 Offset: 0x230FE0 VA: 0x180231BE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231C60 Offset: 0x231060 VA: 0x180231C60 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231C90 Offset: 0x231090 VA: 0x180231C90
	public void WriteToStreamDelta(Stream stream, DemoShotParentKeyframe previous) { }

	// RVA: 0x231C10 Offset: 0x231010 VA: 0x180231C10 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E646B0 Offset: 0x1E62CB0 VA: 0x181E646B0
	public static DemoShotParentKeyframe Deserialize(byte[] buffer, ref DemoShotParentKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E647E0 Offset: 0x1E62DE0 VA: 0x181E647E0
	public static DemoShotParentKeyframe Deserialize(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E63FE0 Offset: 0x1E625E0 VA: 0x181E63FE0
	public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E64300 Offset: 0x1E62900 VA: 0x181E64300
	public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E649E0 Offset: 0x1E62FE0 VA: 0x181E649E0
	public static void SerializeDelta(Stream stream, DemoShotParentKeyframe instance, DemoShotParentKeyframe previous) { }

	// RVA: 0x1E64DF0 Offset: 0x1E633F0 VA: 0x181E64DF0
	public static void Serialize(Stream stream, DemoShotParentKeyframe instance) { }

	// RVA: 0x231C40 Offset: 0x231040 VA: 0x180231C40
	public byte[] ToProtoBytes() { }

	// RVA: 0x231C60 Offset: 0x231060 VA: 0x180231C60
	public void ToProto(Stream stream) { }

	// RVA: 0x1E64CD0 Offset: 0x1E632D0 VA: 0x181E64CD0
	public static byte[] SerializeToBytes(DemoShotParentKeyframe instance) { }

	// RVA: 0x1E64C20 Offset: 0x1E63220 VA: 0x181E64C20
	public static void SerializeLengthDelimited(Stream stream, DemoShotParentKeyframe instance) { }

}

public class DemoClient : Client, IDisposable // TypeDefIndex: 6692
{	// Fields
	protected Reader demoFile; // 0x70

	// Properties
	public override bool IsPlaying { get; }
	public bool PlayingFinished { get; }

	// Methods

	// RVA: 0x220EC60 Offset: 0x220D260 VA: 0x18220EC60
	public void .ctor(Reader demoFile) { }

	// RVA: 0x220E510 Offset: 0x220CB10 VA: 0x18220E510 Slot: 14
	public virtual void Dispose() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_IsPlaying() { }

	// RVA: 0x220EE10 Offset: 0x220D410 VA: 0x18220EE10
	public bool get_PlayingFinished() { }

	// RVA: 0x220EB40 Offset: 0x220D140 VA: 0x18220EB40
	public void UpdatePlayback(long frameTime) { }

	// RVA: 0x220EAA0 Offset: 0x220D0A0 VA: 0x18220EAA0
	private bool PlaybackPacket() { }

	// RVA: 0x220E540 Offset: 0x220CB40 VA: 0x18220E540
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
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_CurrentShot(DemoShot value) { }

	// RVA: 0x855290 Offset: 0x853890 VA: 0x180855290
	public static bool get_IsPlayingShot() { }

	// RVA: 0x8551A0 Offset: 0x8537A0 VA: 0x1808551A0
	public float get_CurrentShotTime() { }

	// RVA: 0x8546B0 Offset: 0x852CB0 VA: 0x1808546B0
	public void Setup(DemoShot shot) { }

	// RVA: 0x854560 Offset: 0x852B60 VA: 0x180854560
	public void PlayFromStart() { }

	// RVA: 0x8544E0 Offset: 0x852AE0 VA: 0x1808544E0
	public void PauseShot() { }

	// RVA: 0x8545C0 Offset: 0x852BC0 VA: 0x1808545C0
	public void ResumeShot() { }

	// RVA: 0x854050 Offset: 0x852650 VA: 0x180854050
	public void EndShot() { }

	// RVA: 0x854880 Offset: 0x852E80 VA: 0x180854880
	private void Update() { }

	// RVA: 0x854360 Offset: 0x852960 VA: 0x180854360
	private void OnDrawGizmosSelected() { }

	// RVA: 0x855180 Offset: 0x853780 VA: 0x180855180
	public string get_CurrentShotName() { }

	// RVA: 0x855370 Offset: 0x853970 VA: 0x180855370
	public float get_ShotPlaybackProgress() { }

	// RVA: 0x855350 Offset: 0x853950 VA: 0x180855350
	public float get_ShotLength() { }

	// RVA: 0x855320 Offset: 0x853920 VA: 0x180855320
	public float get_ShotEndTime() { }

	// RVA: 0x855240 Offset: 0x853840 VA: 0x180855240
	public bool get_IsPaused() { }

	// RVA: 0x855160 Offset: 0x853760 VA: 0x180855160
	public DemoShotVectorTrack get_CameraPositionTrack() { }

	// RVA: 0x8553A0 Offset: 0x8539A0 VA: 0x1808553A0
	public float get_ShotStartTime() { }

	// RVA: 0x855220 Offset: 0x853820 VA: 0x180855220
	public bool get_HasDofData() { }

	// RVA: 0x854610 Offset: 0x852C10 VA: 0x180854610
	public void SetShotTime(float newTime) { }

	// RVA: 0x853FA0 Offset: 0x8525A0 VA: 0x180853FA0
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
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public RealTimeUntil get_CountdownEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	private void set_CountdownEnds(RealTimeUntil value) { }

	// RVA: 0x8585D0 Offset: 0x856BD0 VA: 0x1808585D0
	public bool get_IsInCountdown() { }

	// RVA: 0x856160 Offset: 0x854760 VA: 0x180856160
	public static void CreateNewShot(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	// RVA: 0x858540 Offset: 0x856B40 VA: 0x180858540
	public float get_CurrentShotTime() { }

	// RVA: 0x858520 Offset: 0x856B20 VA: 0x180858520
	public string get_CurrentShotName() { }

	// RVA: 0x8585F0 Offset: 0x856BF0 VA: 0x1808585F0
	public float get_ShotStartTime() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6670 Offset: 0xD5A70 VA: 0x1800D6670
	// RVA: 0x8582F0 Offset: 0x8568F0 VA: 0x1808582F0
	private IEnumerator StartRecording(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	// RVA: 0x8560F0 Offset: 0x8546F0 VA: 0x1808560F0
	public void CancelRecording() { }

	// RVA: 0x8562A0 Offset: 0x8548A0 VA: 0x1808562A0
	public void FinishRecording() { }

	// RVA: 0x856ED0 Offset: 0x8554D0 VA: 0x180856ED0
	public static string GetShotDirectory(string demoName, bool createDirectory = False) { }

	// RVA: 0x856960 Offset: 0x854F60 VA: 0x180856960
	public static string GetFilePath(string shotName, string demoName, string folderName, bool createDirectory = False) { }

	// RVA: 0x856A50 Offset: 0x855050 VA: 0x180856A50
	public static Dictionary<string, List<string>> GetPathsOfAllShots(string demoName) { }

	// RVA: 0x858110 Offset: 0x856710 VA: 0x180858110
	private static int SortWithTrailingNumber(string x, string y) { }

	// RVA: 0x856FD0 Offset: 0x8555D0 VA: 0x180856FD0
	public static string GetTrailingFolder(string path) { }

	// RVA: 0x8583B0 Offset: 0x8569B0 VA: 0x1808583B0
	private void Update() { }

	// RVA: 0x857290 Offset: 0x855890 VA: 0x180857290
	private void RecordCameraState() { }

	// RVA: 0x857C80 Offset: 0x856280 VA: 0x180857C80
	private void RecordKeyframe(Vector3 value, DemoShotVectorTrack track) { }

	// RVA: 0x857A80 Offset: 0x856080 VA: 0x180857A80
	private void RecordKeyframe(float value, DemoShotFloatTrack track) { }

	// RVA: 0x8577B0 Offset: 0x855DB0 VA: 0x1808577B0
	private void RecordKeyframe(Quaternion value, DemoShotQuaternionTrack track) { }

	// RVA: 0x857F10 Offset: 0x856510 VA: 0x180857F10
	private void RecordParent(BaseEntity parent, string bone, DemoShotParentTrack track) { }

	// RVA: 0x857210 Offset: 0x855810 VA: 0x180857210
	private DemoShotVectorTrack InitialiseKeyframeVectorTrack() { }

	// RVA: 0x857190 Offset: 0x855790 VA: 0x180857190
	private DemoShotQuaternionTrack InitialiseKeyframeQuaternionTrack() { }

	// RVA: 0x857090 Offset: 0x855690 VA: 0x180857090
	private DemoShotFloatTrack InitialiseKeyframeFloatTrack() { }

	// RVA: 0x857110 Offset: 0x855710 VA: 0x180857110
	private DemoShotParentTrack InitialiseKeyframeParentTrack() { }

	// RVA: 0x8584C0 Offset: 0x856AC0 VA: 0x1808584C0
	public void .ctor() { }

	// RVA: 0x858470 Offset: 0x856A70 VA: 0x180858470
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

	// RVA: 0x98B3B0 Offset: 0x9899B0 VA: 0x18098B3B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x98BB10 Offset: 0x98A110 VA: 0x18098BB10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public static class DemoShotHelpers // TypeDefIndex: 9183
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850F80 Offset: 0x84F580 VA: 0x180850F80
	public static Vector3 GetVectorFromTrack(DemoShotVectorTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850BD0 Offset: 0x84F1D0 VA: 0x180850BD0
	public static Quaternion GetQuaternionFromTrack(DemoShotQuaternionTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850040 Offset: 0x84E640 VA: 0x180850040
	public static float GetFloatFromTrack(DemoShotFloatTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850A20 Offset: 0x84F020 VA: 0x180850A20
	public static DemoShotParentKeyframe GetParentFromTrack(DemoShotParentTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850300 Offset: 0x84E900 VA: 0x180850300
	public static void GetKeyframesInRange(DemoShotVectorTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850590 Offset: 0x84EB90 VA: 0x180850590
	public static void GetKeyframesInRange(DemoShotQuaternionTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850800 Offset: 0x84EE00 VA: 0x180850800
	public static void GetKeyframesInRange(DemoShotFloatTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8513D0 Offset: 0x84F9D0 VA: 0x1808513D0
	public static Quaternion ToQuaternion(DemoShotQuaternionKeyframe keyframe) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8513A0 Offset: 0x84F9A0 VA: 0x1808513A0
	public static DemoShotQuaternionKeyframe ToKeyframe(Quaternion value, float time) { }

}

public class DemoPlaybackUI : SingletonComponent<DemoPlaybackUI> // TypeDefIndex: 10855
{	// Fields
	public GameObject Root; // 0x18

	// Methods

	// RVA: 0x84CB30 Offset: 0x84B130 VA: 0x18084CB30
	private void Start() { }

	// RVA: 0x84CBF0 Offset: 0x84B1F0 VA: 0x18084CBF0
	public void Toggle(bool state) { }

	// RVA: 0x84CC70 Offset: 0x84B270 VA: 0x18084CC70
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

	// RVA: 0x84DA90 Offset: 0x84C090 VA: 0x18084DA90
	private void Update() { }

	// RVA: 0x84D9E0 Offset: 0x84BFE0 VA: 0x18084D9E0
	private void SetRectTransformAnchoredX(float xPos, RectTransform t) { }

	// RVA: 0x84D580 Offset: 0x84BB80 VA: 0x18084D580
	public void OnClickedSlider(float value) { }

	// RVA: 0x84DA40 Offset: 0x84C040 VA: 0x18084DA40
	private void TimelineScrubCheck() { }

	// RVA: 0x84D010 Offset: 0x84B610 VA: 0x18084D010
	public void OnClickedPlay() { }

	// RVA: 0x84CF80 Offset: 0x84B580 VA: 0x18084CF80
	public void OnClickedPause() { }

	// RVA: 0x84CCD0 Offset: 0x84B2D0 VA: 0x18084CCD0
	public void OnClickedBackToStart() { }

	// RVA: 0x84D880 Offset: 0x84BE80 VA: 0x18084D880
	public void OnClickedToEnd() { }

	// RVA: 0x84CE50 Offset: 0x84B450 VA: 0x18084CE50
	public void OnClickedLoop() { }

	// RVA: 0x84CDD0 Offset: 0x84B3D0 VA: 0x18084CDD0
	public void OnClickedCancelShot() { }

	// RVA: 0x84CEE0 Offset: 0x84B4E0 VA: 0x18084CEE0
	public void OnClickedNextFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x7FF90 Offset: 0x7F390 VA: 0x18007FF90
	// RVA: 0x84E4D0 Offset: 0x84CAD0 VA: 0x18084E4D0
	private IEnumerator WaitAndPause() { }

	// RVA: 0x84D3A0 Offset: 0x84B9A0 VA: 0x18084D3A0
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

	// RVA: 0x8591E0 Offset: 0x8577E0 VA: 0x1808591E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8592A0 Offset: 0x8578A0 VA: 0x1808592A0 Slot: 8
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

	// RVA: 0x84F7C0 Offset: 0x84DDC0 VA: 0x18084F7C0
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

	// RVA: 0x84F970 Offset: 0x84DF70 VA: 0x18084F970 Slot: 42
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x84F990 Offset: 0x84DF90 VA: 0x18084F990 Slot: 43
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x84F950 Offset: 0x84DF50 VA: 0x18084F950 Slot: 44
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x6F1EE0 Offset: 0x6F04E0 VA: 0x1806F1EE0
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
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_CurrentShot(DemoShot value) { }

	// RVA: 0x84FF20 Offset: 0x84E520 VA: 0x18084FF20
	public void Populate(DemoShot shot, string folder) { }

	// RVA: 0x84FC30 Offset: 0x84E230 VA: 0x18084FC30
	public void OnClicked() { }

	// RVA: 0x84FF80 Offset: 0x84E580 VA: 0x18084FF80
	public void StopShot() { }

	// RVA: 0x84FA80 Offset: 0x84E080 VA: 0x18084FA80
	public void OnClickedDelete() { }

	// RVA: 0x850020 Offset: 0x84E620 VA: 0x180850020
	public void TogglePlayingRoot(bool state) { }

	// RVA: 0x84FEF0 Offset: 0x84E4F0 VA: 0x18084FEF0
	public void PopulateRename() { }

	// RVA: 0x84F9B0 Offset: 0x84DFB0 VA: 0x18084F9B0
	public void ApplyRename() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 4
	public object GetDragData() { }

	// RVA: 0x84FA50 Offset: 0x84E050 VA: 0x18084FA50 Slot: 5
	public string GetDragType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public Sprite GetDragSprite() { }

	// RVA: 0x84FC90 Offset: 0x84E290 VA: 0x18084FC90
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
	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	private void set_CurrentState(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_cachedFolderName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	private void set_cachedFolderName(string value) { }

	// RVA: 0x851A80 Offset: 0x850080 VA: 0x180851A80
	public void Populate(string folderName, bool state) { }

	// RVA: 0x851BA0 Offset: 0x8501A0 VA: 0x180851BA0
	public void ToggleState() { }

	// RVA: 0x851BB0 Offset: 0x8501B0 VA: 0x180851BB0
	public void ToggleState(bool state) { }

	// RVA: 0x851430 Offset: 0x84FA30 VA: 0x180851430
	public void AddChild(DemoShotEntry shot) { }

	// RVA: 0x851C60 Offset: 0x850260 VA: 0x180851C60
	private void UpdateCountText() { }

	// RVA: 0x851790 Offset: 0x84FD90 VA: 0x180851790
	public void OnDroppedValue(object data) { }

	// RVA: 0x8519E0 Offset: 0x84FFE0 VA: 0x1808519E0
	public void OnRightClick() { }

	// RVA: 0x851480 Offset: 0x84FA80 VA: 0x180851480
	public void OnClickedDeleteFolder() { }

	// RVA: 0x8515D0 Offset: 0x84FBD0 VA: 0x1808515D0
	public void OnClickedRenameFolder() { }

	// RVA: 0x851CF0 Offset: 0x8502F0 VA: 0x180851CF0
	public void .ctor() { }

}

public class DemoShotListRootFolder : MonoBehaviour // TypeDefIndex: 10862
{	// Methods

	// RVA: 0x851D00 Offset: 0x850300 VA: 0x180851D00
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

	// RVA: 0x8527E0 Offset: 0x850DE0 VA: 0x1808527E0
	private void OnEnable() { }

	// RVA: 0x852D80 Offset: 0x851380 VA: 0x180852D80
	public void UpdateAvailableShots() { }

	// RVA: 0x852B10 Offset: 0x851110 VA: 0x180852B10
	public void SetCurrentlyPlaying(DemoShot shot) { }

	// RVA: 0x853E70 Offset: 0x852470 VA: 0x180853E70
	private int get_TotalShotCount() { }

	// RVA: 0x8523F0 Offset: 0x8509F0 VA: 0x1808523F0
	public string GetDefaultNewShotName() { }

	// RVA: 0x852150 Offset: 0x850750 VA: 0x180852150
	public void DeleteShot(DemoShot shotName) { }

	// RVA: 0x852940 Offset: 0x850F40 VA: 0x180852940
	public void RenameShot(DemoShot shotToRename, string newName) { }

	// RVA: 0x851F50 Offset: 0x850550 VA: 0x180851F50
	public void CreateFolder() { }

	// RVA: 0x852C70 Offset: 0x851270 VA: 0x180852C70
	public void ToggleOpen(bool state) { }

	// RVA: 0x852C60 Offset: 0x851260 VA: 0x180852C60
	public void ToggleOpen() { }

	// RVA: 0x8522A0 Offset: 0x8508A0 VA: 0x1808522A0
	public List<string> GetCurrentFolders() { }

	// RVA: 0x852630 Offset: 0x850C30 VA: 0x180852630
	public void MoveShotToFolder(DemoShot shot, string targetFolder) { }

	// RVA: 0x8527F0 Offset: 0x850DF0 VA: 0x1808527F0
	public void RenameFolder(string oldName, string newName) { }

	// RVA: 0x852050 Offset: 0x850650 VA: 0x180852050
	public void DeleteFolder(string folderName) { }

	// RVA: 0x853D80 Offset: 0x852380 VA: 0x180853D80
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

	// RVA: 0x855A30 Offset: 0x854030 VA: 0x180855A30
	private void Start() { }

	// RVA: 0x855710 Offset: 0x853D10 VA: 0x180855710
	private void OnEnable() { }

	// RVA: 0x855C20 Offset: 0x854220 VA: 0x180855C20
	public void UpdateShotName() { }

	// RVA: 0x855CB0 Offset: 0x8542B0 VA: 0x180855CB0
	private void Update() { }

	// RVA: 0x855430 Offset: 0x853A30 VA: 0x180855430
	public void OnClickedStartRecording() { }

	// RVA: 0x8553C0 Offset: 0x8539C0 VA: 0x1808553C0
	public void OnClickedFinish() { }

	// RVA: 0x855B20 Offset: 0x854120 VA: 0x180855B20
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

	// RVA: 0x970D20 Offset: 0x96F320 VA: 0x180970D20
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

	// RVA: 0x84ED60 Offset: 0x84D360 VA: 0x18084ED60 Slot: 6
	protected override void Awake() { }

	// RVA: 0x84F0B0 Offset: 0x84D6B0 VA: 0x18084F0B0
	public void Open() { }

	// RVA: 0x84F590 Offset: 0x84DB90 VA: 0x18084F590
	public void Update() { }

	// RVA: 0x84EE70 Offset: 0x84D470 VA: 0x18084EE70
	public void Close() { }

	// RVA: 0x84F4D0 Offset: 0x84DAD0 VA: 0x18084F4D0
	public void SubmitRecord() { }

	// RVA: 0x84F450 Offset: 0x84DA50 VA: 0x18084F450
	public void Record() { }

	// RVA: 0x84F760 Offset: 0x84DD60 VA: 0x18084F760
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
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

	// RVA: 0x84E520 Offset: 0x84CB20 VA: 0x18084E520 Slot: 6
	protected override void Awake() { }

	// RVA: 0x84E6C0 Offset: 0x84CCC0 VA: 0x18084E6C0
	public void Open(string recordingName) { }

	// RVA: 0x84E910 Offset: 0x84CF10 VA: 0x18084E910
	public void Update() { }

	// RVA: 0x84E5D0 Offset: 0x84CBD0 VA: 0x18084E5D0
	public void Close() { }

	// RVA: 0x84E640 Offset: 0x84CC40 VA: 0x18084E640
	public void EnableCursor(bool enable) { }

	// RVA: 0x84E860 Offset: 0x84CE60 VA: 0x18084E860
	public void Stop() { }

	// RVA: 0x84ED00 Offset: 0x84D300 VA: 0x18084ED00
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

	// RVA: 0x84CAA0 Offset: 0x84B0A0 VA: 0x18084CAA0
	public void OnClicked() { }

	// RVA: 0x84C980 Offset: 0x84AF80 VA: 0x18084C980 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0x6F1EE0 Offset: 0x6F04E0 VA: 0x1806F1EE0
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

	// RVA: 0x971440 Offset: 0x96FA40 VA: 0x180971440 Slot: 6
	protected override void Awake() { }

	// RVA: 0x971610 Offset: 0x96FC10 VA: 0x180971610
	private void DeselectItem() { }

	// RVA: 0x972080 Offset: 0x970680 VA: 0x180972080
	private void Populate() { }

	// RVA: 0x972370 Offset: 0x970970 VA: 0x180972370
	private void Rebuild() { }

	// RVA: 0x971FF0 Offset: 0x9705F0 VA: 0x180971FF0
	public void OrderBy(string strBy) { }

	// RVA: 0x9716C0 Offset: 0x96FCC0 VA: 0x1809716C0 Slot: 8
	public int GetItemCount() { }

	// RVA: 0x972410 Offset: 0x970A10 VA: 0x180972410 Slot: 9
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x971700 Offset: 0x96FD00 VA: 0x180971700
	private IOrderedEnumerable<Demos.DemoInfo> GetSortedInfo() { }

	// RVA: 0x971D90 Offset: 0x970390 VA: 0x180971D90
	public void OnItemClicked(DemoItem item) { }

	// RVA: 0x971D10 Offset: 0x970310 VA: 0x180971D10
	public void OnDeleteItem() { }

	// RVA: 0x971460 Offset: 0x96FA60 VA: 0x180971460
	public void DeleteItem() { }

	// RVA: 0x971EE0 Offset: 0x9704E0 VA: 0x180971EE0
	public void OnPlayItem() { }

	// RVA: 0x971FB0 Offset: 0x9705B0 VA: 0x180971FB0
	public void OpenDemosFolder() { }

	// RVA: 0x972400 Offset: 0x970A00 VA: 0x180972400
	public void Refresh() { }

	// RVA: 0x972780 Offset: 0x970D80 VA: 0x180972780
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

	// RVA: 0x98C470 Offset: 0x98AA70 VA: 0x18098C470
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C2A0 Offset: 0x98A8A0 VA: 0x18098C2A0
	internal string <GetSortedInfo>b__14_0(Demos.DemoInfo x) { }

	// RVA: 0x98C2A0 Offset: 0x98A8A0 VA: 0x18098C2A0
	internal string <GetSortedInfo>b__14_1(Demos.DemoInfo x) { }

	// RVA: 0x98C2C0 Offset: 0x98A8C0 VA: 0x18098C2C0
	internal DateTime <GetSortedInfo>b__14_2(Demos.DemoInfo x) { }

	// RVA: 0x98C2C0 Offset: 0x98A8C0 VA: 0x18098C2C0
	internal DateTime <GetSortedInfo>b__14_3(Demos.DemoInfo x) { }

	// RVA: 0x98C2E0 Offset: 0x98A8E0 VA: 0x18098C2E0
	internal TimeSpan <GetSortedInfo>b__14_4(Demos.DemoInfo x) { }

	// RVA: 0x98C2E0 Offset: 0x98A8E0 VA: 0x18098C2E0
	internal TimeSpan <GetSortedInfo>b__14_5(Demos.DemoInfo x) { }

	// RVA: 0x98C2A0 Offset: 0x98A8A0 VA: 0x18098C2A0
	internal string <GetSortedInfo>b__14_6(Demos.DemoInfo x) { }

}

private sealed class Demos.<>c__DisplayClass17_0 // TypeDefIndex: 11103
{	// Fields
	public Demos.DemoInfo demoInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C450 Offset: 0x98AA50 VA: 0x18098C450
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

	// RVA: 0x6D9890 Offset: 0x6D7E90 VA: 0x1806D9890
	public static bool get_hud() { }

	// RVA: 0x6DB420 Offset: 0x6D9A20 VA: 0x1806DB420
	public static void set_hud(bool value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DBB10 Offset: 0x6DA110 VA: 0x1806DBB10
	public static void togglehud(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D97F0 Offset: 0x6D7DF0 VA: 0x1806D97F0
	public static float get_TimeScale() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6DAC10 Offset: 0x6D9210 VA: 0x1806DAC10
	public static string record(string filename) { }

	[ClientVar] // RVA: 0x964E0 Offset: 0x958E0 VA: 0x1800964E0
	// RVA: 0x6DB260 Offset: 0x6D9860 VA: 0x1806DB260
	public static void recorder() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DB7C0 Offset: 0x6D9DC0 VA: 0x1806DB7C0
	public static string stop() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D9DD0 Offset: 0x6D83D0 VA: 0x1806D9DD0
	public static string play(string filename) { }

	// RVA: 0x6D9340 Offset: 0x6D7940 VA: 0x1806D9340
	public static void TryRunDemoCfg(string demoName) { }

	[ClientVar] // RVA: 0x96670 Offset: 0x95A70 VA: 0x180096670
	// RVA: 0x6DB5D0 Offset: 0x6D9BD0 VA: 0x1806DB5D0
	public static string skip(float seconds) { }

	[ClientVar] // RVA: 0x96760 Offset: 0x95B60 VA: 0x180096760
	// RVA: 0x6D9930 Offset: 0x6D7F30 VA: 0x1806D9930
	public static string jump(float seconds) { }

	[ClientVar] // RVA: 0x968D0 Offset: 0x95CD0 VA: 0x1800968D0
	// RVA: 0x6DA640 Offset: 0x6D8C40 VA: 0x1806DA640
	public static string playernames() { }

	[ClientVar] // RVA: 0x96A50 Offset: 0x95E50 VA: 0x180096A50
	// RVA: 0x6D96A0 Offset: 0x6D7CA0 VA: 0x1806D96A0
	public static void browser() { }

	// RVA: 0x6D98F0 Offset: 0x6D7EF0 VA: 0x1806D98F0
	public static string get_lastRecordedDemoName() { }

	// RVA: 0x6DB590 Offset: 0x6D9B90 VA: 0x1806DB590
	public static void set_lastRecordedDemoName(string value) { }

	[ClientVar] // RVA: 0x96AC0 Offset: 0x95EC0 VA: 0x180096AC0
	// RVA: 0x6DBA50 Offset: 0x6DA050 VA: 0x1806DBA50
	public static string toggleNVG(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x96B40 Offset: 0x95F40 VA: 0x180096B40
	// RVA: 0x6D9B80 Offset: 0x6D8180 VA: 0x1806D9B80
	public static string pause() { }

	[ClientVar] // RVA: 0x96C60 Offset: 0x96060 VA: 0x180096C60
	// RVA: 0x6DB2D0 Offset: 0x6D98D0 VA: 0x1806DB2D0
	public static string resume() { }

	// RVA: 0x6D9C60 Offset: 0x6D8260 VA: 0x1806D9C60
	public static string playShot(DemoShot shot) { }

	[ClientVar] // RVA: 0x96E90 Offset: 0x96290 VA: 0x180096E90
	// RVA: 0x6DAB60 Offset: 0x6D9160 VA: 0x1806DAB60
	public static void readcfg() { }

	// RVA: 0x6D9640 Offset: 0x6D7C40 VA: 0x1806D9640
	public void .ctor() { }

	// RVA: 0x6D9590 Offset: 0x6D7B90 VA: 0x1806D9590
	private static void .cctor() { }

}

public class Demo.Header : DemoHeader, IDemoHeader // TypeDefIndex: 11908
{	// Properties
	private long Network.IDemoHeader.Length { get; set; }

	// Methods

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 15
	private long Network.IDemoHeader.get_Length() { }

	// RVA: 0x6E6D70 Offset: 0x6E5370 VA: 0x1806E6D70 Slot: 16
	private void Network.IDemoHeader.set_Length(long value) { }

	// RVA: 0x6E6D80 Offset: 0x6E5380 VA: 0x1806E6D80 Slot: 17
	public void Write(BinaryWriter writer) { }

	// RVA: 0x6E6E30 Offset: 0x6E5430 VA: 0x1806E6E30
	public void .ctor() { }

}

