public class Vector4Serialized // TypeDefIndex: 6287
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Vector4 instance) { }

	// RVA: 0x1E4EB30 Offset: 0x1E4D130 VA: 0x181E4EB30
	public static Vector4 Deserialize(byte[] buffer, ref Vector4 instance, bool isDelta = False) { }

	// RVA: 0x1E4EC60 Offset: 0x1E4D260 VA: 0x181E4EC60
	public static Vector4 Deserialize(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4E300 Offset: 0x1E4C900 VA: 0x181E4E300
	public static Vector4 DeserializeLengthDelimited(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4E730 Offset: 0x1E4CD30 VA: 0x181E4E730
	public static Vector4 DeserializeLength(Stream stream, int length, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4EFC0 Offset: 0x1E4D5C0 VA: 0x181E4EFC0
	public static void SerializeDelta(Stream stream, Vector4 instance, Vector4 previous) { }

	// RVA: 0x1E4F510 Offset: 0x1E4DB10 VA: 0x181E4F510
	public static void Serialize(Stream stream, Vector4 instance) { }

	// RVA: 0x1E4F2F0 Offset: 0x1E4D8F0 VA: 0x181E4F2F0
	public static byte[] SerializeToBytes(Vector4 instance) { }

	// RVA: 0x1E4F1F0 Offset: 0x1E4D7F0 VA: 0x181E4F1F0
	public static void SerializeLengthDelimited(Stream stream, Vector4 instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

