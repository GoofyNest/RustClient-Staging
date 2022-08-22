public sealed class ParticleSystem : Component // TypeDefIndex: 4527
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[RequireComponent] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[UsedByNativeCodeAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
[NativeHeaderAttribute] // RVA: 0xECB30 Offset: 0xEBF30 VA: 0x1800ECB30
public sealed class ParticleSystem : Component // TypeDefIndex: 4527
	// Properties
	[ObsoleteAttribute] // RVA: 0xEE630 Offset: 0xEDA30 VA: 0x1800EE630
	public bool playOnAwake { get; }
	[ObsoleteAttribute] // RVA: 0xEE6A0 Offset: 0xEDAA0 VA: 0x1800EE6A0
	public float duration { get; }
	[ObsoleteAttribute] // RVA: 0xEE810 Offset: 0xEDC10 VA: 0x1800EE810
	public bool enableEmission { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE940 Offset: 0xEDD40 VA: 0x1800EE940
	public float emissionRate { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEA70 Offset: 0xEDE70 VA: 0x1800EEA70
	public float startSpeed { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEBD0 Offset: 0xEDFD0 VA: 0x1800EEBD0
	public float startSize { get; set; }
	[ObsoleteAttribute] // RVA: 0xEED40 Offset: 0xEE140 VA: 0x1800EED40
	public float startLifetime { get; set; }
	[ObsoleteAttribute] // RVA: 0xEEF00 Offset: 0xEE300 VA: 0x1800EEF00
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

	[ObsoleteAttribute] // RVA: 0xED260 Offset: 0xEC660 VA: 0x1800ED260
	// RVA: 0x22C6BC0 Offset: 0x22C51C0 VA: 0x1822C6BC0
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] // RVA: 0xED3A0 Offset: 0xEC7A0 VA: 0x1800ED3A0
	// RVA: 0x22C6B70 Offset: 0x22C5170 VA: 0x1822C6B70
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x22C7650 Offset: 0x22C5C50 VA: 0x1822C7650
	public bool get_playOnAwake() { }

	// RVA: 0x22C7450 Offset: 0x22C5A50 VA: 0x1822C7450
	public float get_duration() { }

	// RVA: 0x22C74F0 Offset: 0x22C5AF0 VA: 0x1822C74F0
	public bool get_enableEmission() { }

	// RVA: 0x22C7860 Offset: 0x22C5E60 VA: 0x1822C7860
	public void set_enableEmission(bool value) { }

	// RVA: 0x22C74A0 Offset: 0x22C5AA0 VA: 0x1822C74A0
	public float get_emissionRate() { }

	// RVA: 0x22C7790 Offset: 0x22C5D90 VA: 0x1822C7790
	public void set_emissionRate(float value) { }

	// RVA: 0x22C7740 Offset: 0x22C5D40 VA: 0x1822C7740
	public float get_startSpeed() { }

	// RVA: 0x22C79E0 Offset: 0x22C5FE0 VA: 0x1822C79E0
	public void set_startSpeed(float value) { }

	// RVA: 0x22C76F0 Offset: 0x22C5CF0 VA: 0x1822C76F0
	public float get_startSize() { }

	// RVA: 0x22C7980 Offset: 0x22C5F80 VA: 0x1822C7980
	public void set_startSize(float value) { }

	// RVA: 0x22C76A0 Offset: 0x22C5CA0 VA: 0x1822C76A0
	public float get_startLifetime() { }

	// RVA: 0x22C7920 Offset: 0x22C5F20 VA: 0x1822C7920
	public void set_startLifetime(float value) { }

	// RVA: 0x22C7540 Offset: 0x22C5B40 VA: 0x1822C7540
	public float get_gravityModifier() { }

	// RVA: 0x22C78C0 Offset: 0x22C5EC0 VA: 0x1822C78C0
	public void set_gravityModifier(float value) { }

	[NativeNameAttribute] // RVA: 0xED420 Offset: 0xEC820 VA: 0x1800ED420
	// RVA: 0x22C7590 Offset: 0x22C5B90 VA: 0x1822C7590
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xED500 Offset: 0xEC900 VA: 0x1800ED500
	// RVA: 0x22C75D0 Offset: 0x22C5BD0 VA: 0x1822C75D0
	public bool get_isStopped() { }

	[NativeNameAttribute] // RVA: 0xED600 Offset: 0xECA00 VA: 0x1800ED600
	// RVA: 0x22C7610 Offset: 0x22C5C10 VA: 0x1822C7610
	public int get_particleCount() { }

	[NativeNameAttribute] // RVA: 0xED6B0 Offset: 0xECAB0 VA: 0x1800ED6B0
	// RVA: 0x22C7A40 Offset: 0x22C6040 VA: 0x1822C7A40
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xED910 Offset: 0xECD10 VA: 0x1800ED910
	// RVA: 0x22C72F0 Offset: 0x22C58F0 VA: 0x1822C72F0
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x22C7280 Offset: 0x22C5880 VA: 0x1822C7280
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x22C71D0 Offset: 0x22C57D0 VA: 0x1822C71D0
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x22C7230 Offset: 0x22C5830 VA: 0x1822C7230
	public void Simulate(float t) { }

	[FreeFunctionAttribute] // RVA: 0xED9E0 Offset: 0xECDE0 VA: 0x1800ED9E0
	// RVA: 0x22C7020 Offset: 0x22C5620 VA: 0x1822C7020
	public void Play(bool withChildren) { }

	// RVA: 0x22C6FE0 Offset: 0x22C55E0 VA: 0x1822C6FE0
	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0xEDB00 Offset: 0xECF00 VA: 0x1800EDB00
	// RVA: 0x22C6F50 Offset: 0x22C5550 VA: 0x1822C6F50
	public void Pause(bool withChildren) { }

	// RVA: 0x22C6FA0 Offset: 0x22C55A0 VA: 0x1822C6FA0
	public void Pause() { }

	[FreeFunctionAttribute] // RVA: 0xEDC10 Offset: 0xED010 VA: 0x1800EDC10
	// RVA: 0x22C73A0 Offset: 0x22C59A0 VA: 0x1822C73A0
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x22C7400 Offset: 0x22C5A00 VA: 0x1822C7400
	public void Stop(bool withChildren) { }

	// RVA: 0x22C7360 Offset: 0x22C5960 VA: 0x1822C7360
	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0xEDCC0 Offset: 0xED0C0 VA: 0x1800EDCC0
	// RVA: 0x22C69A0 Offset: 0x22C4FA0 VA: 0x1822C69A0
	public void Clear(bool withChildren) { }

	// RVA: 0x22C69F0 Offset: 0x22C4FF0 VA: 0x1822C69F0
	public void Clear() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22C6B30 Offset: 0x22C5130 VA: 0x1822C6B30
	public void Emit(int count) { }

	[NativeNameAttribute] // RVA: 0xEDE30 Offset: 0xED230 VA: 0x1800EDE30
	// RVA: 0x22C6B30 Offset: 0x22C5130 VA: 0x1822C6B30
	private void Emit_Internal(int count) { }

	[NativeNameAttribute] // RVA: 0xEE010 Offset: 0xED410 VA: 0x1800EE010
	// RVA: 0x22C6E10 Offset: 0x22C5410 VA: 0x1822C6E10
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] // RVA: 0xEE110 Offset: 0xED510 VA: 0x1800EE110
	// RVA: 0x22C6A80 Offset: 0x22C5080 VA: 0x1822C6A80
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x22C6E70 Offset: 0x22C5470 VA: 0x1822C6E70
	internal void* GetManagedJobData() { }

	// RVA: 0x22C6F00 Offset: 0x22C5500 VA: 0x1822C6F00
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x22C7180 Offset: 0x22C5780 VA: 0x1822C7180
	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0xEAAE0 Offset: 0xE9EE0 VA: 0x1800EAAE0
	// RVA: 0x22C70D0 Offset: 0x22C56D0 VA: 0x1822C70D0
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22C6A30 Offset: 0x22C5030 VA: 0x1822C6A30
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

	// RVA: 0x22C6AD0 Offset: 0x22C50D0 VA: 0x1822C6AD0
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x22C6EB0 Offset: 0x22C54B0 VA: 0x1822C6EB0
	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0x22C7130 Offset: 0x22C5730 VA: 0x1822C7130
	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0x22C7070 Offset: 0x22C5670 VA: 0x1822C7070
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
	[NativeNameAttribute] // RVA: 0xEF150 Offset: 0xEE550 VA: 0x1800EF150
	public ParticleSystem.MinMaxCurve startSize { get; set; }
	[NativeNameAttribute] // RVA: 0xEF260 Offset: 0xEE660 VA: 0x1800EF260
	public float startSizeMultiplier { get; set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	public float gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { set; }
	public bool playOnAwake { get; }
	public int maxParticles { get; set; }
	public ParticleSystemCullingMode cullingMode { set; }

	// Methods

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B780 Offset: 0x23AB80 VA: 0x18023B780
	public float get_duration() { }

	// RVA: 0x23B920 Offset: 0x23AD20 VA: 0x18023B920
	public ParticleSystem.MinMaxCurve get_startLifetime() { }

	// RVA: 0x23BC80 Offset: 0x23B080 VA: 0x18023BC80
	public void set_startLifetime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B8E0 Offset: 0x23ACE0 VA: 0x18023B8E0
	public float get_startLifetimeMultiplier() { }

	// RVA: 0x23BC30 Offset: 0x23B030 VA: 0x18023BC30
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x23BA40 Offset: 0x23AE40 VA: 0x18023BA40
	public ParticleSystem.MinMaxCurve get_startSpeed() { }

	// RVA: 0x23BDC0 Offset: 0x23B1C0 VA: 0x18023BDC0
	public void set_startSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23BA00 Offset: 0x23AE00 VA: 0x18023BA00
	public float get_startSpeedMultiplier() { }

	// RVA: 0x23BD70 Offset: 0x23B170 VA: 0x18023BD70
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x23B9B0 Offset: 0x23ADB0 VA: 0x18023B9B0
	public ParticleSystem.MinMaxCurve get_startSize() { }

	// RVA: 0x23BD20 Offset: 0x23B120 VA: 0x18023BD20
	public void set_startSize(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B970 Offset: 0x23AD70 VA: 0x18023B970
	public float get_startSizeMultiplier() { }

	// RVA: 0x23BCD0 Offset: 0x23B0D0 VA: 0x18023BCD0
	public void set_startSizeMultiplier(float value) { }

	// RVA: 0x23B880 Offset: 0x23AC80 VA: 0x18023B880
	public ParticleSystem.MinMaxGradient get_startColor() { }

	// RVA: 0x23BBD0 Offset: 0x23AFD0 VA: 0x18023BBD0
	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x23B7C0 Offset: 0x23ABC0 VA: 0x18023B7C0
	public float get_gravityModifierMultiplier() { }

	// RVA: 0x23BAE0 Offset: 0x23AEE0 VA: 0x18023BAE0
	public void set_gravityModifierMultiplier(float value) { }

	// RVA: 0x23BB80 Offset: 0x23AF80 VA: 0x18023BB80
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x23B840 Offset: 0x23AC40 VA: 0x18023B840
	public bool get_playOnAwake() { }

	// RVA: 0x23B800 Offset: 0x23AC00 VA: 0x18023B800
	public int get_maxParticles() { }

	// RVA: 0x23BB30 Offset: 0x23AF30 VA: 0x18023BB30
	public void set_maxParticles(int value) { }

	// RVA: 0x23BA90 Offset: 0x23AE90 VA: 0x18023BA90
	public void set_cullingMode(ParticleSystemCullingMode value) { }

	// RVA: 0x22C58F0 Offset: 0x22C3EF0 VA: 0x1822C58F0
	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5AE0 Offset: 0x22C40E0 VA: 0x1822C5AE0
	private static void get_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C5F40 Offset: 0x22C4540 VA: 0x1822C5F40
	private static void set_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C5AA0 Offset: 0x22C40A0 VA: 0x1822C5AA0
	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5EF0 Offset: 0x22C44F0 VA: 0x1822C5EF0
	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C5CA0 Offset: 0x22C42A0 VA: 0x1822C5CA0
	private static void get_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C6120 Offset: 0x22C4720 VA: 0x1822C6120
	private static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C5C60 Offset: 0x22C4260 VA: 0x1822C5C60
	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C60D0 Offset: 0x22C46D0 VA: 0x1822C60D0
	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C5BC0 Offset: 0x22C41C0 VA: 0x1822C5BC0
	private static void get_startSize_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C6030 Offset: 0x22C4630 VA: 0x1822C6030
	private static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C5B80 Offset: 0x22C4180 VA: 0x1822C5B80
	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5FE0 Offset: 0x22C45E0 VA: 0x1822C5FE0
	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C59F0 Offset: 0x22C3FF0 VA: 0x1822C59F0
	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	// RVA: 0x22C5E50 Offset: 0x22C4450 VA: 0x1822C5E50
	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x22C5930 Offset: 0x22C3F30 VA: 0x1822C5930
	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5D80 Offset: 0x22C4380 VA: 0x1822C5D80
	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C5E10 Offset: 0x22C4410 VA: 0x1822C5E10
	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0x22C59B0 Offset: 0x22C3FB0 VA: 0x1822C59B0
	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5970 Offset: 0x22C3F70 VA: 0x1822C5970
	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C5DD0 Offset: 0x22C43D0 VA: 0x1822C5DD0
	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	// RVA: 0x22C5D40 Offset: 0x22C4340 VA: 0x1822C5D40
	private static void set_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemCullingMode value) { }

}

public struct ParticleSystem.EmissionModule // TypeDefIndex: 4529
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	[ObsoleteAttribute] // RVA: 0xEF460 Offset: 0xEE860 VA: 0x1800EF460
	public ParticleSystem.MinMaxCurve rate { set; }
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { get; set; }
	public float rateOverTimeMultiplier { get; set; }

	// Methods

	// RVA: 0x23B470 Offset: 0x23A870 VA: 0x18023B470
	public void set_rate(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B300 Offset: 0x23A700 VA: 0x18023B300
	public bool get_enabled() { }

	// RVA: 0x23B3D0 Offset: 0x23A7D0 VA: 0x18023B3D0
	public void set_enabled(bool value) { }

	// RVA: 0x23B380 Offset: 0x23A780 VA: 0x18023B380
	public ParticleSystem.MinMaxCurve get_rateOverTime() { }

	// RVA: 0x23B470 Offset: 0x23A870 VA: 0x18023B470
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x23B340 Offset: 0x23A740 VA: 0x18023B340
	public float get_rateOverTimeMultiplier() { }

	// RVA: 0x23B420 Offset: 0x23A820 VA: 0x18023B420
	public void set_rateOverTimeMultiplier(float value) { }

	// RVA: 0x23B290 Offset: 0x23A690 VA: 0x18023B290
	public void SetBurst(int index, ParticleSystem.Burst burst) { }

	// RVA: 0x23B220 Offset: 0x23A620 VA: 0x18023B220
	public ParticleSystem.Burst GetBurst(int index) { }

	// RVA: 0x22C55C0 Offset: 0x22C3BC0 VA: 0x1822C55C0
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x22C56E0 Offset: 0x22C3CE0 VA: 0x1822C56E0
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x22C5640 Offset: 0x22C3C40 VA: 0x1822C5640
	private static void get_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C5780 Offset: 0x22C3D80 VA: 0x1822C5780
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C5600 Offset: 0x22C3C00 VA: 0x1822C5600
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x22C5730 Offset: 0x22C3D30 VA: 0x1822C5730
	private static void set_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self, float value) { }

	// RVA: 0x22C5520 Offset: 0x22C3B20 VA: 0x1822C5520
	private static void SetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, ref ParticleSystem.Burst burst) { }

	// RVA: 0x22C5460 Offset: 0x22C3A60 VA: 0x1822C5460
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

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23C4C0 Offset: 0x23B8C0 VA: 0x18023C4C0
	public void set_shapeType(ParticleSystemShapeType value) { }

	// RVA: 0x23C420 Offset: 0x23B820 VA: 0x18023C420
	public void set_randomDirectionAmount(float value) { }

	// RVA: 0x23C1B0 Offset: 0x23B5B0 VA: 0x18023C1B0
	public float get_radius() { }

	// RVA: 0x23C3D0 Offset: 0x23B7D0 VA: 0x18023C3D0
	public void set_radius(float value) { }

	// RVA: 0x23C240 Offset: 0x23B640 VA: 0x18023C240
	public void set_angle(float value) { }

	// RVA: 0x23C2E0 Offset: 0x23B6E0 VA: 0x18023C2E0
	public void set_length(float value) { }

	// RVA: 0x23C330 Offset: 0x23B730 VA: 0x18023C330
	public void set_meshRenderer(MeshRenderer value) { }

	// RVA: 0x23C290 Offset: 0x23B690 VA: 0x18023C290
	public void set_arc(float value) { }

	// RVA: 0x23C380 Offset: 0x23B780 VA: 0x18023C380
	public void set_position(Vector3 value) { }

	// RVA: 0x23C1F0 Offset: 0x23B5F0 VA: 0x18023C1F0
	public Vector3 get_rotation() { }

	// RVA: 0x23C470 Offset: 0x23B870 VA: 0x18023C470
	public void set_scale(Vector3 value) { }

	// RVA: 0x22C7E90 Offset: 0x22C6490 VA: 0x1822C7E90
	private static void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value) { }

	// RVA: 0x22C7DA0 Offset: 0x22C63A0 VA: 0x1822C7DA0
	private static void set_randomDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7A90 Offset: 0x22C6090 VA: 0x1822C7A90
	private static float get_radius_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x22C7D50 Offset: 0x22C6350 VA: 0x1822C7D50
	private static void set_radius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7B70 Offset: 0x22C6170 VA: 0x1822C7B70
	private static void set_angle_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7C10 Offset: 0x22C6210 VA: 0x1822C7C10
	private static void set_length_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7C60 Offset: 0x22C6260 VA: 0x1822C7C60
	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, MeshRenderer value) { }

	// RVA: 0x22C7BC0 Offset: 0x22C61C0 VA: 0x1822C7BC0
	private static void set_arc_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C7CB0 Offset: 0x22C62B0 VA: 0x1822C7CB0
	private static void set_position_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0x22C7AD0 Offset: 0x22C60D0 VA: 0x1822C7AD0
	private static void get_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0x22C7DF0 Offset: 0x22C63F0 VA: 0x1822C7DF0
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
	[ObsoleteAttribute] // RVA: 0xEF840 Offset: 0xEEC40 VA: 0x1800EF840
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

	// RVA: 0x23C080 Offset: 0x23B480 VA: 0x18023C080
	public void set_lifetime(float value) { }

	// RVA: 0x204F30 Offset: 0x204330 VA: 0x180204F30
	public void set_position(Vector3 value) { }

	// RVA: 0x212CC0 Offset: 0x2120C0 VA: 0x180212CC0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x23C080 Offset: 0x23B480 VA: 0x18023C080
	public void set_remainingLifetime(float value) { }

	// RVA: 0x23C150 Offset: 0x23B550 VA: 0x18023C150
	public void set_startLifetime(float value) { }

	// RVA: 0x23C140 Offset: 0x23B540 VA: 0x18023C140
	public void set_startColor(Color32 value) { }

	// RVA: 0x23C090 Offset: 0x23B490 VA: 0x18023C090
	public void set_randomSeed(uint value) { }

	// RVA: 0x23C160 Offset: 0x23B560 VA: 0x18023C160
	public void set_startSize(float value) { }

	// RVA: 0x23C0A0 Offset: 0x23B4A0 VA: 0x18023C0A0
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x23BFE0 Offset: 0x23B3E0 VA: 0x18023BFE0
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

	// RVA: 0x23AFD0 Offset: 0x23A3D0 VA: 0x18023AFD0
	public void set_probability(float value) { }

}

