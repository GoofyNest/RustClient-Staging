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

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public BlendedLoopEngineSound.EngineLoop[] GetEngineLoops() { }

	// RVA: 0x512E60 Offset: 0x511460 VA: 0x180512E60
	public float GetLoopGain(int idx) { }

	// RVA: 0x512EB0 Offset: 0x5114B0 VA: 0x180512EB0
	public float GetLoopPitch(int idx) { }

	// RVA: 0x513360 Offset: 0x511960 VA: 0x180513360
	public float get_maxDistance() { }

	// RVA: 0x512F00 Offset: 0x511500 VA: 0x180512F00
	public void Init(BlendedEngineLoopDefinition definition) { }

	// RVA: 0x513140 Offset: 0x511740 VA: 0x180513140
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

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(BlendedEngineLoopDefinition.EngineLoopDefinition definition, BlendedLoopEngineSound parent) { }

	// RVA: 0x522880 Offset: 0x520E80 VA: 0x180522880
	public void Update(float RPM, float cameraDistance) { }

	// RVA: 0x522650 Offset: 0x520C50 VA: 0x180522650
	public void CreateSound() { }

	// RVA: 0x5227A0 Offset: 0x520DA0 VA: 0x1805227A0
	public void RecycleSound() { }

}

