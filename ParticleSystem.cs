public sealed class ParticleSystem : Component // TypeDefIndex: 4527
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[NativeHeaderAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[NativeHeaderAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[NativeHeaderAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[NativeHeaderAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[RequireComponent] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[UsedByNativeCodeAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[NativeHeaderAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[NativeHeaderAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
[NativeHeaderAttribute] // RVA: 0xECAE0 Offset: 0xEBEE0 VA: 0x1800ECAE0
public sealed class ParticleSystem : Component // TypeDefIndex: 4527
	// Properties
	[ObsoleteAttribute] // RVA: 0xEE560 Offset: 0xED960 VA: 0x1800EE560
	public bool playOnAwake { get; }
	[ObsoleteAttribute] // RVA: 0xEE690 Offset: 0xEDA90 VA: 0x1800EE690
	public float duration { get; }
	[ObsoleteAttribute] // RVA: 0xEE750 Offset: 0xEDB50 VA: 0x1800EE750
	public bool enableEmission { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE870 Offset: 0xEDC70 VA: 0x1800EE870
	public float emissionRate { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE9F0 Offset: 0xEDDF0 VA: 0x1800EE9F0
	public float startSpeed { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEB50 Offset: 0xEDF50 VA: 0x1800EEB50
	public float startSize { get; set; }
	[ObsoleteAttribute] // RVA: 0xEED40 Offset: 0xEE140 VA: 0x1800EED40
	public float startLifetime { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEE80 Offset: 0xEE280 VA: 0x1800EEE80
	public float gravityModifier { get; set; }
	public bool isPlaying { get; }
	public bool isStopped { get; }
	public int particleCount { get; }
	public bool useAutoRandomSeed { set; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.ColorOverLifetimeModule colorOverLifetime { get; }
	public ParticleSystem.CollisionModule collision { get; }

	// Methods

	[ObsoleteAttribute] // RVA: 0xED190 Offset: 0xEC590 VA: 0x1800ED190
	// RVA: 0x22C6D80 Offset: 0x22C5380 VA: 0x1822C6D80
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] // RVA: 0xED2F0 Offset: 0xEC6F0 VA: 0x1800ED2F0
	// RVA: 0x22C6D30 Offset: 0x22C5330 VA: 0x1822C6D30
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x22C7810 Offset: 0x22C5E10 VA: 0x1822C7810
	public bool get_playOnAwake() { }

	// RVA: 0x22C7610 Offset: 0x22C5C10 VA: 0x1822C7610
	public float get_duration() { }

	// RVA: 0x22C76B0 Offset: 0x22C5CB0 VA: 0x1822C76B0
	public bool get_enableEmission() { }

	// RVA: 0x22C7A20 Offset: 0x22C6020 VA: 0x1822C7A20
	public void set_enableEmission(bool value) { }

	// RVA: 0x22C7660 Offset: 0x22C5C60 VA: 0x1822C7660
	public float get_emissionRate() { }

	// RVA: 0x22C7950 Offset: 0x22C5F50 VA: 0x1822C7950
	public void set_emissionRate(float value) { }

	// RVA: 0x22C7900 Offset: 0x22C5F00 VA: 0x1822C7900
	public float get_startSpeed() { }

	// RVA: 0x22C7BA0 Offset: 0x22C61A0 VA: 0x1822C7BA0
	public void set_startSpeed(float value) { }

	// RVA: 0x22C78B0 Offset: 0x22C5EB0 VA: 0x1822C78B0
	public float get_startSize() { }

	// RVA: 0x22C7B40 Offset: 0x22C6140 VA: 0x1822C7B40
	public void set_startSize(float value) { }

	// RVA: 0x22C7860 Offset: 0x22C5E60 VA: 0x1822C7860
	public float get_startLifetime() { }

	// RVA: 0x22C7AE0 Offset: 0x22C60E0 VA: 0x1822C7AE0
	public void set_startLifetime(float value) { }

	// RVA: 0x22C7700 Offset: 0x22C5D00 VA: 0x1822C7700
	public float get_gravityModifier() { }

	// RVA: 0x22C7A80 Offset: 0x22C6080 VA: 0x1822C7A80
	public void set_gravityModifier(float value) { }

	[NativeNameAttribute] // RVA: 0xED410 Offset: 0xEC810 VA: 0x1800ED410
	// RVA: 0x22C7750 Offset: 0x22C5D50 VA: 0x1822C7750
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xED4B0 Offset: 0xEC8B0 VA: 0x1800ED4B0
	// RVA: 0x22C7790 Offset: 0x22C5D90 VA: 0x1822C7790
	public bool get_isStopped() { }

	[NativeNameAttribute] // RVA: 0xED580 Offset: 0xEC980 VA: 0x1800ED580
	// RVA: 0x22C77D0 Offset: 0x22C5DD0 VA: 0x1822C77D0
	public int get_particleCount() { }

	[NativeNameAttribute] // RVA: 0xED6B0 Offset: 0xECAB0 VA: 0x1800ED6B0
	// RVA: 0x22C7C00 Offset: 0x22C6200 VA: 0x1822C7C00
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xED890 Offset: 0xECC90 VA: 0x1800ED890
	// RVA: 0x22C74B0 Offset: 0x22C5AB0 VA: 0x1822C74B0
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x22C7440 Offset: 0x22C5A40 VA: 0x1822C7440
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x22C7390 Offset: 0x22C5990 VA: 0x1822C7390
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x22C73F0 Offset: 0x22C59F0 VA: 0x1822C73F0
	public void Simulate(float t) { }

	[FreeFunctionAttribute] // RVA: 0xEDA10 Offset: 0xECE10 VA: 0x1800EDA10
	// RVA: 0x22C71E0 Offset: 0x22C57E0 VA: 0x1822C71E0
	public void Play(bool withChildren) { }

	// RVA: 0x22C71A0 Offset: 0x22C57A0 VA: 0x1822C71A0
	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0xEDA50 Offset: 0xECE50 VA: 0x1800EDA50
	// RVA: 0x22C7110 Offset: 0x22C5710 VA: 0x1822C7110
	public void Pause(bool withChildren) { }

	// RVA: 0x22C7160 Offset: 0x22C5760 VA: 0x1822C7160
	public void Pause() { }

	[FreeFunctionAttribute] // RVA: 0xEDB60 Offset: 0xECF60 VA: 0x1800EDB60
	// RVA: 0x22C7560 Offset: 0x22C5B60 VA: 0x1822C7560
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x22C75C0 Offset: 0x22C5BC0 VA: 0x1822C75C0
	public void Stop(bool withChildren) { }

	// RVA: 0x22C7520 Offset: 0x22C5B20 VA: 0x1822C7520
	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0xEDC70 Offset: 0xED070 VA: 0x1800EDC70
	// RVA: 0x22C6B60 Offset: 0x22C5160 VA: 0x1822C6B60
	public void Clear(bool withChildren) { }

	// RVA: 0x22C6BB0 Offset: 0x22C51B0 VA: 0x1822C6BB0
	public void Clear() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22C6CF0 Offset: 0x22C52F0 VA: 0x1822C6CF0
	public void Emit(int count) { }

	[NativeNameAttribute] // RVA: 0xEDDE0 Offset: 0xED1E0 VA: 0x1800EDDE0
	// RVA: 0x22C6CF0 Offset: 0x22C52F0 VA: 0x1822C6CF0
	private void Emit_Internal(int count) { }

	[NativeNameAttribute] // RVA: 0xEDEE0 Offset: 0xED2E0 VA: 0x1800EDEE0
	// RVA: 0x22C6FD0 Offset: 0x22C55D0 VA: 0x1822C6FD0
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] // RVA: 0xEE0C0 Offset: 0xED4C0 VA: 0x1800EE0C0
	// RVA: 0x22C6C40 Offset: 0x22C5240 VA: 0x1822C6C40
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x22C7030 Offset: 0x22C5630 VA: 0x1822C7030
	internal void* GetManagedJobData() { }

	// RVA: 0x22C70C0 Offset: 0x22C56C0 VA: 0x1822C70C0
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x22C7340 Offset: 0x22C5940 VA: 0x1822C7340
	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0xEAB20 Offset: 0xE9F20 VA: 0x1800EAB20
	// RVA: 0x22C7290 Offset: 0x22C5890 VA: 0x1822C7290
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] // RVA: 0x93BC0 Offset: 0x92FC0 VA: 0x180093BC0
	// RVA: 0x22C6BF0 Offset: 0x22C51F0 VA: 0x1822C6BF0
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	// RVA: 0x14A02C0 Offset: 0x149E8C0 VA: 0x1814A02C0
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x14A02C0 Offset: 0x149E8C0 VA: 0x1814A02C0
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x14A02C0 Offset: 0x149E8C0 VA: 0x1814A02C0
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x14A02C0 Offset: 0x149E8C0 VA: 0x1814A02C0
	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0x14A02C0 Offset: 0x149E8C0 VA: 0x1814A02C0
	public ParticleSystem.CollisionModule get_collision() { }

	// RVA: 0x22C6C90 Offset: 0x22C5290 VA: 0x1822C6C90
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x22C7070 Offset: 0x22C5670 VA: 0x1822C7070
	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0x22C72F0 Offset: 0x22C58F0 VA: 0x1822C72F0
	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0x22C7230 Offset: 0x22C5830 VA: 0x1822C7230
	private static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) { }

}

public struct ParticleSystem.MainModule // TypeDefIndex: 4528
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public float duration { get; }
	public ParticleSystem.MinMaxCurve startLifetime { get; set; }
	public float startLifetimeMultiplier { get; set; }
	public ParticleSystem.MinMaxCurve startSpeed { get; set; }
	public float startSpeedMultiplier { get; set; }
	[NativeNameAttribute] // RVA: 0xEF090 Offset: 0xEE490 VA: 0x1800EF090
	public ParticleSystem.MinMaxCurve startSize { get; set; }
	[NativeNameAttribute] // RVA: 0xEF190 Offset: 0xEE590 VA: 0x1800EF190
	public float startSizeMultiplier { get; set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	public float gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { set; }
	public bool playOnAwake { get; }
	public int maxParticles { get; set; }
	public ParticleSystemCullingMode cullingMode { set; }

	// Methods

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B800 Offset: 0x23AC00 VA: 0x18023B800
	public float get_duration() { }

	// RVA: 0x23B9A0 Offset: 0x23ADA0 VA: 0x18023B9A0
	public ParticleSystem.MinMaxCurve get_startLifetime() { }

	// RVA: 0x23BD00 Offset: 0x23B100 VA: 0x18023BD00
	public void set_startLifetime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B960 Offset: 0x23AD60 VA: 0x18023B960
	public float get_startLifetimeMultiplier() { }

	// RVA: 0x23BCB0 Offset: 0x23B0B0 VA: 0x18023BCB0
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x23BAC0 Offset: 0x23AEC0 VA: 0x18023BAC0
	public ParticleSystem.MinMaxCurve get_startSpeed() { }

	// RVA: 0x23BE40 Offset: 0x23B240 VA: 0x18023BE40
	public void set_startSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23BA80 Offset: 0x23AE80 VA: 0x18023BA80
	public float get_startSpeedMultiplier() { }

	// RVA: 0x23BDF0 Offset: 0x23B1F0 VA: 0x18023BDF0
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x23BA30 Offset: 0x23AE30 VA: 0x18023BA30
	public ParticleSystem.MinMaxCurve get_startSize() { }

	// RVA: 0x23BDA0 Offset: 0x23B1A0 VA: 0x18023BDA0
	public void set_startSize(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B9F0 Offset: 0x23ADF0 VA: 0x18023B9F0
	public float get_startSizeMultiplier() { }

	// RVA: 0x23BD50 Offset: 0x23B150 VA: 0x18023BD50
	public void set_startSizeMultiplier(float value) { }

	// RVA: 0x23B900 Offset: 0x23AD00 VA: 0x18023B900
	public ParticleSystem.MinMaxGradient get_startColor() { }

	// RVA: 0x23BC50 Offset: 0x23B050 VA: 0x18023BC50
	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x23B840 Offset: 0x23AC40 VA: 0x18023B840
	public float get_gravityModifierMultiplier() { }

	// RVA: 0x23BB60 Offset: 0x23AF60 VA: 0x18023BB60
	public void set_gravityModifierMultiplier(float value) { }

	// RVA: 0x23BC00 Offset: 0x23B000 VA: 0x18023BC00
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x23B8C0 Offset: 0x23ACC0 VA: 0x18023B8C0
	public bool get_playOnAwake() { }

	// RVA: 0x23B880 Offset: 0x23AC80 VA: 0x18023B880
	public int get_maxParticles() { }

	// RVA: 0x23BBB0 Offset: 0x23AFB0 VA: 0x18023BBB0
	public void set_maxParticles(int value) { }

	// RVA: 0x23BB10 Offset: 0x23AF10 VA: 0x18023BB10
	public void set_cullingMode(ParticleSystemCullingMode value) { }

	// RVA: 0x22C5AB0 Offset: 0x22C40B0 VA: 0x1822C5AB0
	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5CA0 Offset: 0x22C42A0 VA: 0x1822C5CA0
	private static void get_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C6100 Offset: 0x22C4700 VA: 0x1822C6100
	private static void set_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C5C60 Offset: 0x22C4260 VA: 0x1822C5C60
	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C60B0 Offset: 0x22C46B0 VA: 0x1822C60B0
	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C5E60 Offset: 0x22C4460 VA: 0x1822C5E60
	private static void get_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C62E0 Offset: 0x22C48E0 VA: 0x1822C62E0
	private static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C5E20 Offset: 0x22C4420 VA: 0x1822C5E20
	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C6290 Offset: 0x22C4890 VA: 0x1822C6290
	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C5D80 Offset: 0x22C4380 VA: 0x1822C5D80
	private static void get_startSize_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C61F0 Offset: 0x22C47F0 VA: 0x1822C61F0
	private static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C5D40 Offset: 0x22C4340 VA: 0x1822C5D40
	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C61A0 Offset: 0x22C47A0 VA: 0x1822C61A0
	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C5BB0 Offset: 0x22C41B0 VA: 0x1822C5BB0
	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	// RVA: 0x22C6010 Offset: 0x22C4610 VA: 0x1822C6010
	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x22C5AF0 Offset: 0x22C40F0 VA: 0x1822C5AF0
	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5F40 Offset: 0x22C4540 VA: 0x1822C5F40
	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C5FD0 Offset: 0x22C45D0 VA: 0x1822C5FD0
	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0x22C5B70 Offset: 0x22C4170 VA: 0x1822C5B70
	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5B30 Offset: 0x22C4130 VA: 0x1822C5B30
	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5F90 Offset: 0x22C4590 VA: 0x1822C5F90
	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	// RVA: 0x22C5F00 Offset: 0x22C4500 VA: 0x1822C5F00
	private static void set_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemCullingMode value) { }

}

public struct ParticleSystem.EmissionModule // TypeDefIndex: 4529
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	[ObsoleteAttribute] // RVA: 0xEF3B0 Offset: 0xEE7B0 VA: 0x1800EF3B0
	public ParticleSystem.MinMaxCurve rate { set; }
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { get; set; }
	public float rateOverTimeMultiplier { get; set; }

	// Methods

	// RVA: 0x23B4F0 Offset: 0x23A8F0 VA: 0x18023B4F0
	public void set_rate(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B380 Offset: 0x23A780 VA: 0x18023B380
	public bool get_enabled() { }

	// RVA: 0x23B450 Offset: 0x23A850 VA: 0x18023B450
	public void set_enabled(bool value) { }

	// RVA: 0x23B400 Offset: 0x23A800 VA: 0x18023B400
	public ParticleSystem.MinMaxCurve get_rateOverTime() { }

	// RVA: 0x23B4F0 Offset: 0x23A8F0 VA: 0x18023B4F0
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B3C0 Offset: 0x23A7C0 VA: 0x18023B3C0
	public float get_rateOverTimeMultiplier() { }

	// RVA: 0x23B4A0 Offset: 0x23A8A0 VA: 0x18023B4A0
	public void set_rateOverTimeMultiplier(float value) { }

	// RVA: 0x23B310 Offset: 0x23A710 VA: 0x18023B310
	public void SetBurst(int index, ParticleSystem.Burst burst) { }

	// RVA: 0x23B2A0 Offset: 0x23A6A0 VA: 0x18023B2A0
	public ParticleSystem.Burst GetBurst(int index) { }

	// RVA: 0x22C5780 Offset: 0x22C3D80 VA: 0x1822C5780
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x22C58A0 Offset: 0x22C3EA0 VA: 0x1822C58A0
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x22C5800 Offset: 0x22C3E00 VA: 0x1822C5800
	private static void get_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C5940 Offset: 0x22C3F40 VA: 0x1822C5940
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C57C0 Offset: 0x22C3DC0 VA: 0x1822C57C0
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x22C58F0 Offset: 0x22C3EF0 VA: 0x1822C58F0
	private static void set_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self, float value) { }

	// RVA: 0x22C56E0 Offset: 0x22C3CE0 VA: 0x1822C56E0
	private static void SetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, ref ParticleSystem.Burst burst) { }

	// RVA: 0x22C5620 Offset: 0x22C3C20 VA: 0x1822C5620
	private static void GetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, out ParticleSystem.Burst ret) { }

}

public struct ParticleSystem.ShapeModule // TypeDefIndex: 4530
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public ParticleSystemShapeType shapeType { set; }
	public float randomDirectionAmount { set; }
	public float radius { get; set; }
	public float angle { set; }
	public float length { set; }
	public MeshRenderer meshRenderer { set; }
	public float arc { set; }
	public Vector3 position { set; }
	public Vector3 rotation { get; }
	public Vector3 scale { set; }

	// Methods

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23C540 Offset: 0x23B940 VA: 0x18023C540
	public void set_shapeType(ParticleSystemShapeType value) { }

	// RVA: 0x23C4A0 Offset: 0x23B8A0 VA: 0x18023C4A0
	public void set_randomDirectionAmount(float value) { }

	// RVA: 0x23C230 Offset: 0x23B630 VA: 0x18023C230
	public float get_radius() { }

	// RVA: 0x23C450 Offset: 0x23B850 VA: 0x18023C450
	public void set_radius(float value) { }

	// RVA: 0x23C2C0 Offset: 0x23B6C0 VA: 0x18023C2C0
	public void set_angle(float value) { }

	// RVA: 0x23C360 Offset: 0x23B760 VA: 0x18023C360
	public void set_length(float value) { }

	// RVA: 0x23C3B0 Offset: 0x23B7B0 VA: 0x18023C3B0
	public void set_meshRenderer(MeshRenderer value) { }

	// RVA: 0x23C310 Offset: 0x23B710 VA: 0x18023C310
	public void set_arc(float value) { }

	// RVA: 0x23C400 Offset: 0x23B800 VA: 0x18023C400
	public void set_position(Vector3 value) { }

	// RVA: 0x23C270 Offset: 0x23B670 VA: 0x18023C270
	public Vector3 get_rotation() { }

	// RVA: 0x23C4F0 Offset: 0x23B8F0 VA: 0x18023C4F0
	public void set_scale(Vector3 value) { }

	// RVA: 0x22C8050 Offset: 0x22C6650 VA: 0x1822C8050
	private static void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value) { }

	// RVA: 0x22C7F60 Offset: 0x22C6560 VA: 0x1822C7F60
	private static void set_randomDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7C50 Offset: 0x22C6250 VA: 0x1822C7C50
	private static float get_radius_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x22C7F10 Offset: 0x22C6510 VA: 0x1822C7F10
	private static void set_radius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7D30 Offset: 0x22C6330 VA: 0x1822C7D30
	private static void set_angle_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7DD0 Offset: 0x22C63D0 VA: 0x1822C7DD0
	private static void set_length_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7E20 Offset: 0x22C6420 VA: 0x1822C7E20
	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, MeshRenderer value) { }

	// RVA: 0x22C7D80 Offset: 0x22C6380 VA: 0x1822C7D80
	private static void set_arc_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7E70 Offset: 0x22C6470 VA: 0x1822C7E70
	private static void set_position_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0x22C7C90 Offset: 0x22C6290 VA: 0x1822C7C90
	private static void get_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0x22C7FB0 Offset: 0x22C65B0 VA: 0x1822C7FB0
	private static void set_scale_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

}

public struct ParticleSystem.Particle // TypeDefIndex: 4531
{	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	// Properties
	[ObsoleteAttribute] // RVA: 0xEF7C0 Offset: 0xEEBC0 VA: 0x1800EF7C0
	public float lifetime { set; }
	public Vector3 position { set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0x23C100 Offset: 0x23B500 VA: 0x18023C100
	public void set_lifetime(float value) { }

	// RVA: 0x204FB0 Offset: 0x2043B0 VA: 0x180204FB0
	public void set_position(Vector3 value) { }

	// RVA: 0x212D40 Offset: 0x212140 VA: 0x180212D40
	public void set_velocity(Vector3 value) { }

	// RVA: 0x23C100 Offset: 0x23B500 VA: 0x18023C100
	public void set_remainingLifetime(float value) { }

	// RVA: 0x23C1D0 Offset: 0x23B5D0 VA: 0x18023C1D0
	public void set_startLifetime(float value) { }

	// RVA: 0x23C1C0 Offset: 0x23B5C0 VA: 0x18023C1C0
	public void set_startColor(Color32 value) { }

	// RVA: 0x23C110 Offset: 0x23B510 VA: 0x18023C110
	public void set_randomSeed(uint value) { }

	// RVA: 0x23C1E0 Offset: 0x23B5E0 VA: 0x18023C1E0
	public void set_startSize(float value) { }

	// RVA: 0x23C120 Offset: 0x23B520 VA: 0x18023C120
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x23C060 Offset: 0x23B460 VA: 0x18023C060
	public void set_angularVelocity3D(Vector3 value) { }

}

public struct ParticleSystem.Burst // TypeDefIndex: 4532
{	// Fields
	private float m_Time; // 0x0
	private ParticleSystem.MinMaxCurve m_Count; // 0x8
	private int m_RepeatCount; // 0x28
	private float m_RepeatInterval; // 0x2C
	private float m_InvProbability; // 0x30

	// Properties
	public float probability { set; }

	// Methods

	// RVA: 0x23B050 Offset: 0x23A450 VA: 0x18023B050
	public void set_probability(float value) { }

}

public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 4533
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_CurveMultiplier; // 0x4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AnimationCurve m_CurveMin; // 0x8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AnimationCurve m_CurveMax; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_ConstantMin; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float m_ConstantMax; // 0x1C

	// Properties
	public ParticleSystemCurveMode mode { set; }
	public float constantMax { get; set; }
	public float constantMin { set; }
	public float constant { get; set; }

	// Methods

	// RVA: 0x23BEB0 Offset: 0x23B2B0 VA: 0x18023BEB0
	public void .ctor(float constant) { }

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_mode(ParticleSystemCurveMode value) { }

	// RVA: 0x239650 Offset: 0x238A50 VA: 0x180239650
	public float get_constantMax() { }

	// RVA: 0x2398B0 Offset: 0x238CB0 VA: 0x1802398B0
	public void set_constantMax(float value) { }

	// RVA: 0x239620 Offset: 0x238A20 VA: 0x180239620
	public void set_constantMin(float value) { }

	// RVA: 0x239650 Offset: 0x238A50 VA: 0x180239650
	public float get_constant() { }

	// RVA: 0x2398B0 Offset: 0x238CB0 VA: 0x1802398B0
	public void set_constant(float value) { }

	// RVA: 0x22C6380 Offset: 0x22C4980 VA: 0x1822C6380
	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }

}

