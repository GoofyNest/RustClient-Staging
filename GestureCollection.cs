public class GestureCollection : ScriptableObject // TypeDefIndex: 10086
{	// Fields
	public GestureConfig[] AllGestures; // 0x18
	public float GestureVmInDuration; // 0x20
	public AnimationCurve GestureInCurve; // 0x28
	public float GestureVmOutDuration; // 0x30
	public AnimationCurve GestureOutCurve; // 0x38
	public float GestureViewmodelDeployDelay; // 0x40

	// Methods

	// RVA: 0xC99170 Offset: 0xC97770 VA: 0x180C99170
	public GestureConfig IdToGesture(uint id) { }

	// RVA: 0xC991D0 Offset: 0xC977D0 VA: 0x180C991D0
	public GestureConfig StringToGesture(string gestureName) { }

	// RVA: 0xC99260 Offset: 0xC97860 VA: 0x180C99260
	public void .ctor() { }

}

