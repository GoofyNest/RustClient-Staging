public sealed class LineRenderer : Renderer // TypeDefIndex: 3401
{	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute] // RVA: 0x8E270 Offset: 0x8D670 VA: 0x18008E270
	public int positionCount { get; set; }


	[ObsoleteAttribute] // RVA: 0x8DF20 Offset: 0x8D320 VA: 0x18008DF20
	public void SetColors(Color start, Color end) { }

	public void set_startColor(Color value) { }

	public void set_endColor(Color value) { }

	public int get_positionCount() { }

	public void set_positionCount(int value) { }

	public void SetPosition(int index, Vector3 position) { }

	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute] // RVA: 0x8DFB0 Offset: 0x8D3B0 VA: 0x18008DFB0
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x8E050 Offset: 0x8D450 VA: 0x18008E050
	public void SetPositions(Vector3[] positions) { }

	private void set_startColor_Injected(ref Color value) { }

	private void set_endColor_Injected(ref Color value) { }

	private void SetPosition_Injected(int index, ref Vector3 position) { }

	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

