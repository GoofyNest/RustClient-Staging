public class GestureCollection : ScriptableObject // TypeDefIndex: 10086
{	// Fields
	public GestureConfig[] AllGestures; // 0x18
	public float GestureVmInDuration; // 0x20
	public AnimationCurve GestureInCurve; // 0x28
	public float GestureVmOutDuration; // 0x30
	public AnimationCurve GestureOutCurve; // 0x38
	public float GestureViewmodelDeployDelay; // 0x40

	// Methods

	// RVA: 0xC98A10 Offset: 0xC97010 VA: 0x180C98A10
	public GestureConfig IdToGesture(uint id) { }

	// RVA: 0xC98A70 Offset: 0xC97070 VA: 0x180C98A70
	public GestureConfig StringToGesture(string gestureName) { }

	// RVA: 0xC98B00 Offset: 0xC97100 VA: 0x180C98B00
	public void .ctor() { }

}

