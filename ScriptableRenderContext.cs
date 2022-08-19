public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 3852
{	// Fields
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x222D30 Offset: 0x222130 VA: 0x180222D30
	private int GetNumberOfCameras_Internal() { }

	// RVA: 0x222CD0 Offset: 0x2220D0 VA: 0x180222CD0
	private Camera GetCamera_Internal(int index) { }

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x222D30 Offset: 0x222130 VA: 0x180222D30
	internal int GetNumberOfCameras() { }

	// RVA: 0x222CD0 Offset: 0x2220D0 VA: 0x180222CD0
	internal Camera GetCamera(int index) { }

	// RVA: 0x222BB0 Offset: 0x221FB0 VA: 0x180222BB0 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x222C10 Offset: 0x222010 VA: 0x180222C10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x222D20 Offset: 0x222120 VA: 0x180222D20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19B4DE0 Offset: 0x19B33E0 VA: 0x1819B4DE0
	private static int GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x19B4DA0 Offset: 0x19B33A0 VA: 0x1819B4DA0
	private static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, int index) { }

}

