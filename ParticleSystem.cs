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
	// RVA: 0x22C76A0 Offset: 0x22C5CA0 VA: 0x1822C76A0
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] // RVA: 0xED3A0 Offset: 0xEC7A0 VA: 0x1800ED3A0
	// RVA: 0x22C7650 Offset: 0x22C5C50 VA: 0x1822C7650
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x22C8130 Offset: 0x22C6730 VA: 0x1822C8130
	public bool get_playOnAwake() { }

	// RVA: 0x22C7F30 Offset: 0x22C6530 VA: 0x1822C7F30
	public float get_duration() { }

	// RVA: 0x22C7FD0 Offset: 0x22C65D0 VA: 0x1822C7FD0
	public bool get_enableEmission() { }

	// RVA: 0x22C8340 Offset: 0x22C6940 VA: 0x1822C8340
	public void set_enableEmission(bool value) { }

	// RVA: 0x22C7F80 Offset: 0x22C6580 VA: 0x1822C7F80
	public float get_emissionRate() { }

	// RVA: 0x22C8270 Offset: 0x22C6870 VA: 0x1822C8270
	public void set_emissionRate(float value) { }

	// RVA: 0x22C8220 Offset: 0x22C6820 VA: 0x1822C8220
	public float get_startSpeed() { }

	// RVA: 0x22C84C0 Offset: 0x22C6AC0 VA: 0x1822C84C0
	public void set_startSpeed(float value) { }

	// RVA: 0x22C81D0 Offset: 0x22C67D0 VA: 0x1822C81D0
	public float get_startSize() { }

	// RVA: 0x22C8460 Offset: 0x22C6A60 VA: 0x1822C8460
	public void set_startSize(float value) { }

	// RVA: 0x22C8180 Offset: 0x22C6780 VA: 0x1822C8180
	public float get_startLifetime() { }

	// RVA: 0x22C8400 Offset: 0x22C6A00 VA: 0x1822C8400
	public void set_startLifetime(float value) { }

	// RVA: 0x22C8020 Offset: 0x22C6620 VA: 0x1822C8020
	public float get_gravityModifier() { }

	// RVA: 0x22C83A0 Offset: 0x22C69A0 VA: 0x1822C83A0
	public void set_gravityModifier(float value) { }

	[NativeNameAttribute] // RVA: 0xED420 Offset: 0xEC820 VA: 0x1800ED420
	// RVA: 0x22C8070 Offset: 0x22C6670 VA: 0x1822C8070
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xED500 Offset: 0xEC900 VA: 0x1800ED500
	// RVA: 0x22C80B0 Offset: 0x22C66B0 VA: 0x1822C80B0
	public bool get_isStopped() { }

	[NativeNameAttribute] // RVA: 0xED600 Offset: 0xECA00 VA: 0x1800ED600
	// RVA: 0x22C80F0 Offset: 0x22C66F0 VA: 0x1822C80F0
	public int get_particleCount() { }

	[NativeNameAttribute] // RVA: 0xED6B0 Offset: 0xECAB0 VA: 0x1800ED6B0
	// RVA: 0x22C8520 Offset: 0x22C6B20 VA: 0x1822C8520
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xED910 Offset: 0xECD10 VA: 0x1800ED910
	// RVA: 0x22C7DD0 Offset: 0x22C63D0 VA: 0x1822C7DD0
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x22C7D60 Offset: 0x22C6360 VA: 0x1822C7D60
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x22C7CB0 Offset: 0x22C62B0 VA: 0x1822C7CB0
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x22C7D10 Offset: 0x22C6310 VA: 0x1822C7D10
	public void Simulate(float t) { }

	[FreeFunctionAttribute] // RVA: 0xED9E0 Offset: 0xECDE0 VA: 0x1800ED9E0
	// RVA: 0x22C7B00 Offset: 0x22C6100 VA: 0x1822C7B00
	public void Play(bool withChildren) { }

	// RVA: 0x22C7AC0 Offset: 0x22C60C0 VA: 0x1822C7AC0
	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0xEDB00 Offset: 0xECF00 VA: 0x1800EDB00
	// RVA: 0x22C7A30 Offset: 0x22C6030 VA: 0x1822C7A30
	public void Pause(bool withChildren) { }

	// RVA: 0x22C7A80 Offset: 0x22C6080 VA: 0x1822C7A80
	public void Pause() { }

	[FreeFunctionAttribute] // RVA: 0xEDC10 Offset: 0xED010 VA: 0x1800EDC10
	// RVA: 0x22C7E80 Offset: 0x22C6480 VA: 0x1822C7E80
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x22C7EE0 Offset: 0x22C64E0 VA: 0x1822C7EE0
	public void Stop(bool withChildren) { }

	// RVA: 0x22C7E40 Offset: 0x22C6440 VA: 0x1822C7E40
	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0xEDCC0 Offset: 0xED0C0 VA: 0x1800EDCC0
	// RVA: 0x22C7480 Offset: 0x22C5A80 VA: 0x1822C7480
	public void Clear(bool withChildren) { }

	// RVA: 0x22C74D0 Offset: 0x22C5AD0 VA: 0x1822C74D0
	public void Clear() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22C7610 Offset: 0x22C5C10 VA: 0x1822C7610
	public void Emit(int count) { }

	[NativeNameAttribute] // RVA: 0xEDE30 Offset: 0xED230 VA: 0x1800EDE30
	// RVA: 0x22C7610 Offset: 0x22C5C10 VA: 0x1822C7610
	private void Emit_Internal(int count) { }

	[NativeNameAttribute] // RVA: 0xEE010 Offset: 0xED410 VA: 0x1800EE010
	// RVA: 0x22C78F0 Offset: 0x22C5EF0 VA: 0x1822C78F0
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] // RVA: 0xEE110 Offset: 0xED510 VA: 0x1800EE110
	// RVA: 0x22C7560 Offset: 0x22C5B60 VA: 0x1822C7560
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x22C7950 Offset: 0x22C5F50 VA: 0x1822C7950
	internal void* GetManagedJobData() { }

	// RVA: 0x22C79E0 Offset: 0x22C5FE0 VA: 0x1822C79E0
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x22C7C60 Offset: 0x22C6260 VA: 0x1822C7C60
	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0xEAAE0 Offset: 0xE9EE0 VA: 0x1800EAAE0
	// RVA: 0x22C7BB0 Offset: 0x22C61B0 VA: 0x1822C7BB0
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] // RVA: 0x93CD0 Offset: 0x930D0 VA: 0x180093CD0
	// RVA: 0x22C7510 Offset: 0x22C5B10 VA: 0x1822C7510
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	// RVA: 0x149F650 Offset: 0x149DC50 VA: 0x18149F650
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x149F650 Offset: 0x149DC50 VA: 0x18149F650
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x149F650 Offset: 0x149DC50 VA: 0x18149F650
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x149F650 Offset: 0x149DC50 VA: 0x18149F650
	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0x149F650 Offset: 0x149DC50 VA: 0x18149F650
	public ParticleSystem.CollisionModule get_collision() { }

	// RVA: 0x22C75B0 Offset: 0x22C5BB0 VA: 0x1822C75B0
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x22C7990 Offset: 0x22C5F90 VA: 0x1822C7990
	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0x22C7C10 Offset: 0x22C6210 VA: 0x1822C7C10
	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0x22C7B50 Offset: 0x22C6150 VA: 0x1822C7B50
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

	// RVA: 0x22C63D0 Offset: 0x22C49D0 VA: 0x1822C63D0
	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C65C0 Offset: 0x22C4BC0 VA: 0x1822C65C0
	private static void get_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C6A20 Offset: 0x22C5020 VA: 0x1822C6A20
	private static void set_startLifetime_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C6580 Offset: 0x22C4B80 VA: 0x1822C6580
	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C69D0 Offset: 0x22C4FD0 VA: 0x1822C69D0
	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C6780 Offset: 0x22C4D80 VA: 0x1822C6780
	private static void get_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C6C00 Offset: 0x22C5200 VA: 0x1822C6C00
	private static void set_startSpeed_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C6740 Offset: 0x22C4D40 VA: 0x1822C6740
	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C6BB0 Offset: 0x22C51B0 VA: 0x1822C6BB0
	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C66A0 Offset: 0x22C4CA0 VA: 0x1822C66A0
	private static void get_startSize_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C6B10 Offset: 0x22C5110 VA: 0x1822C6B10
	private static void set_startSize_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C6660 Offset: 0x22C4C60 VA: 0x1822C6660
	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C6AC0 Offset: 0x22C50C0 VA: 0x1822C6AC0
	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C64D0 Offset: 0x22C4AD0 VA: 0x1822C64D0
	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	// RVA: 0x22C6930 Offset: 0x22C4F30 VA: 0x1822C6930
	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x22C6410 Offset: 0x22C4A10 VA: 0x1822C6410
	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C6860 Offset: 0x22C4E60 VA: 0x1822C6860
	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x22C68F0 Offset: 0x22C4EF0 VA: 0x1822C68F0
	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0x22C6490 Offset: 0x22C4A90 VA: 0x1822C6490
	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C6450 Offset: 0x22C4A50 VA: 0x1822C6450
	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x22C68B0 Offset: 0x22C4EB0 VA: 0x1822C68B0
	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	// RVA: 0x22C6820 Offset: 0x22C4E20 VA: 0x1822C6820
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

	// RVA: 0x22C60A0 Offset: 0x22C46A0 VA: 0x1822C60A0
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x22C61C0 Offset: 0x22C47C0 VA: 0x1822C61C0
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x22C6120 Offset: 0x22C4720 VA: 0x1822C6120
	private static void get_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x22C6260 Offset: 0x22C4860 VA: 0x1822C6260
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x22C60E0 Offset: 0x22C46E0 VA: 0x1822C60E0
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x22C6210 Offset: 0x22C4810 VA: 0x1822C6210
	private static void set_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self, float value) { }

	// RVA: 0x22C6000 Offset: 0x22C4600 VA: 0x1822C6000
	private static void SetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, ref ParticleSystem.Burst burst) { }

	// RVA: 0x22C5F40 Offset: 0x22C4540 VA: 0x1822C5F40
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

	// RVA: 0x22C8970 Offset: 0x22C6F70 VA: 0x1822C8970
	private static void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value) { }

	// RVA: 0x22C8880 Offset: 0x22C6E80 VA: 0x1822C8880
	private static void set_randomDirectionAmount_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C8570 Offset: 0x22C6B70 VA: 0x1822C8570
	private static float get_radius_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x22C8830 Offset: 0x22C6E30 VA: 0x1822C8830
	private static void set_radius_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C8650 Offset: 0x22C6C50 VA: 0x1822C8650
	private static void set_angle_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C86F0 Offset: 0x22C6CF0 VA: 0x1822C86F0
	private static void set_length_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C8740 Offset: 0x22C6D40 VA: 0x1822C8740
	private static void set_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, MeshRenderer value) { }

	// RVA: 0x22C86A0 Offset: 0x22C6CA0 VA: 0x1822C86A0
	private static void set_arc_Injected(ref ParticleSystem.ShapeModule _unity_self, float value) { }

	// RVA: 0x22C8790 Offset: 0x22C6D90 VA: 0x1822C8790
	private static void set_position_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value) { }

	// RVA: 0x22C85B0 Offset: 0x22C6BB0 VA: 0x1822C85B0
	private static void get_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret) { }

	// RVA: 0x22C88D0 Offset: 0x22C6ED0 VA: 0x1822C88D0
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

	// RVA: 0x204B60 Offset: 0x203F60 VA: 0x180204B60
	public void set_position(Vector3 value) { }

	// RVA: 0x2120F0 Offset: 0x2114F0 VA: 0x1802120F0
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

	// RVA: 0x22C6CA0 Offset: 0x22C52A0 VA: 0x1822C6CA0
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

	// RVA: 0x22C6E10 Offset: 0x22C5410 VA: 0x1822C6E10
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }

	// RVA: 0x22C6ED0 Offset: 0x22C54D0 VA: 0x1822C6ED0
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

	// RVA: 0x22C5EA0 Offset: 0x22C44A0 VA: 0x1822C5EA0
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

	// RVA: 0x22C5DD0 Offset: 0x22C43D0 VA: 0x1822C5DD0
	private static bool get_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self) { }

	// RVA: 0x22C5E10 Offset: 0x22C4410 VA: 0x1822C5E10
	private static void set_enabled_Injected(ref ParticleSystem.CollisionModule _unity_self, bool value) { }

	// RVA: 0x22C5E60 Offset: 0x22C4460 VA: 0x1822C5E60
	private static void set_quality_Injected(ref ParticleSystem.CollisionModule _unity_self, ParticleSystemCollisionQuality value) { }

}

