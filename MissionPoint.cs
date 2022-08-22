public class MissionPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6451
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string identifier; // 0x18
	public Vector3 location; // 0x20

	// Methods

	// RVA: 0x1F4EEE0 Offset: 0x1F4D4E0 VA: 0x181F4EEE0
	public static void ResetToPool(MissionPoint instance) { }

	// RVA: 0x1F4EE30 Offset: 0x1F4D430 VA: 0x181F4EE30
	public void ResetToPool() { }

	// RVA: 0x1F4ED70 Offset: 0x1F4D370 VA: 0x181F4ED70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4E290 Offset: 0x1F4C890 VA: 0x181F4E290
	public void CopyTo(MissionPoint instance) { }

	// RVA: 0x1F4E2E0 Offset: 0x1F4C8E0 VA: 0x181F4E2E0
	public MissionPoint Copy() { }

	// RVA: 0x1F4ECF0 Offset: 0x1F4D2F0 VA: 0x181F4ECF0
	public static MissionPoint Deserialize(Stream stream) { }

	// RVA: 0x1F4E5E0 Offset: 0x1F4CBE0 VA: 0x181F4E5E0
	public static MissionPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4E660 Offset: 0x1F4CC60 VA: 0x181F4E660
	public static MissionPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4EA30 Offset: 0x1F4D030 VA: 0x181F4EA30
	public static MissionPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F4EDF0 Offset: 0x1F4D3F0 VA: 0x181F4EDF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4F640 Offset: 0x1F4DC40 VA: 0x181F4F640 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4F660 Offset: 0x1F4DC60 VA: 0x181F4F660 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionPoint previous) { }

	// RVA: 0x1F4EE10 Offset: 0x1F4D410 VA: 0x181F4EE10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4E930 Offset: 0x1F4CF30 VA: 0x181F4E930
	public static MissionPoint Deserialize(byte[] buffer, MissionPoint instance, bool isDelta = False) { }

	// RVA: 0x1F4EB50 Offset: 0x1F4D150 VA: 0x181F4EB50
	public static MissionPoint Deserialize(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4E370 Offset: 0x1F4C970 VA: 0x181F4E370
	public static MissionPoint DeserializeLengthDelimited(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4E6F0 Offset: 0x1F4CCF0 VA: 0x181F4E6F0
	public static MissionPoint DeserializeLength(Stream stream, int length, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F4EF90 Offset: 0x1F4D590 VA: 0x181F4EF90
	public static void SerializeDelta(Stream stream, MissionPoint instance, MissionPoint previous) { }

	// RVA: 0x1F4F430 Offset: 0x1F4DA30 VA: 0x181F4F430
	public static void Serialize(Stream stream, MissionPoint instance) { }

	// RVA: 0x1F4F630 Offset: 0x1F4DC30 VA: 0x181F4F630
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4F640 Offset: 0x1F4DC40 VA: 0x181F4F640
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4F320 Offset: 0x1F4D920 VA: 0x181F4F320
	public static byte[] SerializeToBytes(MissionPoint instance) { }

	// RVA: 0x1F4F270 Offset: 0x1F4D870 VA: 0x181F4F270
	public static void SerializeLengthDelimited(Stream stream, MissionPoint instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x7682A0 Offset: 0x7668A0 VA: 0x1807682A0
	public static int TypeToIndex(int id) { }

	// RVA: 0x768290 Offset: 0x766890 VA: 0x180768290
	public static int IndexToType(int idx) { }

	// RVA: 0x768410 Offset: 0x766A10 VA: 0x180768410
	public void .ctor() { }

	// RVA: 0x768320 Offset: 0x766920 VA: 0x180768320
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

