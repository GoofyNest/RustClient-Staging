public class Vector4Serialized // TypeDefIndex: 6287
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Vector4 instance) { }

	// RVA: 0x1E4E050 Offset: 0x1E4C650 VA: 0x181E4E050
	public static Vector4 Deserialize(byte[] buffer, ref Vector4 instance, bool isDelta = False) { }

	// RVA: 0x1E4E180 Offset: 0x1E4C780 VA: 0x181E4E180
	public static Vector4 Deserialize(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4D820 Offset: 0x1E4BE20 VA: 0x181E4D820
	public static Vector4 DeserializeLengthDelimited(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4DC50 Offset: 0x1E4C250 VA: 0x181E4DC50
	public static Vector4 DeserializeLength(Stream stream, int length, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4E4E0 Offset: 0x1E4CAE0 VA: 0x181E4E4E0
	public static void SerializeDelta(Stream stream, Vector4 instance, Vector4 previous) { }

	// RVA: 0x1E4EA30 Offset: 0x1E4D030 VA: 0x181E4EA30
	public static void Serialize(Stream stream, Vector4 instance) { }

	// RVA: 0x1E4E810 Offset: 0x1E4CE10 VA: 0x181E4E810
	public static byte[] SerializeToBytes(Vector4 instance) { }

	// RVA: 0x1E4E710 Offset: 0x1E4CD10 VA: 0x181E4E710
	public static void SerializeLengthDelimited(Stream stream, Vector4 instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