public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 4533
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_CurveMultiplier; // 0x4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve m_CurveMin; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AnimationCurve m_CurveMax; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_ConstantMin; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_ConstantMax; // 0x1C

	// Properties
	public ParticleSystemCurveMode mode { set; }
	public float constantMax { get; set; }
	public float constantMin { set; }
	public float constant { get; set; }

	// Methods

	// RVA: 0x23BE30 Offset: 0x23B230 VA: 0x18023BE30
	public void .ctor(float constant) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_mode(ParticleSystemCurveMode value) { }

	// RVA: 0x2395D0 Offset: 0x2389D0 VA: 0x1802395D0
	public float get_constantMax() { }

	// RVA: 0x239830 Offset: 0x238C30 VA: 0x180239830
	public void set_constantMax(float value) { }

	// RVA: 0x2395A0 Offset: 0x2389A0 VA: 0x1802395A0
	public void set_constantMin(float value) { }

	// RVA: 0x2395D0 Offset: 0x2389D0 VA: 0x1802395D0
	public float get_constant() { }

	// RVA: 0x239830 Offset: 0x238C30 VA: 0x180239830
	public void set_constant(float value) { }

	// RVA: 0x22C61C0 Offset: 0x22C47C0 VA: 0x1822C61C0
	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }

}

