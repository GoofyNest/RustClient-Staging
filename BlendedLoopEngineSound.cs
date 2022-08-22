public class BlendedLoopEngineSound : MonoBehaviour, IClientComponent // TypeDefIndex: 8983
{	// Fields
	public BlendedEngineLoopDefinition loopDefinition; // 0x18
	public bool engineOn; // 0x20
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float RPMControl; // 0x24
	public float smoothedRPMControl; // 0x28
	private BlendedLoopEngineSound.EngineLoop[] engineLoops; // 0x30

	// Properties
	public float maxDistance { get; }

	// Methods

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public BlendedLoopEngineSound.EngineLoop[] GetEngineLoops() { }

	// RVA: 0x512ED0 Offset: 0x5114D0 VA: 0x180512ED0
	public float GetLoopGain(int idx) { }

	// RVA: 0x512F20 Offset: 0x511520 VA: 0x180512F20
	public float GetLoopPitch(int idx) { }

	// RVA: 0x5133D0 Offset: 0x5119D0 VA: 0x1805133D0
	public float get_maxDistance() { }

	// RVA: 0x512F70 Offset: 0x511570 VA: 0x180512F70
	public void Init(BlendedEngineLoopDefinition definition) { }

	// RVA: 0x5131B0 Offset: 0x5117B0 VA: 0x1805131B0
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class BlendedLoopEngineSound.EngineLoop // TypeDefIndex: 8984
{	// Fields
	public BlendedEngineLoopDefinition.EngineLoopDefinition definition; // 0x10
	public BlendedLoopEngineSound parent; // 0x18
	public Sound sound; // 0x20
	public SoundModulation.Modulator gainMod; // 0x28
	public SoundModulation.Modulator pitchMod; // 0x30

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(BlendedEngineLoopDefinition.EngineLoopDefinition definition, BlendedLoopEngineSound parent) { }

	// RVA: 0x5228F0 Offset: 0x520EF0 VA: 0x1805228F0
	public void Update(float RPM, float cameraDistance) { }

	// RVA: 0x5226C0 Offset: 0x520CC0 VA: 0x1805226C0
	public void CreateSound() { }

	// RVA: 0x522810 Offset: 0x520E10 VA: 0x180522810
	public void RecycleSound() { }

}

