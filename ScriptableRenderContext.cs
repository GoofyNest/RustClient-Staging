public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 3852
{	// Fields
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x222CB0 Offset: 0x2220B0 VA: 0x180222CB0
	private int GetNumberOfCameras_Internal() { }

	// RVA: 0x222C50 Offset: 0x222050 VA: 0x180222C50
	private Camera GetCamera_Internal(int index) { }

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x222CB0 Offset: 0x2220B0 VA: 0x180222CB0
	internal int GetNumberOfCameras() { }

	// RVA: 0x222C50 Offset: 0x222050 VA: 0x180222C50
	internal Camera GetCamera(int index) { }

	// RVA: 0x222B30 Offset: 0x221F30 VA: 0x180222B30 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x222B90 Offset: 0x221F90 VA: 0x180222B90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x222CA0 Offset: 0x2220A0 VA: 0x180222CA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19B4DA0 Offset: 0x19B33A0 VA: 0x1819B4DA0
	private static int GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x19B4D60 Offset: 0x19B3360 VA: 0x1819B4D60
	private static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, int index) { }

}

