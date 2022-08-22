public static class QuaternionEx // TypeDefIndex: 11705
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FE340 Offset: 0x9FC940 VA: 0x1809FE340
	public static Quaternion AlignToNormal(Quaternion rot, Vector3 normal) { }

	// RVA: 0x9FEC00 Offset: 0x9FD200 VA: 0x1809FEC00
	public static Quaternion LookRotationWithOffset(Vector3 offset, Vector3 forward, Vector3 up) { }

	// RVA: 0x9FE510 Offset: 0x9FCB10 VA: 0x1809FE510
	public static Quaternion LookRotationForcedUp(Vector3 forward, Vector3 up) { }

	// RVA: 0x9FE6E0 Offset: 0x9FCCE0 VA: 0x1809FE6E0
	public static Quaternion LookRotationGradient(Vector3 normal, Vector3 up) { }

	// RVA: 0x9FE8A0 Offset: 0x9FCEA0 VA: 0x1809FE8A0
	public static Quaternion LookRotationNormal(Vector3 normal, Vector3 up) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FE450 Offset: 0x9FCA50 VA: 0x1809FE450
	public static Quaternion EnsureValid(Quaternion rot, float epsilon = 1,401298E-45) { }

}

