public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 3852
{	// Fields
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x21E230 Offset: 0x21D630 VA: 0x18021E230
	private int GetNumberOfCameras_Internal() { }

	// RVA: 0x21E1D0 Offset: 0x21D5D0 VA: 0x18021E1D0
	private Camera GetCamera_Internal(int index) { }

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x21E230 Offset: 0x21D630 VA: 0x18021E230
	internal int GetNumberOfCameras() { }

	// RVA: 0x21E1D0 Offset: 0x21D5D0 VA: 0x18021E1D0
	internal Camera GetCamera(int index) { }

	// RVA: 0x21E0B0 Offset: 0x21D4B0 VA: 0x18021E0B0 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x21E110 Offset: 0x21D510 VA: 0x18021E110 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21E220 Offset: 0x21D620 VA: 0x18021E220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19A2460 Offset: 0x19A0A60 VA: 0x1819A2460
	private static int GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x19A2420 Offset: 0x19A0A20 VA: 0x1819A2420
	private static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, int index) { }

}

