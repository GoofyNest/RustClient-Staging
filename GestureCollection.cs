public class GestureCollection : ScriptableObject // TypeDefIndex: 10086
{	// Fields
	public GestureConfig[] AllGestures; // 0x18
	public float GestureVmInDuration; // 0x20
	public AnimationCurve GestureInCurve; // 0x28
	public float GestureVmOutDuration; // 0x30
	public AnimationCurve GestureOutCurve; // 0x38
	public float GestureViewmodelDeployDelay; // 0x40

	// Methods

	// RVA: 0xC98CD0 Offset: 0xC972D0 VA: 0x180C98CD0
	public GestureConfig IdToGesture(uint id) { }

	// RVA: 0xC98D30 Offset: 0xC97330 VA: 0x180C98D30
	public GestureConfig StringToGesture(string gestureName) { }

	// RVA: 0xC98DC0 Offset: 0xC973C0 VA: 0x180C98DC0
	public void .ctor() { }

}

