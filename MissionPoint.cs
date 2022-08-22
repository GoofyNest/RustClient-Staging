public class MissionPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6451
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string identifier; // 0x18
	public Vector3 location; // 0x20

	// Methods

	// RVA: 0x1F4E6C0 Offset: 0x1F4CCC0 VA: 0x181F4E6C0
	public static void ResetToPool(MissionPoint instance) { }

	// RVA: 0x1F4E610 Offset: 0x1F4CC10 VA: 0x181F4E610
	public void ResetToPool() { }

	// RVA: 0x1F4E550 Offset: 0x1F4CB50 VA: 0x181F4E550 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4DA70 Offset: 0x1F4C070 VA: 0x181F4DA70
	public void CopyTo(MissionPoint instance) { }

	// RVA: 0x1F4DAC0 Offset: 0x1F4C0C0 VA: 0x181F4DAC0
	public MissionPoint Copy() { }

	// RVA: 0x1F4E4D0 Offset: 0x1F4CAD0 VA: 0x181F4E4D0
	public static MissionPoint Deserialize(Stream stream) { }

	// RVA: 0x1F4DDC0 Offset: 0x1F4C3C0 VA: 0x181F4DDC0
	public static MissionPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4DE40 Offset: 0x1F4C440 VA: 0x181F4DE40
	public static MissionPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4E210 Offset: 0x1F4C810 VA: 0x181F4E210
	public static MissionPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F4E5D0 Offset: 0x1F4CBD0 VA: 0x181F4E5D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4EE20 Offset: 0x1F4D420 VA: 0x181F4EE20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4EE40 Offset: 0x1F4D440 VA: 0x181F4EE40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionPoint previous) { }

	// RVA: 0x1F4E5F0 Offset: 0x1F4CBF0 VA: 0x181F4E5F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4E110 Offset: 0x1F4C710 VA: 0x181F4E110
	public static MissionPoint Deserialize(byte[] buffer, MissionPoint instance, bool isDelta = False) { }

	// RVA: 0x1F4E330 Offset: 0x1F4C930 VA: 0x181F4E330
	public static MissionPoint Deserialize(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4DB50 Offset: 0x1F4C150 VA: 0x181F4DB50
	public static MissionPoint DeserializeLengthDelimited(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4DED0 Offset: 0x1F4C4D0 VA: 0x181F4DED0
	public static MissionPoint DeserializeLength(Stream stream, int length, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4E770 Offset: 0x1F4CD70 VA: 0x181F4E770
	public static void SerializeDelta(Stream stream, MissionPoint instance, MissionPoint previous) { }

	// RVA: 0x1F4EC10 Offset: 0x1F4D210 VA: 0x181F4EC10
	public static void Serialize(Stream stream, MissionPoint instance) { }

	// RVA: 0x1F4EE10 Offset: 0x1F4D410 VA: 0x181F4EE10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4EE20 Offset: 0x1F4D420 VA: 0x181F4EE20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4EB00 Offset: 0x1F4D100 VA: 0x181F4EB00
	public static byte[] SerializeToBytes(MissionPoint instance) { }

	// RVA: 0x1F4EA50 Offset: 0x1F4D050 VA: 0x181F4EA50
	public static void SerializeLengthDelimited(Stream stream, MissionPoint instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x768350 Offset: 0x766950 VA: 0x180768350
	public static int TypeToIndex(int id) { }

	// RVA: 0x768340 Offset: 0x766940 VA: 0x180768340
	public static int IndexToType(int idx) { }

	// RVA: 0x7684C0 Offset: 0x766AC0 VA: 0x1807684C0
	public void .ctor() { }

	// RVA: 0x7683D0 Offset: 0x7669D0 VA: 0x1807683D0
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

