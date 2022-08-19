public class MissionPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6451
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string identifier; // 0x18
	public Vector3 location; // 0x20

	// Methods

	// RVA: 0x1F4E5C0 Offset: 0x1F4CBC0 VA: 0x181F4E5C0
	public static void ResetToPool(MissionPoint instance) { }

	// RVA: 0x1F4E510 Offset: 0x1F4CB10 VA: 0x181F4E510
	public void ResetToPool() { }

	// RVA: 0x1F4E450 Offset: 0x1F4CA50 VA: 0x181F4E450 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4D970 Offset: 0x1F4BF70 VA: 0x181F4D970
	public void CopyTo(MissionPoint instance) { }

	// RVA: 0x1F4D9C0 Offset: 0x1F4BFC0 VA: 0x181F4D9C0
	public MissionPoint Copy() { }

	// RVA: 0x1F4E3D0 Offset: 0x1F4C9D0 VA: 0x181F4E3D0
	public static MissionPoint Deserialize(Stream stream) { }

	// RVA: 0x1F4DCC0 Offset: 0x1F4C2C0 VA: 0x181F4DCC0
	public static MissionPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4DD40 Offset: 0x1F4C340 VA: 0x181F4DD40
	public static MissionPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4E110 Offset: 0x1F4C710 VA: 0x181F4E110
	public static MissionPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F4E4D0 Offset: 0x1F4CAD0 VA: 0x181F4E4D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4ED20 Offset: 0x1F4D320 VA: 0x181F4ED20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4ED40 Offset: 0x1F4D340 VA: 0x181F4ED40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionPoint previous) { }

	// RVA: 0x1F4E4F0 Offset: 0x1F4CAF0 VA: 0x181F4E4F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4E010 Offset: 0x1F4C610 VA: 0x181F4E010
	public static MissionPoint Deserialize(byte[] buffer, MissionPoint instance, bool isDelta = False) { }

	// RVA: 0x1F4E230 Offset: 0x1F4C830 VA: 0x181F4E230
	public static MissionPoint Deserialize(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4DA50 Offset: 0x1F4C050 VA: 0x181F4DA50
	public static MissionPoint DeserializeLengthDelimited(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4DDD0 Offset: 0x1F4C3D0 VA: 0x181F4DDD0
	public static MissionPoint DeserializeLength(Stream stream, int length, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4E670 Offset: 0x1F4CC70 VA: 0x181F4E670
	public static void SerializeDelta(Stream stream, MissionPoint instance, MissionPoint previous) { }

	// RVA: 0x1F4EB10 Offset: 0x1F4D110 VA: 0x181F4EB10
	public static void Serialize(Stream stream, MissionPoint instance) { }

	// RVA: 0x1F4ED10 Offset: 0x1F4D310 VA: 0x181F4ED10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4ED20 Offset: 0x1F4D320 VA: 0x181F4ED20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4EA00 Offset: 0x1F4D000 VA: 0x181F4EA00
	public static byte[] SerializeToBytes(MissionPoint instance) { }

	// RVA: 0x1F4E950 Offset: 0x1F4CF50 VA: 0x181F4E950
	public static void SerializeLengthDelimited(Stream stream, MissionPoint instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class MissionPoint : MonoBehaviour // TypeDefIndex: 10215
{	// Fields
	public bool dropToGround; // 0x18
	public const int COUNT = 8;
	public const int EVERYTHING = -1;
	public const int NOTHING = 0;
	public const int EASY_MONUMENT = 1;
	public const int MED_MONUMENT = 2;
	public const int HARD_MONUMENT = 4;
	public const int ITEM_HIDESPOT = 8;
	public const int UNDERWATER = 128;
	public const int EASY_MONUMENT_IDX = 0;
	public const int MED_MONUMENT_IDX = 1;
	public const int HARD_MONUMENT_IDX = 2;
	public const int ITEM_HIDESPOT_IDX = 3;
	public const int FOREST_IDX = 4;
	public const int ROADSIDE_IDX = 5;
	public const int BEACH = 6;
	public const int UNDERWATER_IDX = 7;
	private static Dictionary<int, int> type2index; // 0x0

	// Methods

	// RVA: 0x768240 Offset: 0x766840 VA: 0x180768240
	public static int TypeToIndex(int id) { }

	// RVA: 0x768230 Offset: 0x766830 VA: 0x180768230
	public static int IndexToType(int idx) { }

	// RVA: 0x7683B0 Offset: 0x7669B0 VA: 0x1807683B0
	public void .ctor() { }

	// RVA: 0x7682C0 Offset: 0x7668C0 VA: 0x1807682C0
	private static void .cctor() { }

}

public enum MissionPoint.MissionPointEnum // TypeDefIndex: 10216
{	// Fields
	public int value__; // 0x0
	public const MissionPoint.MissionPointEnum EasyMonument = 1;
	public const MissionPoint.MissionPointEnum MediumMonument = 2;
	public const MissionPoint.MissionPointEnum HardMonument = 4;
	public const MissionPoint.MissionPointEnum Item_Hidespot = 8;
	public const MissionPoint.MissionPointEnum Underwater = 128;

}