public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 4534
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Gradient m_GradientMin; // 0x8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Gradient m_GradientMax; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_ColorMin; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Color m_ColorMax; // 0x28

	// Properties
	public ParticleSystemGradientMode mode { set; }
	public Color color { get; set; }
	public Gradient gradient { set; }

	// Methods

	// RVA: 0x23BF00 Offset: 0x23B300 VA: 0x18023BF00
	public void .ctor(Color color) { }

	// RVA: 0x23BF60 Offset: 0x23B360 VA: 0x18023BF60
	public void .ctor(Gradient gradient) { }

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_mode(ParticleSystemGradientMode value) { }

	// RVA: 0x23BF70 Offset: 0x23B370 VA: 0x18023BF70
	public Color get_color() { }

	// RVA: 0x23BF80 Offset: 0x23B380 VA: 0x18023BF80
	public void set_color(Color value) { }

	// RVA: 0xF14F0 Offset: 0xF08F0 VA: 0x1800F14F0
	public void set_gradient(Gradient value) { }

	// RVA: 0x22C64F0 Offset: 0x22C4AF0 VA: 0x1822C64F0
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }

	// RVA: 0x22C65B0 Offset: 0x22C4BB0 VA: 0x1822C65B0
	public static ParticleSystem.MinMaxGradient op_Implicit(Gradient gradient) { }

}