public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 4534
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Gradient m_GradientMin; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Gradient m_GradientMax; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_ColorMin; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Color m_ColorMax; // 0x28

	// Properties
	public ParticleSystemGradientMode mode { set; }
	public Color color { get; set; }
	public Gradient gradient { set; }

	// Methods

	// RVA: 0x23BE80 Offset: 0x23B280 VA: 0x18023BE80
	public void .ctor(Color color) { }

	// RVA: 0x23BEE0 Offset: 0x23B2E0 VA: 0x18023BEE0
	public void .ctor(Gradient gradient) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_mode(ParticleSystemGradientMode value) { }

	// RVA: 0x23BEF0 Offset: 0x23B2F0 VA: 0x18023BEF0
	public Color get_color() { }

	// RVA: 0x23BF00 Offset: 0x23B300 VA: 0x18023BF00
	public void set_color(Color value) { }

	// RVA: 0xF1470 Offset: 0xF0870 VA: 0x1800F1470
	public void set_gradient(Gradient value) { }

	// RVA: 0x22C6330 Offset: 0x22C4930 VA: 0x1822C6330
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }

	// RVA: 0x22C63F0 Offset: 0x22C49F0 VA: 0x1822C63F0
	public static ParticleSystem.MinMaxGradient op_Implicit(Gradient gradient) { }

}

