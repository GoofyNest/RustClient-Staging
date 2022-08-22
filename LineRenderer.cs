public sealed class LineRenderer : Renderer // TypeDefIndex: 3401
{	// Properties
	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute] // RVA: 0x8E280 Offset: 0x8D680 VA: 0x18008E280
	public int positionCount { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x8DF20 Offset: 0x8D320 VA: 0x18008DF20
	// RVA: 0x18EA140 Offset: 0x18E8740 VA: 0x1818EA140
	public void SetColors(Color start, Color end) { }

	// RVA: 0x18EA420 Offset: 0x18E8A20 VA: 0x1818EA420
	public void set_startColor(Color value) { }

	// RVA: 0x18EA340 Offset: 0x18E8940 VA: 0x1818EA340
	public void set_endColor(Color value) { }

	// RVA: 0x18EA2B0 Offset: 0x18E88B0 VA: 0x1818EA2B0
	public int get_positionCount() { }

	// RVA: 0x18EA390 Offset: 0x18E8990 VA: 0x1818EA390
	public void set_positionCount(int value) { }

	// RVA: 0x18EA210 Offset: 0x18E8810 VA: 0x1818EA210
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x18EA090 Offset: 0x18E8690 VA: 0x1818EA090
	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute] // RVA: 0x8DF80 Offset: 0x8D380 VA: 0x18008DF80
	// RVA: 0x18EA0F0 Offset: 0x18E86F0 VA: 0x1818EA0F0
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x8E060 Offset: 0x8D460 VA: 0x18008E060
	// RVA: 0x18EA260 Offset: 0x18E8860 VA: 0x1818EA260
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x18EA3D0 Offset: 0x18E89D0 VA: 0x1818EA3D0
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x18EA2F0 Offset: 0x18E88F0 VA: 0x1818EA2F0
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x18EA1C0 Offset: 0x18E87C0 VA: 0x1818EA1C0
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x18EA040 Offset: 0x18E8640 VA: 0x1818EA040
	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

