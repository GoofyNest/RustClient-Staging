public static class QuaternionEx // TypeDefIndex: 11705
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FE080 Offset: 0x9FC680 VA: 0x1809FE080
	public static Quaternion AlignToNormal(Quaternion rot, Vector3 normal) { }

	// RVA: 0x9FE940 Offset: 0x9FCF40 VA: 0x1809FE940
	public static Quaternion LookRotationWithOffset(Vector3 offset, Vector3 forward, Vector3 up) { }

	// RVA: 0x9FE250 Offset: 0x9FC850 VA: 0x1809FE250
	public static Quaternion LookRotationForcedUp(Vector3 forward, Vector3 up) { }

	// RVA: 0x9FE420 Offset: 0x9FCA20 VA: 0x1809FE420
	public static Quaternion LookRotationGradient(Vector3 normal, Vector3 up) { }

	// RVA: 0x9FE5E0 Offset: 0x9FCBE0 VA: 0x1809FE5E0
	public static Quaternion LookRotationNormal(Vector3 normal, Vector3 up) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FE190 Offset: 0x9FC790 VA: 0x1809FE190
	public static Quaternion EnsureValid(Quaternion rot, float epsilon = 1,401298E-45) { }

}

