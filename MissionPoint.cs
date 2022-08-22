public class MissionPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6451
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string identifier; // 0x18
	public Vector3 location; // 0x20

	// Methods

	// RVA: 0x1F4E400 Offset: 0x1F4CA00 VA: 0x181F4E400
	public static void ResetToPool(MissionPoint instance) { }

	// RVA: 0x1F4E350 Offset: 0x1F4C950 VA: 0x181F4E350
	public void ResetToPool() { }

	// RVA: 0x1F4E290 Offset: 0x1F4C890 VA: 0x181F4E290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4D7B0 Offset: 0x1F4BDB0 VA: 0x181F4D7B0
	public void CopyTo(MissionPoint instance) { }

	// RVA: 0x1F4D800 Offset: 0x1F4BE00 VA: 0x181F4D800
	public MissionPoint Copy() { }

	// RVA: 0x1F4E210 Offset: 0x1F4C810 VA: 0x181F4E210
	public static MissionPoint Deserialize(Stream stream) { }

	// RVA: 0x1F4DB00 Offset: 0x1F4C100 VA: 0x181F4DB00
	public static MissionPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4DB80 Offset: 0x1F4C180 VA: 0x181F4DB80
	public static MissionPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4DF50 Offset: 0x1F4C550 VA: 0x181F4DF50
	public static MissionPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F4E310 Offset: 0x1F4C910 VA: 0x181F4E310
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4EB60 Offset: 0x1F4D160 VA: 0x181F4EB60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4EB80 Offset: 0x1F4D180 VA: 0x181F4EB80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionPoint previous) { }

	// RVA: 0x1F4E330 Offset: 0x1F4C930 VA: 0x181F4E330 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4DE50 Offset: 0x1F4C450 VA: 0x181F4DE50
	public static MissionPoint Deserialize(byte[] buffer, MissionPoint instance, bool isDelta = False) { }

	// RVA: 0x1F4E070 Offset: 0x1F4C670 VA: 0x181F4E070
	public static MissionPoint Deserialize(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4D890 Offset: 0x1F4BE90 VA: 0x181F4D890
	public static MissionPoint DeserializeLengthDelimited(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4DC10 Offset: 0x1F4C210 VA: 0x181F4DC10
	public static MissionPoint DeserializeLength(Stream stream, int length, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4E4B0 Offset: 0x1F4CAB0 VA: 0x181F4E4B0
	public static void SerializeDelta(Stream stream, MissionPoint instance, MissionPoint previous) { }

	// RVA: 0x1F4E950 Offset: 0x1F4CF50 VA: 0x181F4E950
	public static void Serialize(Stream stream, MissionPoint instance) { }

	// RVA: 0x1F4EB50 Offset: 0x1F4D150 VA: 0x181F4EB50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4EB60 Offset: 0x1F4D160 VA: 0x181F4EB60
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4E840 Offset: 0x1F4CE40 VA: 0x181F4E840
	public static byte[] SerializeToBytes(MissionPoint instance) { }

	// RVA: 0x1F4E790 Offset: 0x1F4CD90 VA: 0x181F4E790
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

