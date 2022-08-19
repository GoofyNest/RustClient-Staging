public class BlendedEngineLoopDefinition : ScriptableObject // TypeDefIndex: 8981
{	// Fields
	public BlendedEngineLoopDefinition.EngineLoopDefinition[] engineLoops; // 0x18
	public float minRPM; // 0x20
	public float maxRPM; // 0x24
	public float RPMChangeRateUp; // 0x28
	public float RPMChangeRateDown; // 0x2C

	// Methods

	// RVA: 0x512EB0 Offset: 0x5114B0 VA: 0x180512EB0
	public void .ctor() { }

}

public class BlendedEngineLoopDefinition.EngineLoopDefinition // TypeDefIndex: 8982
{	// Fields
	public SoundDefinition soundDefinition; // 0x10
	public float RPM; // 0x18
	public float startRPM; // 0x1C
	public float startFullRPM; // 0x20
	public float stopFullRPM; // 0x24
	public float stopRPM; // 0x28

	// Methods

	// RVA: 0x5226B0 Offset: 0x520CB0 VA: 0x1805226B0
	public float GetPitchForRPM(float targetRPM) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