public struct ParticleSystem.EmitParams // TypeDefIndex: 4535
{	// Fields
	[NativeNameAttribute] // RVA: 0xF03A0 Offset: 0xEF7A0 VA: 0x1800F03A0
	private ParticleSystem.Particle m_Particle; // 0x0
	[NativeNameAttribute] // RVA: 0xF0500 Offset: 0xEF900 VA: 0x1800F0500
	private bool m_PositionSet; // 0x84
	[NativeNameAttribute] // RVA: 0xF0670 Offset: 0xEFA70 VA: 0x1800F0670
	private bool m_VelocitySet; // 0x85
	[NativeNameAttribute] // RVA: 0xF0790 Offset: 0xEFB90 VA: 0x1800F0790
	private bool m_AxisOfRotationSet; // 0x86
	[NativeNameAttribute] // RVA: 0xF08A0 Offset: 0xEFCA0 VA: 0x1800F08A0
	private bool m_RotationSet; // 0x87
	[NativeNameAttribute] // RVA: 0xF09B0 Offset: 0xEFDB0 VA: 0x1800F09B0
	private bool m_AngularVelocitySet; // 0x88
	[NativeNameAttribute] // RVA: 0xF0BF0 Offset: 0xEFFF0 VA: 0x1800F0BF0
	private bool m_StartSizeSet; // 0x89
	[NativeNameAttribute] // RVA: 0xF0E70 Offset: 0xF0270 VA: 0x1800F0E70
	private bool m_StartColorSet; // 0x8A
	[NativeNameAttribute] // RVA: 0xF0EE0 Offset: 0xF02E0 VA: 0x1800F0EE0
	private bool m_RandomSeedSet; // 0x8B
	[NativeNameAttribute] // RVA: 0x6F3B0 Offset: 0x6E7B0 VA: 0x18006F3B0
	private bool m_StartLifetimeSet; // 0x8C
	[NativeNameAttribute] // RVA: 0x6F630 Offset: 0x6EA30 VA: 0x18006F630
	private bool m_MeshIndexSet; // 0x8D
	[NativeNameAttribute] // RVA: 0x6F7D0 Offset: 0x6EBD0 VA: 0x18006F7D0
	private bool m_ApplyShapeToPosition; // 0x8E