public struct ParticleSystem.EmitParams // TypeDefIndex: 4535
{	// Fields
	[NativeNameAttribute] // RVA: 0xF0430 Offset: 0xEF830 VA: 0x1800F0430
	private ParticleSystem.Particle m_Particle; // 0x0
	[NativeNameAttribute] // RVA: 0xF0550 Offset: 0xEF950 VA: 0x1800F0550
	private bool m_PositionSet; // 0x84
	[NativeNameAttribute] // RVA: 0xF0700 Offset: 0xEFB00 VA: 0x1800F0700
	private bool m_VelocitySet; // 0x85
	[NativeNameAttribute] // RVA: 0xF0820 Offset: 0xEFC20 VA: 0x1800F0820
	private bool m_AxisOfRotationSet; // 0x86
	[NativeNameAttribute] // RVA: 0xF0930 Offset: 0xEFD30 VA: 0x1800F0930
	private bool m_RotationSet; // 0x87
	[NativeNameAttribute] // RVA: 0xF0AA0 Offset: 0xEFEA0 VA: 0x1800F0AA0
	private bool m_AngularVelocitySet; // 0x88
	[NativeNameAttribute] // RVA: 0xF0C80 Offset: 0xF0080 VA: 0x1800F0C80
	private bool m_StartSizeSet; // 0x89
	[NativeNameAttribute] // RVA: 0xF0E90 Offset: 0xF0290 VA: 0x1800F0E90
	private bool m_StartColorSet; // 0x8A
	[NativeNameAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool m_RandomSeedSet; // 0x8B
	[NativeNameAttribute] // RVA: 0x6F4A0 Offset: 0x6E8A0 VA: 0x18006F4A0
	private bool m_StartLifetimeSet; // 0x8C
	[NativeNameAttribute] // RVA: 0x6F700 Offset: 0x6EB00 VA: 0x18006F700
	private bool m_MeshIndexSet; // 0x8D
	[NativeNameAttribute] // RVA: 0x6FB20 Offset: 0x6EF20 VA: 0x18006FB20
	private bool m_ApplyShapeToPosition; // 0x8E

	// Properties
	public Vector3 position { set; }
	public float startSize { set; }
	public Color32 startColor { set; }

	// Methods

	// RVA: 0x23B4E0 Offset: 0x23A8E0 VA: 0x18023B4E0
	public void set_position(Vector3 value) { }

	// RVA: 0x23B510 Offset: 0x23A910 VA: 0x18023B510
	public void set_startSize(float value) { }

	// RVA: 0x23B500 Offset: 0x23A900 VA: 0x18023B500
	public void set_startColor(Color32 value) { }

}

public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 4536
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public ParticleSystem.MinMaxGradient color { set; }

	// Methods

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B1A0 Offset: 0x23A5A0 VA: 0x18023B1A0
	public void set_color(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x22C53C0 Offset: 0x22C39C0 VA: 0x1822C53C0
	private static void set_color_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

}

public struct ParticleSystem.CollisionModule // TypeDefIndex: 4537
{	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; set; }
	public ParticleSystemCollisionQuality quality { set; }

	// Methods

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x23B0A0 Offset: 0x23A4A0 VA: 0x18023B0A0
	public bool get_enabled() { }

	// RVA: 0x23B0E0 Offset: 0x23A4E0 VA: 0x18023B0E0
	public void set_enabled(bool value) { }

	// RVA: 0x23B130 Offset: 0x23A530 VA: 0x18023B130
	public void set_quality(ParticleSystemCollisionQuality value) { }

	// RVA: 0x22C52F0 Offset: 0x22C38F0 VA: 0x1822C52F0
	private static bool get_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self) { }

	// RVA: 0x22C5330 Offset: 0x22C3930 VA: 0x1822C5330
	private static void set_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self, bool value) { }

	// RVA: 0x22C5380 Offset: 0x22C3980 VA: 0x1822C5380
	private static void set_quality_Injected(ref ParticleSystem.CollisionModule _unity_self, ParticleSystemCollisionQuality value) { }

}