	// Properties
	public Vector3 position { set; }
	public float startSize { set; }
	public Color32 startColor { set; }

	// Methods

	// RVA: 0x23B560 Offset: 0x23A960 VA: 0x18023B560
	public void set_position(Vector3 value) { }

	// RVA: 0x23B590 Offset: 0x23A990 VA: 0x18023B590
	public void set_startSize(float value) { }

	// RVA: 0x23B580 Offset: 0x23A980 VA: 0x18023B580
	public void set_startColor(Color32 value) { }

}

public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 4536
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public ParticleSystem.MinMaxGradient color { set; }

	// Methods

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B220 Offset: 0x23A620 VA: 0x18023B220
	public void set_color(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x22C5580 Offset: 0x22C3B80 VA: 0x1822C5580
	private static void set_color_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

}

public struct ParticleSystem.CollisionModule // TypeDefIndex: 4537
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; set; }
	public ParticleSystemCollisionQuality quality { set; }

	// Methods

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B120 Offset: 0x23A520 VA: 0x18023B120
	public bool get_enabled() { }

	// RVA: 0x23B160 Offset: 0x23A560 VA: 0x18023B160
	public void set_enabled(bool value) { }

	// RVA: 0x23B1B0 Offset: 0x23A5B0 VA: 0x18023B1B0
	public void set_quality(ParticleSystemCollisionQuality value) { }

	// RVA: 0x22C54B0 Offset: 0x22C3AB0 VA: 0x1822C54B0
	private static bool get_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self) { }

	// RVA: 0x22C54F0 Offset: 0x22C3AF0 VA: 0x1822C54F0
	private static void set_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self, bool value) { }

	// RVA: 0x22C5540 Offset: 0x22C3B40 VA: 0x1822C5540
	private static void set_quality_Injected(ref ParticleSystem.CollisionModule _unity_self, ParticleSystemCollisionQuality value) { }

}

